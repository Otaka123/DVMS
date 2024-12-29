namespace WindowsFormsApp1
{
    partial class FullInfoAppCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullInfoAppCard));
            this.applicationCard1 = new WindowsFormsApp1.ApplicationCard();
            this.localAppplicationcard1 = new WindowsFormsApp1.localAppplicationcard();
            this.SuspendLayout();
            // 
            // applicationCard1
            // 
            this.applicationCard1.Appid = 0;
            this.applicationCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("applicationCard1.BackgroundImage")));
            this.applicationCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.applicationCard1.Location = new System.Drawing.Point(347, -29);
            this.applicationCard1.Name = "applicationCard1";
            this.applicationCard1.Size = new System.Drawing.Size(870, 419);
            this.applicationCard1.TabIndex = 3;
            // 
            // localAppplicationcard1
            // 
            this.localAppplicationcard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("localAppplicationcard1.BackgroundImage")));
            this.localAppplicationcard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localAppplicationcard1.Location = new System.Drawing.Point(-48, 0);
            this.localAppplicationcard1.Name = "localAppplicationcard1";
            this.localAppplicationcard1.Size = new System.Drawing.Size(558, 375);
            this.localAppplicationcard1.TabIndex = 2;
            // 
            // FullInfoAppCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.localAppplicationcard1);
            this.Controls.Add(this.applicationCard1);
            this.Name = "FullInfoAppCard";
            this.Size = new System.Drawing.Size(1054, 374);
            this.Load += new System.EventHandler(this.FullInfoAppCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationCard applicationCard1;
        private localAppplicationcard localAppplicationcard1;
    }
}
