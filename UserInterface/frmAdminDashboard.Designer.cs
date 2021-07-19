using System;

namespace Invoicing_Software
{
	partial class frmAdminDashboard
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
			this.pnlFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dealerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblLoggedInUser = new System.Windows.Forms.Label();
			this.lblAppFName = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblSHead = new System.Windows.Forms.Label();
			this.pnlFooter.SuspendLayout();
			this.menuStripTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFooter
			// 
			this.pnlFooter.BackColor = System.Drawing.Color.DarkCyan;
			this.pnlFooter.Controls.Add(this.lblFooter);
			this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlFooter.Location = new System.Drawing.Point(0, 659);
			this.pnlFooter.Name = "pnlFooter";
			this.pnlFooter.Size = new System.Drawing.Size(1775, 75);
			this.pnlFooter.TabIndex = 0;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.ForeColor = System.Drawing.Color.White;
			this.lblFooter.Location = new System.Drawing.Point(889, 17);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(385, 38);
			this.lblFooter.TabIndex = 0;
			this.lblFooter.Text = "Developed By: Saptarshi Patra";
			this.lblFooter.Click += new System.EventHandler(this.lblFooter_Click);
			// 
			// menuStripTop
			// 
			this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.dealerCustomerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(1775, 28);
			this.menuStripTop.TabIndex = 1;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.usersToolStripMenuItem.Text = "Users";
			this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			this.categoryToolStripMenuItem.Text = "Category";
			this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
			this.productsToolStripMenuItem.Text = "Products";
			this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
			// 
			// dealerCustomerToolStripMenuItem
			// 
			this.dealerCustomerToolStripMenuItem.Name = "dealerCustomerToolStripMenuItem";
			this.dealerCustomerToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.dealerCustomerToolStripMenuItem.Text = "Dealer and Customer";
			this.dealerCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerCustomerToolStripMenuItem_Click);
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
			this.inventoryToolStripMenuItem.Text = "Inventory";
			this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
			// 
			// transactionsToolStripMenuItem
			// 
			this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
			this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
			this.transactionsToolStripMenuItem.Text = "Transactions";
			this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(13, 45);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(48, 23);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "User:";
			// 
			// lblLoggedInUser
			// 
			this.lblLoggedInUser.AutoSize = true;
			this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblLoggedInUser.Location = new System.Drawing.Point(67, 45);
			this.lblLoggedInUser.Name = "lblLoggedInUser";
			this.lblLoggedInUser.Size = new System.Drawing.Size(0, 23);
			this.lblLoggedInUser.TabIndex = 3;
			// 
			// lblAppFName
			// 
			this.lblAppFName.AutoSize = true;
			this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppFName.Location = new System.Drawing.Point(902, 397);
			this.lblAppFName.Name = "lblAppFName";
			this.lblAppFName.Size = new System.Drawing.Size(152, 45);
			this.lblAppFName.TabIndex = 4;
			this.lblAppFName.Text = "Invoicing";
			this.lblAppFName.Click += new System.EventHandler(this.lblAppFName_Click);
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLName.Location = new System.Drawing.Point(1060, 397);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(161, 45);
			this.lblLName.TabIndex = 5;
			this.lblLName.Text = "Software";
			this.lblLName.Click += new System.EventHandler(this.lblLName_Click);
			// 
			// lblSHead
			// 
			this.lblSHead.AutoSize = true;
			this.lblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSHead.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.lblSHead.Location = new System.Drawing.Point(861, 442);
			this.lblSHead.Name = "lblSHead";
			this.lblSHead.Size = new System.Drawing.Size(395, 32);
			this.lblSHead.TabIndex = 6;
			this.lblSHead.Text = "Billing and Inventory Management";
			// 
			// frmAdminDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1775, 734);
			this.Controls.Add(this.lblSHead);
			this.Controls.Add(this.lblLName);
			this.Controls.Add(this.lblAppFName);
			this.Controls.Add(this.lblLoggedInUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.pnlFooter);
			this.Controls.Add(this.menuStripTop);
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "frmAdminDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Dashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminDashboard_FormClosed);
			this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
			this.pnlFooter.ResumeLayout(false);
			this.pnlFooter.PerformLayout();
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void lblAppFName_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void lblLName_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void lblFooter_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Panel pnlFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblLoggedInUser;
		private System.Windows.Forms.Label lblAppFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblSHead;
		private System.Windows.Forms.ToolStripMenuItem dealerCustomerToolStripMenuItem;
	}
}

