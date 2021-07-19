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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
		loginBLL l = new loginBLL();
		loginDAL dal = new loginDAL();
		public static string loggedIn;

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			l.username = txtUsername.Text.Trim();
			l.password = txtPassword.Text.Trim();
			l.user_type = cmbUserType.Text.Trim();

			//checking the login credentials
			bool successs = dal.loginCheck(l);
			if(successs==true)
			{
				//login successfull
				MessageBox.Show("Login Successfull");
				loggedIn = l.username;
				//now we need to open respective form
				switch(l.user_type)
				{
					case "Admin":
						{
							//Display admin dashboard
							frmAdminDashboard admin = new frmAdminDashboard();
							admin.Show();
							this.Hide();
						}
						break;
					case "User":
						{
							//Dsiplay users dashboard
							frmUserDashboard user = new frmUserDashboard();
							user.Show();
							this.Hide();
						}
						break;
					default:
						{
							//Display error message
							MessageBox.Show("Invalid User Type");
						}
						break;
				}
			}
			else
			{
				//login failed
				MessageBox.Show("Login Failed");
			}
		}
	}
}
