namespace WindowsFormsApp1
{
    partial class Changepasswordd
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
            this.changePassword1 = new WindowsFormsApp1.Usercontrols.ChangePassword();
            this.SuspendLayout();
            // 
            // changePassword1
            // 
            this.changePassword1.Location = new System.Drawing.Point(1, 0);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(567, 602);
            this.changePassword1.TabIndex = 0;
            this.changePassword1.UserId = 0;
            this.changePassword1.Oncloseclicked += new System.Action(this.changePassword1_Oncloseclicked);
            this.changePassword1.Load += new System.EventHandler(this.changePassword1_Load);
            // 
            // Changepasswordd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 627);
            this.Controls.Add(this.changePassword1);
            this.Name = "Changepasswordd";
            this.Text = "Changepassword";
            this.Load += new System.EventHandler(this.Changepassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Usercontrols.ChangePassword changePassword1;
    }
}