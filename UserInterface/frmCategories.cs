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
	public partial class frmCategories : Form
	{
		public frmCategories()
		{
			InitializeComponent();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		categoriesBLL c = new categoriesBLL();
		categoriesDAL dal = new categoriesDAL();
		userDAL udal = new userDAL();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//Get the vales from categories form
			c.title = txtTitle.Text;
			c.description = txtDescription.Text;
			c.added_date = DateTime.Now;

			//Getting ID in Added by Field
			string loggedUser = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUser);

			//Passing the ID Logged in uSer in Added by field
			c.added_by = usr.id;

			//Creating Boolean Method to insert data into database
			bool success = dal.Insert(c);

			//If the category is inserted successfully then the value of the success will be truue else it will be false
			if(success==true)
			{
				//New Category Inserted Suuccessfully
				MessageBox.Show("New Category Inserted Successfully");
				Clear();

				//To refresh datagridviewS
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
			else
			{
				//Failed to Inmsert New category
				MessageBox.Show("Failed to Insert New Category");
			}
		}
		public void Clear()
		{
			txtCategoryID.Text = "";
			txtTitle.Text = "";
			txtDescription.Text = "";
			txtSearch.Text = "";
		}

		private void frmCategories_Load(object sender, EventArgs e)
		{
			//To Display All of the Categories in DAta Grid View
			DataTable dt = dal.Select();
			dgvCategories.DataSource = dt;
		}

		private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//Finding the row index of the row clicked on data grid view
			int RowIndex = e.RowIndex;
			txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
			txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
			txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//get the vales from the categoris form
			c.id = int.Parse(txtCategoryID.Text);
			c.title = txtTitle.Text;
			c.description = txtDescription.Text;
			c.added_date = DateTime.Now;

			//Getting ID in Added by Field
			string loggedUser = frmLogin.loggedIn;
			userBLL usr = udal.GetIDFromUsername(loggedUser);

			//Passing the ID Logged in uSer in Added by field
			c.added_by = usr.id;
			//Creating variable to update categories
			bool success = dal.Update(c);
			//If the category is pdated successflly then the value of success will be true else it will be false
			if(success==true)
			{
				//Category updated successfully
				MessageBox.Show("Category Updated Successfully");
				Clear();

				//To refresh datagridview
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
			else
			{
				//Failed to update
				MessageBox.Show("Failed to Update Category");
			}
		}

		private void btn_Click(object sender, EventArgs e)
		{
			//get the id of the category we want to delete
			c.id = int.Parse(txtCategoryID.Text);

			//creating boolean variable to delete the category
			bool success = dal.Delete(c);

			//If the category is deletd successfully then the value will be true else it will be false
			if(success==true)
			{
				//category deleted successfully
				MessageBox.Show("Category Deleted Successfully");
				Clear();
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
			else
			{
				//Failed to delete category
				MessageBox.Show("Failed to Delete Category");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			//get the keywords first
			string keywords = txtSearch.Text;

			//Filter the categories based on keywords
			if(keywords!=null)
			{
				//use Search Method to display categories
				DataTable dt = dal.Search(keywords);
				dgvCategories.DataSource = dt;
			}
			else
			{
				//Use Select Method to display all categories
				DataTable dt = dal.Select();
				dgvCategories.DataSource = dt;
			}
		}
	}
}
