using Invoicing_Software.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_Software
{
	public partial class frmUserDashboard : Form
	{
		public frmUserDashboard()
		{
			InitializeComponent();
		}

		//set a public method to specify weather the form is purchase or sales
		public static string transactionType;
		private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//set value on trasaction type static method
			transactionType = "SALES";
			frmPurchaseandSales sales = new frmPurchaseandSales();
			sales.Show();
		}

		private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmLogin login = new frmLogin();
			login.Show();
			this.Hide();
		}

		private void frmUserDashboard_Load(object sender, EventArgs e)
		{
			lblLoggedInUser.Text = frmLogin.loggedIn;
		}

		private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDlrCustmr DeaCust = new frmDlrCustmr();
			DeaCust.Show();
		}

		private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//set value on trasaction type static method
			transactionType = "PURCHASE";
			frmPurchaseandSales purchase = new frmPurchaseandSales();
			purchase.Show();
		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmInventory Inventory = new frmInventory();
			Inventory.Show();
		}
	}
}
