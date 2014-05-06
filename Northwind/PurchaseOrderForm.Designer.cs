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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            this.homeHeader = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.LinkLabel();
            this.completeOrder = new System.Windows.Forms.LinkLabel();
            this.shipOrderLabel = new System.Windows.Forms.LinkLabel();
            this.createInvoiceLabel = new System.Windows.Forms.LinkLabel();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.orderDetailsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shippingInformationTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.paymentInformation = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.homeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.orderDetailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.shippingInformationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.paymentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeHeader
            // 
            this.homeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeHeader.BackgroundImage = global::Northwind.Properties.Resources.GenericHeader;
            this.homeHeader.Controls.Add(this.closeLabel);
            this.homeHeader.Controls.Add(this.completeOrder);
            this.homeHeader.Controls.Add(this.shipOrderLabel);
            this.homeHeader.Controls.Add(this.createInvoiceLabel);
            this.homeHeader.Controls.Add(this.statusLabel);
            this.homeHeader.Controls.Add(this.headerImage);
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(672, 72);
            this.homeHeader.TabIndex = 10;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.closeLabel.LinkColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(628, 52);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(34, 14);
            this.closeLabel.TabIndex = 13;
            this.closeLabel.TabStop = true;
            this.closeLabel.Text = "Close";
            // 
            // completeOrder
            // 
            this.completeOrder.AutoSize = true;
            this.completeOrder.BackColor = System.Drawing.Color.Transparent;
            this.completeOrder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrder.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.completeOrder.LinkColor = System.Drawing.Color.White;
            this.completeOrder.Location = new System.Drawing.Point(424, 52);
            this.completeOrder.Name = "completeOrder";
            this.completeOrder.Size = new System.Drawing.Size(89, 14);
            this.completeOrder.TabIndex = 11;
            this.completeOrder.TabStop = true;
            this.completeOrder.Text = "Cancel Purchase";
            // 
            // shipOrderLabel
            // 
            this.shipOrderLabel.AutoSize = true;
            this.shipOrderLabel.BackColor = System.Drawing.Color.Transparent;
            this.shipOrderLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipOrderLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.shipOrderLabel.LinkColor = System.Drawing.Color.White;
            this.shipOrderLabel.Location = new System.Drawing.Point(301, 52);
            this.shipOrderLabel.Name = "shipOrderLabel";
            this.shipOrderLabel.Size = new System.Drawing.Size(98, 14);
            this.shipOrderLabel.TabIndex = 10;
            this.shipOrderLabel.TabStop = true;
            this.shipOrderLabel.Text = "Approve Purchase";
            // 
            // createInvoiceLabel
            // 
            this.createInvoiceLabel.AutoSize = true;
            this.createInvoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.createInvoiceLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createInvoiceLabel.LinkColor = System.Drawing.Color.White;
            this.createInvoiceLabel.Location = new System.Drawing.Point(173, 52);
            this.createInvoiceLabel.Name = "createInvoiceLabel";
            this.createInvoiceLabel.Size = new System.Drawing.Size(104, 14);
            this.createInvoiceLabel.TabIndex = 9;
            this.createInvoiceLabel.TabStop = true;
            this.createInvoiceLabel.Text = "Submit For Approval";
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
            this.approvedDateBox.Size = new System.Drawing.Size(139, 20);
            this.approvedDateBox.TabIndex = 29;
            // 
            // submittedDateBox
            // 
            this.submittedDateBox.Location = new System.Drawing.Point(497, 57);
            this.submittedDateBox.Name = "submittedDateBox";
            this.submittedDateBox.Size = new System.Drawing.Size(139, 20);
            this.submittedDateBox.TabIndex = 28;
            // 
            // creationDateBox
            // 
            this.creationDateBox.Location = new System.Drawing.Point(497, 30);
            this.creationDateBox.Name = "creationDateBox";
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
            this.approvedByBox.FormattingEnabled = true;
            this.approvedByBox.Location = new System.Drawing.Point(121, 85);
            this.approvedByBox.Name = "approvedByBox";
            this.approvedByBox.Size = new System.Drawing.Size(232, 21);
            this.approvedByBox.TabIndex = 21;
            // 
            // submittedByBox
            // 
            this.submittedByBox.FormattingEnabled = true;
            this.submittedByBox.Location = new System.Drawing.Point(121, 57);
            this.submittedByBox.Name = "submittedByBox";
            this.submittedByBox.Size = new System.Drawing.Size(232, 21);
            this.submittedByBox.TabIndex = 20;
            // 
            // createdByBox
            // 
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.orderDetailsTab);
            this.tabControl1.Controls.Add(this.shippingInformationTab);
            this.tabControl1.Controls.Add(this.paymentInformation);
            this.tabControl1.Location = new System.Drawing.Point(12, 206);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 274);
            this.tabControl1.TabIndex = 12;
            // 
            // orderDetailsTab
            // 
            this.orderDetailsTab.Controls.Add(this.dataGridView1);
            this.orderDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.orderDetailsTab.Name = "orderDetailsTab";
            this.orderDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderDetailsTab.Size = new System.Drawing.Size(645, 248);
            this.orderDetailsTab.TabIndex = 0;
            this.orderDetailsTab.Text = "Order Details";
            this.orderDetailsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // shippingInformationTab
            // 
            this.shippingInformationTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.shippingInformationTab.Controls.Add(this.dataGridView2);
            this.shippingInformationTab.Location = new System.Drawing.Point(4, 22);
            this.shippingInformationTab.Name = "shippingInformationTab";
            this.shippingInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.shippingInformationTab.Size = new System.Drawing.Size(645, 248);
            this.shippingInformationTab.TabIndex = 1;
            this.shippingInformationTab.Text = "Shipping Information";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 248);
            this.dataGridView2.TabIndex = 1;
            // 
            // paymentInformation
            // 
            this.paymentInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.paymentInformation.Controls.Add(this.comboBox4);
            this.paymentInformation.Controls.Add(this.textBox11);
            this.paymentInformation.Controls.Add(this.textBox12);
            this.paymentInformation.Controls.Add(this.label14);
            this.paymentInformation.Controls.Add(this.label15);
            this.paymentInformation.Controls.Add(this.label16);
            this.paymentInformation.Location = new System.Drawing.Point(4, 22);
            this.paymentInformation.Name = "paymentInformation";
            this.paymentInformation.Size = new System.Drawing.Size(645, 248);
            this.paymentInformation.TabIndex = 2;
            this.paymentInformation.Text = "Payment Information";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(145, 17);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(153, 21);
            this.comboBox4.TabIndex = 19;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(145, 71);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(473, 53);
            this.textBox11.TabIndex = 21;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(145, 45);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(153, 20);
            this.textBox12.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label14.Location = new System.Drawing.Point(11, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 30);
            this.label14.TabIndex = 8;
            this.label14.Text = "Payment/Order\r\nNotes\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label15.Location = new System.Drawing.Point(11, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Payment Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label16.Location = new System.Drawing.Point(11, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Payment Type";
            // 
            // PurchaseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(674, 492);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.orderDetailsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.shippingInformationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.paymentInformation.ResumeLayout(false);
            this.paymentInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homeHeader;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox headerImage;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.LinkLabel closeLabel;
        private System.Windows.Forms.LinkLabel completeOrder;
        private System.Windows.Forms.LinkLabel shipOrderLabel;
        private System.Windows.Forms.LinkLabel createInvoiceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage orderDetailsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage shippingInformationTab;
        private System.Windows.Forms.TabPage paymentInformation;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}