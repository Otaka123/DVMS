namespace WindowsFormsApp1
{
    partial class localAppplicationcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(localAppplicationcard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblocalId = new System.Windows.Forms.Label();
            this.lbclassname = new System.Windows.Forms.Label();
            this.lbpassedtest = new System.Windows.Forms.Label();
            this.lbtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " : رقم الطلب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = " :  نوع الرخصه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = " : عدد الاختبارات المجتازه ";
            // 
            // lblocalId
            // 
            this.lblocalId.AutoSize = true;
            this.lblocalId.BackColor = System.Drawing.Color.Transparent;
            this.lblocalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocalId.Location = new System.Drawing.Point(376, 145);
            this.lblocalId.Name = "lblocalId";
            this.lblocalId.Size = new System.Drawing.Size(35, 20);
            this.lblocalId.TabIndex = 3;
            this.lblocalId.Text = "N/A";
            // 
            // lbclassname
            // 
            this.lbclassname.AutoSize = true;
            this.lbclassname.BackColor = System.Drawing.Color.Transparent;
            this.lbclassname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclassname.Location = new System.Drawing.Point(258, 211);
            this.lbclassname.Name = "lbclassname";
            this.lbclassname.Size = new System.Drawing.Size(35, 20);
            this.lbclassname.TabIndex = 4;
            this.lbclassname.Text = "N/A";
            // 
            // lbpassedtest
            // 
            this.lbpassedtest.AutoSize = true;
            this.lbpassedtest.BackColor = System.Drawing.Color.Transparent;
            this.lbpassedtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassedtest.Location = new System.Drawing.Point(291, 171);
            this.lbpassedtest.Name = "lbpassedtest";
            this.lbpassedtest.Size = new System.Drawing.Size(35, 20);
            this.lbpassedtest.TabIndex = 5;
            this.lbpassedtest.Text = "N/A";
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.BackColor = System.Drawing.Color.Transparent;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(126, 93);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(324, 33);
            this.lbtitle.TabIndex = 6;
            this.lbtitle.Text = "بيانات  طلب التقديم علي رخصة ";
            // 
            // localAppplicationcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.lbpassedtest);
            this.Controls.Add(this.lbclassname);
            this.Controls.Add(this.lblocalId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "localAppplicationcard";
            this.Size = new System.Drawing.Size(558, 400);
            this.Load += new System.EventHandler(this.localAppplicationcard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblocalId;
        private System.Windows.Forms.Label lbclassname;
        private System.Windows.Forms.Label lbpassedtest;
        private System.Windows.Forms.Label lbtitle;
    }
}
