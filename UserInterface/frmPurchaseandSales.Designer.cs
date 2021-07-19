namespace Invoicing_Software.UserInterface
{
	partial class frmPurchaseandSales
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseandSales));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.lblTop = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlDeaCust = new System.Windows.Forms.Panel();
			this.dtpDandCBillDate = new System.Windows.Forms.DateTimePicker();
			this.txtDandCContact = new System.Windows.Forms.TextBox();
			this.txtDandCName = new System.Windows.Forms.TextBox();
			this.txtDandCAddress = new System.Windows.Forms.TextBox();
			this.txtDandCEmail = new System.Windows.Forms.TextBox();
			this.txtDandCSearch = new System.Windows.Forms.TextBox();
			this.lblDandCContact = new System.Windows.Forms.Label();
			this.lblDandCName = new System.Windows.Forms.Label();
			this.lblDandCBillDate = new System.Windows.Forms.Label();
			this.lblDandCAddress = new System.Windows.Forms.Label();
			this.lblDandCEmail = new System.Windows.Forms.Label();
			this.lblDandCSearch = new System.Windows.Forms.Label();
			this.lblDeaCustTitle = new System.Windows.Forms.Label();
			this.pnlProductDetails = new System.Windows.Forms.Panel();
			this.txtPDRate = new System.Windows.Forms.TextBox();
			this.txtPDName = new System.Windows.Forms.TextBox();
			this.txtPDQty = new System.Windows.Forms.TextBox();
			this.txtPDInventory = new System.Windows.Forms.TextBox();
			this.txtPDSearch = new System.Windows.Forms.TextBox();
			this.lblPDRate = new System.Windows.Forms.Label();
			this.lblPDName = new System.Windows.Forms.Label();
			this.lblPDQty = new System.Windows.Forms.Label();
			this.lblPDInventory = new System.Windows.Forms.Label();
			this.lblPDSearch = new System.Windows.Forms.Label();
			this.lblProductDetails = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlAddedProducts = new System.Windows.Forms.Panel();
			this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.pnlCalculationDetails = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtReturnAmount = new System.Windows.Forms.TextBox();
			this.lblReturnAmount = new System.Windows.Forms.Label();
			this.txtPaidAmount = new System.Windows.Forms.TextBox();
			this.lblPaidAmount = new System.Windows.Forms.Label();
			this.txtGrandTotal = new System.Windows.Forms.TextBox();
			this.lblGrandTotal = new System.Windows.Forms.Label();
			this.txtGST = new System.Windows.Forms.TextBox();
			this.lblGst = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnlDeaCust.SuspendLayout();
			this.pnlProductDetails.SuspendLayout();
			this.pnlAddedProducts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
			this.pnlCalculationDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1258, 3);
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
			this.lblTop.Location = new System.Drawing.Point(570, 19);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(266, 32);
			this.lblTop.TabIndex = 0;
			this.lblTop.Text = "PURCHASE AND SALES";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Controls.Add(this.lblTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1334, 73);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(12, 79);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(750, 100);
			this.panel2.TabIndex = 5;
			// 
			// pnlDeaCust
			// 
			this.pnlDeaCust.Controls.Add(this.dtpDandCBillDate);
			this.pnlDeaCust.Controls.Add(this.txtDandCContact);
			this.pnlDeaCust.Controls.Add(this.txtDandCName);
			this.pnlDeaCust.Controls.Add(this.txtDandCAddress);
			this.pnlDeaCust.Controls.Add(this.txtDandCEmail);
			this.pnlDeaCust.Controls.Add(this.txtDandCSearch);
			this.pnlDeaCust.Controls.Add(this.lblDandCContact);
			this.pnlDeaCust.Controls.Add(this.lblDandCName);
			this.pnlDeaCust.Controls.Add(this.lblDandCBillDate);
			this.pnlDeaCust.Controls.Add(this.lblDandCAddress);
			this.pnlDeaCust.Controls.Add(this.lblDandCEmail);
			this.pnlDeaCust.Controls.Add(this.lblDandCSearch);
			this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
			this.pnlDeaCust.Location = new System.Drawing.Point(12, 78);
			this.pnlDeaCust.Name = "pnlDeaCust";
			this.pnlDeaCust.Size = new System.Drawing.Size(1310, 127);
			this.pnlDeaCust.TabIndex = 5;
			// 
			// dtpDandCBillDate
			// 
			this.dtpDandCBillDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDandCBillDate.Location = new System.Drawing.Point(1085, 30);
			this.dtpDandCBillDate.Name = "dtpDandCBillDate";
			this.dtpDandCBillDate.Size = new System.Drawing.Size(200, 30);
			this.dtpDandCBillDate.TabIndex = 18;
			// 
			// txtDandCContact
			// 
			this.txtDandCContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDandCContact.Location = new System.Drawing.Point(382, 80);
			this.txtDandCContact.Name = "txtDandCContact";
			this.txtDandCContact.ReadOnly = true;
			this.txtDandCContact.Size = new System.Drawing.Size(248, 30);
			this.txtDandCContact.TabIndex = 17;
			// 
			// txtDandCName
			// 
			this.txtDandCName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDandCName.Location = new System.Drawing.Point(76, 80);
			this.txtDandCName.Name = "txtDandCName";
			this.txtDandCName.ReadOnly = true;
			this.txtDandCName.Size = new System.Drawing.Size(219, 30);
			this.txtDandCName.TabIndex = 16;
			// 
			// txtDandCAddress
			// 
			this.txtDandCAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDandCAddress.Location = new System.Drawing.Point(721, 27);
			this.txtDandCAddress.Multiline = true;
			this.txtDandCAddress.Name = "txtDandCAddress";
			this.txtDandCAddress.ReadOnly = true;
			this.txtDandCAddress.Size = new System.Drawing.Size(263, 83);
			this.txtDandCAddress.TabIndex = 15;
			// 
			// txtDandCEmail
			// 
			this.txtDandCEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDandCEmail.Location = new System.Drawing.Point(382, 27);
			this.txtDandCEmail.Name = "txtDandCEmail";
			this.txtDandCEmail.ReadOnly = true;
			this.txtDandCEmail.Size = new System.Drawing.Size(248, 30);
			this.txtDandCEmail.TabIndex = 14;
			// 
			// txtDandCSearch
			// 
			this.txtDandCSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDandCSearch.Location = new System.Drawing.Point(76, 30);
			this.txtDandCSearch.Name = "txtDandCSearch";
			this.txtDandCSearch.Size = new System.Drawing.Size(219, 30);
			this.txtDandCSearch.TabIndex = 13;
			this.txtDandCSearch.TextChanged += new System.EventHandler(this.txtDandCSearch_TextChanged);
			// 
			// lblDandCContact
			// 
			this.lblDandCContact.AutoSize = true;
			this.lblDandCContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDandCContact.Location = new System.Drawing.Point(306, 83);
			this.lblDandCContact.Name = "lblDandCContact";
			this.lblDandCContact.Size = new System.Drawing.Size(70, 23);
			this.lblDandCContact.TabIndex = 12;
			this.lblDandCContact.Text = "Contact";
			// 
			// lblDandCName
			// 
			this.lblDandCName.AutoSize = true;
			this.lblDandCName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDandCName.Location = new System.Drawing.Point(9, 83);
			this.lblDandCName.Name = "lblDandCName";
			this.lblDandCName.Size = new System.Drawing.Size(56, 23);
			this.lblDandCName.TabIndex = 11;
			this.lblDandCName.Text = "Name";
			// 
			// lblDandCBillDate
			// 
			this.lblDandCBillDate.AutoSize = true;
			this.lblDandCBillDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDandCBillDate.Location = new System.Drawing.Point(1008, 30);
			this.lblDandCBillDate.Name = "lblDandCBillDate";
			this.lblDandCBillDate.Size = new System.Drawing.Size(73, 23);
			this.lblDandCBillDate.TabIndex = 10;
			this.lblDandCBillDate.Text = "Bill Date";
			// 
			// lblDandCAddress
			// 
			this.lblDandCAddress.AutoSize = true;
			this.lblDandCAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDandCAddress.Location = new System.Drawing.Point(645, 29);
			this.lblDandCAddress.Name = "lblDandCAddress";
			this.lblDandCAddress.Size = new System.Drawing.Size(70, 23);
			this.lblDandCAddress.TabIndex = 9;
			this.lblDandCAddress.Text = "Address";
			// 
			// lblDandCEmail
			// 
			this.lblDandCEmail.AutoSize = true;
			this.lblDandCEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDandCEmail.Location = new System.Drawing.Point(315, 30);
			this.lblDandCEmail.Name = "lblDandCEmail";
			this.lblDandCEmail.Size = new System.Drawing.Size(51, 23);
			this.lblDandCEmail.TabIndex = 8;
			this.lblDandCEmail.Text = "Email";
			// 
			// lblDandCSearch
			// 
			this.lblDandCSearch.AutoSize = true;
			this.lblDandCSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDandCSearch.Location = new System.Drawing.Point(9, 34);
			this.lblDandCSearch.Name = "lblDandCSearch";
			this.lblDandCSearch.Size = new System.Drawing.Size(61, 23);
			this.lblDandCSearch.TabIndex = 7;
			this.lblDandCSearch.Text = "Search";
			// 
			// lblDeaCustTitle
			// 
			this.lblDeaCustTitle.AutoSize = true;
			this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeaCustTitle.Location = new System.Drawing.Point(3, 2);
			this.lblDeaCustTitle.Name = "lblDeaCustTitle";
			this.lblDeaCustTitle.Size = new System.Drawing.Size(263, 25);
			this.lblDeaCustTitle.TabIndex = 6;
			this.lblDeaCustTitle.Text = "Dealer and Customer Details";
			// 
			// pnlProductDetails
			// 
			this.pnlProductDetails.Controls.Add(this.txtPDRate);
			this.pnlProductDetails.Controls.Add(this.txtPDName);
			this.pnlProductDetails.Controls.Add(this.txtPDQty);
			this.pnlProductDetails.Controls.Add(this.txtPDInventory);
			this.pnlProductDetails.Controls.Add(this.txtPDSearch);
			this.pnlProductDetails.Controls.Add(this.lblPDRate);
			this.pnlProductDetails.Controls.Add(this.lblPDName);
			this.pnlProductDetails.Controls.Add(this.lblPDQty);
			this.pnlProductDetails.Controls.Add(this.lblPDInventory);
			this.pnlProductDetails.Controls.Add(this.lblPDSearch);
			this.pnlProductDetails.Controls.Add(this.lblProductDetails);
			this.pnlProductDetails.Location = new System.Drawing.Point(12, 224);
			this.pnlProductDetails.Name = "pnlProductDetails";
			this.pnlProductDetails.Size = new System.Drawing.Size(1310, 127);
			this.pnlProductDetails.TabIndex = 5;
			// 
			// txtPDRate
			// 
			this.txtPDRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPDRate.Location = new System.Drawing.Point(711, 31);
			this.txtPDRate.Name = "txtPDRate";
			this.txtPDRate.ReadOnly = true;
			this.txtPDRate.Size = new System.Drawing.Size(231, 30);
			this.txtPDRate.TabIndex = 17;
			// 
			// txtPDName
			// 
			this.txtPDName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPDName.Location = new System.Drawing.Point(372, 30);
			this.txtPDName.Name = "txtPDName";
			this.txtPDName.ReadOnly = true;
			this.txtPDName.Size = new System.Drawing.Size(248, 30);
			this.txtPDName.TabIndex = 16;
			// 
			// txtPDQty
			// 
			this.txtPDQty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPDQty.Location = new System.Drawing.Point(1027, 32);
			this.txtPDQty.Name = "txtPDQty";
			this.txtPDQty.Size = new System.Drawing.Size(263, 30);
			this.txtPDQty.TabIndex = 15;
			// 
			// txtPDInventory
			// 
			this.txtPDInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPDInventory.Location = new System.Drawing.Point(97, 83);
			this.txtPDInventory.Name = "txtPDInventory";
			this.txtPDInventory.ReadOnly = true;
			this.txtPDInventory.Size = new System.Drawing.Size(248, 30);
			this.txtPDInventory.TabIndex = 14;
			// 
			// txtPDSearch
			// 
			this.txtPDSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPDSearch.Location = new System.Drawing.Point(76, 30);
			this.txtPDSearch.Name = "txtPDSearch";
			this.txtPDSearch.Size = new System.Drawing.Size(219, 30);
			this.txtPDSearch.TabIndex = 13;
			this.txtPDSearch.TextChanged += new System.EventHandler(this.txtPDSearch_TextChanged);
			// 
			// lblPDRate
			// 
			this.lblPDRate.AutoSize = true;
			this.lblPDRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPDRate.Location = new System.Drawing.Point(645, 34);
			this.lblPDRate.Name = "lblPDRate";
			this.lblPDRate.Size = new System.Drawing.Size(44, 23);
			this.lblPDRate.TabIndex = 12;
			this.lblPDRate.Text = "Rate";
			// 
			// lblPDName
			// 
			this.lblPDName.AutoSize = true;
			this.lblPDName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPDName.Location = new System.Drawing.Point(310, 33);
			this.lblPDName.Name = "lblPDName";
			this.lblPDName.Size = new System.Drawing.Size(56, 23);
			this.lblPDName.TabIndex = 11;
			this.lblPDName.Text = "Name";
			// 
			// lblPDQty
			// 
			this.lblPDQty.AutoSize = true;
			this.lblPDQty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPDQty.Location = new System.Drawing.Point(984, 34);
			this.lblPDQty.Name = "lblPDQty";
			this.lblPDQty.Size = new System.Drawing.Size(37, 23);
			this.lblPDQty.TabIndex = 9;
			this.lblPDQty.Text = "Qty";
			// 
			// lblPDInventory
			// 
			this.lblPDInventory.AutoSize = true;
			this.lblPDInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPDInventory.Location = new System.Drawing.Point(9, 86);
			this.lblPDInventory.Name = "lblPDInventory";
			this.lblPDInventory.Size = new System.Drawing.Size(82, 23);
			this.lblPDInventory.TabIndex = 8;
			this.lblPDInventory.Text = "Inventory";
			// 
			// lblPDSearch
			// 
			this.lblPDSearch.AutoSize = true;
			this.lblPDSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPDSearch.Location = new System.Drawing.Point(9, 34);
			this.lblPDSearch.Name = "lblPDSearch";
			this.lblPDSearch.Size = new System.Drawing.Size(61, 23);
			this.lblPDSearch.TabIndex = 7;
			this.lblPDSearch.Text = "Search";
			// 
			// lblProductDetails
			// 
			this.lblProductDetails.AutoSize = true;
			this.lblProductDetails.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductDetails.Location = new System.Drawing.Point(3, 2);
			this.lblProductDetails.Name = "lblProductDetails";
			this.lblProductDetails.Size = new System.Drawing.Size(148, 25);
			this.lblProductDetails.TabIndex = 6;
			this.lblProductDetails.Text = "Product Details";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnAdd.Location = new System.Drawing.Point(497, 357);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(161, 72);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlAddedProducts
			// 
			this.pnlAddedProducts.Controls.Add(this.dgvAddedProducts);
			this.pnlAddedProducts.Controls.Add(this.label3);
			this.pnlAddedProducts.Location = new System.Drawing.Point(12, 435);
			this.pnlAddedProducts.Name = "pnlAddedProducts";
			this.pnlAddedProducts.Size = new System.Drawing.Size(646, 383);
			this.pnlAddedProducts.TabIndex = 18;
			// 
			// dgvAddedProducts
			// 
			this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddedProducts.Location = new System.Drawing.Point(13, 48);
			this.dgvAddedProducts.Name = "dgvAddedProducts";
			this.dgvAddedProducts.RowHeadersWidth = 51;
			this.dgvAddedProducts.RowTemplate.Height = 24;
			this.dgvAddedProducts.Size = new System.Drawing.Size(617, 321);
			this.dgvAddedProducts.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Added Products";
			// 
			// pnlCalculationDetails
			// 
			this.pnlCalculationDetails.Controls.Add(this.btnSave);
			this.pnlCalculationDetails.Controls.Add(this.txtReturnAmount);
			this.pnlCalculationDetails.Controls.Add(this.lblReturnAmount);
			this.pnlCalculationDetails.Controls.Add(this.txtPaidAmount);
			this.pnlCalculationDetails.Controls.Add(this.lblPaidAmount);
			this.pnlCalculationDetails.Controls.Add(this.txtGrandTotal);
			this.pnlCalculationDetails.Controls.Add(this.lblGrandTotal);
			this.pnlCalculationDetails.Controls.Add(this.txtGST);
			this.pnlCalculationDetails.Controls.Add(this.lblGst);
			this.pnlCalculationDetails.Controls.Add(this.txtDiscount);
			this.pnlCalculationDetails.Controls.Add(this.lblDiscount);
			this.pnlCalculationDetails.Controls.Add(this.txtSubTotal);
			this.pnlCalculationDetails.Controls.Add(this.lblSubTotal);
			this.pnlCalculationDetails.Controls.Add(this.label1);
			this.pnlCalculationDetails.Location = new System.Drawing.Point(676, 357);
			this.pnlCalculationDetails.Name = "pnlCalculationDetails";
			this.pnlCalculationDetails.Size = new System.Drawing.Size(646, 461);
			this.pnlCalculationDetails.TabIndex = 18;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(289, 385);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(201, 73);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtReturnAmount
			// 
			this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReturnAmount.Location = new System.Drawing.Point(216, 350);
			this.txtReturnAmount.Name = "txtReturnAmount";
			this.txtReturnAmount.ReadOnly = true;
			this.txtReturnAmount.Size = new System.Drawing.Size(394, 30);
			this.txtReturnAmount.TabIndex = 19;
			// 
			// lblReturnAmount
			// 
			this.lblReturnAmount.AutoSize = true;
			this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReturnAmount.Location = new System.Drawing.Point(62, 357);
			this.lblReturnAmount.Name = "lblReturnAmount";
			this.lblReturnAmount.Size = new System.Drawing.Size(128, 23);
			this.lblReturnAmount.TabIndex = 18;
			this.lblReturnAmount.Text = "Return Amount";
			// 
			// txtPaidAmount
			// 
			this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaidAmount.Location = new System.Drawing.Point(216, 289);
			this.txtPaidAmount.Name = "txtPaidAmount";
			this.txtPaidAmount.Size = new System.Drawing.Size(394, 30);
			this.txtPaidAmount.TabIndex = 17;
			this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
			// 
			// lblPaidAmount
			// 
			this.lblPaidAmount.AutoSize = true;
			this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPaidAmount.Location = new System.Drawing.Point(62, 292);
			this.lblPaidAmount.Name = "lblPaidAmount";
			this.lblPaidAmount.Size = new System.Drawing.Size(109, 23);
			this.lblPaidAmount.TabIndex = 16;
			this.lblPaidAmount.Text = "Paid Amount";
			// 
			// txtGrandTotal
			// 
			this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGrandTotal.Location = new System.Drawing.Point(216, 227);
			this.txtGrandTotal.Name = "txtGrandTotal";
			this.txtGrandTotal.ReadOnly = true;
			this.txtGrandTotal.Size = new System.Drawing.Size(394, 30);
			this.txtGrandTotal.TabIndex = 15;
			// 
			// lblGrandTotal
			// 
			this.lblGrandTotal.AutoSize = true;
			this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrandTotal.Location = new System.Drawing.Point(62, 230);
			this.lblGrandTotal.Name = "lblGrandTotal";
			this.lblGrandTotal.Size = new System.Drawing.Size(98, 23);
			this.lblGrandTotal.TabIndex = 14;
			this.lblGrandTotal.Text = "Grand Total";
			// 
			// txtGST
			// 
			this.txtGST.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGST.Location = new System.Drawing.Point(216, 162);
			this.txtGST.Name = "txtGST";
			this.txtGST.Size = new System.Drawing.Size(394, 30);
			this.txtGST.TabIndex = 13;
			this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
			// 
			// lblGst
			// 
			this.lblGst.AutoSize = true;
			this.lblGst.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGst.Location = new System.Drawing.Point(62, 165);
			this.lblGst.Name = "lblGst";
			this.lblGst.Size = new System.Drawing.Size(69, 23);
			this.lblGst.TabIndex = 12;
			this.lblGst.Text = "GST (%)";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscount.Location = new System.Drawing.Point(216, 100);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(394, 30);
			this.txtDiscount.TabIndex = 11;
			this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
			// 
			// lblDiscount
			// 
			this.lblDiscount.AutoSize = true;
			this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiscount.Location = new System.Drawing.Point(62, 103);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(106, 23);
			this.lblDiscount.TabIndex = 10;
			this.lblDiscount.Text = "Discount (%)";
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubTotal.Location = new System.Drawing.Point(216, 46);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.ReadOnly = true;
			this.txtSubTotal.Size = new System.Drawing.Size(394, 30);
			this.txtSubTotal.TabIndex = 9;
			this.txtSubTotal.Text = "0";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.AutoSize = true;
			this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTotal.Location = new System.Drawing.Point(62, 49);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Size = new System.Drawing.Size(80, 23);
			this.lblSubTotal.TabIndex = 8;
			this.lblSubTotal.Text = "Sub Total";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Calculation Details";
			// 
			// frmPurchaseandSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1334, 830);
			this.Controls.Add(this.pnlCalculationDetails);
			this.Controls.Add(this.pnlAddedProducts);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlProductDetails);
			this.Controls.Add(this.pnlDeaCust);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmPurchaseandSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Purchase and Sales";
			this.Load += new System.EventHandler(this.frmPurchaseandSales_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlDeaCust.ResumeLayout(false);
			this.pnlDeaCust.PerformLayout();
			this.pnlProductDetails.ResumeLayout(false);
			this.pnlProductDetails.PerformLayout();
			this.pnlAddedProducts.ResumeLayout(false);
			this.pnlAddedProducts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
			this.pnlCalculationDetails.ResumeLayout(false);
			this.pnlCalculationDetails.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlDeaCust;
		private System.Windows.Forms.Label lblDeaCustTitle;
		private System.Windows.Forms.TextBox txtDandCSearch;
		private System.Windows.Forms.Label lblDandCContact;
		private System.Windows.Forms.Label lblDandCName;
		private System.Windows.Forms.Label lblDandCBillDate;
		private System.Windows.Forms.Label lblDandCAddress;
		private System.Windows.Forms.Label lblDandCEmail;
		private System.Windows.Forms.Label lblDandCSearch;
		private System.Windows.Forms.TextBox txtDandCContact;
		private System.Windows.Forms.TextBox txtDandCName;
		private System.Windows.Forms.TextBox txtDandCAddress;
		private System.Windows.Forms.TextBox txtDandCEmail;
		private System.Windows.Forms.DateTimePicker dtpDandCBillDate;
		private System.Windows.Forms.Panel pnlProductDetails;
		private System.Windows.Forms.TextBox txtPDRate;
		private System.Windows.Forms.TextBox txtPDName;
		private System.Windows.Forms.TextBox txtPDQty;
		private System.Windows.Forms.TextBox txtPDInventory;
		private System.Windows.Forms.TextBox txtPDSearch;
		private System.Windows.Forms.Label lblPDRate;
		private System.Windows.Forms.Label lblPDName;
		private System.Windows.Forms.Label lblPDQty;
		private System.Windows.Forms.Label lblPDInventory;
		private System.Windows.Forms.Label lblPDSearch;
		private System.Windows.Forms.Label lblProductDetails;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel pnlAddedProducts;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnlCalculationDetails;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvAddedProducts;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtReturnAmount;
		private System.Windows.Forms.Label lblReturnAmount;
		private System.Windows.Forms.TextBox txtPaidAmount;
		private System.Windows.Forms.Label lblPaidAmount;
		private System.Windows.Forms.TextBox txtGrandTotal;
		private System.Windows.Forms.Label lblGrandTotal;
		private System.Windows.Forms.TextBox txtGST;
		private System.Windows.Forms.Label lblGst;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label lblDiscount;
		private System.Windows.Forms.TextBox txtSubTotal;
		private System.Windows.Forms.Label lblSubTotal;
	}
}