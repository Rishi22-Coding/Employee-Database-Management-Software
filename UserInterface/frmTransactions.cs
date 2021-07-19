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
	public partial class frmTransactions : Form
	{
		public frmTransactions()
		{
			InitializeComponent();
		}

		transactionsDAL tdal = new transactionsDAL();
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void frmTransactions_Load(object sender, EventArgs e)
		{
			//display all the transactions
			DataTable dt = tdal.DisplayAllTransactions();
			dgvTransactions.DataSource = dt;
		}

		private void cmbTransactionsType_SelectedIndexChanged(object sender, EventArgs e)
		{
			//get the values from cmb box
			string type = cmbTransactionsType.Text;

			DataTable dt = tdal.DisplayTransactionByType(type);
			dgvTransactions.DataSource = dt;
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			//display all the transactions
			DataTable dt = tdal.DisplayAllTransactions();
			dgvTransactions.DataSource = dt;
		}
	}
}
