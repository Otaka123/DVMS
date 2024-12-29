using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Edit_AddUser : UserControl
    {
        public delegate void databackhandler(int personId);
        public databackhandler PersonIDHandler;
        public Edit_AddUser()
        {
            InitializeComponent();
        }
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public int personId { get; set; }
        public bool isinfoAccepted = false;
        public clsUser user;

        private void personCardWithFilter1_OnPersonSelected(int obj)
        {

            personId = obj;

            if (clsUser.ISExist(personId))
            {
                isinfoAccepted = false;
                isinfoAccepted = false;
                Logininfo.Enabled = false;
                pbNext.Enabled = false;
                pbback.Enabled = false;
            }
            else
            { 
                personId = obj;
                isinfoAccepted = true;
                Logininfo.Enabled = true;
                pbNext.Enabled = true;
                pbback.Enabled = true;
            }
              

            
          

        }
        private void UpdateMode()
        {
           
            lbTitle.Text = "UpDate User Info";
            pbNext.Image = buttonsimage.Images[0];
            tabPersonInfot.SelectedTab = tabPage1;
            Logininfo.Enabled = true;
            pbUserId.Image = icons.Images[1];
            pbUsername.Image = icons.Images[7];
            pbpassword.Image = icons.Images[9];
            pbpasswordconf.Image = icons.Images[4];
            pbSave.Image = buttonsimage.Images[4];
            pbClose.Image = buttonsimage.Images[2];
            pbback.Image = buttonsimage.Images[6];
            pbback.Enabled = false;
            pbNext.Enabled = true;
            //pbSave.Enabled = false;
        }
        //public void UpdateMode(int G_Userid)
        //{
        //    _Mode = enMode.Update;
        //    if ((user = clsUser.Find(G_Userid)) == null)
        //    {
        //        MessageBox.Show("فيه مشكله ف UserId");
        //        return;


        //    }
        //    else
        //    {
        //        personId = user.PersonID;
        //        tbUserName.Text = user.UserName;
        //        tbPassword.Text = user.Password;
        //        tbconfPassword.Text = user.Password;
        //        if (user.IsActive)
        //        {
        //            ckisActive.Checked = true;
        //        }
        //        else
        //        {
        //            ckisActive.Checked = false;

        //        }
        

        //    }
        //    pbtitle.Image = buttonsimage.Images[8];
        //     lbTitle.Text = "UpDate User Info";
        //    pbNext.Image = buttonsimage.Images[0];
        //    tabPersonInfot.SelectedTab = tabPage1;
        //    Logininfo.Enabled = true;
        //    pbUserId.Image = icons.Images[1];
        //    pbUsername.Image = icons.Images[7];
        //    pbpassword.Image = icons.Images[9];
        //    pbpasswordconf.Image = icons.Images[4];
        //    pbSave.Image = buttonsimage.Images[4];
        //    pbClose.Image = buttonsimage.Images[2];
        //    pbback.Image = buttonsimage.Images[6];
        //    pbback.Enabled = true;
        //    pbNext.Enabled = true;
        //    //pbSave.Enabled = false;
        //}

        private void AddNewMode()
        {
            pbNext.Image = buttonsimage.Images[0];
            tabPersonInfot.SelectedTab = tabPage1;
            Logininfo.Enabled = false;
            pbUserId.Image = icons.Images[0];
            pbUsername.Image = icons.Images[6];
            pbpassword.Image = icons.Images[9];
            pbpasswordconf.Image = icons.Images[3];
            pbSave.Image = buttonsimage.Images[4];
            pbClose.Image = buttonsimage.Images[2];
            pbback.Image = buttonsimage.Images[6];
            pbback.Enabled = false;
            pbback.Visible = false;
            pbNext.Enabled = false;
            pbSave.Enabled = false;
            back.Visible = false;
        }
        private bool IsAllinfofill()
        {
            bool isallinfofill = false;
            if (_Mode == enMode.AddNew)
            {
                isallinfofill = (!string.IsNullOrEmpty(tbUserName.Text) && !clsUser.IsExist(tbUserName.Text)) ? (!string.IsNullOrEmpty(tbPassword.Text)) ? (!string.IsNullOrEmpty(tbconfPassword.Text) && tbconfPassword.Text == tbPassword.Text) ? true : false : false : false;
            }
            else
            {
                isallinfofill = (!string.IsNullOrEmpty(tbUserName.Text)) ? (!string.IsNullOrEmpty(tbPassword.Text)) ? (!string.IsNullOrEmpty(tbconfPassword.Text) && tbconfPassword.Text == tbPassword.Text) ? true : false : false : false;
            }

            return isallinfofill;


        }
        private void fillinfo()
        {
            if (_Mode == enMode.AddNew)
            {
                user = new clsUser();

            }
           
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.PersonID = personId;
            if(ckisActive.Checked)
            {
                user.IsActive = true;
            }
            else
            {

                user.IsActive =false;
            }
        }
        private void AddUser()
        {

            if (IsAllinfofill())
            {
               
                fillinfo();
                if (_Mode == enMode.AddNew)
                {
                    if (user.Save())
                    {
                        MessageBox.Show("تم الحفظ بنجاح");
                        _Mode = enMode.Update;
                        UpdateMode();
                        lbUserId.Text = user.UserID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("حصل مشكله واحنا بنحفظ الحساب");
                    }
                }
                else
                {
                    fillinfo();
                    if (user.Save())
                    {
                        MessageBox.Show("تم الحفظ بنجاح");
                        
                        lbUserId.Text = user.UserID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("حصل مشكله واحنا بنحفظ الحساب");
                    }


                }
            }
            else
            {
                MessageBox.Show("اتاكد انك دخلت كل البيانات بشكل صحيح");
            }

            
        }

        private void Edit_AddUser_Load(object sender, EventArgs e)
        {
            personCardWithFilter1.Mode(1);

            if (_Mode == enMode.AddNew)
            {
                AddNewMode();
            }
            
            if(_Mode==enMode.Update)
            {
                UpdateMode();
            }
        }

        private void pbNext_MouseEnter(object sender, EventArgs e)
        {
            pbNext.Image = buttonsimage.Images[1];

        }

        private void pbNext_MouseLeave(object sender, EventArgs e)
        {
            pbNext.Image = buttonsimage.Images[0];

        }
       
        private void tabPersonInfot_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (isinfoAccepted != true)
            {
                if (e.TabPage == Logininfo)
                {
                    e.Cancel = true;
                    

                }
              
            }
           
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (!isinfoAccepted)
            {
                MessageBox.Show("اتاكد انك اخترت شخص لربطه ب حساب او ضيف شخص جديد");
            }
            else
            {
                tabPersonInfot.SelectedTab = Logininfo;
                pbNext.Visible = false;
                next.Visible = false;
                pbback.Visible = true;
                back.Visible = true;

            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text))
            {


                errorProvider.SetError(tbUserName, "لازم تكتب اسم المستخدم");
                Succed.SetError(tbUserName, "");


            }
            else
            {
                if(_Mode==enMode.AddNew)
                {
                    if (clsUser.IsExist(tbUserName.Text))
                    {
                        errorProvider.SetError(tbUserName, "اسم المستخدم دا موجود قبل كدا");
                        Succed.SetError(tbUserName, "");
                    }
                    else
                    {
                        errorProvider.SetError(tbUserName, "");

                        Succed.SetError(tbUserName, "تمام");

                    }
                }
                else
                {
                    errorProvider.SetError(tbUserName, "");

                    Succed.SetError(tbUserName, "تمام");

                }
               
            }
        }

        private void tbconfPassword_TextChanged(object sender, EventArgs e)
        {
            UnlockSavepb();
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

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            UnlockSavepb();
            if (string.IsNullOrEmpty(tbPassword.Text))
            {


                errorProvider.SetError(tbPassword, "لازم تكتب الباسورد ");
                Succed.SetError(tbPassword, "");


            }
            else
            {
                Succed.SetError(tbPassword, "تمام");

            }
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            tabPersonInfot.SelectedTab = tabPage1;
            pbback.Visible = false;
            back.Visible = false;
            pbNext.Visible = true;
            next.Visible = true;
        }

        private void pbback_MouseEnter(object sender, EventArgs e)
        {
            pbback.Image=buttonsimage.Images[7];
        }

        private void pbback_MouseLeave(object sender, EventArgs e)
        {
            pbback.Image = buttonsimage.Images[6];

        }

      
        private void pbClose_Click(object sender, EventArgs e)
        {
            PersonIDHandler?.Invoke(personId);
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            AddUser();
        }


        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[5];

        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[4];

        }
        private void UnlockSavepb()
        {
            if (IsAllinfofill())
            {
                pbSave.Enabled = true;
            }
            else
            {
                pbSave.Enabled = false;
            }
        }
        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[3];
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[2];

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            UnlockSavepb();
        }

        private void ckisActive_CheckedChanged(object sender, EventArgs e)
        {
            UnlockSavepb();
        }
        public void fillcardinfo(string Nationalno)
        {
        }
        private void personCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
