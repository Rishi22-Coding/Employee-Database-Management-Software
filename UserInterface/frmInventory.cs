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
	public partial class frmInventory : Form
	{
		public frmInventory()
		{
			InitializeComponent();
		}

		categoriesDAL cDAL = new categoriesDAL();
		productsDAL pDAL = new productsDAL();
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void frmInventory_Load(object sender, EventArgs e)
		{
			//display the categories in cmbBox
			DataTable cDT = cDAL.Select();

			cmbCategory.DataSource = cDT;

			//give the value member and display member for combo box
			cmbCategory.DisplayMember = "title";
			cmbCategory.ValueMember = "title";

			//display all the products in the dgv when the frm loaded
			DataTable pDT = pDAL.Select();
			dgvProducts.DataSource = pDT;
		}

		private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Display all the products based on selected categhories
			string category = cmbCategory.Text;

			DataTable dt = pDAL.DisplayProductByCategory(category);
			dgvProducts.DataSource = dt;
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			//display all the products when this btn is clicked
			DataTable dt = pDAL.Select();
			dgvProducts.DataSource = dt;
		}
	}
}
