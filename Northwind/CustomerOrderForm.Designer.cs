namespace Northwind
{
    partial class CustomerOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDateBox = new System.Windows.Forms.TextBox();
            this.emailAddressBox = new System.Windows.Forms.TextBox();
            this.salespersonBox = new System.Windows.Forms.ComboBox();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.salespersonLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.orderDetailsTab = new System.Windows.Forms.TabPage();
            this.orderDetailsView = new System.Windows.Forms.DataGridView();
            this.shippingInformationTab = new System.Windows.Forms.TabPage();
            this.clearAddressButton = new System.Windows.Forms.Button();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.zipPostalBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.shipAddressBox = new System.Windows.Forms.TextBox();
            this.shipNameBox = new System.Windows.Forms.TextBox();
            this.countryRegionLabel = new System.Windows.Forms.Label();
            this.zipPostalLabel = new System.Windows.Forms.Label();
            this.stateProvinceLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.shipAddressLabel = new System.Windows.Forms.Label();
            this.shipNameLabel = new System.Windows.Forms.Label();
            this.shippingPanel = new System.Windows.Forms.Panel();
            this.shippingFeeBox = new System.Windows.Forms.TextBox();
            this.shipDateBox = new System.Windows.Forms.TextBox();
            this.shippingCompanyBox = new System.Windows.Forms.ComboBox();
            this.shippingFeeLabel = new System.Windows.Forms.Label();
            this.shipDateLabel = new System.Windows.Forms.Label();
            this.shippingCompanyLabel = new System.Windows.Forms.Label();
            this.paymentInformation = new System.Windows.Forms.TabPage();
            this.paymentTypeBox = new System.Windows.Forms.ComboBox();
            this.orderNotesBox = new System.Windows.Forms.TextBox();
            this.paymentDateBox = new System.Windows.Forms.TextBox();
            this.orderNotesLabel = new System.Windows.Forms.Label();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.homeHeader = new System.Windows.Forms.Panel();
            this.saveLink = new System.Windows.Forms.LinkLabel();
            this.deleteOrderLink = new System.Windows.Forms.LinkLabel();
            this.completeOrderLink = new System.Windows.Forms.LinkLabel();
            this.shipOrderLink = new System.Windows.Forms.LinkLabel();
            this.createInvoiceLink = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.headerTitle = new System.Windows.Forms.Label();
            this.productColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProvinceBox = new System.Windows.Forms.ComboBox();
            this.countryRegionBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.orderDetailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsView)).BeginInit();
            this.shippingInformationTab.SuspendLayout();
            this.addressPanel.SuspendLayout();
            this.shippingPanel.SuspendLayout();
            this.paymentInformation.SuspendLayout();
            this.homeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.orderDateBox);
            this.panel1.Controls.Add(this.emailAddressBox);
            this.panel1.Controls.Add(this.salespersonBox);
            this.panel1.Controls.Add(this.customerBox);
            this.panel1.Controls.Add(this.orderDateLabel);
            this.panel1.Controls.Add(this.salespersonLabel);
            this.panel1.Controls.Add(this.emailAddressLabel);
            this.panel1.Controls.Add(this.customerLabel);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 66);
            this.panel1.TabIndex = 11;
            // 
            // orderDateBox
            // 
            this.orderDateBox.Location = new System.Drawing.Point(509, 37);
            this.orderDateBox.Name = "orderDateBox";
            this.orderDateBox.ReadOnly = true;
            this.orderDateBox.Size = new System.Drawing.Size(179, 20);
            this.orderDateBox.TabIndex = 16;
            // 
            // emailAddressBox
            // 
            this.emailAddressBox.Location = new System.Drawing.Point(169, 37);
            this.emailAddressBox.Name = "emailAddressBox";
            this.emailAddressBox.ReadOnly = true;
            this.emailAddressBox.Size = new System.Drawing.Size(179, 20);
            this.emailAddressBox.TabIndex = 15;
            // 
            // salespersonBox
            // 
            this.salespersonBox.FormattingEnabled = true;
            this.salespersonBox.Location = new System.Drawing.Point(509, 8);
            this.salespersonBox.Name = "salespersonBox";
            this.salespersonBox.Size = new System.Drawing.Size(179, 21);
            this.salespersonBox.TabIndex = 14;
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(169, 8);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(179, 21);
            this.customerBox.TabIndex = 13;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.orderDateLabel.Location = new System.Drawing.Point(368, 39);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(67, 15);
            this.orderDateLabel.TabIndex = 12;
            this.orderDateLabel.Text = "Order Date";
            // 
            // salespersonLabel
            // 
            this.salespersonLabel.AutoSize = true;
            this.salespersonLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salespersonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.salespersonLabel.Location = new System.Drawing.Point(368, 10);
            this.salespersonLabel.Name = "salespersonLabel";
            this.salespersonLabel.Size = new System.Drawing.Size(78, 15);
            this.salespersonLabel.TabIndex = 11;
            this.salespersonLabel.Text = "Salesperson";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.emailAddressLabel.Location = new System.Drawing.Point(14, 39);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(87, 15);
            this.emailAddressLabel.TabIndex = 10;
            this.emailAddressLabel.Text = "Email Address";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.customerLabel.Location = new System.Drawing.Point(14, 10);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(62, 15);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer";
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.orderDetailsTab);
            this.tabControl1.Controls.Add(this.shippingInformationTab);
            this.tabControl1.Controls.Add(this.paymentInformation);
            this.tabControl1.Location = new System.Drawing.Point(12, 159);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 321);
            this.tabControl1.TabIndex = 12;
            // 
            // orderDetailsTab
            // 
            this.orderDetailsTab.Controls.Add(this.orderDetailsView);
            this.orderDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.orderDetailsTab.Name = "orderDetailsTab";
            this.orderDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderDetailsTab.Size = new System.Drawing.Size(717, 295);
            this.orderDetailsTab.TabIndex = 0;
            this.orderDetailsTab.Text = "Order Details";
            this.orderDetailsTab.UseVisualStyleBackColor = true;
            // 
            // orderDetailsView
            // 
            this.orderDetailsView.AllowUserToOrderColumns = true;
            this.orderDetailsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderDetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productColumn,
            this.quantityColumn,
            this.unitPriceColumn,
            this.discountColumn,
            this.totalPriceColumn,
            this.statusColumn});
            this.orderDetailsView.Location = new System.Drawing.Point(0, -1);
            this.orderDetailsView.Name = "orderDetailsView";
            this.orderDetailsView.Size = new System.Drawing.Size(717, 295);
            this.orderDetailsView.TabIndex = 0;
            // 
            // shippingInformationTab
            // 
            this.shippingInformationTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.shippingInformationTab.Controls.Add(this.clearAddressButton);
            this.shippingInformationTab.Controls.Add(this.addressPanel);
            this.shippingInformationTab.Controls.Add(this.shippingPanel);
            this.shippingInformationTab.Location = new System.Drawing.Point(4, 22);
            this.shippingInformationTab.Name = "shippingInformationTab";
            this.shippingInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.shippingInformationTab.Size = new System.Drawing.Size(717, 295);
            this.shippingInformationTab.TabIndex = 1;
            this.shippingInformationTab.Text = "Shipping Information";
            // 
            // clearAddressButton
            // 
            this.clearAddressButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAddressButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.clearAddressButton.Location = new System.Drawing.Point(14, 266);
            this.clearAddressButton.Name = "clearAddressButton";
            this.clearAddressButton.Size = new System.Drawing.Size(116, 23);
            this.clearAddressButton.TabIndex = 14;
            this.clearAddressButton.Text = "Clear Address";
            this.clearAddressButton.UseVisualStyleBackColor = true;
            this.clearAddressButton.Click += new System.EventHandler(this.clearAddressButton_Click);
            // 
            // addressPanel
            // 
            this.addressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressPanel.Controls.Add(this.countryRegionBox);
            this.addressPanel.Controls.Add(this.stateProvinceBox);
            this.addressPanel.Controls.Add(this.zipPostalBox);
            this.addressPanel.Controls.Add(this.cityBox);
            this.addressPanel.Controls.Add(this.shipAddressBox);
            this.addressPanel.Controls.Add(this.shipNameBox);
            this.addressPanel.Controls.Add(this.countryRegionLabel);
            this.addressPanel.Controls.Add(this.zipPostalLabel);
            this.addressPanel.Controls.Add(this.stateProvinceLabel);
            this.addressPanel.Controls.Add(this.cityLabel);
            this.addressPanel.Controls.Add(this.shipAddressLabel);
            this.addressPanel.Controls.Add(this.shipNameLabel);
            this.addressPanel.Location = new System.Drawing.Point(14, 58);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(689, 202);
            this.addressPanel.TabIndex = 13;
            // 
            // zipPostalBox
            // 
            this.zipPostalBox.Location = new System.Drawing.Point(162, 149);
            this.zipPostalBox.Name = "zipPostalBox";
            this.zipPostalBox.Size = new System.Drawing.Size(514, 20);
            this.zipPostalBox.TabIndex = 21;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(162, 95);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(514, 20);
            this.cityBox.TabIndex = 19;
            // 
            // shipAddressBox
            // 
            this.shipAddressBox.Location = new System.Drawing.Point(162, 36);
            this.shipAddressBox.Multiline = true;
            this.shipAddressBox.Name = "shipAddressBox";
            this.shipAddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shipAddressBox.Size = new System.Drawing.Size(514, 53);
            this.shipAddressBox.TabIndex = 18;
            // 
            // shipNameBox
            // 
            this.shipNameBox.Location = new System.Drawing.Point(162, 9);
            this.shipNameBox.Name = "shipNameBox";
            this.shipNameBox.Size = new System.Drawing.Size(514, 20);
            this.shipNameBox.TabIndex = 17;
            // 
            // countryRegionLabel
            // 
            this.countryRegionLabel.AutoSize = true;
            this.countryRegionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryRegionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.countryRegionLabel.Location = new System.Drawing.Point(7, 174);
            this.countryRegionLabel.Name = "countryRegionLabel";
            this.countryRegionLabel.Size = new System.Drawing.Size(92, 15);
            this.countryRegionLabel.TabIndex = 8;
            this.countryRegionLabel.Text = "Country/Region";
            // 
            // zipPostalLabel
            // 
            this.zipPostalLabel.AutoSize = true;
            this.zipPostalLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipPostalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.zipPostalLabel.Location = new System.Drawing.Point(7, 149);
            this.zipPostalLabel.Name = "zipPostalLabel";
            this.zipPostalLabel.Size = new System.Drawing.Size(95, 15);
            this.zipPostalLabel.TabIndex = 7;
            this.zipPostalLabel.Text = "Zip/Postal Code";
            // 
            // stateProvinceLabel
            // 
            this.stateProvinceLabel.AutoSize = true;
            this.stateProvinceLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateProvinceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.stateProvinceLabel.Location = new System.Drawing.Point(7, 122);
            this.stateProvinceLabel.Name = "stateProvinceLabel";
            this.stateProvinceLabel.Size = new System.Drawing.Size(85, 15);
            this.stateProvinceLabel.TabIndex = 6;
            this.stateProvinceLabel.Text = "State/Province";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.cityLabel.Location = new System.Drawing.Point(7, 95);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 15);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // shipAddressLabel
            // 
            this.shipAddressLabel.AutoSize = true;
            this.shipAddressLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.shipAddressLabel.Location = new System.Drawing.Point(7, 36);
            this.shipAddressLabel.Name = "shipAddressLabel";
            this.shipAddressLabel.Size = new System.Drawing.Size(80, 15);
            this.shipAddressLabel.TabIndex = 4;
            this.shipAddressLabel.Text = "Ship Address";
            // 
            // shipNameLabel
            // 
            this.shipNameLabel.AutoSize = true;
            this.shipNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.shipNameLabel.Location = new System.Drawing.Point(7, 9);
            this.shipNameLabel.Name = "shipNameLabel";
            this.shipNameLabel.Size = new System.Drawing.Size(69, 15);
            this.shipNameLabel.TabIndex = 3;
            this.shipNameLabel.Text = "Ship Name";
            // 
            // shippingPanel
            // 
            this.shippingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shippingPanel.Controls.Add(this.shippingFeeBox);
            this.shippingPanel.Controls.Add(this.shipDateBox);
            this.shippingPanel.Controls.Add(this.shippingCompanyBox);
            this.shippingPanel.Controls.Add(this.shippingFeeLabel);
            this.shippingPanel.Controls.Add(this.shipDateLabel);
            this.shippingPanel.Controls.Add(this.shippingCompanyLabel);
            this.shippingPanel.Location = new System.Drawing.Point(14, 11);
            this.shippingPanel.Name = "shippingPanel";
            this.shippingPanel.Size = new System.Drawing.Size(689, 41);
            this.shippingPanel.TabIndex = 12;
            // 
            // shippingFeeBox
            // 
            this.shippingFeeBox.Location = new System.Drawing.Point(603, 7);
            this.shippingFeeBox.Name = "shippingFeeBox";
            this.shippingFeeBox.Size = new System.Drawing.Size(73, 20);
            this.shippingFeeBox.TabIndex = 18;
            // 
            // shipDateBox
            // 
            this.shipDateBox.Location = new System.Drawing.Point(371, 7);
            this.shipDateBox.Name = "shipDateBox";
            this.shipDateBox.Size = new System.Drawing.Size(125, 20);
            this.shipDateBox.TabIndex = 17;
            // 
            // shippingCompanyBox
            // 
            this.shippingCompanyBox.FormattingEnabled = true;
            this.shippingCompanyBox.Location = new System.Drawing.Point(135, 7);
            this.shippingCompanyBox.Name = "shippingCompanyBox";
            this.shippingCompanyBox.Size = new System.Drawing.Size(153, 21);
            this.shippingCompanyBox.TabIndex = 17;
            // 
            // shippingFeeLabel
            // 
            this.shippingFeeLabel.AutoSize = true;
            this.shippingFeeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.shippingFeeLabel.Location = new System.Drawing.Point(502, 9);
            this.shippingFeeLabel.Name = "shippingFeeLabel";
            this.shippingFeeLabel.Size = new System.Drawing.Size(80, 15);
            this.shippingFeeLabel.TabIndex = 2;
            this.shippingFeeLabel.Text = "Shipping Fee";
            // 
            // shipDateLabel
            // 
            this.shipDateLabel.AutoSize = true;
            this.shipDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.shipDateLabel.Location = new System.Drawing.Point(304, 9);
            this.shipDateLabel.Name = "shipDateLabel";
            this.shipDateLabel.Size = new System.Drawing.Size(61, 15);
            this.shipDateLabel.TabIndex = 1;
            this.shipDateLabel.Text = "Ship Date";
            // 
            // shippingCompanyLabel
            // 
            this.shippingCompanyLabel.AutoSize = true;
            this.shippingCompanyLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingCompanyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.shippingCompanyLabel.Location = new System.Drawing.Point(3, 9);
            this.shippingCompanyLabel.Name = "shippingCompanyLabel";
            this.shippingCompanyLabel.Size = new System.Drawing.Size(112, 15);
            this.shippingCompanyLabel.TabIndex = 0;
            this.shippingCompanyLabel.Text = "Shipping Company";
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
            this.paymentInformation.Size = new System.Drawing.Size(717, 295);
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
            this.orderNotesBox.Size = new System.Drawing.Size(514, 53);
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
            // homeHeader
            // 
            this.homeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeHeader.BackgroundImage = global::Northwind.Properties.Resources.GenericHeader;
            this.homeHeader.Controls.Add(this.saveLink);
            this.homeHeader.Controls.Add(this.deleteOrderLink);
            this.homeHeader.Controls.Add(this.completeOrderLink);
            this.homeHeader.Controls.Add(this.shipOrderLink);
            this.homeHeader.Controls.Add(this.createInvoiceLink);
            this.homeHeader.Controls.Add(this.statusLabel);
            this.homeHeader.Controls.Add(this.headerImage);
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(747, 72);
            this.homeHeader.TabIndex = 10;
            // 
            // saveLink
            // 
            this.saveLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.saveLink.AutoSize = true;
            this.saveLink.BackColor = System.Drawing.Color.Transparent;
            this.saveLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.saveLink.LinkColor = System.Drawing.Color.White;
            this.saveLink.Location = new System.Drawing.Point(682, 51);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(32, 14);
            this.saveLink.TabIndex = 13;
            this.saveLink.TabStop = true;
            this.saveLink.Text = "Save";
            this.saveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveLink_LinkClicked);
            // 
            // deleteOrderLink
            // 
            this.deleteOrderLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.deleteOrderLink.AutoSize = true;
            this.deleteOrderLink.BackColor = System.Drawing.Color.Transparent;
            this.deleteOrderLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.deleteOrderLink.LinkColor = System.Drawing.Color.White;
            this.deleteOrderLink.Location = new System.Drawing.Point(459, 51);
            this.deleteOrderLink.Name = "deleteOrderLink";
            this.deleteOrderLink.Size = new System.Drawing.Size(68, 14);
            this.deleteOrderLink.TabIndex = 12;
            this.deleteOrderLink.TabStop = true;
            this.deleteOrderLink.Text = "Delete Order";
            // 
            // completeOrderLink
            // 
            this.completeOrderLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.completeOrderLink.AutoSize = true;
            this.completeOrderLink.BackColor = System.Drawing.Color.Transparent;
            this.completeOrderLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrderLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.completeOrderLink.LinkColor = System.Drawing.Color.White;
            this.completeOrderLink.Location = new System.Drawing.Point(369, 51);
            this.completeOrderLink.Name = "completeOrderLink";
            this.completeOrderLink.Size = new System.Drawing.Size(82, 14);
            this.completeOrderLink.TabIndex = 11;
            this.completeOrderLink.TabStop = true;
            this.completeOrderLink.Text = "Complete Order";
            // 
            // shipOrderLink
            // 
            this.shipOrderLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.shipOrderLink.AutoSize = true;
            this.shipOrderLink.BackColor = System.Drawing.Color.Transparent;
            this.shipOrderLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipOrderLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.shipOrderLink.LinkColor = System.Drawing.Color.White;
            this.shipOrderLink.Location = new System.Drawing.Point(301, 51);
            this.shipOrderLink.Name = "shipOrderLink";
            this.shipOrderLink.Size = new System.Drawing.Size(59, 14);
            this.shipOrderLink.TabIndex = 10;
            this.shipOrderLink.TabStop = true;
            this.shipOrderLink.Text = "Ship Order";
            // 
            // createInvoiceLink
            // 
            this.createInvoiceLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.createInvoiceLink.AutoSize = true;
            this.createInvoiceLink.BackColor = System.Drawing.Color.Transparent;
            this.createInvoiceLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createInvoiceLink.LinkColor = System.Drawing.Color.White;
            this.createInvoiceLink.Location = new System.Drawing.Point(215, 51);
            this.createInvoiceLink.Name = "createInvoiceLink";
            this.createInvoiceLink.Size = new System.Drawing.Size(76, 14);
            this.createInvoiceLink.TabIndex = 9;
            this.createInvoiceLink.TabStop = true;
            this.createInvoiceLink.Text = "Create Invoice";
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
            this.headerImage.Image = global::Northwind.Properties.Resources.OrderDetailsIcon;
            this.headerImage.Location = new System.Drawing.Point(20, 2);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(54, 41);
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
            this.headerTitle.Size = new System.Drawing.Size(164, 29);
            this.headerTitle.TabIndex = 7;
            this.headerTitle.Text = "Order # (New)";
            // 
            // productColumn
            // 
            this.productColumn.DataPropertyName = "Product";
            this.productColumn.HeaderText = "Product";
            this.productColumn.Name = "productColumn";
            this.productColumn.Width = 50;
            // 
            // quantityColumn
            // 
            this.quantityColumn.DataPropertyName = "Qty";
            this.quantityColumn.HeaderText = "Qty";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 48;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.DataPropertyName = "Unit Price";
            this.unitPriceColumn.HeaderText = "Unit Price";
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.Width = 78;
            // 
            // discountColumn
            // 
            this.discountColumn.DataPropertyName = "Discount";
            this.discountColumn.HeaderText = "Discount";
            this.discountColumn.Name = "discountColumn";
            this.discountColumn.Width = 74;
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.DataPropertyName = "Total Price";
            this.totalPriceColumn.HeaderText = "Total Price";
            this.totalPriceColumn.Name = "totalPriceColumn";
            this.totalPriceColumn.Width = 83;
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "Status";
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusColumn.Width = 62;
            // 
            // stateProvinceBox
            // 
            this.stateProvinceBox.FormattingEnabled = true;
            this.stateProvinceBox.Location = new System.Drawing.Point(162, 120);
            this.stateProvinceBox.Name = "stateProvinceBox";
            this.stateProvinceBox.Size = new System.Drawing.Size(514, 21);
            this.stateProvinceBox.TabIndex = 22;
            // 
            // countryRegionBox
            // 
            this.countryRegionBox.FormattingEnabled = true;
            this.countryRegionBox.Location = new System.Drawing.Point(162, 172);
            this.countryRegionBox.Name = "countryRegionBox";
            this.countryRegionBox.Size = new System.Drawing.Size(514, 21);
            this.countryRegionBox.TabIndex = 23;
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(749, 492);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerOrderForm";
            this.Text = "Order Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.orderDetailsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsView)).EndInit();
            this.shippingInformationTab.ResumeLayout(false);
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.shippingPanel.ResumeLayout(false);
            this.shippingPanel.PerformLayout();
            this.paymentInformation.ResumeLayout(false);
            this.paymentInformation.PerformLayout();
            this.homeHeader.ResumeLayout(false);
            this.homeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeHeader;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox headerImage;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.LinkLabel saveLink;
        private System.Windows.Forms.LinkLabel deleteOrderLink;
        private System.Windows.Forms.LinkLabel completeOrderLink;
        private System.Windows.Forms.LinkLabel shipOrderLink;
        private System.Windows.Forms.LinkLabel createInvoiceLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage orderDetailsTab;
        private System.Windows.Forms.DataGridView orderDetailsView;
        private System.Windows.Forms.TabPage shippingInformationTab;
        private System.Windows.Forms.TabPage paymentInformation;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label salespersonLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button clearAddressButton;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.Label countryRegionLabel;
        private System.Windows.Forms.Label zipPostalLabel;
        private System.Windows.Forms.Label stateProvinceLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label shipAddressLabel;
        private System.Windows.Forms.Label shipNameLabel;
        private System.Windows.Forms.Panel shippingPanel;
        private System.Windows.Forms.Label shippingFeeLabel;
        private System.Windows.Forms.Label shipDateLabel;
        private System.Windows.Forms.Label shippingCompanyLabel;
        private System.Windows.Forms.TextBox orderDateBox;
        private System.Windows.Forms.TextBox emailAddressBox;
        private System.Windows.Forms.ComboBox salespersonBox;
        private System.Windows.Forms.ComboBox customerBox;
        private System.Windows.Forms.TextBox zipPostalBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox shipAddressBox;
        private System.Windows.Forms.TextBox shipNameBox;
        private System.Windows.Forms.TextBox shippingFeeBox;
        private System.Windows.Forms.TextBox shipDateBox;
        private System.Windows.Forms.ComboBox shippingCompanyBox;
        private System.Windows.Forms.ComboBox paymentTypeBox;
        private System.Windows.Forms.TextBox orderNotesBox;
        private System.Windows.Forms.TextBox paymentDateBox;
        private System.Windows.Forms.Label orderNotesLabel;
        private System.Windows.Forms.Label paymentDateLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.ComboBox countryRegionBox;
        private System.Windows.Forms.ComboBox stateProvinceBox;
    }
}