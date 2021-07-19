namespace Invoicing_Software.UserInterface
{
	partial class frmInventory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTop = new System.Windows.Forms.Label();
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.lblCategory = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnShowAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1010, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(73, 67);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 1;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1086, 73);
			this.panel1.TabIndex = 4;
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(490, 19);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(144, 32);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "INVENTORY";
			// 
			// dgvProducts
			// 
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(12, 138);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.RowHeadersWidth = 51;
			this.dgvProducts.RowTemplate.Height = 24;
			this.dgvProducts.Size = new System.Drawing.Size(1062, 377);
			this.dgvProducts.TabIndex = 5;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblCategory.Location = new System.Drawing.Point(12, 90);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(88, 25);
			this.lblCategory.TabIndex = 6;
			this.lblCategory.Text = "Category";
			// 
			// cmbCategory
			// 
			this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(106, 87);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(361, 33);
			this.cmbCategory.TabIndex = 7;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnShowAll.Location = new System.Drawing.Point(627, 79);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(161, 53);
			this.btnShowAll.TabIndex = 8;
			this.btnShowAll.Text = "Show All";
			this.btnShowAll.UseVisualStyleBackColor = false;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// frmInventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1086, 527);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.dgvProducts);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInventory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inventory";
			this.Load += new System.EventHandler(this.frmInventory_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.DataGridView dgvProducts;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnShowAll;
	}
}