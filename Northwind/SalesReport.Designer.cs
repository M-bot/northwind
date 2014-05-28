namespace Northwind
{
    partial class SalesReportFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportFrom));
            this.homeHeader = new System.Windows.Forms.Panel();
            this.previewLink = new System.Windows.Forms.LinkLabel();
            this.createInvoiceLink = new System.Windows.Forms.LinkLabel();
            this.headerTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesTypeBox = new System.Windows.Forms.ListBox();
            this.salesPeriodBox = new System.Windows.Forms.ListBox();
            this.filterSalesBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.quarterlyBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.homeHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeHeader
            // 
            this.homeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeHeader.BackgroundImage = global::Northwind.Properties.Resources.GenericHeader;
            this.homeHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeHeader.Controls.Add(this.previewLink);
            this.homeHeader.Controls.Add(this.createInvoiceLink);
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(518, 72);
            this.homeHeader.TabIndex = 11;
            // 
            // previewLink
            // 
            this.previewLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.previewLink.AutoSize = true;
            this.previewLink.BackColor = System.Drawing.Color.Transparent;
            this.previewLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.previewLink.LinkColor = System.Drawing.Color.White;
            this.previewLink.Location = new System.Drawing.Point(57, 50);
            this.previewLink.Name = "previewLink";
            this.previewLink.Size = new System.Drawing.Size(47, 14);
            this.previewLink.TabIndex = 13;
            this.previewLink.TabStop = true;
            this.previewLink.Text = "Preview";
            this.previewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.previewLink_LinkClicked);
            // 
            // createInvoiceLink
            // 
            this.createInvoiceLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.createInvoiceLink.AutoSize = true;
            this.createInvoiceLink.BackColor = System.Drawing.Color.Transparent;
            this.createInvoiceLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createInvoiceLink.LinkColor = System.Drawing.Color.White;
            this.createInvoiceLink.Location = new System.Drawing.Point(20, 50);
            this.createInvoiceLink.Name = "createInvoiceLink";
            this.createInvoiceLink.Size = new System.Drawing.Size(28, 14);
            this.createInvoiceLink.TabIndex = 12;
            this.createInvoiceLink.TabStop = true;
            this.createInvoiceLink.Text = "Print";
            // 
            // headerTitle
            // 
            this.headerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerTitle.AutoSize = true;
            this.headerTitle.BackColor = System.Drawing.Color.Transparent;
            this.headerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTitle.ForeColor = System.Drawing.Color.White;
            this.headerTitle.Location = new System.Drawing.Point(12, 2);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(165, 29);
            this.headerTitle.TabIndex = 7;
            this.headerTitle.Text = "Sales Reports";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(277, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 240);
            this.panel1.TabIndex = 12;
            // 
            // salesTypeBox
            // 
            this.salesTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTypeBox.ItemHeight = 16;
            this.salesTypeBox.Items.AddRange(new object[] {
            "Sales By Category",
            "Sales By Country",
            "Sales By Customer",
            "Sales By Employee",
            "Sales By Product"});
            this.salesTypeBox.Location = new System.Drawing.Point(17, 116);
            this.salesTypeBox.Name = "salesTypeBox";
            this.salesTypeBox.Size = new System.Drawing.Size(250, 116);
            this.salesTypeBox.TabIndex = 13;
            this.salesTypeBox.SelectedIndexChanged += new System.EventHandler(this.salesTypeBox_SelectedIndexChanged);
            // 
            // salesPeriodBox
            // 
            this.salesPeriodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPeriodBox.ItemHeight = 16;
            this.salesPeriodBox.Items.AddRange(new object[] {
            "Monthly Sales",
            "Quarterly Sales",
            "Yearly Sales"});
            this.salesPeriodBox.Location = new System.Drawing.Point(290, 116);
            this.salesPeriodBox.Name = "salesPeriodBox";
            this.salesPeriodBox.Size = new System.Drawing.Size(216, 100);
            this.salesPeriodBox.TabIndex = 14;
            this.salesPeriodBox.SelectedIndexChanged += new System.EventHandler(this.salesPeriodBox_SelectedIndexChanged);
            // 
            // filterSalesBox
            // 
            this.filterSalesBox.FormattingEnabled = true;
            this.filterSalesBox.Location = new System.Drawing.Point(17, 260);
            this.filterSalesBox.Name = "filterSalesBox";
            this.filterSalesBox.Size = new System.Drawing.Size(250, 21);
            this.filterSalesBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Sales Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(15, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filter Sales Items...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label3.Location = new System.Drawing.Point(287, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select Sales Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label4.Location = new System.Drawing.Point(287, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label5.Location = new System.Drawing.Point(287, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quarter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label6.Location = new System.Drawing.Point(287, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Month";
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(353, 236);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(153, 21);
            this.yearBox.TabIndex = 22;
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
            // 
            // quarterlyBox
            // 
            this.quarterlyBox.FormattingEnabled = true;
            this.quarterlyBox.Items.AddRange(new object[] {
            "1st Quarter",
            "2nd Quarter",
            "3rd Quarter",
            "4th Quarter"});
            this.quarterlyBox.Location = new System.Drawing.Point(353, 262);
            this.quarterlyBox.Name = "quarterlyBox";
            this.quarterlyBox.Size = new System.Drawing.Size(153, 21);
            this.quarterlyBox.TabIndex = 23;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(353, 289);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(153, 21);
            this.monthBox.TabIndex = 24;
            // 
            // SalesReportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(518, 322);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.quarterlyBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterSalesBox);
            this.Controls.Add(this.salesPeriodBox);
            this.Controls.Add(this.salesTypeBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesReportFrom";
            this.Text = "Sales Reports Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesReportFrom_FormClosing);
            this.Load += new System.EventHandler(this.SalesReportFrom_Load);
            this.homeHeader.ResumeLayout(false);
            this.homeHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homeHeader;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.LinkLabel previewLink;
        private System.Windows.Forms.LinkLabel createInvoiceLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox salesTypeBox;
        private System.Windows.Forms.ListBox salesPeriodBox;
        private System.Windows.Forms.ComboBox filterSalesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox quarterlyBox;
        private System.Windows.Forms.ComboBox monthBox;
    }
}