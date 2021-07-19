using System;

namespace SSNProject
{
	partial class Search_SSN
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_SSN));
			this.sSNDatabaseDataSet = new SSNProject.SSNDatabaseDataSet();
			this.table_SSNBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.table_SSNTableAdapter = new SSNProject.SSNDatabaseDataSetTableAdapters.Table_SSNTableAdapter();
			this.tableAdapterManager = new SSNProject.SSNDatabaseDataSetTableAdapters.TableAdapterManager();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.table_SSNDataGridView = new System.Windows.Forms.DataGridView();
			this.BtnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sSNDatabaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table_SSNBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table_SSNDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// sSNDatabaseDataSet
			// 
			this.sSNDatabaseDataSet.DataSetName = "SSNDatabaseDataSet";
			this.sSNDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// table_SSNBindingSource
			// 
			this.table_SSNBindingSource.DataMember = "Table_SSN";
			this.table_SSNBindingSource.DataSource = this.sSNDatabaseDataSet;
			// 
			// table_SSNTableAdapter
			// 
			this.table_SSNTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Table_SSNTableAdapter = this.table_SSNTableAdapter;
			this.tableAdapterManager.UpdateOrder = SSNProject.SSNDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.Location = new System.Drawing.Point(152, 181);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(760, 38);
			this.textBoxSearch.TabIndex = 2;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(380, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(309, 69);
			this.label2.TabIndex = 4;
			this.label2.Text = "FIND SSN";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(982, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(73, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// table_SSNDataGridView
			// 
			this.table_SSNDataGridView.AllowUserToOrderColumns = true;
			this.table_SSNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table_SSNDataGridView.Location = new System.Drawing.Point(39, 237);
			this.table_SSNDataGridView.Name = "table_SSNDataGridView";
			this.table_SSNDataGridView.RowHeadersWidth = 51;
			this.table_SSNDataGridView.RowTemplate.Height = 24;
			this.table_SSNDataGridView.Size = new System.Drawing.Size(1031, 456);
			this.table_SSNDataGridView.TabIndex = 6;
			// 
			// BtnSearch
			// 
			this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSearch.Location = new System.Drawing.Point(930, 172);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(125, 59);
			this.BtnSearch.TabIndex = 7;
			this.BtnSearch.Text = "Search";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// Search_SSN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 758);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.table_SSNDataGridView);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Search_SSN";
			this.Text = "Search_SSN";
			this.Load += new System.EventHandler(this.Search_SSN_Load);
			((System.ComponentModel.ISupportInitialize)(this.sSNDatabaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table_SSNBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table_SSNDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private SSNDatabaseDataSet sSNDatabaseDataSet;
		private System.Windows.Forms.BindingSource table_SSNBindingSource;
		private SSNDatabaseDataSetTableAdapters.Table_SSNTableAdapter table_SSNTableAdapter;
		private SSNDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView table_SSNDataGridView;
		private System.Windows.Forms.Button BtnSearch;
	}
}