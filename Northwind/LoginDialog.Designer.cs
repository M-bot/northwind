namespace Northwind
{
    partial class LoginDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialog));
            this.northwindLogo = new System.Windows.Forms.PictureBox();
            this.loginTitle = new System.Windows.Forms.Label();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.disclaimerLabel = new System.Windows.Forms.Label();
            this.backdrop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.northwindLogo)).BeginInit();
            this.backdrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // northwindLogo
            // 
            this.northwindLogo.BackColor = System.Drawing.Color.Transparent;
            this.northwindLogo.Image = global::Northwind.Properties.Resources.LogoLarge;
            this.northwindLogo.Location = new System.Drawing.Point(16, 23);
            this.northwindLogo.Name = "northwindLogo";
            this.northwindLogo.Size = new System.Drawing.Size(93, 123);
            this.northwindLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.northwindLogo.TabIndex = 0;
            this.northwindLogo.TabStop = false;
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(120, 30);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(249, 40);
            this.loginTitle.TabIndex = 1;
            this.loginTitle.Text = "Northwind Login";
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(127, 115);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(242, 21);
            this.employeeBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(386, 113);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(66, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(82)))), ((int)(((byte)(22)))));
            this.employeeLabel.Location = new System.Drawing.Point(124, 97);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(99, 15);
            this.employeeLabel.TabIndex = 6;
            this.employeeLabel.Text = "Select Employee";
            // 
            // disclaimerLabel
            // 
            this.disclaimerLabel.AutoSize = true;
            this.disclaimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.disclaimerLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(143)))));
            this.disclaimerLabel.Location = new System.Drawing.Point(5, 149);
            this.disclaimerLabel.Name = "disclaimerLabel";
            this.disclaimerLabel.Size = new System.Drawing.Size(445, 56);
            this.disclaimerLabel.TabIndex = 7;
            this.disclaimerLabel.Text = resources.GetString("disclaimerLabel.Text");
            // 
            // backdrop
            // 
            this.backdrop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backdrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backdrop.BackgroundImage")));
            this.backdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backdrop.Controls.Add(this.disclaimerLabel);
            this.backdrop.Controls.Add(this.employeeLabel);
            this.backdrop.Controls.Add(this.loginButton);
            this.backdrop.Controls.Add(this.employeeBox);
            this.backdrop.Controls.Add(this.loginTitle);
            this.backdrop.Controls.Add(this.northwindLogo);
            this.backdrop.Location = new System.Drawing.Point(0, 0);
            this.backdrop.Name = "backdrop";
            this.backdrop.Size = new System.Drawing.Size(465, 265);
            this.backdrop.TabIndex = 2;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.backdrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginDialog_FormClosing);
            this.Load += new System.EventHandler(this.LoginDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindLogo)).EndInit();
            this.backdrop.ResumeLayout(false);
            this.backdrop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox northwindLogo;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label disclaimerLabel;
        private System.Windows.Forms.Panel backdrop;

    }
}