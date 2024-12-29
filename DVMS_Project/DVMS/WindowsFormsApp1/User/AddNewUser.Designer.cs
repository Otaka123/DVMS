namespace WindowsFormsApp1
{
    partial class AddNewUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonsimage = new System.Windows.Forms.ImageList(this.components);
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Succed = new System.Windows.Forms.ErrorProvider(this.components);
            this.edit_AddUser1 = new WindowsFormsApp1.Edit_AddUser();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Succed)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-User0.png");
            this.imageList1.Images.SetKeyName(1, "addUserEnter.png");
            // 
            // buttonsimage
            // 
            this.buttonsimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonsimage.ImageStream")));
            this.buttonsimage.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonsimage.Images.SetKeyName(0, "next-button (4).png");
            this.buttonsimage.Images.SetKeyName(1, "next-button (1).png");
            this.buttonsimage.Images.SetKeyName(2, "cross (1).png");
            this.buttonsimage.Images.SetKeyName(3, "cross (2).png");
            this.buttonsimage.Images.SetKeyName(4, "download (1).png");
            this.buttonsimage.Images.SetKeyName(5, "download (2).png");
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "id (1).png");
            this.icons.Images.SetKeyName(1, "id (2).png");
            this.icons.Images.SetKeyName(2, "id.png");
            this.icons.Images.SetKeyName(3, "reset-password.png");
            this.icons.Images.SetKeyName(4, "reset-password8.png");
            this.icons.Images.SetKeyName(5, "reset-password (1).png");
            this.icons.Images.SetKeyName(6, "username.png");
            this.icons.Images.SetKeyName(7, "username (2).png");
            this.icons.Images.SetKeyName(8, "username (1).png");
            this.icons.Images.SetKeyName(9, "padlock.png");
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Succed
            // 
            this.Succed.ContainerControl = this;
            this.Succed.Icon = ((System.Drawing.Icon)(resources.GetObject("Succed.Icon")));
            // 
            // edit_AddUser1
            // 
            this.edit_AddUser1.Location = new System.Drawing.Point(-6, 0);
            this.edit_AddUser1.Name = "edit_AddUser1";
            this.edit_AddUser1.personId = 0;
            this.edit_AddUser1.Size = new System.Drawing.Size(715, 670);
            this.edit_AddUser1.TabIndex = 0;
            this.edit_AddUser1.Load += new System.EventHandler(this.edit_AddUser1_Load);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(702, 631);
            this.Controls.Add(this.edit_AddUser1);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Succed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList buttonsimage;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider Succed;
        private Edit_AddUser edit_AddUser1;
    }
}