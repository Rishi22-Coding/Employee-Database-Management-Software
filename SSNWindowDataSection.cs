using SSNProject.SSNClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSNProject
{
	public partial class SSNWindowDataSection : Form
	{
		public SSNWindowDataSection()
		{
			InitializeComponent();
		}
		SSNClass c = new SSNClass();
		private string myconnstrng;

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			//get the value from input fields
			c.ID = Convert.ToInt32(TextBoxID.Text);
			c.Name = TextBoxName.Text;
			c.State = TextBoxState.Text;
			c.DateOfBirth = DateTimePickerDOB.Text;
			c.IssuingYear = DateTimePickerIssuingYear.Text;
			c.TelephoneNumber = TextBoxTelephoneNumber.Text;
			c.ZipCode = TextBoxZipCode.Text;
			c.SSN = TextBoxSSN.Text;

			//insert data into database using method we created
			bool success = c.Insert(c);
			if(success==true)
			{
				//successfully inserted
				MessageBox.Show("Data Inserted Successfully");
				//Call clear method here
				Clear();
			}
			else
			{
				//Failed to Add
				MessageBox.Show("Failed to Insert");
			}
			//Load Data on Data grid View
			DataTable dt = c.Select();
			DgvSSNList.DataSource = dt;
		}

		private void SSNWindow_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sSNDatabaseDataSet.Table_SSN' table. You can move, or remove it, as needed.
			this.table_SSNTableAdapter.Fill(this.sSNDatabaseDataSet.Table_SSN);
			DataTable dt = c.Select();
			DgvSSNList.DataSource = dt;
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//Method to clear all fields
		public void Clear()
		{
			TextBoxID.Text = "";
			TextBoxName.Text = "";
			TextBoxState.Text = "";
			DateTimePickerDOB.Text = "";
			DateTimePickerIssuingYear.Text = "";
			TextBoxTelephoneNumber.Text = "";
			TextBoxZipCode.Text = "";
			TextBoxSSN.Text = "";
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			//get the data from textboxes
			c.ID = Convert.ToInt32(TextBoxID.Text);
			c.Name = TextBoxName.Text;
			c.State = TextBoxState.Text;
			c.DateOfBirth = DateTimePickerDOB.Text;
			c.IssuingYear = DateTimePickerIssuingYear.Text;
			c.TelephoneNumber = TextBoxTelephoneNumber.Text;
			c.ZipCode = TextBoxZipCode.Text;
			c.SSN = TextBoxSSN.Text;
			//Update data in database
			bool success = c.Update(c);
			if(success==true)
			{
				//Updated Successfully
				MessageBox.Show("Updated Successfully");
				DataTable dt = c.Select();
				DgvSSNList.DataSource = dt;
				Clear();
			}
			else
			{
				//Failed to update
				MessageBox.Show("Update Failed");
			}
		}

		private void DgvSSNList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//Get the data from the grid view and load it to the text boxes respectively Identify the row on which mouse is clicked
			int rowIndex = e.RowIndex;
			TextBoxID.Text = DgvSSNList.Rows[rowIndex].Cells[0].Value.ToString();
			TextBoxSSN.Text = DgvSSNList.Rows[rowIndex].Cells[1].Value.ToString();
			TextBoxName.Text = DgvSSNList.Rows[rowIndex].Cells[2].Value.ToString();
			TextBoxState.Text = DgvSSNList.Rows[rowIndex].Cells[3].Value.ToString();
			DateTimePickerDOB.Text = DgvSSNList.Rows[rowIndex].Cells[4].Value.ToString();
			DateTimePickerIssuingYear.Text = DgvSSNList.Rows[rowIndex].Cells[5].Value.ToString();
			TextBoxTelephoneNumber.Text = DgvSSNList.Rows[rowIndex].Cells[6].Value.ToString();
			TextBoxZipCode.Text = DgvSSNList.Rows[rowIndex].Cells[7].Value.ToString();
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			//Call Clear Method Here
			Clear();
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			//Get data From data grid view from the text boxes
			c.ID = Convert.ToInt32(TextBoxID.Text);
			bool success = c.Delete(c);
			if(success==true)
			{
				//Successfully deleted
				MessageBox.Show("Deleted Successfully");
				DataTable dt = c.Select();
				DgvSSNList.DataSource = dt;
				Clear();

			}
			else
			{
				//Failed to delete
				MessageBox.Show("Failed To Delete");
			}
		}
	}
}
