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
	public partial class Search_SSN : Form
	{
		public object TextBoxSearch { get; private set; }

		public Search_SSN()
		{
			InitializeComponent();
		}

		private void Table_SSNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.table_SSNBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.sSNDatabaseDataSet);

		}

		private void Search_SSN_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sSNDatabaseDataSet.Table_SSN' table. You can move, or remove it, as needed.
			this.table_SSNTableAdapter.Fill(this.sSNDatabaseDataSet.Table_SSN);

		}
		static string myconnstr = ConfigurationManager.ConnectionStrings["SSNProject.Properties.Settings.SSNDatabaseConnectionString"].ConnectionString;
		private void TextBoxSearch_TextChanged_1(object sender, EventArgs e)
		{
			/*Get the value from text boxes
			string keyword = textBoxSearch.Text;
			SqlConnection conn = new SqlConnection(myconnstr);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Table_SSN WHERE Name Like '%" + keyword + "%' OR State Like '%" + keyword + "%' OR TelephoneNumber Like '%" + keyword + "%' OR ZipCode Like '%" + keyword + "%' OR SSN Like '%" + keyword + "%'", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			table_SSNDataGridView.DataSource = dt;

			string search = textBoxSearch.Text;
			for (int i = 0; i < table_SSNDataGridView.Rows.Count; i++)
			{
				if (table_SSNDataGridView.Rows[i].Cells[0].Value.ToString() == "search")
				{
					table_SSNDataGridView.Rows[i].Selected = true;
					table_SSNDataGridView.Rows[i].Visible = true;
				}
				else
				{
					table_SSNDataGridView.Rows[i].Visible = false;
					table_SSNDataGridView.Rows[i].Selected = false;
				}
			}*/
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			string keyword = textBoxSearch.Text;
			SqlConnection conn = new SqlConnection(myconnstr);
			SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Table_SSN WHERE Name Like '%" + keyword + "%' OR State Like '%" + keyword + "%' OR TelephoneNumber Like '%" + keyword + "%' OR ZipCode Like '%" + keyword + "%' OR SSN Like '%" + keyword + "%'", conn);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			table_SSNDataGridView.DataSource = dt;

			/*string search = textBoxSearch.Text;
			for (int i = 0; i < table_SSNDataGridView.Rows.Count; i++)
			{
				if (table_SSNDataGridView.Rows[i].Cells[0].Value.ToString() == "search")
				{
					table_SSNDataGridView.Rows[i].Selected = true;
					table_SSNDataGridView.Rows[i].Visible = true;
				}
				else
				{
					table_SSNDataGridView.Rows[i].Visible = false;
					table_SSNDataGridView.Rows[i].Selected = false;
				}
			}*/

		}
	}
}
