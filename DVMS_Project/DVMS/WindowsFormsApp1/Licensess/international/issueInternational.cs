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
    public partial class issueInternational : Form
    {
        public issueInternational()
        {
            InitializeComponent();
        }
        //private int ApplicationId = 0;
        private int LicenseID = 0;
        private void pbissuelicense_MouseLeave(object sender, EventArgs e)
        {
            pbissuelicense.Image = imageList1.Images[0];

        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = imageList1.Images[2];

        }

        private void pbissuelicense_MouseEnter(object sender, EventArgs e)
        {
            pbissuelicense.Image = imageList1.Images[1];

        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbclose.Image = imageList1.Images[3];

        }

        private void personLicenseHistory_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 230);
            pbissuelicense.Image = imageList1.Images[0];
            pbclose.Image = imageList1.Images[2];


        }

    

        private void licenseCardWithFilter1_OnLicenseSelected(int arg1, int arg2)
        {
            LicenseID = arg1;
            clsLicense mylicense = clsLicense.Find(LicenseID);
            if(mylicense!=null)
            {
                MessageBox.Show($" صالحه  {LicenseID} = الرخصه رقم");
                applicationCard1.StartInternational(mylicense.personiD,6);

            }

        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbissuelicense_Click(object sender, EventArgs e)
        {
            clsLicense mylicense = clsLicense.Find(LicenseID);
            if (mylicense != null)
            {
                if (!clsinternationalLicense.IsLocalLicenseActive(LicenseID))
                {
                    MessageBox.Show("الرخصه المحلية غير ساريه تاكد من استخدام رخصه صالحه");
                }
                else
                {
                    if (clsinternationalLicense.HaveAntherLicense(LicenseID) > 0)
                    {
                        int internationalID = clsinternationalLicense.HaveAntherLicense(LicenseID);
                        MessageBox.Show($" {internationalID} = انت عندك رخصه ساريه برقم ");

                    }
                    else
                    {
                        clsinternationalLicense currentlicense = new clsinternationalLicense();
                        currentlicense.PersoID = mylicense.personiD;
                        currentlicense.createdbyuserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                        currentlicense.DriverID = clsLicense.GetDriverID(mylicense.personiD);
                        currentlicense.LocalLicenseID = LicenseID;
                        currentlicense.IssueDate = DateTime.Now;
                        currentlicense.ExpireDate = DateTime.Now.AddYears(1);
                        currentlicense.fees = clsApllicationTypes.Find(6).ApplicaionFees;
                        currentlicense.IsActive = true;
                        if (currentlicense.AddNew())
                        {
                           
                            MessageBox.Show($" بنجاح {currentlicense.internationalLicenseID} = تم اصدار الرخصه رقم   ");
                            applicationCard1.Start(currentlicense.ApplicationId);

                        }
                        else
                        {
                            MessageBox.Show("حصل مشكله اثناء اصدار الرخصه");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("اتاكد من بيانات الرخصه");
            }
        }
    }
}
