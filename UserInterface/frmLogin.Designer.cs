using System;
using System.Windows.Forms;

namespace Invoicing_Software.UserInterface
{
	partial class frmLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.panelTop = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.panelBorder = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.cmbUserType = new System.Windows.Forms.ComboBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblUserType = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblBottom = new System.Windows.Forms.Label();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelBorder.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Teal;
			this.panelTop.Controls.Add(this.pictureBox1);
			this.panelTop.Controls.Add(this.lblLogin);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(800, 73);
			this.panelTop.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(679, -10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(129, 92);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.Color.Bisque;
			this.lblLogin.Location = new System.Drawing.Point(336, 9);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(123, 51);
			this.lblLogin.TabIndex = 0;
			this.lblLogin.Text = "LogIn";
			// 
			// panelBorder
			// 
			this.panelBorder.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelBorder.Controls.Add(this.btnLogin);
			this.panelBorder.Controls.Add(this.cmbUserType);
			this.panelBorder.Controls.Add(this.txtPassword);
			this.panelBorder.Controls.Add(this.txtUsername);
			this.panelBorder.Controls.Add(this.lblUserType);
			this.panelBorder.Controls.Add(this.lblPassword);
			this.panelBorder.Controls.Add(this.lblUsername);
			this.panelBorder.Location = new System.Drawing.Point(46, 110);
			this.panelBorder.Name = "panelBorder";
			this.panelBorder.Size = new System.Drawing.Size(706, 516);
			this.panelBorder.TabIndex = 1;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.PaleGreen;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(108, 398);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(483, 69);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "LogIn";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// cmbUserType
			// 
			this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUserType.FormattingEnabled = true;
			this.cmbUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
			this.cmbUserType.Location = new System.Drawing.Point(116, 321);
			this.cmbUserType.Name = "cmbUserType";
			this.cmbUserType.Size = new System.Drawing.Size(463, 36);
			this.cmbUserType.TabIndex = 5;
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(116, 202);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(463, 34);
			this.txtPassword.TabIndex = 4;
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(116, 89);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(463, 34);
			this.txtUsername.TabIndex = 3;
			// 
			// lblUserType
			// 
			this.lblUserType.AutoSize = true;
			this.lblUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserType.Location = new System.Drawing.Point(103, 290);
			this.lblUserType.Name = "lblUserType";
			this.lblUserType.Size = new System.Drawing.Size(102, 28);
			this.lblUserType.TabIndex = 2;
			this.lblUserType.Text = "User Type";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(103, 171);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(97, 28);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(103, 58);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(104, 28);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.lblBottom);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 663);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 74);
			this.panel1.TabIndex = 1;
			// 
			// lblBottom
			// 
			this.lblBottom.AutoSize = true;
			this.lblBottom.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBottom.ForeColor = System.Drawing.Color.Bisque;
			this.lblBottom.Location = new System.Drawing.Point(146, 19);
			this.lblBottom.Name = "lblBottom";
			this.lblBottom.Size = new System.Drawing.Size(492, 45);
			this.lblBottom.TabIndex = 1;
			this.lblBottom.Text = "Welcome to Invoicing Software";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 737);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelBorder);
			this.Controls.Add(this.panelTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn";
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelBorder.ResumeLayout(false);
			this.panelBorder.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelBorder;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.ComboBox cmbUserType;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblUserType;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblBottom;
		private System.Windows.Forms.PictureBox pictureBox1;
		//private PaintEventHandler panelBorder_Paint;
	}
}