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
	class delrCustDAL
	{
		//static string method for db conn
		static string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

		#region Select Method for Dealer and Customer
		public DataTable Select()
		{
			//sql connection for db connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//Datat Table for hold the value from db and return it
			DataTable dt = new DataTable();
			try
			{
				//sql query to select all the data from db
				string sql = "SELECT * FROM tbl_dea_cust";

				//Creating sql command
				SqlCommand cmd = new SqlCommand(sql, conn);

				//creating data adapter to store db temp
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				conn.Open();
				//passing the values from the data adpter to db table
				adapter.Fill(dt);
			}
			catch (Exception ex)
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
		#region Insert Method to Add Details for Dealer and Customer
		public bool Insert(deaCustBLL dc)
		{
			//creating sql connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//create a boolean value and set its default to false
			bool isSuccess = false;

			try
			{
				//sql query to insert deatils of dealer or customer
				string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address, added_date, added_by) VALUES (@type, @name, @email, @contact, @address, @added_date, @added_by)";

				//sql command to pass the values to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing the values usiing parameters
				cmd.Parameters.AddWithValue("@type", dc.type);
				cmd.Parameters.AddWithValue("@name", dc.name);
				cmd.Parameters.AddWithValue("@email", dc.email);
				cmd.Parameters.AddWithValue("@contact", dc.contact);
				cmd.Parameters.AddWithValue("@address", dc.address);
				cmd.Parameters.AddWithValue("@added_date", dc.added_date);
				cmd.Parameters.AddWithValue("@added_by", dc.added_by);

				//open the db conn
				conn.Open();

				//creating int variable to check wheather the query the executed or not
				int rows = cmd.ExecuteNonQuery();

				//if the query is executed successfully then the value of the rows will be >0 else <0
				if (rows > 0)
				{
					//query executed successfully
					isSuccess = true;
				}
				else
				{
					//failed to execute the query
					isSuccess = false;
				}
			}
			catch (Exception ex)
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
		#region Update Method for Dealer and Customer Module
		public bool Update(deaCustBLL dc)
		{
			//sql conn for db conn
			SqlConnection conn = new SqlConnection(myconnstring);
			//create a boolean  variable and set its deafult value to false
			bool isSuccess = false;

			try
			{
				//sql query to update in db
				string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=@added_by WHERE id=@id";
				//create sql command to pass the values
				SqlCommand cmd = new SqlCommand(sql, conn);

				//passing the values through parameters
				cmd.Parameters.AddWithValue("@type", dc.type);
				cmd.Parameters.AddWithValue("@name", dc.name);
				cmd.Parameters.AddWithValue("@email", dc.email);
				cmd.Parameters.AddWithValue("@contact", dc.contact);
				cmd.Parameters.AddWithValue("@address", dc.address);
				cmd.Parameters.AddWithValue("@added_date", dc.added_date);
				cmd.Parameters.AddWithValue("@added_by", dc.added_by);
				cmd.Parameters.AddWithValue("@id", dc.id);

				conn.Open();

				//int variable to check if the query is successfully executed or !
				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					//Query executed successfully
					isSuccess = true;
				}
				else
				{
					//Failed to execute the query
					isSuccess = false;
				}
			}
			catch (Exception ex)
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
		#region Delete Method for Dealer and Customer Module
		public bool Delete(deaCustBLL dc)
		{
			//creating sql connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//create a boolean value and set its default to false
			bool isSuccess = false;

			try
			{
				//sql query to delet data from db
				string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

				//sql command to pass the value
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing the valuue
				cmd.Parameters.AddWithValue("@id", dc.id);

				//open the db conn
				conn.Open();

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					//Qury executed successfully
					isSuccess = true;
				}
				else
				{
					//Failed to execute the query
					isSuccess = false;
				}
			}
			catch (Exception ex)
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
		#region Search Method For Dealer And Customer Module
		public DataTable Search(string keyword)
		{
			//Create a sql conn
			SqlConnection conn = new SqlConnection(myconnstring);
			//creating a data table and returning its value
			DataTable dt = new DataTable();

			try
			{
				//query to search the dealer or customer
				string sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
				//sql command to execute the query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sql data adapter to hold the data
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				conn.Open();
				//pass the value from the adapter to data table
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
		#region Method to Search Dealer or Customer For Transaction Module
		public deaCustBLL searchDealerCustomerforTransaction(string keyword)
		{
			//Creating object for dea cust bll class
			deaCustBLL dc = new deaCustBLL();

			//creating a database connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//creating a data table to hold the value temporarily
			DataTable dt = new DataTable();

			try
			{
				//writing a sql query to search dealer or customer based on keywords
				string sql = "SELECT name, email, contact, address from tbl_dea_cust WHERE id LIKE '%" +keyword+ "%' OR name LIKE '%" +keyword+ "%'";

				//creating a sql query data adapater to execute the query
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

				conn.Open();

				//transfer the data from sqldata adapter to data table
				adapter.Fill(dt);

				//if we have values on dt we need to save in dealercustomer Bll
				if(dt.Rows.Count>0)
				{
					dc.name = dt.Rows[0]["name"].ToString();
					dc.email = dt.Rows[0]["email"].ToString();
					dc.contact = dt.Rows[0]["contact"].ToString();
					dc.address = dt.Rows[0]["address"].ToString();
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
			return dc;
		}
		#endregion
		#region Method To Get The ID Of The Dealer OR Customer based On Name
		public deaCustBLL GetDeaCustIDFromName(string Name)
		{
			//First create an object of deacustBLL and return it
			deaCustBLL dc = new deaCustBLL();
			//sql conn
			SqlConnection conn = new SqlConnection(myconnstring);
			//data table to hold data temporariliy
			DataTable dt = new DataTable();
			try
			{
				// sql query to get id based on name
				string sql = "SELECT id FROM tbl_dea_cust WHERE name='" + Name + "'";
				//create the sql data adapter
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();

				//passing the value from adapter to data table
				adapter.Fill(dt);
				if(dt.Rows.Count>0)
				{
					//pass the value from dt to deacustBLLdc
					dc.id = int.Parse(dt.Rows[0]["id"].ToString());
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
			return dc;
		}
		#endregion
	}
}