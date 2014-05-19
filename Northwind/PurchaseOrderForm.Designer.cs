namespace Northwind
{
    partial class PurchaseOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            this.homeHeader = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.Label();
            this.saveLink = new System.Windows.Forms.LinkLabel();
            this.cancelPurchaseLink = new System.Windows.Forms.LinkLabel();
            this.approvePurchaseLink = new System.Windows.Forms.LinkLabel();
            this.submitForApprovalLink = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.headerTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.approvedDateBox = new System.Windows.Forms.TextBox();
            this.submittedDateBox = new System.Windows.Forms.TextBox();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.expectedDateBox = new System.Windows.Forms.TextBox();
            this.approvedDateLabel = new System.Windows.Forms.Label();
            this.submittedDateLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.expectedDateLabel = new System.Windows.Forms.Label();
            this.approvedByBox = new System.Windows.Forms.ComboBox();
            this.submittedByBox = new System.Windows.Forms.ComboBox();
            this.createdByBox = new System.Windows.Forms.ComboBox();
            this.approvedByLabel = new System.Windows.Forms.Label();
            this.submittedByLabel = new System.Windows.Forms.Label();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.purchaseDetailsTab = new System.Windows.Forms.TabPage();
            this.purchaseDetailsView = new System.Windows.Forms.DataGridView();
            this.productColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryReceivingTab = new System.Windows.Forms.TabPage();
            this.inventoryReceivingView = new System.Windows.Forms.DataGridView();
            this.paymentInformation = new System.Windows.Forms.TabPage();
            this.paymentTypeBox = new System.Windows.Forms.ComboBox();
            this.orderNotesBox = new System.Windows.Forms.TextBox();
            this.paymentDateBox = new System.Windows.Forms.TextBox();
            this.orderNotesLabel = new System.Windows.Forms.Label();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.productColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecievedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToInventory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.homeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.purchaseDetailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsView)).BeginInit();
            this.inventoryReceivingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryReceivingView)).BeginInit();
            this.paymentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeHeader
            // 
            this.homeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeHeader.BackgroundImage = global::Northwind.Properties.Resources.GenericHeader;
            this.homeHeader.Controls.Add(this.statusText);
            this.homeHeader.Controls.Add(this.saveLink);
            this.homeHeader.Controls.Add(this.cancelPurchaseLink);
            this.homeHeader.Controls.Add(this.approvePurchaseLink);
            this.homeHeader.Controls.Add(this.submitForApprovalLink);
            this.homeHeader.Controls.Add(this.statusLabel);
            this.homeHeader.Controls.Add(this.headerImage);
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(672, 72);
            this.homeHeader.TabIndex = 10;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.BackColor = System.Drawing.Color.Transparent;
            this.statusText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.Color.White;
            this.statusText.Location = new System.Drawing.Point(70, 50);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 16);
            this.statusText.TabIndex = 14;
            // 
            // saveLink
            // 
            this.saveLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.saveLink.AutoSize = true;
            this.saveLink.BackColor = System.Drawing.Color.Transparent;
            this.saveLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.saveLink.LinkColor = System.Drawing.Color.White;
            this.saveLink.Location = new System.Drawing.Point(628, 52);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(32, 14);
            this.saveLink.TabIndex = 13;
            this.saveLink.TabStop = true;
            this.saveLink.Text = "Save";
            this.saveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveLink_LinkClicked);
            // 
            // cancelPurchaseLink
            // 
            this.cancelPurchaseLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.cancelPurchaseLink.AutoSize = true;
            this.cancelPurchaseLink.BackColor = System.Drawing.Color.Transparent;
            this.cancelPurchaseLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPurchaseLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cancelPurchaseLink.LinkColor = System.Drawing.Color.White;
            this.cancelPurchaseLink.Location = new System.Drawing.Point(424, 52);
            this.cancelPurchaseLink.Name = "cancelPurchaseLink";
            this.cancelPurchaseLink.Size = new System.Drawing.Size(89, 14);
            this.cancelPurchaseLink.TabIndex = 11;
            this.cancelPurchaseLink.TabStop = true;
            this.cancelPurchaseLink.Text = "Cancel Purchase";
            this.cancelPurchaseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancelPurchaseLink_LinkClicked);
            // 
            // approvePurchaseLink
            // 
            this.approvePurchaseLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.approvePurchaseLink.AutoSize = true;
            this.approvePurchaseLink.BackColor = System.Drawing.Color.Transparent;
            this.approvePurchaseLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvePurchaseLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.approvePurchaseLink.LinkColor = System.Drawing.Color.White;
            this.approvePurchaseLink.Location = new System.Drawing.Point(301, 52);
            this.approvePurchaseLink.Name = "approvePurchaseLink";
            this.approvePurchaseLink.Size = new System.Drawing.Size(98, 14);
            this.approvePurchaseLink.TabIndex = 10;
            this.approvePurchaseLink.TabStop = true;
            this.approvePurchaseLink.Text = "Approve Purchase";
            this.approvePurchaseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.approvePurchaseLink_LinkClicked);
            // 
            // submitForApprovalLink
            // 
            this.submitForApprovalLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.submitForApprovalLink.AutoSize = true;
            this.submitForApprovalLink.BackColor = System.Drawing.Color.Transparent;
            this.submitForApprovalLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitForApprovalLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.submitForApprovalLink.LinkColor = System.Drawing.Color.White;
            this.submitForApprovalLink.Location = new System.Drawing.Point(173, 52);
            this.submitForApprovalLink.Name = "submitForApprovalLink";
            this.submitForApprovalLink.Size = new System.Drawing.Size(104, 14);
            this.submitForApprovalLink.TabIndex = 9;
            this.submitForApprovalLink.TabStop = true;
            this.submitForApprovalLink.Text = "Submit For Approval";
            this.submitForApprovalLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.submitForApprovalLink_LinkClicked);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(19, 51);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 15);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            // 
            // headerImage
            // 
            this.headerImage.BackColor = System.Drawing.Color.Transparent;
            this.headerImage.Image = global::Northwind.Properties.Resources.PurchaseOrderDetailsIcon;
            this.headerImage.Location = new System.Drawing.Point(20, 2);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(49, 41);
            this.headerImage.TabIndex = 0;
            this.headerImage.TabStop = false;
            // 
            // headerTitle
            // 
            this.headerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerTitle.AutoSize = true;
            this.headerTitle.BackColor = System.Drawing.Color.Transparent;
            this.headerTitle.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.ForeColor = System.Drawing.Color.White;
            this.headerTitle.Location = new System.Drawing.Point(80, 2);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(267, 29);
            this.headerTitle.TabIndex = 7;
            this.headerTitle.Text = "Purchase Order # (New)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.approvedDateBox);
            this.panel1.Controls.Add(this.submittedDateBox);
            this.panel1.Controls.Add(this.creationDateBox);
            this.panel1.Controls.Add(this.expectedDateBox);
            this.panel1.Controls.Add(this.approvedDateLabel);
            this.panel1.Controls.Add(this.submittedDateLabel);
            this.panel1.Controls.Add(this.creationDateLabel);
            this.panel1.Controls.Add(this.expectedDateLabel);
            this.panel1.Controls.Add(this.approvedByBox);
            this.panel1.Controls.Add(this.submittedByBox);
            this.panel1.Controls.Add(this.createdByBox);
            this.panel1.Controls.Add(this.approvedByLabel);
            this.panel1.Controls.Add(this.submittedByLabel);
            this.panel1.Controls.Add(this.supplierBox);
            this.panel1.Controls.Add(this.createdByLabel);
            this.panel1.Controls.Add(this.supplierLabel);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 114);
            this.panel1.TabIndex = 11;
            // 
            // approvedDateBox
            // 
            this.approvedDateBox.Location = new System.Drawing.Point(497, 85);
            this.approvedDateBox.Name = "approvedDateBox";
            this.approvedDateBox.ReadOnly = true;
            this.approvedDateBox.Size = new System.Drawing.Size(139, 20);
            this.approvedDateBox.TabIndex = 29;
            // 
            // submittedDateBox
            // 
            this.submittedDateBox.Location = new System.Drawing.Point(497, 57);
            this.submittedDateBox.Name = "submittedDateBox";
            this.submittedDateBox.ReadOnly = true;
            this.submittedDateBox.Size = new System.Drawing.Size(139, 20);
            this.submittedDateBox.TabIndex = 28;
            // 
            // creationDateBox
            // 
            this.creationDateBox.Location = new System.Drawing.Point(497, 30);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.ReadOnly = true;
            this.creationDateBox.Size = new System.Drawing.Size(139, 20);
            this.creationDateBox.TabIndex = 27;
            // 
            // expectedDateBox
            // 
            this.expectedDateBox.Location = new System.Drawing.Point(497, 3);
            this.expectedDateBox.Name = "expectedDateBox";
            this.expectedDateBox.Size = new System.Drawing.Size(139, 20);
            this.expectedDateBox.TabIndex = 26;
            // 
            // approvedDateLabel
            // 
            this.approvedDateLabel.AutoSize = true;
            this.approvedDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.approvedDateLabel.Location = new System.Drawing.Point(385, 87);
            this.approvedDateLabel.Name = "approvedDateLabel";
            this.approvedDateLabel.Size = new System.Drawing.Size(87, 15);
            this.approvedDateLabel.TabIndex = 25;
            this.approvedDateLabel.Text = "Approved Date";
            // 
            // submittedDateLabel
            // 
            this.submittedDateLabel.AutoSize = true;
            this.submittedDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submittedDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.submittedDateLabel.Location = new System.Drawing.Point(385, 59);
            this.submittedDateLabel.Name = "submittedDateLabel";
            this.submittedDateLabel.Size = new System.Drawing.Size(92, 15);
            this.submittedDateLabel.TabIndex = 24;
            this.submittedDateLabel.Text = "Submitted Date";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.creationDateLabel.Location = new System.Drawing.Point(385, 32);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(83, 15);
            this.creationDateLabel.TabIndex = 23;
            this.creationDateLabel.Text = "Creation Date";
            // 
            // expectedDateLabel
            // 
            this.expectedDateLabel.AutoSize = true;
            this.expectedDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectedDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.expectedDateLabel.Location = new System.Drawing.Point(385, 5);
            this.expectedDateLabel.Name = "expectedDateLabel";
            this.expectedDateLabel.Size = new System.Drawing.Size(86, 15);
            this.expectedDateLabel.TabIndex = 22;
            this.expectedDateLabel.Text = "Expected Date";
            // 
            // approvedByBox
            // 
            this.approvedByBox.Enabled = false;
            this.approvedByBox.FormattingEnabled = true;
            this.approvedByBox.Location = new System.Drawing.Point(121, 85);
            this.approvedByBox.Name = "approvedByBox";
            this.approvedByBox.Size = new System.Drawing.Size(232, 21);
            this.approvedByBox.TabIndex = 21;
            // 
            // submittedByBox
            // 
            this.submittedByBox.Enabled = false;
            this.submittedByBox.FormattingEnabled = true;
            this.submittedByBox.Location = new System.Drawing.Point(121, 57);
            this.submittedByBox.Name = "submittedByBox";
            this.submittedByBox.Size = new System.Drawing.Size(232, 21);
            this.submittedByBox.TabIndex = 20;
            // 
            // createdByBox
            // 
            this.createdByBox.Enabled = false;
            this.createdByBox.FormattingEnabled = true;
            this.createdByBox.Location = new System.Drawing.Point(121, 30);
            this.createdByBox.Name = "createdByBox";
            this.createdByBox.Size = new System.Drawing.Size(232, 21);
            this.createdByBox.TabIndex = 19;
            // 
            // approvedByLabel
            // 
            this.approvedByLabel.AutoSize = true;
            this.approvedByLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.approvedByLabel.Location = new System.Drawing.Point(6, 87);
            this.approvedByLabel.Name = "approvedByLabel";
            this.approvedByLabel.Size = new System.Drawing.Size(77, 15);
            this.approvedByLabel.TabIndex = 18;
            this.approvedByLabel.Text = "Approved By:";
            // 
            // submittedByLabel
            // 
            this.submittedByLabel.AutoSize = true;
            this.submittedByLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submittedByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.submittedByLabel.Location = new System.Drawing.Point(6, 59);
            this.submittedByLabel.Name = "submittedByLabel";
            this.submittedByLabel.Size = new System.Drawing.Size(82, 15);
            this.submittedByLabel.TabIndex = 17;
            this.submittedByLabel.Text = "Submitted By:";
            // 
            // supplierBox
            // 
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(121, 3);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(232, 21);
            this.supplierBox.TabIndex = 13;
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.createdByLabel.Location = new System.Drawing.Point(6, 32);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(70, 15);
            this.createdByLabel.TabIndex = 10;
            this.createdByLabel.Text = "Created By:";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.supplierLabel.Location = new System.Drawing.Point(6, 5);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(53, 15);
            this.supplierLabel.TabIndex = 9;
            this.supplierLabel.Text = "Supplier";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.purchaseDetailsTab);
            this.tabControl.Controls.Add(this.inventoryReceivingTab);
            this.tabControl.Controls.Add(this.paymentInformation);
            this.tabControl.Location = new System.Drawing.Point(12, 206);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(653, 274);
            this.tabControl.TabIndex = 12;
            // 
            // purchaseDetailsTab
            // 
            this.purchaseDetailsTab.Controls.Add(this.purchaseDetailsView);
            this.purchaseDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.purchaseDetailsTab.Name = "purchaseDetailsTab";
            this.purchaseDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.purchaseDetailsTab.Size = new System.Drawing.Size(645, 248);
            this.purchaseDetailsTab.TabIndex = 0;
            this.purchaseDetailsTab.Text = "Purchase Details";
            this.purchaseDetailsTab.UseVisualStyleBackColor = true;
            // 
            // purchaseDetailsView
            // 
            this.purchaseDetailsView.AllowUserToOrderColumns = true;
            this.purchaseDetailsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.purchaseDetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productColumn,
            this.quantityColumn,
            this.unitCostColumn,
            this.totalPriceColumn,
            this.ID});
            this.purchaseDetailsView.Location = new System.Drawing.Point(0, 0);
            this.purchaseDetailsView.Name = "purchaseDetailsView";
            this.purchaseDetailsView.Size = new System.Drawing.Size(646, 248);
            this.purchaseDetailsView.TabIndex = 1;
            this.purchaseDetailsView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseDetailsView_CellEndEdit);
            this.purchaseDetailsView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.purchaseDetailsView_DataError);
            // 
            // productColumn
            // 
            this.productColumn.DataPropertyName = "Product";
            dataGridViewCellStyle1.NullValue = "None";
            this.productColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.productColumn.HeaderText = "Product";
            this.productColumn.Name = "productColumn";
            this.productColumn.Width = 58;
            // 
            // quantityColumn
            // 
            this.quantityColumn.DataPropertyName = "Qty";
            dataGridViewCellStyle2.NullValue = "0";
            this.quantityColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantityColumn.HeaderText = "Qty";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 48;
            // 
            // unitCostColumn
            // 
            this.unitCostColumn.DataPropertyName = "Unit Cost";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.unitCostColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.unitCostColumn.HeaderText = "Unit Cost";
            this.unitCostColumn.Name = "unitCostColumn";
            this.unitCostColumn.Width = 75;
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.DataPropertyName = "Total Price";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.totalPriceColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalPriceColumn.HeaderText = "Total Price";
            this.totalPriceColumn.Name = "totalPriceColumn";
            this.totalPriceColumn.Width = 83;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 43;
            // 
            // inventoryReceivingTab
            // 
            this.inventoryReceivingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.inventoryReceivingTab.Controls.Add(this.inventoryReceivingView);
            this.inventoryReceivingTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryReceivingTab.Name = "inventoryReceivingTab";
            this.inventoryReceivingTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryReceivingTab.Size = new System.Drawing.Size(645, 248);
            this.inventoryReceivingTab.TabIndex = 1;
            this.inventoryReceivingTab.Text = "Inventory Receiving";
            // 
            // inventoryReceivingView
            // 
            this.inventoryReceivingView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventoryReceivingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryReceivingView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productColumn2,
            this.quantityColumn2,
            this.dateRecievedColumn,
            this.addToInventory});
            this.inventoryReceivingView.Location = new System.Drawing.Point(0, 0);
            this.inventoryReceivingView.Name = "inventoryReceivingView";
            this.inventoryReceivingView.Size = new System.Drawing.Size(645, 248);
            this.inventoryReceivingView.TabIndex = 1;
            // 
            // paymentInformation
            // 
            this.paymentInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.paymentInformation.Controls.Add(this.paymentTypeBox);
            this.paymentInformation.Controls.Add(this.orderNotesBox);
            this.paymentInformation.Controls.Add(this.paymentDateBox);
            this.paymentInformation.Controls.Add(this.orderNotesLabel);
            this.paymentInformation.Controls.Add(this.paymentDateLabel);
            this.paymentInformation.Controls.Add(this.paymentTypeLabel);
            this.paymentInformation.Location = new System.Drawing.Point(4, 22);
            this.paymentInformation.Name = "paymentInformation";
            this.paymentInformation.Size = new System.Drawing.Size(645, 248);
            this.paymentInformation.TabIndex = 2;
            this.paymentInformation.Text = "Payment Information";
            // 
            // paymentTypeBox
            // 
            this.paymentTypeBox.FormattingEnabled = true;
            this.paymentTypeBox.Location = new System.Drawing.Point(145, 17);
            this.paymentTypeBox.Name = "paymentTypeBox";
            this.paymentTypeBox.Size = new System.Drawing.Size(153, 21);
            this.paymentTypeBox.TabIndex = 19;
            // 
            // orderNotesBox
            // 
            this.orderNotesBox.Location = new System.Drawing.Point(145, 71);
            this.orderNotesBox.Multiline = true;
            this.orderNotesBox.Name = "orderNotesBox";
            this.orderNotesBox.Size = new System.Drawing.Size(473, 53);
            this.orderNotesBox.TabIndex = 21;
            // 
            // paymentDateBox
            // 
            this.paymentDateBox.Location = new System.Drawing.Point(145, 45);
            this.paymentDateBox.Name = "paymentDateBox";
            this.paymentDateBox.Size = new System.Drawing.Size(153, 20);
            this.paymentDateBox.TabIndex = 20;
            // 
            // orderNotesLabel
            // 
            this.orderNotesLabel.AutoSize = true;
            this.orderNotesLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.orderNotesLabel.Location = new System.Drawing.Point(11, 74);
            this.orderNotesLabel.Name = "orderNotesLabel";
            this.orderNotesLabel.Size = new System.Drawing.Size(89, 30);
            this.orderNotesLabel.TabIndex = 8;
            this.orderNotesLabel.Text = "Payment/Order\r\nNotes\r\n";
            // 
            // paymentDateLabel
            // 
            this.paymentDateLabel.AutoSize = true;
            this.paymentDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.paymentDateLabel.Location = new System.Drawing.Point(11, 47);
            this.paymentDateLabel.Name = "paymentDateLabel";
            this.paymentDateLabel.Size = new System.Drawing.Size(84, 15);
            this.paymentDateLabel.TabIndex = 7;
            this.paymentDateLabel.Text = "Payment Date";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.paymentTypeLabel.Location = new System.Drawing.Point(11, 19);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(83, 15);
            this.paymentTypeLabel.TabIndex = 6;
            this.paymentTypeLabel.Text = "Payment Type";
            // 
            // productColumn2
            // 
            this.productColumn2.HeaderText = "Product";
            this.productColumn2.Name = "productColumn2";
            this.productColumn2.Width = 69;
            // 
            // quantityColumn2
            // 
            this.quantityColumn2.HeaderText = "Qty";
            this.quantityColumn2.Name = "quantityColumn2";
            this.quantityColumn2.Width = 48;
            // 
            // dateRecievedColumn
            // 
            this.dateRecievedColumn.HeaderText = "Date Recieved";
            this.dateRecievedColumn.Name = "dateRecievedColumn";
            this.dateRecievedColumn.Width = 104;
            // 
            // addToInventory
            // 
            this.addToInventory.HeaderText = "Add To Inventory";
            this.addToInventory.Name = "addToInventory";
            this.addToInventory.Width = 95;
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(674, 492);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderForm";
            this.Text = "Order Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchaseOrderForm_FormClosing);
            this.homeHeader.ResumeLayout(false);
            this.homeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.purchaseDetailsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsView)).EndInit();
            this.inventoryReceivingTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryReceivingView)).EndInit();
            this.paymentInformation.ResumeLayout(false);
            this.paymentInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeHeader;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox headerImage;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.LinkLabel saveLink;
        private System.Windows.Forms.LinkLabel cancelPurchaseLink;
        private System.Windows.Forms.LinkLabel approvePurchaseLink;
        private System.Windows.Forms.LinkLabel submitForApprovalLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage purchaseDetailsTab;
        private System.Windows.Forms.TabPage inventoryReceivingTab;
        private System.Windows.Forms.TabPage paymentInformation;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.ComboBox paymentTypeBox;
        private System.Windows.Forms.TextBox orderNotesBox;
        private System.Windows.Forms.TextBox paymentDateBox;
        private System.Windows.Forms.Label orderNotesLabel;
        private System.Windows.Forms.Label paymentDateLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.TextBox approvedDateBox;
        private System.Windows.Forms.TextBox submittedDateBox;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.TextBox expectedDateBox;
        private System.Windows.Forms.Label approvedDateLabel;
        private System.Windows.Forms.Label submittedDateLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label expectedDateLabel;
        private System.Windows.Forms.ComboBox approvedByBox;
        private System.Windows.Forms.ComboBox submittedByBox;
        private System.Windows.Forms.ComboBox createdByBox;
        private System.Windows.Forms.Label approvedByLabel;
        private System.Windows.Forms.Label submittedByLabel;
        private System.Windows.Forms.DataGridView inventoryReceivingView;
        private System.Windows.Forms.DataGridView purchaseDetailsView;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.DataGridViewComboBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecievedColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToInventory;
    }
}