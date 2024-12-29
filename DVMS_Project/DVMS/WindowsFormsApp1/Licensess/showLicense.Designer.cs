namespace WindowsFormsApp1
{
    partial class showLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showLicense));
            this.licenseCard1 = new WindowsFormsApp1.LicenseCard();
            this.SuspendLayout();
            // 
            // licenseCard1
            // 
            this.licenseCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("licenseCard1.BackgroundImage")));
            this.licenseCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.licenseCard1.Location = new System.Drawing.Point(-78, -12);
            this.licenseCard1.Name = "licenseCard1";
            this.licenseCard1.Size = new System.Drawing.Size(958, 460);
            this.licenseCard1.TabIndex = 0;
            // 
            // showLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.licenseCard1);
            this.Name = "showLicense";
            this.Text = "showLicense";
            this.Load += new System.EventHandler(this.showLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LicenseCard licenseCard1;
    }
}