using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSNProject
{
	public partial class Welcome_SSN : Form
	{
		public Welcome_SSN()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			SSNWindowDataSection SSNf1 = new SSNWindowDataSection();
			SSNf1.ShowDialog();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Search_SSN SSNf2 = new Search_SSN();
			SSNf2.ShowDialog();
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
