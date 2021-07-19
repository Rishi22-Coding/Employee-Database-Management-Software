using Invoicing_Software.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_Software.Data_Access_Layer
{
	class transactionDetailDAL
	{
		//create connection string
		static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

		#region Insert Method For Transaction Detail
		public bool InsertTransactionDetail(transactionDetailBLL td)
		{
			//create a bool value and set its default value to false
			bool isSuccess = false;

			//create a database connection
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//Sql query to insert transaction details
				string sql = "INSERT INTO tbl_transaction_detail (product_id, rate, qty, total, dea_cust_id, added_date, added_by) VALUES(@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";
				//SQL COMMAND TO PASS THE VALUE
				SqlCommand cmd = new SqlCommand(sql, conn);
				//Passing the value to the sql query
				cmd.Parameters.AddWithValue("@product_id", td.product_id);
				cmd.Parameters.AddWithValue("@rate", td.rate);
				cmd.Parameters.AddWithValue("@qty", td.qty);
				cmd.Parameters.AddWithValue("@total", td.total);
				cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
				cmd.Parameters.AddWithValue("@added_date", td.added_date);
				cmd.Parameters.AddWithValue("@added_by", td.added_by);

				//open the db conn
				conn.Open();

				//Declair int variable and execute the query
				int rows = cmd.ExecuteNonQuery();
				if(rows>0)
				{
					//Query Executed Successfully
					isSuccess = true;
				}
				else
				{
					//Failed to Execute the Query
					isSuccess = false;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Close the conn
				conn.Close();
			}
			return isSuccess;
		}
		#endregion

	}
}
