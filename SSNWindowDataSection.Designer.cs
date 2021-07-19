namespace SSNProject
{
	partial class SSNWindowDataSection
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSNWindowDataSection));
			this.SSNLabel = new System.Windows.Forms.Label();
			this.LblID = new System.Windows.Forms.Label();
			this.TextBoxID = new System.Windows.Forms.TextBox();
			this.tableSSNBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sSNDatabaseDataSet = new SSNProject.SSNDatabaseDataSet();
			this.TextBoxName = new System.Windows.Forms.TextBox();
			this.LblName = new System.Windows.Forms.Label();
			this.TextBoxState = new System.Windows.Forms.TextBox();
			this.LblState = new System.Windows.Forms.Label();
			this.LblDOB = new System.Windows.Forms.Label();
			this.LblIssuingYear = new System.Windows.Forms.Label();
			this.TextBoxTelephoneNumber = new System.Windows.Forms.TextBox();
			this.LblTelephoneNumber = new System.Windows.Forms.Label();
			this.TextBoxZipCode = new System.Windows.Forms.TextBox();
			this.LblZipCode = new System.Windows.Forms.Label();
			this.TextBoxSSN = new System.Windows.Forms.TextBox();
			this.LblSSN = new System.Windows.Forms.Label();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnClear = new System.Windows.Forms.Button();
			this.DgvSSNList = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.DateTimePickerIssuingYear = new System.Windows.Forms.DateTimePicker();
			this.DateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
			this.table_SSNTableAdapter = new SSNProject.SSNDatabaseDataSetTableAdapters.Table_SSNTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.tableSSNBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sSNDatabaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvSSNList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// SSNLabel
			// 
			this.SSNLabel.AutoSize = true;
			this.SSNLabel.BackColor = System.Drawing.Color.Transparent;
			this.SSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SSNLabel.ForeColor = System.Drawing.Color.Maroon;
			this.SSNLabel.Location = new System.Drawing.Point(580, 20);
			this.SSNLabel.Name = "SSNLabel";
			this.SSNLabel.Size = new System.Drawing.Size(100, 44);
			this.SSNLabel.TabIndex = 0;
			this.SSNLabel.Text = "SSN";
			// 
			// LblID
			// 
			this.LblID.AutoSize = true;
			this.LblID.BackColor = System.Drawing.Color.Transparent;
			this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblID.Location = new System.Drawing.Point(43, 94);
			this.LblID.Name = "LblID";
			this.LblID.Size = new System.Drawing.Size(31, 25);
			this.LblID.TabIndex = 1;
			this.LblID.Text = "ID";
			// 
			// TextBoxID
			// 
			this.TextBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableSSNBindingSource, "ID", true));
			this.TextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxID.Location = new System.Drawing.Point(229, 94);
			this.TextBoxID.Name = "TextBoxID";
			this.TextBoxID.Size = new System.Drawing.Size(286, 30);
			this.TextBoxID.TabIndex = 2;
			// 
			// tableSSNBindingSource
			// 
			this.tableSSNBindingSource.DataMember = "Table_SSN";
			this.tableSSNBindingSource.DataSource = this.sSNDatabaseDataSet;
			// 
			// sSNDatabaseDataSet
			// 
			this.sSNDatabaseDataSet.DataSetName = "SSNDatabaseDataSet";
			this.sSNDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TextBoxName
			// 
			this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxName.Location = new System.Drawing.Point(229, 151);
			this.TextBoxName.Name = "TextBoxName";
			this.TextBoxName.Size = new System.Drawing.Size(286, 30);
			this.TextBoxName.TabIndex = 4;
			// 
			// LblName
			// 
			this.LblName.AutoSize = true;
			this.LblName.BackColor = System.Drawing.Color.Transparent;
			this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblName.Location = new System.Drawing.Point(43, 156);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(64, 25);
			this.LblName.TabIndex = 3;
			this.LblName.Text = "Name";
			// 
			// TextBoxState
			// 
			this.TextBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxState.Location = new System.Drawing.Point(229, 209);
			this.TextBoxState.Name = "TextBoxState";
			this.TextBoxState.Size = new System.Drawing.Size(286, 30);
			this.TextBoxState.TabIndex = 6;
			// 
			// LblState
			// 
			this.LblState.AutoSize = true;
			this.LblState.BackColor = System.Drawing.Color.Transparent;
			this.LblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblState.Location = new System.Drawing.Point(43, 214);
			this.LblState.Name = "LblState";
			this.LblState.Size = new System.Drawing.Size(58, 25);
			this.LblState.TabIndex = 5;
			this.LblState.Text = "State";
			// 
			// LblDOB
			// 
			this.LblDOB.AutoSize = true;
			this.LblDOB.BackColor = System.Drawing.Color.Transparent;
			this.LblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDOB.Location = new System.Drawing.Point(40, 269);
			this.LblDOB.Name = "LblDOB";
			this.LblDOB.Size = new System.Drawing.Size(123, 25);
			this.LblDOB.TabIndex = 7;
			this.LblDOB.Text = "Date Of Birth";
			// 
			// LblIssuingYear
			// 
			this.LblIssuingYear.AutoSize = true;
			this.LblIssuingYear.BackColor = System.Drawing.Color.Transparent;
			this.LblIssuingYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblIssuingYear.Location = new System.Drawing.Point(43, 331);
			this.LblIssuingYear.Name = "LblIssuingYear";
			this.LblIssuingYear.Size = new System.Drawing.Size(120, 25);
			this.LblIssuingYear.TabIndex = 9;
			this.LblIssuingYear.Text = "Issuing Year";
			// 
			// TextBoxTelephoneNumber
			// 
			this.TextBoxTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxTelephoneNumber.Location = new System.Drawing.Point(229, 387);
			this.TextBoxTelephoneNumber.Name = "TextBoxTelephoneNumber";
			this.TextBoxTelephoneNumber.Size = new System.Drawing.Size(286, 30);
			this.TextBoxTelephoneNumber.TabIndex = 12;
			// 
			// LblTelephoneNumber
			// 
			this.LblTelephoneNumber.AutoSize = true;
			this.LblTelephoneNumber.BackColor = System.Drawing.Color.Transparent;
			this.LblTelephoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTelephoneNumber.Location = new System.Drawing.Point(40, 392);
			this.LblTelephoneNumber.Name = "LblTelephoneNumber";
			this.LblTelephoneNumber.Size = new System.Drawing.Size(180, 25);
			this.LblTelephoneNumber.TabIndex = 11;
			this.LblTelephoneNumber.Text = "Telephone Number";
			// 
			// TextBoxZipCode
			// 
			this.TextBoxZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxZipCode.Location = new System.Drawing.Point(229, 442);
			this.TextBoxZipCode.Name = "TextBoxZipCode";
			this.TextBoxZipCode.Size = new System.Drawing.Size(286, 30);
			this.TextBoxZipCode.TabIndex = 14;
			// 
			// LblZipCode
			// 
			this.LblZipCode.AutoSize = true;
			this.LblZipCode.BackColor = System.Drawing.Color.Transparent;
			this.LblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblZipCode.Location = new System.Drawing.Point(43, 447);
			this.LblZipCode.Name = "LblZipCode";
			this.LblZipCode.Size = new System.Drawing.Size(92, 25);
			this.LblZipCode.TabIndex = 13;
			this.LblZipCode.Text = "Zip Code";
			// 
			// TextBoxSSN
			// 
			this.TextBoxSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSSN.Location = new System.Drawing.Point(229, 497);
			this.TextBoxSSN.Name = "TextBoxSSN";
			this.TextBoxSSN.Size = new System.Drawing.Size(286, 30);
			this.TextBoxSSN.TabIndex = 16;
			// 
			// LblSSN
			// 
			this.LblSSN.AutoSize = true;
			this.LblSSN.BackColor = System.Drawing.Color.Transparent;
			this.LblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblSSN.Location = new System.Drawing.Point(43, 502);
			this.LblSSN.Name = "LblSSN";
			this.LblSSN.Size = new System.Drawing.Size(54, 25);
			this.LblSSN.TabIndex = 15;
			this.LblSSN.Text = "SSN";
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAdd.Location = new System.Drawing.Point(45, 580);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(104, 44);
			this.BtnAdd.TabIndex = 17;
			this.BtnAdd.Text = "ADD";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnUpdate.Location = new System.Drawing.Point(166, 580);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(104, 44);
			this.BtnUpdate.TabIndex = 17;
			this.BtnUpdate.Text = "UPDATE";
			this.BtnUpdate.UseVisualStyleBackColor = false;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnDelete.Location = new System.Drawing.Point(288, 580);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(104, 44);
			this.BtnDelete.TabIndex = 17;
			this.BtnDelete.Text = "DELETE";
			this.BtnDelete.UseVisualStyleBackColor = false;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnClear
			// 
			this.BtnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnClear.Location = new System.Drawing.Point(411, 580);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(104, 44);
			this.BtnClear.TabIndex = 17;
			this.BtnClear.Text = "CLEAR";
			this.BtnClear.UseVisualStyleBackColor = false;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// DgvSSNList
			// 
			this.DgvSSNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvSSNList.Location = new System.Drawing.Point(574, 151);
			this.DgvSSNList.Name = "DgvSSNList";
			this.DgvSSNList.RowHeadersWidth = 51;
			this.DgvSSNList.RowTemplate.Height = 24;
			this.DgvSSNList.Size = new System.Drawing.Size(737, 376);
			this.DgvSSNList.TabIndex = 18;
			this.DgvSSNList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSSNList_RowHeaderMouseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1263, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// DateTimePickerIssuingYear
			// 
			this.DateTimePickerIssuingYear.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateTimePickerIssuingYear.Location = new System.Drawing.Point(229, 333);
			this.DateTimePickerIssuingYear.Name = "DateTimePickerIssuingYear";
			this.DateTimePickerIssuingYear.Size = new System.Drawing.Size(286, 22);
			this.DateTimePickerIssuingYear.TabIndex = 21;
			// 
			// DateTimePickerDOB
			// 
			this.DateTimePickerDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateTimePickerDOB.Location = new System.Drawing.Point(229, 272);
			this.DateTimePickerDOB.Name = "DateTimePickerDOB";
			this.DateTimePickerDOB.Size = new System.Drawing.Size(286, 22);
			this.DateTimePickerDOB.TabIndex = 20;
			// 
			// table_SSNTableAdapter
			// 
			this.table_SSNTableAdapter.ClearBeforeFill = true;
			// 
			// SSNWindowDataSection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1367, 727);
			this.Controls.Add(this.DateTimePickerIssuingYear);
			this.Controls.Add(this.DateTimePickerDOB);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.DgvSSNList);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.TextBoxSSN);
			this.Controls.Add(this.LblSSN);
			this.Controls.Add(this.TextBoxZipCode);
			this.Controls.Add(this.LblZipCode);
			this.Controls.Add(this.TextBoxTelephoneNumber);
			this.Controls.Add(this.LblTelephoneNumber);
			this.Controls.Add(this.LblIssuingYear);
			this.Controls.Add(this.LblDOB);
			this.Controls.Add(this.TextBoxState);
			this.Controls.Add(this.LblState);
			this.Controls.Add(this.TextBoxName);
			this.Controls.Add(this.LblName);
			this.Controls.Add(this.TextBoxID);
			this.Controls.Add(this.LblID);
			this.Controls.Add(this.SSNLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SSNWindowDataSection";
			this.Text = "SSN Project";
			this.Load += new System.EventHandler(this.SSNWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.tableSSNBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sSNDatabaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvSSNList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label SSNLabel;
		private System.Windows.Forms.Label LblID;
		private System.Windows.Forms.TextBox TextBoxID;
		private System.Windows.Forms.TextBox TextBoxName;
		private System.Windows.Forms.Label LblName;
		private System.Windows.Forms.TextBox TextBoxState;
		private System.Windows.Forms.Label LblState;
		private System.Windows.Forms.Label LblDOB;
		private System.Windows.Forms.Label LblIssuingYear;
		private System.Windows.Forms.TextBox TextBoxTelephoneNumber;
		private System.Windows.Forms.Label LblTelephoneNumber;
		private System.Windows.Forms.TextBox TextBoxZipCode;
		private System.Windows.Forms.Label LblZipCode;
		private System.Windows.Forms.TextBox TextBoxSSN;
		private System.Windows.Forms.Label LblSSN;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.DataGridView DgvSSNList;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DateTimePicker DateTimePickerIssuingYear;
		private System.Windows.Forms.DateTimePicker DateTimePickerDOB;
		private SSNDatabaseDataSet sSNDatabaseDataSet;
		private System.Windows.Forms.BindingSource tableSSNBindingSource;
		private SSNDatabaseDataSetTableAdapters.Table_SSNTableAdapter table_SSNTableAdapter;
	}
}

