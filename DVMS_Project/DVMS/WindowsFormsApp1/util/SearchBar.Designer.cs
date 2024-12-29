namespace WindowsFormsApp1
{
    partial class SearchBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBar));
            this.cbBy = new System.Windows.Forms.ComboBox();
            this.tbtext = new System.Windows.Forms.TextBox();
            this.btnimage = new System.Windows.Forms.ImageList(this.components);
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBy
            // 
            this.cbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBy.FormattingEnabled = true;
            this.cbBy.Location = new System.Drawing.Point(3, 11);
            this.cbBy.Name = "cbBy";
            this.cbBy.Size = new System.Drawing.Size(183, 21);
            this.cbBy.TabIndex = 0;
            this.cbBy.SelectedIndexChanged += new System.EventHandler(this.cbBy_SelectedIndexChanged);
            this.cbBy.SelectedValueChanged += new System.EventHandler(this.cbBy_SelectedValueChanged);
            // 
            // tbtext
            // 
            this.tbtext.Location = new System.Drawing.Point(210, 12);
            this.tbtext.Name = "tbtext";
            this.tbtext.Size = new System.Drawing.Size(183, 20);
            this.tbtext.TabIndex = 1;
            this.tbtext.TextChanged += new System.EventHandler(this.tbtext_TextChanged);
            this.tbtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbtext_KeyDown);
            this.tbtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtext_KeyPress);
            // 
            // btnimage
            // 
            this.btnimage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnimage.ImageStream")));
            this.btnimage.TransparentColor = System.Drawing.Color.Transparent;
            this.btnimage.Images.SetKeyName(0, "search0.png");
            this.btnimage.Images.SetKeyName(1, "searchenter0.png");
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.Location = new System.Drawing.Point(399, 5);
            this.pbSearchbtn.Name = "pbSearchbtn";
            this.pbSearchbtn.Size = new System.Drawing.Size(32, 32);
            this.pbSearchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchbtn.TabIndex = 2;
            this.pbSearchbtn.TabStop = false;
            this.pbSearchbtn.Click += new System.EventHandler(this.pbSearchbtn_Click);
            this.pbSearchbtn.MouseEnter += new System.EventHandler(this.pbSearchbtn_MouseEnter);
            this.pbSearchbtn.MouseLeave += new System.EventHandler(this.pbSearchbtn_MouseLeave);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbSearchbtn);
            this.Controls.Add(this.tbtext);
            this.Controls.Add(this.cbBy);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(467, 40);
            this.Load += new System.EventHandler(this.SearchBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBy;
        private System.Windows.Forms.TextBox tbtext;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.ImageList btnimage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
