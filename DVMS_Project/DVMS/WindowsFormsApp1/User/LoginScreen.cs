using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        string filePath = @" E:\programing\learn\c#\مشاريع\مشروع اداره السائقين والمركبات\Logininforemember\log";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("متاكد انك عايز تقفل البرنامج", "اغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Exit();


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbremember.Checked&&tbusername.Text!=string.Empty&&tbpassword.Text!=string.Empty)
            {
                File.WriteAllLines(filePath, new string[] { tbusername.Text, tbpassword.Text });

            }
            else if(cbremember.Checked==false)
            {
                File.WriteAllText(filePath, string.Empty);
            }
           

            if (clsUser.Get(tbusername.Text, tbpassword.Text) != null)
            {
                if(clsUser.Get(tbusername.Text, tbpassword.Text).IsActive==false)
                {
                    MessageBox.Show("الحساب بتاعك مش متفعل تواصل مع الادمن","فشل الدخول",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   ConnectionSetting.UserName=tbusername.Text;
                   ConnectionSetting.Password=tbpassword.Text;
                    HomeForm NEW = new HomeForm();
                    NEW.ShowDialog();
                    this.Close();

                }

            }
            else
            {
                MessageBox.Show("اسم المستخدم او الباسورد فيه مشكله", "فشل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

          
            this.Location = new Point(500,200);

            pbhidpass.Image = imageList1.Images[0];

            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath).ToList();
                if (lines.Count >= 2)
                {
                    tbusername.Text = File.ReadLines(filePath).First();
                    tbpassword.Text = File.ReadAllLines(filePath).Skip(1).First();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tbpassword.UseSystemPasswordChar == false)
            {
                tbpassword.UseSystemPasswordChar = true;
                pbhidpass.Image = imageList1.Images[1];
            }
            else
            {
                tbpassword.UseSystemPasswordChar = false;
                pbhidpass.Image = imageList1.Images[0];

            }





        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
