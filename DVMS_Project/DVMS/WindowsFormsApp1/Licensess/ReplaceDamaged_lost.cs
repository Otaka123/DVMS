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

namespace WindowsFormsApp1.Licensess
{
    public partial class ReplaceDamaged_lost : Form
    {
        public ReplaceDamaged_lost()
        {
            InitializeComponent();
        }
        private int _LicenseId =0;
        private int _ApplictionID = 0;
        private byte _issueResone = 0;
        private int _OldLicense = 0;
        private void lbtitle_Click(object sender, EventArgs e)
        {

        }

        private void ReplaceDamaged_lost_Load(object sender, EventArgs e)
        {
            pbSave.Enabled = false;
            rbdamage.Checked = true;

            pbClose.Image = buttonsimage.Images[0];
            pbSave.Image = buttonsimage.Images[2];
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[2];

        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[0];

        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[3];

        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[1];

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _feeslabal();
        }
        private void _feeslabal()
        {
            if (rblost.Checked)
            { 
                lbfees.Text = 10.ToString();
                _issueResone = 3;
            }
            else
            {
                lbfees.Text = 5.ToString();
                _issueResone = 4;
            }


                
           
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _feeslabal();
        }

        private void licenseCardWithFilter1_OnLicenseSelected(int arg1, int arg2)
        {
            _LicenseId=arg1;
            _pbsavebtn();
        }
     
        private void _replacement()
        {

            clsLicense licenseinfo = clsLicense.Find(_LicenseId);
            if (licenseinfo != null)
            {
                _OldLicense=licenseinfo.LicensesID;
                if (clsApplications.haveopenapp(licenseinfo.personiD, _issueResone))
                {
                    MessageBox.Show(" فيه طلب مفتوح  ");
                    pbSave.Enabled = false;


                }
                else
                {
                    pbSave.Enabled = true;
                    clsApplications App= new clsApplications();
                    App.ApplicantPersonID = licenseinfo.personiD;
                    App.ApplicationStatus = 1;
                    App.ApplicationDate = DateTime.Now;
                    App.ApplicationTypeID = 2;
                    App.CreatedByUserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                    App.LastStatusDate = DateTime.Now;
                    App.PaidFees =Convert.ToDecimal(lbfees.Text);
                   _ApplictionID = App.AppSave();
                    if (_ApplictionID != -1)
                    {
                        licenseinfo.ApplictionID =_ApplictionID;
                        licenseinfo.IssueDate = DateTime.Now;
                        int years = clsLicenseclass.getvaildationyears(licenseinfo.LicenseClass);
                        licenseinfo.ExpirationDate = DateTime.Now.AddYears(years);

                        if (licenseinfo.Replace(_issueResone))
                        {
                            if (_issueResone == 3)
                            {
                                MessageBox.Show($" تم إصدار بدل فاقد للرخصة رقم {_OldLicense} ورقم الرخصة الجديد {licenseinfo.LicensesID}");
                            }
                            else if (_issueResone == 4)
                            {
                                MessageBox.Show($"تم إصدار بدل تالف للرخصة رقم {_OldLicense} ورقم الرخصة الجديد {licenseinfo.LicensesID}");
                            }

                        }
                        else
                        {
                            MessageBox.Show("حصل مشكله اثناء الاضافه");
                            pbSave.Enabled = false;

                        }


                    }
                    else
                    {
                        MessageBox.Show("حصل مشكله اثناء الاضافه");
                        pbSave.Enabled = false;

                    }
                }

            }
            else
            {
                MessageBox.Show("فيه مشكله في رقم الرخصه");
            }
        }
        private void _pbsavebtn()
        {
            if(_LicenseId!=0)
            {
                pbSave.Enabled = true;
            }
            else
            {
                pbSave.Enabled = false;
            }

        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if(_LicenseId != 0)
            {
                if(clsLicense.IsDetain(_LicenseId))
                {
                    MessageBox.Show("الرخصه مسحوبه قدم علي طلب فك سحب الرخصه ");
                }
                else
                {
                    if(clsLicense.Find(_LicenseId).IsActive==false)
                    {
                        MessageBox.Show("الرخصه غير ساريه ");

                    }
                    else
                    {

                        _replacement();



                    }
                }
              
            }
            else
            {
                MessageBox.Show("اتاكد انك كاتب رقم رخصه صحيح");
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseId != 0)
            {
                int personid = clsLicense.Find(_LicenseId).personiD;
                LicenseHistory history = new LicenseHistory(personid);
                history.ShowDialog();
            }
        }
    }
}
