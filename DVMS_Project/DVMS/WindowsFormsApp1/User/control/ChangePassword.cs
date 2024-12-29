using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Usercontrols
{
    public partial class ChangePassword : UserControl
    {
        public event Action Oncloseclicked;
        
        public ChangePassword()
        {
            InitializeComponent();
        }

        clsUser user;
        public int UserId { get; set; }
        //private int count = 0;
        public void Start(int USerID)
        {
            UserId = USerID;
            user = clsUser.Find(UserId);
            if (user != null)
            {
                personCard1.loadinfo(user.PersonID);
                lbUserId.Text = user.UserID.ToString();
                lbUserName.Text = user.UserName.ToString();
                if (user.IsActive)
                {
                    lbIsActive.Text = "Yes";
                }
                else
                {
                    lbIsActive.Text = "NO";

                }
            }
            else
            {
                MessageBox.Show("اتاكد منUserID");
            }

        }
        private void lockscreen()
        {
            tbPassword.Enabled = false;
            tbconfPassword.Enabled = false;
            tbCurrentpassword.Enabled = false;
            pbSave.Enabled = false;
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            pbUsername.Image = icons.Images[0];
            pbpassword.Image = icons.Images[1];
            pbpasswordconf.Image = icons.Images[2];
            pbClose.Image=buttonsimage.Images[2];
            pbSave.Image = buttonsimage.Images[4];
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbPassword.Text))
            {


                errorProvider.SetError(tbPassword, "لازم تكتب الباسورد ");
                Succed.SetError(tbPassword, "");


            }
            else
            {
                errorProvider.SetError(tbPassword, "");
               Succed.SetError(tbPassword, "تمام");

            }
        }

        private void tbconfPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbconfPassword.Text))
            {


                errorProvider.SetError(tbconfPassword, "لازم تكتب الباسورد مره كمان");
                Succed.SetError(tbconfPassword, "");


            }
            else
            {
                if (tbconfPassword.Text != tbPassword.Text)
                {

                    errorProvider.SetError(tbconfPassword, "لازم يكون متطابق مع الباسورد فوق ");
                    Succed.SetError(tbconfPassword, "");

                }
                else
                {
                    errorProvider.SetError(tbconfPassword, "");
                    Succed.SetError(tbconfPassword, "تمام");

                }
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentpassword.Text))
            {


                errorProvider.SetError(tbconfPassword, "لازم تكتب الباسورد الحالي");
                Succed.SetError(tbconfPassword, "");

            }
            else
            {

                if (tbCurrentpassword.Text != user.Password.ToString())
                {

                    errorProvider.SetError(tbCurrentpassword, "الباسورد غلط لو نسيت الباسورد ارجع ل الادمن ");
                    Succed.SetError(tbCurrentpassword, "");

                }
                else
                {
                    errorProvider.SetError(tbCurrentpassword, "");
                    Succed.SetError(tbCurrentpassword, "تمام");

                }
            }
        }
        private void fillinfo()
        {
            user.Password=tbPassword.Text;
        }
        private bool isAllfeildsfill()
        {
            return (!string.IsNullOrEmpty(tbCurrentpassword.Text)) ? (!string.IsNullOrEmpty(tbPassword.Text)) ?(!string.IsNullOrEmpty(tbconfPassword.Text)&&tbPassword.Text==tbconfPassword.Text)?true:false :false:false;
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if(isAllfeildsfill())
            {
                fillinfo();
                if (user.Save())
                {
                    MessageBox.Show("تم تغيير الباسورد بنجاح");
                    lockscreen();
                }
                else
                {

                    MessageBox.Show("اتاكد من البيانات المدخله  ");
                }
            }
            else
            {
                MessageBox.Show("اتاكد من البيانات المدخله  ");
            }
        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[5];

        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[4];

        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[3];

        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[2];

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Oncloseclicked?.Invoke();
        }
    }
}
