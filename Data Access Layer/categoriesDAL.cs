using Invoicing_Software.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_Software.Data_Access_Layer
{
	class categoriesDAL
	{
		//static string method for database connection
		static string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

		#region Select Method
		public DataTable Select()
		{
			//Creating Database Connection
			SqlConnection conn = new SqlConnection(myconnstring);
			DataTable dt = new DataTable();
			try
			{
				//Writting SQL Query to get all the data from database
				string sql = "SELECT * FROM tbl_categories";
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				//open database connection
				conn.Open();
				//Adding the value from adpter to data table dt
				adapter.Fill(dt);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return dt;
		}
		#endregion
		#region Inserrt New Category
		public bool Insert(categoriesBLL c)
		{
			//Creating a Boolean Variable and set its default to false
			bool isSuccess = false;

			//Connecting to Database
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//Writing Query to ADD new Category
				string sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";

				//Creating SQL Command to pass values in our Queries
				SqlCommand cmd = new SqlCommand(sql, conn);
				//Passing Values through Parameter
				cmd.Parameters.AddWithValue("@title", c.title);
				cmd.Parameters.AddWithValue("@description", c.description);
				cmd.Parameters.AddWithValue("@added_date", c.added_date);
				cmd.Parameters.AddWithValue("@added_by", c.added_by);
				cmd.Parameters.AddWithValue("@id", c.id);

				//Open Database Connection
				conn.Open();

				//Creating the int variable to execute query
				int rows = cmd.ExecuteNonQuery();

				//If the query is executed successfully then the value will be greater than 0 else it will be less than 0

				if(rows>0)
				{
					//Query Executed Successfully
					isSuccess = true;
				}
				else
				{
					//Failed to Execute
					isSuccess = false;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Closing Databse Connection
				conn.Close();
			}
			return isSuccess;
		}
		#endregion
		#region Update Category
		public bool Update(categoriesBLL c)
		{
			//Creating Boolean Variable and set its default value to false
			bool isSuccess = false;

			//Creating SQL Connection
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//Query to Update Category
				string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

				//SQL Command to pass the values on sql queries
				SqlCommand cmd = new SqlCommand(sql, conn);

				//Passing value using cmd
				cmd.Parameters.AddWithValue("@title", c.title);
				cmd.Parameters.AddWithValue("@description", c.description);
				cmd.Parameters.AddWithValue("@added_date", c.added_date);
				cmd.Parameters.AddWithValue("@added_by", c.added_by);
				cmd.Parameters.AddWithValue("@id", c.id);

				//Open Database Connection
				conn.Open();

				//Create Int Variable to execute query
				int rows = cmd.ExecuteNonQuery();
				//if the query is successfully exceuted than the value will be >0 ellse the value will <0
				if(rows>0)
				{
					//Query Executed Sucessfully
					isSuccess = true;
				}
				else
				{
					//Failed to Execute Quuery
					isSuccess = false;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return isSuccess;
		}
		#endregion
		#region Delete Category Method
		public bool Delete(categoriesBLL c)
		{
			//Create a boolean variable and set its value to false
			bool isSuccess = false;
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//sql query to delete from database
				string sql = "DELETE FROM tbl_categories WHERE id=@id";
				SqlCommand cmd = new SqlCommand(sql, conn);

				//Passing the valuue using cmd
				cmd.Parameters.AddWithValue("@id", c.id);

				//Open Sql Connection
				conn.Open();

				int rows = cmd.ExecuteNonQuery();

				//if the quuery is sucessfully exceuted then the value its of rows will be greater than 0 else it will be less than zero
				if(rows>0)
				{
					//Query Executed Successfully
					isSuccess = true;
				}
				else
				{
					//Failed to Execuute Query
					isSuccess = false;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return isSuccess;
		}
		#endregion
		#region Method for Search
		public DataTable Search(string Keywords)
		{
			//SQL connect for database connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//Creating datatable to hold the data temporarily
			DataTable dt = new DataTable();

			try
			{
				//sql query to search categories from database
				string sql = "SELECT * from tbl_categories WHERE id LIKE '%" + Keywords + "%' OR title LIKE '%"+Keywords+"%' OR description LIKE '%"+Keywords+"'";
				//creating sql command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);

				//Getting data from database
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				//open database conn
				conn.Open();

				//passing the valuues from adapter to data table dt
				adapter.Fill(dt);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return dt;
		}
		#endregion
	}
}
