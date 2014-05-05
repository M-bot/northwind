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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.headerImage.Image = global::Northwind.Properties.Resources.Logo;
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
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 114);
            this.panel1.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(497, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(497, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(497, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label3.Location = new System.Drawing.Point(385, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Approved Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label4.Location = new System.Drawing.Point(385, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Submitted Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label5.Location = new System.Drawing.Point(385, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Creation Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label6.Location = new System.Drawing.Point(385, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Expected Date";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(121, 85);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(232, 21);
            this.comboBox5.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(232, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Approved By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Submitted By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Created By:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label10.Location = new System.Drawing.Point(6, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Supplier";
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}