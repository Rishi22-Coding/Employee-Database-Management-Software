using System;
using Invoicing_Software;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicing_Software.UserInterface;

namespace Invoicing_Software
{
	public partial class frmAdminDashboard : Form
	{
		public frmAdminDashboard()
		{
			InitializeComponent();
		}

		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUsers user = new frmUsers();
			user.Show();
		}

		private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmLogin login = new frmLogin();
			login.Show();
			this.Hide();
		}

		private void frmAdminDashboard_Load(object sender, EventArgs e)
		{
			lblLoggedInUser.Text = frmLogin.loggedIn;
		}

		private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCategories category = new frmCategories();
			category.Show();
		}

		private void productsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmProducts product = new frmProducts();
			product.Show();
		}

		private void dealerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDlrCustmr DeaCust = new frmDlrCustmr();
			DeaCust.Show();
		}

		private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTransactions transaction = new frmTransactions();
			transaction.Show();
		}

		private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmInventory Inventory = new frmInventory();
			Inventory.Show();
		}
	}
}
