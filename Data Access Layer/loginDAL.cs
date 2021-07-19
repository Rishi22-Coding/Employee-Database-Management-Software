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
	class loginDAL
	{
		//static string to connect database
		static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

		public bool loginCheck(loginBLL l)
		{
			//Create a boolean variable and set its value to false and return it
			bool isSuccess = false;

			//Connection to Database
			SqlConnection conn = new SqlConnection(myconnstring);

			try
			{
				//Sql Query to check LOgIn
				string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password And user_type=@user_type";

				//creating sql command to pass value
				SqlCommand cmd = new SqlCommand(sql, conn);

				cmd.Parameters.AddWithValue("@username", l.username);
				cmd.Parameters.AddWithValue("@password", l.password);
				cmd.Parameters.AddWithValue("@user_type", l.user_type);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				DataTable dt = new DataTable();

				adapter.Fill(dt);

				//Checking the rows in datatable
				if(dt.Rows.Count>0)
				{
					//login successfull
					isSuccess = true;
				}
				else
				{
					//login failed
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
	}
}
