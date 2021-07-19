using Invoicing_Software.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_Software.Data_Access_Layer
{
	class productsDAL
	{
		//static string method for database connection
		static string myconnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

		#region Select Method for Product Module
		public DataTable Select()
		{
			//create sql connection to connect database 
			SqlConnection conn = new SqlConnection(myconnstring);

			//DataTable to hold the data from database
			DataTable dt = new DataTable();

			try
			{
				//query to select all the prducts from the database
				string sql = "SELECT * FROM tbl_products";

				//creating sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);

				//sql data adapter to hold the value from database temporarily
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				//open database connection
				conn.Open();

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
		#region Method to Insert Product in Database
		public bool Insert(productsBLL p)
		{
			//creating boolean variable and set its default value to false
			bool isSuccess = false;

			//sql connection for database
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//sql query to insert product to database
				string sql = "INSERT INTO tbl_products (name, category, description, rate, qty, added_date, added_by) VALUES(@name, @category, @description, @rate, @qty, @added_date, @added_by)";

				//creating sql command to pass the values
				SqlCommand cmd = new SqlCommand(sql, conn);

				//passing the values through parameters
				cmd.Parameters.AddWithValue("@name", p.name);
				cmd.Parameters.AddWithValue("@category", p.category);
				cmd.Parameters.AddWithValue("@description", p.description);
				cmd.Parameters.AddWithValue("@rate", p.rate);
				cmd.Parameters.AddWithValue("@qty", p.qty);
				cmd.Parameters.AddWithValue("@added_date", p.added_date);
				cmd.Parameters.AddWithValue("@added_by", p.added_by);

				//openning the database connection
				conn.Open();

				int rows = cmd.ExecuteNonQuery();

				//If the query is executed successfully then the value of rows will be gretaer than 0 else it will less than0
				if (rows > 0)
				{
					//Query Executed Successfully
					isSuccess = true;
				}
				else
				{
					//Failed to Execute Query
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
		#region Method to Update Product in Database
		public bool Update(productsBLL p)
		{
			//create a bool variable and set its default value to false
			bool isSuccess = false;

			//Create sql connection for database
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//sql query to update and database
				string sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";

				//Create sql command to pass the value to query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//Passing the values using parameters and cmd
				cmd.Parameters.AddWithValue("@name", p.name);
				cmd.Parameters.AddWithValue("@category", p.category);
				cmd.Parameters.AddWithValue("@description", p.description);
				cmd.Parameters.AddWithValue("@rate", p.rate);
				cmd.Parameters.AddWithValue("@qty", p.qty);
				cmd.Parameters.AddWithValue("@added_date", p.added_date);
				cmd.Parameters.AddWithValue("@added_by", p.added_by);
				cmd.Parameters.AddWithValue("@id", p.id);

				//Open the database connection
				conn.Open();

				//create int variable to check the query is executed or not
				int rows = cmd.ExecuteNonQuery();

				//If the query is executed then the rows will be >0 else <0
				if (rows > 0)
				{
					//Query successfully Execuuted
					isSuccess = true;
				}
				else
				{
					//Failed to Execute the query
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
		#region Method to Delete Product from the Database
		public bool Delete(productsBLL p)
		{
			//Create boolean variable and set its default value to false
			bool isSuccess = false;

			//SqlConnection for db connection
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//Sql quuery to delete from database
				string sql = "DELETE FROM tbl_products WHERE id=@id";

				//Sql command to pass the value
				SqlCommand cmd = new SqlCommand(sql, conn);

				//Passing the values using cmd
				cmd.Parameters.AddWithValue("@id", p.id);

				//open the database conn
				conn.Open();

				int rows = cmd.ExecuteNonQuery();
				//if the qery is execuuted sccessfully then the value will >0 else <0
				if (rows > 0)
				{
					//Quuery exected sccessfully
					isSuccess = true;
				}
				else
				{
					//Faiiled to execute query
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
		#region SEARCH Method for product module
		public DataTable Search(string keywords)
		{
			//create sql connection to connect database 
			SqlConnection conn = new SqlConnection(myconnstring);
			//Creating data table to hold value from db
			DataTable dt = new DataTable();

			try
			{
				//sql query to search product
				string sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";
				//SQL command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);

				//sql data adapter to hold the data from the db temp
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				conn.Open();
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
		#region Method to Search Product in Transaction Module
		public productsBLL GetProductForTransaction(string keyword)
		{
			//Create an object of productBLL and return it
			productsBLL p = new productsBLL();
			//sql connection
			SqlConnection conn = new SqlConnection(myconnstring);
			DataTable dt = new DataTable();

			try
			{
				//write the query to get the details
				string sql = "SELECT name, rate, qty FROM tbl_products WHERE id LIKE '%" + keyword + "%'OR name LIKE '%" + keyword + "%'";
				//create sql data adpater to execute the query
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				//Open db conn
				conn.Open();

				//Pass the value from adapter dt
				adapter.Fill(dt);

				//if we have any values on dt then set the values on productBLL
				if (dt.Rows.Count > 0)
				{
					p.name = dt.Rows[0]["name"].ToString();
					p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
					p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

			return p;
		}
		#endregion
		#region Method To Get ProductID Based On ProductName
		public productsBLL GetProductsIDFromName(string ProductName)
		{
			//First create an object of deacustBLL and return it
			productsBLL p = new productsBLL();
			//sql conn
			SqlConnection conn = new SqlConnection(myconnstring);
			//data table to hold data temporariliy
			DataTable dt = new DataTable();
			try
			{
				// sql query to get id based on name
				string sql = "SELECT id FROM tbl_products WHERE name='" + ProductName + "'";
				//create the sql data adapter
				SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
				conn.Open();

				//passing the value from adapter to data table
				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					//pass the value from dt to deacustBLLdc
					p.id = int.Parse(dt.Rows[0]["id"].ToString());
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
			return p;
		}
		#endregion
		#region Method to Get Current Quantity From Database Based On ProductID
		public decimal GetProductQty(int ProductID)
		{
			//sql conn first
			SqlConnection conn = new SqlConnection(myconnstring);
			//create a decimal variable and set its default value to 0
			decimal qty = 0;

			//create datatable to save the data from db temprarily
			DataTable dt =new DataTable();

			try
			{
				//write sql query to get quantity from db
				string sql = "SELECT qty FROM tbl_products WHERE id = "+ProductID;
				SqlCommand cmd = new SqlCommand(sql, conn);

				//create sql data adpater to execute the query
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				conn.Open();
				//pass the value from data adapter to dt tabel
				adapter.Fill(dt);

				//lets chgeck if the data table has value or !
				if(dt.Rows.Count>0)
				{
					qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

			return qty;
		}
		#endregion
		#region Method to Update Qty
		public bool UpdateQuantity(int ProductID, decimal qty)
		{
			bool success = false;

			//sql conn to connect db
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//write the sql query to update qty
				string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";

				//create sql command to pass the value into query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing the value through parametres
				cmd.Parameters.AddWithValue("@qty", qty);
				cmd.Parameters.AddWithValue("@id", ProductID);

				conn.Open();

				//creating int variable to check wheather the query is executed or !
				int rows = cmd.ExecuteNonQuery();
				//if the query is executed successfully or !
				if(rows>0)
				{
					success = true;
				}
				else
				{
					//failed to execute
					success = false;
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

			return success;
		}
		#endregion
		#region Method to Increase the Products
		public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
		{
			bool success = false;

			//create sql conn to conn db
			SqlConnection conn = new SqlConnection(myconnstring);
			try
			{
				//get the current qty into db based on ID
				decimal CurrentQty = GetProductQty(ProductID);

				//increase the currentqty by the qty purchased from dealer
				decimal NewQty = CurrentQty + IncreaseQty;

				//update the product qty now
				success = UpdateQuantity(ProductID, NewQty);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return success;
		}
		#endregion
		#region Method To Decerease product
		public bool DecreaseProduct(int ProductID, decimal Qty)
		{
			bool success = false;
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//get the current product qty
				decimal CurrentQty = GetProductQty(ProductID);

				//decrease the product qty based on product purchase sales
				decimal NewQty = CurrentQty - Qty;

				//update the product in db
				success = UpdateQuantity(ProductID, NewQty);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				conn.Close();
			}
			return success;
		}
		#endregion
		#region Display Products Based On categories
		public DataTable DisplayProductByCategory(string category)
		{
			//sql conn
			SqlConnection conn = new SqlConnection(myconnstring);
			DataTable dt = new DataTable();

			try
			{
				//sql query to display products based on category
				string sql = "SELECT * FROm tbl_products WHERE category='" + category + "'";
				SqlCommand cmd = new SqlCommand(sql,conn);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				conn.Open();
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