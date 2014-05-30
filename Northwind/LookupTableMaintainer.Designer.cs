namespace Northwind
{
    partial class LookupTableMaintainer
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
            this.homeHeader = new System.Windows.Forms.Panel();
            this.headerTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablesBox = new System.Windows.Forms.ListBox();
            this.valuesBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
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
            this.homeHeader.Controls.Add(this.headerTitle);
            this.homeHeader.Location = new System.Drawing.Point(0, 0);
            this.homeHeader.Name = "homeHeader";
            this.homeHeader.Size = new System.Drawing.Size(518, 72);
            this.homeHeader.TabIndex = 12;
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
            this.headerTitle.Size = new System.Drawing.Size(174, 29);
            this.headerTitle.TabIndex = 7;
            this.headerTitle.Text = "Lookup Tables";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select Table";
            // 
            // tablesBox
            // 
            this.tablesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesBox.ItemHeight = 16;
            this.tablesBox.Items.AddRange(new object[] {
            "Category",
            "Country",
            "Job Title",
            "State"});
            this.tablesBox.Location = new System.Drawing.Point(12, 102);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.Size = new System.Drawing.Size(250, 196);
            this.tablesBox.TabIndex = 17;
            this.tablesBox.SelectedIndexChanged += new System.EventHandler(this.tablesBox_SelectedIndexChanged);
            // 
            // valuesBox
            // 
            this.valuesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesBox.FormattingEnabled = true;
            this.valuesBox.ItemHeight = 16;
            this.valuesBox.Location = new System.Drawing.Point(268, 102);
            this.valuesBox.Name = "valuesBox";
            this.valuesBox.Size = new System.Drawing.Size(238, 164);
            this.valuesBox.TabIndex = 19;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(431, 272);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(350, 272);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(268, 274);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(76, 20);
            this.addBox.TabIndex = 22;
            // 
            // LookupTableMaintainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 322);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.valuesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablesBox);
            this.Controls.Add(this.homeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LookupTableMaintainer";
            this.Text = "Modify Lookup Tables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LookupTableMaintainer_FormClosing);
            this.Load += new System.EventHandler(this.LookupTableMaintainer_Load);
            this.homeHeader.ResumeLayout(false);
            this.homeHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homeHeader;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox tablesBox;
        private System.Windows.Forms.ListBox valuesBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addBox;
    }
}