using Invoicing_Software.Business_Logic_Layer;
using Invoicing_Software.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_Software.UserInterface
{
	public partial class frmDlrCustmr : Form
	{
		public frmDlrCustmr()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		deaCustBLL dc = new deaCustBLL();
		delrCustDAL dcdal = new delrCustDAL();

		userDAL uDal = new userDAL();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			//get the values from the UI DLR Cstmr
			dc.type = cmbDeaCust.Text;
			dc.name = txtName.Text;
			dc.email = txtEmail.Text;
			dc.contact = txtContact.Text;
			dc.address = txtAddress.Text;
			dc.added_date = DateTime.Now;
			//getting the id in usr and passing its value in dlr custmr module
			string loggedUser = frmLogin.loggedIn;
			userBLL usr = uDal.GetIDFromUsername(loggedUser);
			dc.added_by = usr.id;

			//creating boolean variable to check wheather the dealer or customer is added or not
			bool isSuccess = dcdal.Insert(dc);
			if(isSuccess==true)
			{
				//Dealer or customer value inserted successfully
				MessageBox.Show("Dealer or Customer Added Successfully");
				Clear();
				//To refresh datagridviewS
				DataTable dt = dcdal.Select();
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				//Failed to Insert
				MessageBox.Show("Failed to Add Dealer or Customer");
			}
		}
		public void Clear()
		{
			txtDeaCustID.Text = "";
			txtName.Text = "";
			txtEmail.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			txtSearch.Text = "";
		}

		private void frmDlrCustmr_Load(object sender, EventArgs e)
		{
			//To show data in datagridview
			DataTable dt = dcdal.Select();
			dgvDeaCust.DataSource = dt;
		}

		private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//int variable to get the identity from clicked
			int rowIndex = e.RowIndex;
			txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
			cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
			txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
			txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
			txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
			txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
		}

		private void btnuPDATE_Click(object sender, EventArgs e)
		{
			//Get the values from the UI
			dc.id = int.Parse(txtDeaCustID.Text);
			dc.type = cmbDeaCust.Text;
			dc.name = txtName.Text;
			dc.email = txtEmail.Text;
			dc.contact = txtContact.Text;
			dc.address = txtAddress.Text;
			dc.added_date = DateTime.Now;
			//getting the id in usr and passing its value in dlr custmr module
			string loggedUser = frmLogin.loggedIn;
			userBLL usr = uDal.GetIDFromUsername(loggedUser);
			dc.added_by = usr.id;

			//Bool variable to check wheather the deqaler or customer is updated or not
			bool success = dcdal.Update(dc);
			if(success==true)
			{
				//deasler and customer updated successfully
				MessageBox.Show("Dealer or Customer Updated Successfully");
				Clear();
				//Refresh data in datagridview
				DataTable dt = dcdal.Select();
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				//Failed to update
				MessageBox.Show("Failed to Update Dealer or Customer");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//get the id of the user to be deleted from UI
			dc.id = int.Parse(txtDeaCustID.Text);

			//create bool variable to check whetaher the dealer or customer is delted or not
			bool success = dcdal.Delete(dc);
			if(success==true)
			{
				//Delaer or Customer Deleted Successfully
				MessageBox.Show("Dealer or Customer Deleted Successfully");
				Clear();
				//Refresh data in datagridview
				DataTable dt = dcdal.Select();
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				//Failed to Delete
				MessageBox.Show("Failed to Delete Dealer or Customer");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			//get the keyword from the text box
			string keyword = txtSearch.Text;
			if(keyword!=null)
			{
				//search the delear or customer
				DataTable dt = dcdal.Search(keyword);
				dgvDeaCust.DataSource = dt;
			}
			else
			{
				//Show all the records
				DataTable dt = dcdal.Select();
				dgvDeaCust.DataSource = dt;
			}
		}
	}
}
