using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Licensess
{
    public partial class Detain_License : Form
    {
        public Detain_License()
        {
            InitializeComponent();
        }
        private int _LicenseId = 0;
        private void Detain_License_Load(object sender, EventArgs e)
        {
            pbSave.Enabled = false;

            pbClose.Image = buttonsimage.Images[0];
            pbSave.Image = buttonsimage.Images[2];

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseId != 0)
            {
                int personid = clsLicense.Find(_LicenseId).personiD;
                LicenseHistory history = new LicenseHistory(personid);
                history.ShowDialog();
            }
            else
            {
                MessageBox.Show("تأكد من ادخال رقم الرخصه لاظهار السجل");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            _Detain();
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[2];

        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = buttonsimage.Images[3];

        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[0];

        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = buttonsimage.Images[1];

        }
        private bool validationnum(string input)
        {
            string pattern = @"^\d+$"; // التعبير يضمن أن النص يحتوي فقط على أرقام
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        private void validationnotEmptyorNotString(Control ControlName, string isEmpty, string NotNum)
        {
            if (string.IsNullOrEmpty(ControlName.Text))
            {


                errorProvider.SetError(ControlName, isEmpty);
                Succed.SetError(ControlName, "");


            }
            else
            {
                if (validationnum(ControlName.Text))
                {
                    errorProvider.SetError(ControlName, "");

                    Succed.SetError(ControlName, "Succed");


                }
                else
                {
                    errorProvider.SetError(ControlName, NotNum);
                    Succed.SetError(ControlName, "");


                }


            }
        }
        private void tbfees_Validating(object sender, CancelEventArgs e)
        {
        }

        private void tbfees_TextChanged(object sender, EventArgs e)
        {
            if (validationnum(tbfees.Text))
            {
                pbSave.Enabled = true;
            }
            else
            {
                pbSave.Enabled = false;

            }
            validationnotEmptyorNotString(tbfees, "لازم تكتب قيمه المخالفه هنا", "اتاكد انك بتكتب قيمه المخالفه ب الارقام");

        }
        private void _Detain()
        {
            if (_LicenseId != 0)
            {
                clsLicense licenseinfo = clsLicense.Find(_LicenseId);
                if (licenseinfo != null)
                {
                    if (clsLicense.IsDetain(_LicenseId))
                    {
                        MessageBox.Show("الرخصه ب الرقم دا مسحوبه قبل كدا");
                    }
                    else
                    {

                        clsdetain detatin =new clsdetain();
                        detatin.DetainDate= DateTime.Now;
                        detatin.CreatedByUserID = clsUser.GetUserIdByUserName(ConnectionSetting.UserName);
                        detatin.FineFees=Convert.ToDecimal(tbfees.Text);
                        detatin.LicenseID = _LicenseId;
                        if(detatin.Save())
                        {
                            MessageBox.Show("تم تسجيل السحب");
                            tbfees.Enabled = false;
                            pbSave.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم تسجيل السحب");

                        }


                    }
                }
            }
        }
        private void licenseCardWithFilter1_OnLicenseSelected(int arg1, int arg2)
        {
            _LicenseId=arg1;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
