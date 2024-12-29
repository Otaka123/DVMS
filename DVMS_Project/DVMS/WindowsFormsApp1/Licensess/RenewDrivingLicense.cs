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

namespace WindowsFormsApp1
{
    public partial class RenewDrivingLicense : Form
    {
        public RenewDrivingLicense()
        {
            InitializeComponent();
        }
        private int ApplictionID = 0; 
        private int licenseID= 0;  
        private void licenseCardWithFilter1_OnLicenseSelected(int arg1, int arg2)
        {
            licenseID=arg1;
            pbSave.Enabled = true;

        }

        private void RenewDrivingLicense_Load(object sender, EventArgs e)
        {
            pbSave.Enabled = false;

            pbClose.Image=buttonsimage.Images[0];
            pbSave.Image=buttonsimage.Images[2];
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[2];

        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[0];

        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[1];

        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[3];

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _renewlicense()
        {
            clsApplications App=new clsApplications();
            if (licenseID != 0)
            {
                clsLicense licenseinfo = clsLicense.Find(licenseID);
                if (licenseinfo != null)
                {
                    if (clsApplications.haveopenapp(licenseinfo.personiD, 2))
                    {
                        MessageBox.Show(" فيه طلب مفتوح  ");
                        pbSave.Enabled = false;


                    }
                    else
                    {
                        
                        App.ApplicantPersonID = licenseinfo.personiD;
                        App.ApplicationStatus = 1;
                        App.ApplicationDate = DateTime.Now;
                        App.ApplicationTypeID = 2;
                        App.CreatedByUserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                        App.LastStatusDate = DateTime.Now;
                        App.PaidFees = clsApllicationTypes.Find(2).ApplicaionFees;
                        ApplictionID = App.AppSave();
                        if (ApplictionID != -1)
                        {
                            licenseinfo.IssueDate = DateTime.Now;
                            int years = clsLicenseclass.getvaildationyears(licenseinfo.LicenseClass);
                            licenseinfo.ExpirationDate = DateTime.Now.AddYears(years);

                            if (licenseinfo.renewlicense())
                            {
                                MessageBox.Show($"{licenseinfo.ExpirationDate} تم تجديد الرخصه بنجاح الي تاريخ ");
                                applicationCard1.Start(ApplictionID);

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

            }
            else
            {
                MessageBox.Show("تاكد من كتابه رقم الرخصه بشكل صحيح");
                pbSave.Enabled = false;

            }


        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            _renewlicense();
        }
    }
}
