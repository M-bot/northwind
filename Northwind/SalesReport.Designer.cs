namespace Northwind
{
    partial class SalesReport
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Sales by Category");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Sales by Country");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.homeHeader = new System.Windows.Forms.Panel();
            this.shipOrderLink = new System.Windows.Forms.LinkLabel();
            this.createInvoiceLink = new System.Windows.Forms.LinkLabel();
            this.headerTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
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
            this.homeHeader.Controls.Add(this.shipOrderLink);
            this.homeHeader.Controls.Add(this.createInvoiceLink);
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(518, 72);
            this.homeHeader.TabIndex = 11;
            // 
            // shipOrderLink
            // 
            this.shipOrderLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.shipOrderLink.AutoSize = true;
            this.shipOrderLink.BackColor = System.Drawing.Color.Transparent;
            this.shipOrderLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipOrderLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.shipOrderLink.LinkColor = System.Drawing.Color.White;
            this.shipOrderLink.Location = new System.Drawing.Point(57, 50);
            this.shipOrderLink.Name = "shipOrderLink";
            this.shipOrderLink.Size = new System.Drawing.Size(47, 14);
            this.shipOrderLink.TabIndex = 13;
            this.shipOrderLink.TabStop = true;
            this.shipOrderLink.Text = "Preview";
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
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(17, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(250, 111);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(290, 116);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(216, 111);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 15;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(353, 236);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(353, 262);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 21);
            this.comboBox3.TabIndex = 23;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(353, 289);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(153, 21);
            this.comboBox4.TabIndex = 24;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(518, 322);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReport";
            this.Text = "Sales Reports Dialog";
            this.homeHeader.ResumeLayout(false);
            this.homeHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homeHeader;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.LinkLabel shipOrderLink;
        private System.Windows.Forms.LinkLabel createInvoiceLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}