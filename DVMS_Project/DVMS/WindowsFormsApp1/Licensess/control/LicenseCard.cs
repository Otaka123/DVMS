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
    public partial class LicenseCard : UserControl
    {
        public LicenseCard()
        {
            InitializeComponent();
        }
        private int ApplictionID = 0;
        public void Start(int G_ApplictionID)
        {
            ApplictionID = G_ApplictionID;
            if (ApplictionID != 0)
            {
                clsLicense mylicense= clsLicense.FindbyApplicationID(ApplictionID);
                if (mylicense != null)
                {
                    clsPerson person = clsPerson.Find(mylicense.personiD);
                     
                    if (person != null)
                    {
                        lbbirthdate.Text = person.DateOfBirth.ToString();
                        if (person.Gendor)
                        {
                            lbgendor.Text = "انثي";
                        }
                        else
                        {
                            lbgendor.Text = "ذكر";

                        }
                        if (person.ImagePath != string.Empty)
                        {
                            pictureBox1.ImageLocation = person.ImagePath;
                        }


                    }
                    lbname.Text = clsApplicationCard.Find(ApplictionID).Applicant;
                    lbNationo.Text = clsApplicationCard.Find(ApplictionID).personNo;
                    lbclass.Text = clsLicenseclass.Find(mylicense.LicenseClass).ClassName;
                    lbexpiredate.Text = mylicense.ExpirationDate.ToString();
                    if (mylicense.IsActive)
                    {
                        lbisActive.Text = "نعم";

                    }
                    else
                    {
                        lbisActive.Text = "لا";

                    }
                    if (clsLicense.IsDetain(mylicense.LicensesID))
                    {
                        lbisdetien.Text = "نعم";

                    }
                    else
                    {
                        lbisdetien.Text = "لا";

                    }
                    lbisshudate.Text = mylicense.IssueDate.ToString();
                    lbisshuresson.Text = clsApplicationCard.Find(ApplictionID).ApplicationType;
                    lblicenseid.Text = mylicense.LicensesID.ToString();
                    if (mylicense.Notes == string.Empty)
                    {
                        lbNote.Text = "لا يوجد";
                    }
                    else
                    {
                        lbNote.Text = mylicense.Notes;

                    }
                }
                else
                {
                    MessageBox.Show("هذا الشخص لا يملك رخصه");
                }
                
            }
           
        }
        public void StartwithLicneseID(int LicenseId)
        {
           
            if (LicenseId != 0)
            {
                clsLicense mylicense = clsLicense.Find(LicenseId);
                if (mylicense != null)
                {
                    clsPerson person = clsPerson.Find(mylicense.personiD);

                    if (person != null)
                    {
                        lbbirthdate.Text = person.DateOfBirth.ToString();
                        if (person.Gendor)
                        {
                            lbgendor.Text = "انثي";
                        }
                        else
                        {
                            lbgendor.Text = "ذكر";

                        }
                        if (person.ImagePath != string.Empty)
                        {
                            pictureBox1.ImageLocation = person.ImagePath;
                        }


                    }
                    lbname.Text = clsApplicationCard.Find(ApplictionID).Applicant;
                    lbNationo.Text = clsApplicationCard.Find(ApplictionID).personNo;
                    lbclass.Text = clsLicenseclass.Find(mylicense.LicenseClass).ClassName;
                    lbexpiredate.Text = mylicense.ExpirationDate.ToString();
                    if (mylicense.IsActive)
                    {
                        lbisActive.Text = "نعم";

                    }
                    else
                    {
                        lbisActive.Text = "لا";

                    }
                    if (clsLicense.IsDetain(mylicense.LicensesID))
                    {
                        lbisdetien.Text = "نعم";

                    }
                    else
                    {
                        lbisdetien.Text = "لا";

                    }
                    lbisshudate.Text = mylicense.IssueDate.ToString();
                    lbisshuresson.Text = clsApplicationCard.Find(ApplictionID).ApplicationType;
                    lblicenseid.Text = mylicense.LicensesID.ToString();
                    if (mylicense.Notes == string.Empty)
                    {
                        lbNote.Text = "لا يوجد";
                    }
                    else
                    {
                        lbNote.Text = mylicense.Notes;

                    }
                }
                else
                {
                    MessageBox.Show("هذا الشخص لا يملك رخصه");
                }

            }

        }
        private void LicenseCard_Load(object sender, EventArgs e)
        {

        }
    }
}
