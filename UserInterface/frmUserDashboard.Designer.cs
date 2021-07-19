namespace Invoicing_Software
{
	partial class frmUserDashboard
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
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblSHead = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblAppFName = new System.Windows.Forms.Label();
			this.lblLoggedInUser = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.pnlFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.menuStripTop.SuspendLayout();
			this.pnlFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripTop
			// 
			this.menuStripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(1775, 28);
			this.menuStripTop.TabIndex = 0;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// purchaseToolStripMenuItem
			// 
			this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
			this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.purchaseToolStripMenuItem.Text = "Purchase";
			this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
			// 
			// salesFormsToolStripMenuItem
			// 
			this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
			this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
			this.salesFormsToolStripMenuItem.Text = "Sales";
			this.salesFormsToolStripMenuItem.Click += new System.EventHandler(this.salesFormsToolStripMenuItem_Click);
			// 
			// inventoryToolStripMenuItem
			// 
			this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
			this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
			this.inventoryToolStripMenuItem.Text = "Inventory";
			this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
			// 
			// dealerAndCustomerToolStripMenuItem
			// 
			this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
			this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
			this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
			// 
			// lblSHead
			// 
			this.lblSHead.AutoSize = true;
			this.lblSHead.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSHead.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.lblSHead.Location = new System.Drawing.Point(889, 443);
			this.lblSHead.Name = "lblSHead";
			this.lblSHead.Size = new System.Drawing.Size(395, 32);
			this.lblSHead.TabIndex = 12;
			this.lblSHead.Text = "Billing and Inventory Management";
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLName.Location = new System.Drawing.Point(1088, 398);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(161, 45);
			this.lblLName.TabIndex = 11;
			this.lblLName.Text = "Software";
			// 
			// lblAppFName
			// 
			this.lblAppFName.AutoSize = true;
			this.lblAppFName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAppFName.Location = new System.Drawing.Point(930, 398);
			this.lblAppFName.Name = "lblAppFName";
			this.lblAppFName.Size = new System.Drawing.Size(152, 45);
			this.lblAppFName.TabIndex = 10;
			this.lblAppFName.Text = "Invoicing";
			// 
			// lblLoggedInUser
			// 
			this.lblLoggedInUser.AutoSize = true;
			this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoggedInUser.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblLoggedInUser.Location = new System.Drawing.Point(66, 37);
			this.lblLoggedInUser.Name = "lblLoggedInUser";
			this.lblLoggedInUser.Size = new System.Drawing.Size(0, 23);
			this.lblLoggedInUser.TabIndex = 9;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(12, 37);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(48, 23);
			this.lblUser.TabIndex = 8;
			this.lblUser.Text = "User:";
			// 
			// pnlFooter
			// 
			this.pnlFooter.BackColor = System.Drawing.Color.DarkCyan;
			this.pnlFooter.Controls.Add(this.lblFooter);
			this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlFooter.Location = new System.Drawing.Point(0, 663);
			this.pnlFooter.Name = "pnlFooter";
			this.pnlFooter.Size = new System.Drawing.Size(1775, 75);
			this.pnlFooter.TabIndex = 7;
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
			// 
			// frmUserDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1775, 738);
			this.Controls.Add(this.lblSHead);
			this.Controls.Add(this.lblLName);
			this.Controls.Add(this.lblAppFName);
			this.Controls.Add(this.lblLoggedInUser);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.pnlFooter);
			this.Controls.Add(this.menuStripTop);
			this.MainMenuStrip = this.menuStripTop;
			this.Name = "frmUserDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Dashboard";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserDashboard_FormClosed);
			this.Load += new System.EventHandler(this.frmUserDashboard_Load);
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.pnlFooter.ResumeLayout(false);
			this.pnlFooter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripTop;
		private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
		private System.Windows.Forms.Label lblSHead;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblAppFName;
		private System.Windows.Forms.Label lblLoggedInUser;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Panel pnlFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
	}
}