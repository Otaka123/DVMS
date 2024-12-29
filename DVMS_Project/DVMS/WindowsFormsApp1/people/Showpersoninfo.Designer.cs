namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personCard1 = new WindowsFormsApp1.personCard();
            this.SuspendLayout();
            // 
            // personCard1
            // 
            this.personCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personCard1.BackgroundImage")));
            this.personCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personCard1.Location = new System.Drawing.Point(-4, 0);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(674, 336);
            this.personCard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 333);
            this.Controls.Add(this.personCard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private personCard personCard1;
    }
}