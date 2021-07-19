using DGVPrinterHelper;
using Invoicing_Software.Business_Logic_Layer;
using Invoicing_Software.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Invoicing_Software.UserInterface
{
	public partial class frmPurchaseandSales : Form
	{
		public frmPurchaseandSales()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		delrCustDAL dcDAL = new delrCustDAL();
		productsDAL pDAL = new productsDAL();
		userDAL uDAL = new userDAL();
		transactionsDAL tDAL = new transactionsDAL();
		transactionDetailDAL tdDAL = new transactionDetailDAL();

		DataTable transactiondt = new DataTable();
		private void frmPurchaseandSales_Load(object sender, EventArgs e)
		{
			//Get the transaction type value from user dashboard
			string type = frmUserDashboard.transactionType;
			//set the value on lbltop
			lblTop.Text = type;

			//specify collums for our transaction data table
			transactiondt.Columns.Add("Product Name");
			transactiondt.Columns.Add("Rate");
			transactiondt.Columns.Add("Quantity");
			transactiondt.Columns.Add("Total");
		}

		private void txtDandCSearch_TextChanged(object sender, EventArgs e)
		{
			//get the keyword from the text box
			string keywords = txtDandCSearch.Text;

			if(keywords=="")
			{
				//clear all the text boxes
				txtDandCName.Text = "";
				txtDandCEmail.Text = "";
				txtDandCContact.Text = "";
				txtDandCAddress.Text = "";
				return;
			}
			//write the code to get details and set the value on text boxes
			deaCustBLL dc = dcDAL.searchDealerCustomerforTransaction(keywords);

			//Now transfer or set the value from deacustBLL to textboxes
			txtDandCName.Text = dc.name;
			txtDandCEmail.Text = dc.email;
			txtDandCContact.Text = dc.contact;
			txtDandCAddress.Text = dc.address;
		}

		private void txtPDSearch_TextChanged(object sender, EventArgs e)
		{
			//Get the keyword from the product
			string keyword = txtPDSearch.Text;
			//check if we have value or !
			if(keyword=="")
			{
				txtPDName.Text = "";
				txtPDInventory.Text = "";
				txtPDRate.Text = "";
				txtPDQty.Text = "";
				return;
			}

			//Search the product and display on respective textboxes
			productsBLL p = pDAL.GetProductForTransaction(keyword);

			//get the values on textboxes based on p object
			txtPDName.Text = p.name;
			txtPDInventory.Text = p.qty.ToString();
			txtPDRate.Text = p.rate.ToString();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//get product name, rate, qty customer wants to buy
			string productname = txtPDName.Text;
			decimal rate =decimal.Parse(txtPDRate.Text);
			decimal qty = decimal.Parse(txtPDQty.Text);

			decimal Total = rate * qty;
			
			//display the subtotal
			//get the total value from textbox
			decimal subTotal = decimal.Parse(txtSubTotal.Text);
			subTotal = subTotal + Total;

			//check weather the product is selected or !
			if(productname=="")
			{
				//display error message
				MessageBox.Show("Select the Product first. Try Again!");
			}
			else
			{
				//add product to the data grid view
				transactiondt.Rows.Add(productname, rate, qty, Total);

				//show in dta grid view
				dgvAddedProducts.DataSource = transactiondt;
				//display the subtotal in text boxes
				txtSubTotal.Text = subTotal.ToString();

				//clear the text boxes
				txtPDSearch.Text = "";
				txtPDName.Text = "";
				txtPDInventory.Text = "";
				txtPDRate.Text = "";
				txtPDQty.Text = "";
			}
		}

		private void txtDiscount_TextChanged(object sender, EventArgs e)
		{
			//Get the vlaue from discount text box
			string value = txtDiscount.Text;

			if(value=="")
			{
				//display error message
				MessageBox.Show("Please Add Discount First");
			}
			else
			{
				//get the discount in decimal value
				decimal subTotal = decimal.Parse(txtSubTotal.Text);
				decimal discount = decimal.Parse(txtDiscount.Text);

				//calculate the grand total
				decimal grandTotal = ((100 - discount) * subTotal) / 100;

				//display the grandtotal in text box
				txtGrandTotal.Text = grandTotal.ToString();
			}
		}

		private void txtGST_TextChanged(object sender, EventArgs e)
		{
			//if the grand total has value or ! if it has ! value then calculate the discount first
			string check = txtGrandTotal.Text;
			if(check=="")
			{
				//display the error message to calculate the discount
				MessageBox.Show("Calculate the discount and set the grand total First");
			}
			else
			{
				//calculate gst
				//getting the gst perecent first
				double previousGT = 0;
				previousGT = double.Parse(txtGrandTotal.Text);
				
				double gst = double.Parse(txtGST.Text);
				double grandTotalwithGST = (((previousGT * gst) / 100) + previousGT);

				//displaying the new grand total with gst
				txtGrandTotal.Text = grandTotalwithGST.ToString();
			}
		}

		private void txtPaidAmount_TextChanged(object sender, EventArgs e)
		{
			//get the paid amount and grandtotal
			decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
			decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

			decimal returnAmount = grandTotal-paidAmount;

			//display the return amount as well
			txtReturnAmount.Text = returnAmount.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//get the details from the form purchase sales form first
			transactionsBLL transaction = new transactionsBLL();

			transaction.type = lblTop.Text;

			//get the id of dealer or customer
			//lets get name of the delar or customer first
			string deaCustName = txtDandCName.Text;
			deaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

			transaction.dea_cust_id = dc.id;
			transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
			transaction.transaction_date = DateTime.Now;
			transaction.gst = decimal.Parse(txtGST.Text);
			transaction.discount = decimal.Parse(txtDiscount.Text);

			//get the user name of logged in user
			string username = frmLogin.loggedIn;
			userBLL u = uDAL.GetIDFromUsername(username);

			transaction.added_by = u.id;
			transaction.transactionDetails = transactiondt;

			//boolean variable and set its value to FALSE
			bool success = false;

			//actual code to insert transaction and transaction details
			using (TransactionScope scope = new TransactionScope())
			{
				int transactionID = -1;
				//create bool value and insert transaction
				bool w = tDAL.Insert_transaction(transaction, out transactionID);

				//use for loop to insert transaction details
				for(int i=0;i<transactiondt.Rows.Count;i++)
				{
					//get all the details of the product
					transactionDetailBLL transactionDetail = new transactionDetailBLL();
					//get the product name and converse into id
					string ProductName = transactiondt.Rows[i][0].ToString();
					productsBLL p = pDAL.GetProductsIDFromName(ProductName);

					transactionDetail.product_id = p.id;
					transactionDetail.rate = decimal.Parse(transactiondt.Rows[i][1].ToString());
					transactionDetail.qty = decimal.Parse(transactiondt.Rows[i][2].ToString());
					transactionDetail.total = Math.Round(decimal.Parse(transactiondt.Rows[i][3].ToString()), 2);
					transactionDetail.dea_cust_id = dc.id;
					transactionDetail.added_date = DateTime.Now;
					transactionDetail.added_by = u.id;

					//Increase or Decrease Product Qty based on Purchase Or Sales
					string transactionType = lblTop.Text;

					//check whether we r on purchase or sales
					bool x = false;
					if(transactionType=="PURCHASE")
					{
						//Increase the Product
						x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
					}
					else if(transactionType=="SALES")
					{
						//Decrease the Product
						x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
					}

					//Insert transactionsDetails inside the db
					bool y = tdDAL.InsertTransactionDetail(transactionDetail);
					success = w && x && y;
				}
				if (success == true)
				{
					//transaction is Compelete
					scope.Complete();

					//scope to print the bill
					DGVPrinter printer = new DGVPrinter();

					printer.Title = "\r\n\r\n\r\nRISHI SOFTWARE PVT.LTD\r\n\r\n";
					printer.SubTitle = "Kenduadihi, Bankura \r\n Phone:-89720635\r\n\r\n";
					printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
					printer.PageNumbers = true;
					printer.PageNumberInHeader = false;
					printer.PorportionalColumns = true;
					printer.HeaderCellAlignment = StringAlignment.Near;
					//footer for our bill
					printer.Footer = "Discount:- " + txtDiscount.Text + "% \r\n" + "GST:- " + txtGST.Text + "%\r\n" + "Grand Total:- " + txtGrandTotal.Text + "\r\n\r\n" + "Thank You For Shopping With Us";
					printer.FooterSpacing = 15;
					printer.PrintDataGridView(dgvAddedProducts);

					MessageBox.Show("Transaction Completed Successfully");
					//clear the data grid view and clear all the textboxes
					dgvAddedProducts.DataSource = null;
					dgvAddedProducts.Rows.Clear();

					txtDandCSearch.Text = "";
					txtDandCName.Text = "";
					txtDandCEmail.Text = "";
					txtDandCContact.Text = "";
					txtDandCAddress.Text = "";

					txtPDSearch.Text = "";
					txtPDName.Text = "";
					txtPDInventory.Text = "0";
					txtPDRate.Text = "0";
					txtPDQty.Text = "0";

					txtSubTotal.Text = "0";
					txtDiscount.Text = "0";
					txtGST.Text = "0";
					txtGrandTotal.Text = "0";
					txtPaidAmount.Text = "0";
					txtReturnAmount.Text = "0";
				}
				else
				{
					//Transaction Failed
					MessageBox.Show("Transaction Failed!");
				}
			}
		}
	}
}
