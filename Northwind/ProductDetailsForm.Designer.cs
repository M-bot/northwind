namespace Northwind
{
    partial class ProductDetailsForm
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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.discontinuedBox = new System.Windows.Forms.CheckBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.reorderBox = new System.Windows.Forms.TextBox();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.defaultReorderBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.discontinuedLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.defaultReorderLabel = new System.Windows.Forms.Label();
            this.reorderLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.historyView = new System.Windows.Forms.DataGridView();
            this.homeHeader = new Northwind.Header();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.newLink = new System.Windows.Forms.LinkLabel();
            this.saveLink = new System.Windows.Forms.LinkLabel();
            this.goToProductLabel = new System.Windows.Forms.Label();
            this.headerImage = new System.Windows.Forms.PictureBox();
            this.headerTitle = new System.Windows.Forms.Label();
            this.supplierBox = new PresentationControls.CheckBoxComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).BeginInit();
            this.homeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 528);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.tabPage1.Controls.Add(this.supplierBox);
            this.tabPage1.Controls.Add(this.descriptionBox);
            this.tabPage1.Controls.Add(this.discontinuedBox);
            this.tabPage1.Controls.Add(this.costBox);
            this.tabPage1.Controls.Add(this.priceBox);
            this.tabPage1.Controls.Add(this.reorderBox);
            this.tabPage1.Controls.Add(this.targetBox);
            this.tabPage1.Controls.Add(this.defaultReorderBox);
            this.tabPage1.Controls.Add(this.quantityBox);
            this.tabPage1.Controls.Add(this.categoryBox);
            this.tabPage1.Controls.Add(this.codeBox);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.idBox);
            this.tabPage1.Controls.Add(this.discontinuedLabel);
            this.tabPage1.Controls.Add(this.targetLabel);
            this.tabPage1.Controls.Add(this.defaultReorderLabel);
            this.tabPage1.Controls.Add(this.reorderLabel);
            this.tabPage1.Controls.Add(this.priceLabel);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.descriptionLabel);
            this.tabPage1.Controls.Add(this.quantityLabel);
            this.tabPage1.Controls.Add(this.categoryLabel);
            this.tabPage1.Controls.Add(this.supplierLabel);
            this.tabPage1.Controls.Add(this.productCodeLabel);
            this.tabPage1.Controls.Add(this.productNameLabel);
            this.tabPage1.Controls.Add(this.productIDLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Details";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(22, 230);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(349, 265);
            this.descriptionBox.TabIndex = 37;
            // 
            // discontinuedBox
            // 
            this.discontinuedBox.AutoSize = true;
            this.discontinuedBox.Location = new System.Drawing.Point(554, 172);
            this.discontinuedBox.Name = "discontinuedBox";
            this.discontinuedBox.Size = new System.Drawing.Size(15, 14);
            this.discontinuedBox.TabIndex = 35;
            this.discontinuedBox.UseVisualStyleBackColor = true;
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(554, 26);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(171, 20);
            this.costBox.TabIndex = 34;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(554, 54);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(171, 20);
            this.priceBox.TabIndex = 33;
            // 
            // reorderBox
            // 
            this.reorderBox.Location = new System.Drawing.Point(554, 83);
            this.reorderBox.Name = "reorderBox";
            this.reorderBox.Size = new System.Drawing.Size(171, 20);
            this.reorderBox.TabIndex = 32;
            // 
            // targetBox
            // 
            this.targetBox.Location = new System.Drawing.Point(554, 112);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(171, 20);
            this.targetBox.TabIndex = 31;
            // 
            // defaultReorderBox
            // 
            this.defaultReorderBox.Location = new System.Drawing.Point(554, 141);
            this.defaultReorderBox.Name = "defaultReorderBox";
            this.defaultReorderBox.Size = new System.Drawing.Size(171, 20);
            this.defaultReorderBox.TabIndex = 30;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(149, 170);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(222, 20);
            this.quantityBox.TabIndex = 29;
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(149, 112);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(222, 20);
            this.categoryBox.TabIndex = 28;
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(149, 83);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(222, 20);
            this.codeBox.TabIndex = 27;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(149, 54);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(222, 20);
            this.nameBox.TabIndex = 26;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(149, 26);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(222, 20);
            this.idBox.TabIndex = 25;
            // 
            // discontinuedLabel
            // 
            this.discontinuedLabel.AutoSize = true;
            this.discontinuedLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discontinuedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.discontinuedLabel.Location = new System.Drawing.Point(383, 172);
            this.discontinuedLabel.Name = "discontinuedLabel";
            this.discontinuedLabel.Size = new System.Drawing.Size(80, 15);
            this.discontinuedLabel.TabIndex = 19;
            this.discontinuedLabel.Text = "Discontinued";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.targetLabel.Location = new System.Drawing.Point(383, 114);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(73, 15);
            this.targetLabel.TabIndex = 20;
            this.targetLabel.Text = "Target Level";
            // 
            // defaultReorderLabel
            // 
            this.defaultReorderLabel.AutoSize = true;
            this.defaultReorderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultReorderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.defaultReorderLabel.Location = new System.Drawing.Point(383, 143);
            this.defaultReorderLabel.Name = "defaultReorderLabel";
            this.defaultReorderLabel.Size = new System.Drawing.Size(141, 15);
            this.defaultReorderLabel.TabIndex = 21;
            this.defaultReorderLabel.Text = "Default Reorder Quantity";
            // 
            // reorderLabel
            // 
            this.reorderLabel.AutoSize = true;
            this.reorderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.reorderLabel.Location = new System.Drawing.Point(383, 85);
            this.reorderLabel.Name = "reorderLabel";
            this.reorderLabel.Size = new System.Drawing.Size(84, 15);
            this.reorderLabel.TabIndex = 22;
            this.reorderLabel.Text = "Reorder Level";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.priceLabel.Location = new System.Drawing.Point(383, 56);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 15);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "List Price";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.costLabel.Location = new System.Drawing.Point(383, 28);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(86, 15);
            this.costLabel.TabIndex = 24;
            this.costLabel.Text = "Standard Cost";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.descriptionLabel.Location = new System.Drawing.Point(19, 201);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Description";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.quantityLabel.Location = new System.Drawing.Point(19, 172);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(98, 15);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.Text = "Quantity Per Unit";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.categoryLabel.Location = new System.Drawing.Point(19, 114);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(56, 15);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Category";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.supplierLabel.Location = new System.Drawing.Point(19, 143);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(53, 15);
            this.supplierLabel.TabIndex = 14;
            this.supplierLabel.Text = "Supplier";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.productCodeLabel.Location = new System.Drawing.Point(19, 85);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(82, 15);
            this.productCodeLabel.TabIndex = 15;
            this.productCodeLabel.Text = "Product Code";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.productNameLabel.Location = new System.Drawing.Point(19, 56);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(41, 15);
            this.productNameLabel.TabIndex = 16;
            this.productNameLabel.Text = "Name";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.productIDLabel.Location = new System.Drawing.Point(19, 28);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(64, 15);
            this.productIDLabel.TabIndex = 17;
            this.productIDLabel.Text = "Product ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.tabPage2.Controls.Add(this.historyView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order/Purchase History";
            // 
            // historyView
            // 
            this.historyView.AllowUserToAddRows = false;
            this.historyView.AllowUserToDeleteRows = false;
            this.historyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyView.Location = new System.Drawing.Point(34, 41);
            this.historyView.Name = "historyView";
            this.historyView.ReadOnly = true;
            this.historyView.Size = new System.Drawing.Size(683, 415);
            this.historyView.TabIndex = 0;
            // 
            // homeHeader
            // 
            this.homeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeHeader.Controls.Add(this.productBox);
            this.homeHeader.Controls.Add(this.newLink);
            this.homeHeader.Controls.Add(this.saveLink);
            this.homeHeader.Controls.Add(this.goToProductLabel);
            this.homeHeader.Controls.Add(this.headerImage);
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(771, 72);
            this.homeHeader.TabIndex = 11;
            // 
            // productBox
            // 
            this.productBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(104, 45);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(85, 24);
            this.productBox.TabIndex = 15;
            // 
            // newLink
            // 
            this.newLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.newLink.AutoSize = true;
            this.newLink.BackColor = System.Drawing.Color.Transparent;
            this.newLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.newLink.LinkColor = System.Drawing.Color.White;
            this.newLink.Location = new System.Drawing.Point(725, 51);
            this.newLink.Name = "newLink";
            this.newLink.Size = new System.Drawing.Size(30, 14);
            this.newLink.TabIndex = 14;
            this.newLink.TabStop = true;
            this.newLink.Text = "New";
            this.newLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newLink_LinkClicked);
            // 
            // saveLink
            // 
            this.saveLink.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.saveLink.AutoSize = true;
            this.saveLink.BackColor = System.Drawing.Color.Transparent;
            this.saveLink.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.saveLink.LinkColor = System.Drawing.Color.White;
            this.saveLink.Location = new System.Drawing.Point(677, 51);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(32, 14);
            this.saveLink.TabIndex = 13;
            this.saveLink.TabStop = true;
            this.saveLink.Text = "Save";
            this.saveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveLink_LinkClicked);
            // 
            // goToProductLabel
            // 
            this.goToProductLabel.AutoSize = true;
            this.goToProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.goToProductLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToProductLabel.ForeColor = System.Drawing.Color.White;
            this.goToProductLabel.Location = new System.Drawing.Point(17, 51);
            this.goToProductLabel.Name = "goToProductLabel";
            this.goToProductLabel.Size = new System.Drawing.Size(81, 15);
            this.goToProductLabel.TabIndex = 8;
            this.goToProductLabel.Text = "Go to Product";
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
            this.headerTitle.Size = new System.Drawing.Size(164, 29);
            this.headerTitle.TabIndex = 7;
            this.headerTitle.Text = "Product Name";
            // 
            // supplierBox
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.supplierBox.CheckBoxProperties = checkBoxProperties1;
            this.supplierBox.DisplayMemberSingleItem = "";
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(149, 141);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(222, 21);
            this.supplierBox.TabIndex = 38;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(769, 602);
            this.Controls.Add(this.homeHeader);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetailsForm";
            this.Text = "Product Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductDetailsForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).EndInit();
            this.homeHeader.ResumeLayout(false);
            this.homeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Header homeHeader;
        private System.Windows.Forms.LinkLabel saveLink;
        private System.Windows.Forms.Label goToProductLabel;
        private System.Windows.Forms.PictureBox headerImage;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.LinkLabel newLink;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.CheckBox discontinuedBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox reorderBox;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.TextBox defaultReorderBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label discontinuedLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label defaultReorderLabel;
        private System.Windows.Forms.Label reorderLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.DataGridView historyView;
        private System.Windows.Forms.ComboBox productBox;
        private PresentationControls.CheckBoxComboBox supplierBox;
    }
}