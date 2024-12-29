namespace WindowsFormsApp1
{
    partial class Applicationshowinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applicationshowinfo));
            this.applicationCard1 = new WindowsFormsApp1.ApplicationCard();
            this.SuspendLayout();
            // 
            // applicationCard1
            // 
            this.applicationCard1.Appid = 0;
            this.applicationCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("applicationCard1.BackgroundImage")));
            this.applicationCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.applicationCard1.Location = new System.Drawing.Point(-16, -26);
            this.applicationCard1.Name = "applicationCard1";
            this.applicationCard1.Size = new System.Drawing.Size(870, 419);
            this.applicationCard1.TabIndex = 0;
            // 
            // Applicationshowinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 378);
            this.Controls.Add(this.applicationCard1);
            this.Name = "Applicationshowinfo";
            this.Text = "Applicationshowinfo";
            this.Load += new System.EventHandler(this.Applicationshowinfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationCard applicationCard1;
    }
}