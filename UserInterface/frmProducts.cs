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
	public partial class frmProducts : Form
	{
		public frmProducts()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		categoriesDAL cdal = new categoriesDAL();
		productsBLL p = new productsBLL();
		productsDAL pdal = new productsDAL();
		userDAL udal = new userDAL();
		private void frmProducts_Load(object sender, EventArgs e)
		{
			//creating the data table to hold the categories from db
			DataTable categoriesDT = cdal.Select();
			//Specify datasource combo box
			cmbcategory.DataSource = categoriesDT;
			//specify display display and vbalue member for combobox
			cmbcategory.DisplayMember = "title";
			cmbcategory.ValueMember = "title";

			//load all the products in data grid view
			DataTable dt = pdal.Select();
			dgvProdcts.DataSource = dt;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//gET ALL THE VALUES FROM products FORM
			p.name = txtName.Text;
			p.category = cmbcategory.Text;
			p.description = txtDescription.Text;
			p.rate = decimal.Parse(txtRate.Text);
			p.qty = 0;
			p.added_date = DateTime.Now;
			//username of logged in user
			string loggedUsr = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUsr);

			p.added_by = usr.id;

			//Create variable to check if the product is successfully added or not
			bool success = pdal.Insert(p);
			//If the product is added successfully then the value of success will be true else false
			if(success==true)
			{
				//Product Successfully added
				MessageBox.Show("Product Added Successfully");
				Clear();
				//To refresh datagridviewS
				DataTable dt = pdal.Select();
				dgvProdcts.DataSource = dt;
			}
			else
			{
				//Failed to added the product
				MessageBox.Show("Failed to Add the Prodct");
			}
		}
		public void Clear()
		{
			txtID.Text = "";
			txtName.Text = "";
			txtRate.Text = "";
			txtDescription.Text = "";
			txtSearch.Text = "";
		}

		private void dgvProdcts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//Finding the row index of the row clicked on data grid view
			int RowIndex = e.RowIndex;
			txtID.Text = dgvProdcts.Rows[RowIndex].Cells[0].Value.ToString();
			txtName.Text = dgvProdcts.Rows[RowIndex].Cells[1].Value.ToString();
			cmbcategory.Text = dgvProdcts.Rows[RowIndex].Cells[2].Value.ToString();
			txtDescription.Text = dgvProdcts.Rows[RowIndex].Cells[3].Value.ToString();
			txtRate.Text = dgvProdcts.Rows[RowIndex].Cells[4].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//get the values from ui product
			p.id = int.Parse(txtID.Text);
			p.name = txtName.Text;
			p.category = cmbcategory.Text;
			p.description = txtDescription.Text;
			p.rate = decimal.Parse(txtRate.Text);
			p.added_date = DateTime.Now;
			//getting user name of  logged in user for added_by
			string loggedUsr = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUsr);
			p.added_by = usr.id;

			//create bool variable to check if the product is updated or not
			bool success = pdal.Update(p);

			//If the product is updated successfully then the value of success will be true else false
			if(success== true)
			{
				//Updated successfully
				MessageBox.Show("Product Updated Successfully");
				Clear();
				//To refresh datagridviewS
				DataTable dt = pdal.Select();
				dgvProdcts.DataSource = dt;
			}
			else
			{
				//Failed to uupdate
				MessageBox.Show("Failed to Update the Product");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//get the id of the ui product
			p.id = int.Parse(txtID.Text);

			//create bool variable to check if the data is deleted or not
			bool success = pdal.Delete(p);

			//if the product is deleted successfully the value of the success is true else false
			if (success == true)
			{
				//Updated successfully
				MessageBox.Show("Product Deleted Successfully");
				Clear();
				//To refresh datagridviewS
				DataTable dt = pdal.Select();
				dgvProdcts.DataSource = dt;
			}
			else
			{
				//Failed to uupdate
				MessageBox.Show("Failed to Delete the Product");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			//get the keyword from the ui
			string keywords = txtSearch.Text;

			if(keywords!=null)
			{
				//Search the products
				DataTable dt = pdal.Search(keywords);
				dgvProdcts.DataSource = dt;
			}
			else
			{
				//display all the products
				DataTable dt = pdal.Select();
				dgvProdcts.DataSource = dt;
			}
		}
	}
}
