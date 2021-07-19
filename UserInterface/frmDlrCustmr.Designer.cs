namespace Invoicing_Software.UserInterface
{
	partial class frmDlrCustmr
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlrCustmr));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblTop = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblDeaCustID = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblContact = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtDeaCustID = new System.Windows.Forms.TextBox();
			this.cmbDeaCust = new System.Windows.Forms.ComboBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvDeaCust = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.btnUPDATE = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1028, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(73, 67);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxClose.TabIndex = 1;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(414, 20);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(288, 32);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "DEALER AND CUSTOMER";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1104, 73);
			this.panel1.TabIndex = 3;
			// 
			// lblDeaCustID
			// 
			this.lblDeaCustID.AutoSize = true;
			this.lblDeaCustID.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblDeaCustID.Location = new System.Drawing.Point(13, 94);
			this.lblDeaCustID.Name = "lblDeaCustID";
			this.lblDeaCustID.Size = new System.Drawing.Size(176, 25);
			this.lblDeaCustID.TabIndex = 4;
			this.lblDeaCustID.Text = "Dealer Customer ID";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblType.Location = new System.Drawing.Point(12, 150);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(51, 25);
			this.lblType.TabIndex = 5;
			this.lblType.Text = "Type";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblName.Location = new System.Drawing.Point(12, 206);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(62, 25);
			this.lblName.TabIndex = 6;
			this.lblName.Text = "Name";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblEmail.Location = new System.Drawing.Point(12, 257);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(58, 25);
			this.lblEmail.TabIndex = 7;
			this.lblEmail.Text = "Email";
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblContact.Location = new System.Drawing.Point(13, 317);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(77, 25);
			this.lblContact.TabIndex = 8;
			this.lblContact.Text = "Contact";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblAddress.Location = new System.Drawing.Point(12, 376);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(79, 25);
			this.lblAddress.TabIndex = 9;
			this.lblAddress.Text = "Address";
			// 
			// txtDeaCustID
			// 
			this.txtDeaCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDeaCustID.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtDeaCustID.Location = new System.Drawing.Point(219, 92);
			this.txtDeaCustID.Name = "txtDeaCustID";
			this.txtDeaCustID.ReadOnly = true;
			this.txtDeaCustID.Size = new System.Drawing.Size(318, 31);
			this.txtDeaCustID.TabIndex = 10;
			// 
			// cmbDeaCust
			// 
			this.cmbDeaCust.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbDeaCust.FormattingEnabled = true;
			this.cmbDeaCust.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
			this.cmbDeaCust.Location = new System.Drawing.Point(219, 142);
			this.cmbDeaCust.Name = "cmbDeaCust";
			this.cmbDeaCust.Size = new System.Drawing.Size(318, 33);
			this.cmbDeaCust.TabIndex = 11;
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtName.Location = new System.Drawing.Point(219, 200);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(318, 31);
			this.txtName.TabIndex = 12;
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtEmail.Location = new System.Drawing.Point(219, 257);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(318, 31);
			this.txtEmail.TabIndex = 13;
			// 
			// txtContact
			// 
			this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtContact.Location = new System.Drawing.Point(219, 315);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(318, 31);
			this.txtContact.TabIndex = 14;
			// 
			// txtAddress
			// 
			this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtAddress.Location = new System.Drawing.Point(219, 370);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(318, 175);
			this.txtAddress.TabIndex = 15;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnAdd.Location = new System.Drawing.Point(18, 580);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(161, 72);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnDelete.Location = new System.Drawing.Point(376, 580);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(161, 72);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvDeaCust
			// 
			this.dgvDeaCust.ColumnHeadersHeight = 29;
			this.dgvDeaCust.Location = new System.Drawing.Point(571, 132);
			this.dgvDeaCust.Name = "dgvDeaCust";
			this.dgvDeaCust.RowHeadersWidth = 51;
			this.dgvDeaCust.Size = new System.Drawing.Size(510, 413);
			this.dgvDeaCust.TabIndex = 23;
			this.dgvDeaCust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCust_RowHeaderMouseClick);
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.txtSearch.Location = new System.Drawing.Point(651, 90);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(430, 31);
			this.txtSearch.TabIndex = 21;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblSearch.Location = new System.Drawing.Point(566, 94);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(69, 25);
			this.lblSearch.TabIndex = 20;
			this.lblSearch.Text = "Search";
			// 
			// btnUPDATE
			// 
			this.btnUPDATE.BackColor = System.Drawing.Color.Chartreuse;
			this.btnUPDATE.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnUPDATE.Location = new System.Drawing.Point(194, 580);
			this.btnUPDATE.Name = "btnUPDATE";
			this.btnUPDATE.Size = new System.Drawing.Size(161, 72);
			this.btnUPDATE.TabIndex = 22;
			this.btnUPDATE.Text = "UPDATE";
			this.btnUPDATE.UseVisualStyleBackColor = false;
			this.btnUPDATE.Click += new System.EventHandler(this.btnuPDATE_Click);
			// 
			// frmDlrCustmr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1104, 674);
			this.Controls.Add(this.btnUPDATE);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.dgvDeaCust);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmbDeaCust);
			this.Controls.Add(this.txtDeaCustID);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblType);
			this.Controls.Add(this.lblDeaCustID);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDlrCustmr";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDlrCustmr";
			this.Load += new System.EventHandler(this.frmDlrCustmr_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblDeaCustID;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblContact;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtDeaCustID;
		private System.Windows.Forms.ComboBox cmbDeaCust;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtContact;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dgvDeaCust;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Button btnUPDATE;
	}
}