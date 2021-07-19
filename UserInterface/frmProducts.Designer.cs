namespace Invoicing_Software.UserInterface
{
	partial class frmProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTop = new System.Windows.Forms.Label();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblRate = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.cmbcategory = new System.Windows.Forms.ComboBox();
			this.dgvProdcts = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdcts)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1046, 3);
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
			this.panel1.Size = new System.Drawing.Size(1122, 73);
			this.panel1.TabIndex = 2;
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(490, 19);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(137, 32);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "PRODUCTS";
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductID.Location = new System.Drawing.Point(12, 98);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(101, 25);
			this.lblProductID.TabIndex = 3;
			this.lblProductID.Text = "Product ID";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(12, 153);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(62, 25);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategory.Location = new System.Drawing.Point(12, 216);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(88, 25);
			this.lblCategory.TabIndex = 5;
			this.lblCategory.Text = "Category";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(12, 286);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(108, 25);
			this.lblDescription.TabIndex = 6;
			this.lblDescription.Text = "Description";
			// 
			// lblRate
			// 
			this.lblRate.AutoSize = true;
			this.lblRate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRate.Location = new System.Drawing.Point(12, 450);
			this.lblRate.Name = "lblRate";
			this.lblRate.Size = new System.Drawing.Size(49, 25);
			this.lblRate.TabIndex = 7;
			this.lblRate.Text = "Rate";
			// 
			// txtID
			// 
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(160, 93);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(319, 30);
			this.txtID.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(160, 148);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(319, 30);
			this.txtName.TabIndex = 9;
			// 
			// txtDescription
			// 
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(160, 286);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(319, 120);
			this.txtDescription.TabIndex = 11;
			// 
			// txtRate
			// 
			this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRate.Location = new System.Drawing.Point(160, 445);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(319, 30);
			this.txtRate.TabIndex = 12;
			// 
			// cmbcategory
			// 
			this.cmbcategory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbcategory.FormattingEnabled = true;
			this.cmbcategory.Location = new System.Drawing.Point(160, 215);
			this.cmbcategory.Name = "cmbcategory";
			this.cmbcategory.Size = new System.Drawing.Size(319, 33);
			this.cmbcategory.TabIndex = 13;
			// 
			// dgvProdcts
			// 
			this.dgvProdcts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProdcts.Location = new System.Drawing.Point(516, 148);
			this.dgvProdcts.Name = "dgvProdcts";
			this.dgvProdcts.RowHeadersWidth = 51;
			this.dgvProdcts.RowTemplate.Height = 24;
			this.dgvProdcts.Size = new System.Drawing.Size(594, 327);
			this.dgvProdcts.TabIndex = 14;
			this.dgvProdcts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdcts_RowHeaderMouseClick);
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(604, 93);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(506, 30);
			this.txtSearch.TabIndex = 16;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(511, 98);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(69, 25);
			this.lblSearch.TabIndex = 15;
			this.lblSearch.Text = "Search";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnAdd.Location = new System.Drawing.Point(17, 525);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(161, 72);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Chartreuse;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnUpdate.Location = new System.Drawing.Point(198, 525);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(161, 72);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnDelete.Location = new System.Drawing.Point(380, 525);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(161, 72);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1122, 621);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dgvProdcts);
			this.Controls.Add(this.cmbcategory);
			this.Controls.Add(this.txtRate);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblRate);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblProductID);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmProducts";
			this.Load += new System.EventHandler(this.frmProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdcts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblRate;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.ComboBox cmbcategory;
		private System.Windows.Forms.DataGridView dgvProdcts;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
	}
}