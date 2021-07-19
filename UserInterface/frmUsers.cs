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
	public partial class frmUsers : Form
	{
		public frmUsers()
		{
			InitializeComponent();
		}
		userBLL u = new userBLL();
		userDAL dal = new userDAL();

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//Getting username of the logged in user
			string loggedUser = frmLogin.loggedIn;


			//Getting Data from UI
			u.first_name = txtFirstName.Text;
			u.last_name = txtLastName.Text;
			u.email = txtEmail.Text;
			u.username = txtUsername.Text;
			u.password = txtPassword.Text;
			u.contact = txtContact.Text;
			u.address = txtAddress.Text;
			u.gender = cmbGender.Text;
			u.user_type = cmbUserType.Text;
			u.added_date = DateTime.Now;

			//Getting Username of the logged in user
			string loggeduser = frmLogin.loggedIn;
			userBLL usr = dal.GetIDFromUsername(loggedUser);

			u.added_by = usr.id;

			//Inserting Data into Database
			bool success = dal.Insert(u);
			//If the data is successfully inserted then the value will be true else it will be false
			if(success==true)
			{
				//Data Successfully Inserted
				MessageBox.Show("User Suuccessfully Created");
				clear();
			}
			else
			{
				//Failed to Insert Data
				MessageBox.Show("Failed to Add New User");
			}
			//Refresing DatagridView
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;
		}

		private void frmUsers_Load(object sender, EventArgs e)
		{
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;
		}
		private void clear()
		{
			txtUserID.Text = "";
			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtEmail.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			cmbGender.Text = "";
			cmbUserType.Text = "";

		}

		private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//Get the index of the particular row
			int rowIndex = e.RowIndex;
			txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
			txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
			txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
			txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
			txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
			txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
			txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
			txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
			cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
			cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//Get the valuues from UI
			u.id = Convert.ToInt32(txtUserID.Text);
			u.first_name = txtFirstName.Text;
			u.last_name = txtLastName.Text;
			u.email = txtEmail.Text;
			u.username = txtUsername.Text;
			u.password = txtPassword.Text;
			u.contact = txtContact.Text;
			u.address = txtAddress.Text;
			u.gender = cmbGender.Text;
			u.user_type = cmbUserType.Text;
			u.added_date = DateTime.Now;
			u.added_by = 1;

			//Updating Data into Database
			bool success = dal.update(u);
			//if data isnt uupdated suuccessfully then the valuue will be true else it will be false
			if(success==true)
			{
				//Data Updated Successfully
				MessageBox.Show("User Successfully Updated");
				clear();
			}
			else
			{
				//Data Update Unsuccessful
				MessageBox.Show("Failed to Update User");
			}
			//Refresing DatagridView
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//Getting User ID from the UI
			u.id = Convert.ToInt32(txtUserID.Text);

			bool success = dal.Delete(u);
			//if data is deleted then the value of suuccess will be truue else it will be false
			if(success==true)
			{
				//Delete Successfull
				MessageBox.Show("User Deleted Successfully");
			}
			else
			{
				//Delete Unsucessfull
				MessageBox.Show("Failed to Delete User");
			}
			//Refresing DatagridView
			DataTable dt = dal.Select();
			dgvUsers.DataSource = dt;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			//Get Keyword from Text Box Search
			string keywords = txtSearch.Text;

			//Check if the keyword have any value or not
			if(keywords !=null)
			{
				//Show user based on Keywords
				DataTable dt = dal.Search(keywords);
				dgvUsers.DataSource = dt;
			}
			else
			{
				//Show all users from the Database
				DataTable dt = dal.Select();
				dgvUsers.DataSource = dt;
			}
		}
	}
}
