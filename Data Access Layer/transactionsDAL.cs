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
	class transactionsDAL
	{
		//create a connection varaible
		static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

		#region Insert Transaction Method
		public bool Insert_transaction(transactionsBLL t, out int transactionID)
		{
			//create a bool value and seet its default value to false
			bool isSuccess = false;
			//set the transaction id value to -1
			transactionID = -1;
			//create a sql connection
			SqlConnection conn = new SqlConnection(myconnstring);
			try
			{
				//sql query to insert transactions
				string sql = "INSERT INTO tbl_transactions (type, dea_cust_id, grandTotal, transaction_date, gst, discount, added_by) VALUES(@type, @dea_cust_id, @grandTotal, @transaction_date, @gst, @discount, @added_by); SELECT @@IDENTITY ";
				//SQL COMMAND TO PASS THE VALUE
				SqlCommand cmd = new SqlCommand(sql, conn);
				//passing the value using cmd
				cmd.Parameters.AddWithValue("@type", t.type);
				cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
				cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
				cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
				cmd.Parameters.AddWithValue("@gst", t.gst);
				cmd.Parameters.AddWithValue("@discount", t.discount);
				cmd.Parameters.AddWithValue("@added_by", t.added_by);

				//open database connection
				conn.Open();
				//Execute the query
				object o = cmd.ExecuteScalar();

				//IF THE QUERY IS EXECUTED SUCCESSFULLY THEN THE VALUE WILL NOT BE MULL ELSE IT WILL BE NULL
				if(o!=null)
				{
					//Query Executed Successfully
					transactionID = int.Parse(o.ToString());
					isSuccess = true;
				}
				else
				{
					//failed to execute
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
		#region Method to Display All the Transactions
		public DataTable DisplayAllTransactions()
		{
			//sql connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//create a datatabel to hold the database temporarily
			DataTable dt = new DataTable();

			try
			{
				//sql query to display all the transactions
				string sql = "SELECT * FROM tbl_transactions";

				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);

				//sqldata adpater to hold the data from db
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
		#region Method To Display Transaction based on Transaction Type
		public DataTable DisplayTransactionByType(string type)
		{
			//create sql connection
			SqlConnection conn = new SqlConnection(myconnstring);

			//data table
			DataTable dt = new DataTable();

			try
			{
				//sql query
				string sql = "SELECT * FROM tbl_transactions WHERE type='" + type + "'";
				//sql command to execute query
				SqlCommand cmd = new SqlCommand(sql, conn);
				//sqldataadpater to hold the data from db
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				//Open db
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
