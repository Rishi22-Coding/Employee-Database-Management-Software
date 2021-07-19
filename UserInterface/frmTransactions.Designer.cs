namespace Invoicing_Software.UserInterface
{
	partial class frmTransactions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTop = new System.Windows.Forms.Label();
			this.dgvTransactions = new System.Windows.Forms.DataGridView();
			this.lblTransactionsType = new System.Windows.Forms.Label();
			this.cmbTransactionsType = new System.Windows.Forms.ComboBox();
			this.btnShowAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
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
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTop.Location = new System.Drawing.Point(490, 19);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(190, 32);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "TRANSACTIONS";
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactions.Location = new System.Drawing.Point(12, 137);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.RowHeadersWidth = 51;
			this.dgvTransactions.RowTemplate.Height = 24;
			this.dgvTransactions.Size = new System.Drawing.Size(1080, 424);
			this.dgvTransactions.TabIndex = 4;
			// 
			// lblTransactionsType
			// 
			this.lblTransactionsType.AutoSize = true;
			this.lblTransactionsType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.lblTransactionsType.Location = new System.Drawing.Point(12, 92);
			this.lblTransactionsType.Name = "lblTransactionsType";
			this.lblTransactionsType.Size = new System.Drawing.Size(160, 25);
			this.lblTransactionsType.TabIndex = 5;
			this.lblTransactionsType.Text = "Transactions Type";
			// 
			// cmbTransactionsType
			// 
			this.cmbTransactionsType.Font = new System.Drawing.Font("Segoe UI", 10.8F);
			this.cmbTransactionsType.FormattingEnabled = true;
			this.cmbTransactionsType.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
			this.cmbTransactionsType.Location = new System.Drawing.Point(178, 89);
			this.cmbTransactionsType.Name = "cmbTransactionsType";
			this.cmbTransactionsType.Size = new System.Drawing.Size(363, 33);
			this.cmbTransactionsType.TabIndex = 6;
			this.cmbTransactionsType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionsType_SelectedIndexChanged);
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnShowAll.Location = new System.Drawing.Point(641, 78);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(161, 53);
			this.btnShowAll.TabIndex = 7;
			this.btnShowAll.Text = "Show All";
			this.btnShowAll.UseVisualStyleBackColor = false;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// frmTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1104, 574);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.cmbTransactionsType);
			this.Controls.Add(this.lblTransactionsType);
			this.Controls.Add(this.dgvTransactions);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTransactions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transactions";
			this.Load += new System.EventHandler(this.frmTransactions_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.DataGridView dgvTransactions;
		private System.Windows.Forms.Label lblTransactionsType;
		private System.Windows.Forms.ComboBox cmbTransactionsType;
		private System.Windows.Forms.Button btnShowAll;
	}
}