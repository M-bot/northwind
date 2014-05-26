namespace Northwind
{
    partial class ReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewer));
            this.reportBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // reportBrowser
            // 
            this.reportBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBrowser.Location = new System.Drawing.Point(0, 0);
            this.reportBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.reportBrowser.Name = "reportBrowser";
            this.reportBrowser.Size = new System.Drawing.Size(739, 672);
            this.reportBrowser.TabIndex = 0;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 672);
            this.Controls.Add(this.reportBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(755, 10000);
            this.MinimumSize = new System.Drawing.Size(755, 0);
            this.Name = "ReportViewer";
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportViewer_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser reportBrowser;
    }
}