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

namespace WindowsFormsApp1.Licensess.Detain
{
    public partial class ReleaseLicense : Form
    {
        public ReleaseLicense()
        {
            InitializeComponent();
        }
        private int _LicenseId = 0;
        private int _LicenseAppID = 0;
        private int _personID=0;

        private void ReleaseLicense_Load(object sender, EventArgs e)
        {
            pbClose.Image=buttonsimage.Images[0];
            pbSave.Image=buttonsimage.Images[2];
            pbSave.Enabled=false;
        }
        private void _Detain()
        {
            if (_LicenseId != 0)
            {
                clsLicense licenseinfo = clsLicense.Find(_LicenseId);
                if (licenseinfo != null)
                {
                   
                   
                        string personno = clsApplicationCard.Find(_LicenseAppID).personNo;
                        _personID =clsPerson.Find(personno).PersonID;
                        clsApplications application = new clsApplications();
                            application.ApplicantPersonID=_personID;
                        application.ApplicationDate=DateTime.Now;
                        application.ApplicationStatus = 3;
                        application.ApplicationTypeID = 5;
                        application.CreatedByUserID= clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                        application.PaidFees=5;
                        application.LastStatusDate=DateTime.Now;
                        if(application.AddNewApp())
                        {
                            clsdetain detatin = new clsdetain();
                            detatin.LicenseID = _LicenseId;
                            detatin.ReleaseApplicationID=application.ApplicationID;
                            detatin.ReleaseDate=DateTime.Now;
                            detatin.ReleasedByUserID= clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                            
                            if (detatin.Update())
                            {
                                MessageBox.Show("تم تفعيل الرخصه بنجاح  ");
                                groupBox1.Enabled = false;
                                pbSave.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("لم يتم تفعيل الرخصه");

                            }
                        }
                        else
                        {
                            MessageBox.Show("حصل مشكله اثناء تقديم الطلب");
                        }


                    
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[0];

        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[1];

        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[2];

        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[3];

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
        private void CLables()
        {
            if (_LicenseId != 0)
            {
                
                if (clsLicense.IsDetain(_LicenseId))
                {
                    pbSave.Enabled = true;
                    lbfees.Text = clsdetain.Getfees(_LicenseId).ToString();
                    lbtotal.Text = (clsdetain.Getfees(_LicenseId) + 5).ToString();

                }
                else
                {
                    MessageBox.Show("الرخصه ب الرقم دا مش مسحوبه قبل كدا");

                    pbSave.Enabled=false;
                }
            }
        }
        public void fillinfo(int licenseid)
        {
            if(licenseid!=0)
            {
                licenseCardWithFilter1.fillinfo(licenseid);
                pbSave.Enabled=true;
            }
        }
        private void licenseCardWithFilter1_OnLicenseSelected(int arg1, int arg2)
        {
            _LicenseId=arg1;
            _LicenseAppID=arg2 ;
            CLables();

        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            _Detain();
        }
    }
}
