using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Edit_Addperson : UserControl
    {
        public Edit_Addperson()
        {
            InitializeComponent();
        }
        public enum enMode { AddNew = 0, Update = 1 };
        //private enMode _Mode = enMode.AddNew;
        public int modnum;
        public clsPerson personinfo;
        public int PersonID { get; set; }
        public string Distnaionpath = @"E:\programing\learn\c#\مشاريع\مشروع اداره السائقين والمركبات\Images\profileimage";
        public string Currentpicturepath = "";
        private bool valdationEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        private bool validationnum(string input)
        {
            string pattern = @"^\d+$"; // التعبير يضمن أن النص يحتوي فقط على أرقام
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        private void Fillinfo()
        {


            if (PersonID<0)
            {
                personinfo = new clsPerson();

            }
            personinfo.NationalNo = tbNationalID.Text;
            personinfo.FirstName = tbFirstName.Text;
            personinfo.SecondName = tbSecodName.Text;
            personinfo.ThirdName = tbThirdName.Text;
            personinfo.LastName = tbLastName.Text;
            personinfo.Email = tbEmail.Text;
            personinfo.Address = tbAddress.Text;
            if (rbmale.Checked)
            {
                personinfo.Gendor = false;

            }
            else
            {
                personinfo.Gendor = true;
            }
            personinfo.Phone = tbPhone.Text;
            personinfo.DateOfBirth = Convert.ToDateTime(DateofBirth.Value);
            personinfo.ImagePath = Currentpicturepath;
            personinfo.NationalityCountryID = clsCountry.Find(cbCountrys.Text).CountryID;
        }
        private bool AreAllFieldsFilled()
        {
            // ضع جميع TextBoxes في مصفوفة أو قائمة
            System.Windows.Forms.TextBox[] textBoxes = { tbNationalID, tbFirstName, tbSecodName, tbThirdName, tbLastName, tbAddress, tbPhone }; // أضف المزيد من الحقول حسب الحاجة

            foreach (var textBox in textBoxes)
            {

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false; // إذا كان هناك حقل فارغ
                }
                if (textBox.Text == tbNationalID.Text)
                {
                    if (clsPerson.IsExinst(textBox.Text))
                    {
                        return false;
                    }

                }
                else if (textBox.Text == tbFirstName.Text)
                {
                    if (validationnum(tbFirstName.Text))
                    {
                        return false;

                    }
                }
                else if (textBox.Text == tbSecodName.Text)
                {
                    if (validationnum(tbSecodName.Text))
                    {
                        return false;
                    }
                }
                else if (textBox.Text == tbThirdName.Text)
                {
                    if (validationnum(tbThirdName.Text))
                    {
                        return false;
                    }
                }
                else if (textBox.Text == tbLastName.Text)
                {
                    if (validationnum(tbLastName.Text))
                    {
                        return false;
                    }
                }
                else if (textBox.Text == tbPhone.Text)
                {
                    if (!validationnum(tbPhone.Text))
                    {
                        return false;
                    }
                }

            }
            return true; // جميع الحقول مليئة
        }
        private void lockallcontrol()
        {
            tbNationalID.Enabled = false;
            tbFirstName.Enabled = false;
            tbSecodName.Enabled = false;
            tbThirdName.Enabled = false;
            tbLastName.Enabled = false;
            tbEmail.Enabled = false;
            tbAddress.Enabled = false;
            rbfemale.Enabled = false;
            tbPhone.Enabled = false;
            DateofBirth.Enabled = false;
            pbimage.Enabled = false;
            cbCountrys.Enabled = false;
            Succed.Clear();
            errorProvider.Clear();

        }
        private bool AddNew()
        {
            if (AreAllFieldsFilled())
            {
                Fillinfo();
                personinfo.Save();
                return true;
            }
            else
            {
                MessageBox.Show("اتأكد انك مليت كل الخانات المطلوبه");
                return false;

            }
        }
        public bool startMod(int personid)
        {
            PersonID = personid;
            if (PersonID < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void _LoadinfoADD()
        {
            rbmale.Select();
            pbSave.Image = image.Images[4];
            pbimage.Image = image.Images[0];
            lbremove.Visible = false;
            pbmale.Image = Gendor.Images[0];
            pbFemale.Image = Gendor.Images[1];
            foreach (DataRow dataRow in clsCountry.GetAllCountryName().Rows)
                cbCountrys.Items.Add(dataRow["CountryName"]);
            cbCountrys.SelectedItem = "Egypt";
        }
        private void _loadinfoUpdateMode()
        {
            if (PersonID>0)
            {
                personinfo = clsPerson.Find(PersonID);

                
                   
                
                if (personinfo.Gendor == false)
                {
                    rbmale.Select();

                }
                else
                {
                    rbfemale.Select();

                }
                Currentpicturepath = personinfo.ImagePath;
                if (Currentpicturepath != string.Empty)
                {

                    pbimage.ImageLocation = Currentpicturepath;
                    lbremove.Visible = true;
                }
                else
                {
                    defultpic();
                }
                lbedit.Text = "تعديل بيانات ";
                pbSave.Image = image.Images[4];
                tbNationalID.Visible = false;
                tbFirstName.Text = personinfo.FirstName;
                tbSecodName.Text = personinfo.SecondName;
                tbThirdName.Text = personinfo.ThirdName;
                tbLastName.Text = personinfo.LastName;
                tbEmail.Text = personinfo.Email;
                tbAddress.Text = personinfo.Address;
                tbNationalID.Text = personinfo.NationalNo;
                tbPhone.Text = personinfo.Phone;
                //DateofBirth.Value = personinfo.DateOfBirth;
                foreach (DataRow dataRow in clsCountry.GetAllCountryName().Rows)
                    cbCountrys.Items.Add(dataRow["CountryName"]);
                lbPersonID.Text = personinfo.PersonID.ToString();
                cbCountrys.SelectedItem = clsCountry.Find(personinfo.NationalityCountryID).CountryName;
                pbmale.Image = Gendor.Images[0];
                pbFemale.Image = Gendor.Images[1];

            }
            


        }
       
        private void validationnotEmptyoreisitString(Control ControlName, string isEmpty, string isExist)
        {
            if (string.IsNullOrEmpty(ControlName.Text))
            {


                errorProvider.SetError(ControlName, isEmpty);
                Succed.SetError(ControlName, "");


            }
            else
            {
                if (clsPerson.IsExinst(ControlName.Text))
                {
                    errorProvider.SetError(ControlName, "الرقم دا موجود قبل كدا علي السيستم");
                    Succed.SetError(ControlName, "");

                }
                else
                {
                    errorProvider.SetError(ControlName, "");
                    Succed.SetError(ControlName, "Succed");
                }


            }
        }
        private void validationnotEmptyorNotNum(Control ControlName, string isEmpty, string NotNum)
        {
            if (string.IsNullOrEmpty(ControlName.Text))
            {


                errorProvider.SetError(ControlName, isEmpty);
                Succed.SetError(ControlName, "");


            }
            else
            {
                if (!validationnum(ControlName.Text))
                {
                    errorProvider.SetError(ControlName, "");

                    Succed.SetError(ControlName, "Succed");


                }
                else
                {
                    errorProvider.SetError(ControlName, NotNum);

                }


            }
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

                }


            }
        }
        private void validationnotEmpty(Control ControlName, string isEmpty)
        {
            if (string.IsNullOrEmpty(ControlName.Text))
            {


                errorProvider.SetError(ControlName, isEmpty);
                Succed.SetError(ControlName, "");


            }
            else
            {

                errorProvider.SetError(ControlName, "");

                Succed.SetError(ControlName, "Succed");




            }
        }
        private void _setimage()
        {
            Guid newimagename = Guid.NewGuid();
            string imagename = newimagename.ToString() + ".jpg";
            string sorcefiledistpath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر صورة";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // الحصول على المسار الكامل للملف المختار
                sorcefiledistpath = openFileDialog.FileName;


            }
            else
            {
                if (string.IsNullOrEmpty(Currentpicturepath))
                {
                    MessageBox.Show("يفضل تضيف صوره ", "مشكله هنا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbremove.Visible = false;
                }
            }
            if (!string.IsNullOrEmpty(sorcefiledistpath))
            {
                string Distnaion = Path.Combine(Distnaionpath, imagename);
                try
                {
                    File.Copy(sorcefiledistpath, Distnaion, true);

                }
                catch
                {
                    MessageBox.Show(" حصل مشكله واحنا بننقل الصوره ", "مشكله هنا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbremove.Visible = false;

                }
                pbimage.ImageLocation = Distnaion;
                lbremove.Visible = true;
                Currentpicturepath = Distnaion;
            }
        }
      
      
        private void defultpic()
        {
            if (string.IsNullOrEmpty(Currentpicturepath))
            {
                if (rbmale.Checked)
                {
                    pbimage.Image = image.Images[0];
                }
                else
                {
                    pbimage.Image = image.Images[2];

                }
            }
            else
            {
                return;
            }
        }
        private void Mouseenter()
        {
            if (string.IsNullOrEmpty(Currentpicturepath))
            {
                if (rbmale.Checked)
                {
                    pbimage.Image = image.Images[1];

                }
                else
                {
                    pbimage.Image = image.Images[3];

                }
            }
            else
            {
                return;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            defultpic();
        }
        private void pbimage_MouseEnter(object sender, EventArgs e)
        {
            Mouseenter();
        }
        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            defultpic();
        }
        private void pbimage_MouseLeave(object sender, EventArgs e)
        {
            defultpic();
        }
        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            pbSave.Image = image.Images[5];
        }
        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            pbSave.Image = image.Images[4];

        }
        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            validationnotEmpty(tbAddress, "لازم تكتب العنوان");

        }
        private void tbPhone_Validating_1(object sender, CancelEventArgs e)
        {
            validationnotEmptyorNotString(tbPhone, "لازم تكتب رقم تلفون", "اتاكد انك بتكتب ارقام مش حروف");

        }
        private void tbEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                if (!valdationEmail(tbEmail.Text))
                {
                    errorProvider.SetError(tbEmail, "دخل بريد صالح للاستخدام");
                }
                else
                {
                    errorProvider.SetError(tbEmail, "");
                    Succed.SetError(tbEmail, "Succed");


                }
            }
            else
            {
                errorProvider.SetError(tbEmail, "");
                Succed.SetError(tbEmail, "");

            }
        }
        private void tbSecodName_Validating_1(object sender, CancelEventArgs e)
        {
            validationnotEmptyorNotNum(tbSecodName, "لازم تكتب اسم الاب", "لازم الاسم يكون حروف مش ارقام");

        }
       private void tbThirdName_Validating_1(object sender, CancelEventArgs e)
        {
            validationnotEmptyorNotNum(tbThirdName, "لازم تكتب اسم الجد", "لازم الاسم يكون حروف مش ارقام");

        }
        private void tbLastName_Validating_1(object sender, CancelEventArgs e)
        {
            validationnotEmptyorNotNum(tbLastName, "لازم تكتب اسم اللقب", "لازم الاسم يكون حروف مش ارقام");

        }
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            validationnotEmptyorNotNum(tbFirstName, "لازم تكتب الاسم الاول", "لازم الاسم يكون حروف مش ارقام");

        }
        private void tbNationalID_Validating_1(object sender, CancelEventArgs e)
        {
            validationnotEmptyoreisitString(tbNationalID, "لازم تكتب الرقم القومي", "الرقم دا موجود قبل كدا علي السيستم");

        }

        private void lbsetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _setimage();

        }
        public void Start()
        {
            if (!startMod(PersonID))
            {
                lbedit.Visible = true;

                _loadinfoUpdateMode();
               
            }
            else 
            {
                _LoadinfoADD();

            }
        }
        private void Edit_Addperson_Load(object sender, EventArgs e)
        {
            //if (!startMod(modnum,PersonID))
            //{
            //    lbedit.Visible = true;

            //    _loadinfoUpdateMode();

            //}
            //else if(modnum==1)
            //{
            //    _LoadinfoADD();

            //}
        }

        private void pbSave_Click_1(object sender, EventArgs e)
        {
            if (PersonID < 0)
            {
                if (AddNew())
                {
                    lbPersonID.Text = personinfo.PersonID.ToString();
                    lockallcontrol();
                }
            }
            else
            {
                if(AreAllFieldsFilled())
                {
                    Fillinfo();
                    if (personinfo.Save())
                    {
                        MessageBox.Show("تم الحفظ بنجاح");
                        lockallcontrol();

                    }
                    else
                    {
                        MessageBox.Show("حصل مشكله اثناء الحفظ");
                    }
                }

                
        
            }
        }

        private void pbimage_Click_1(object sender, EventArgs e)
        {
            _setimage();

        }

        private void lbremove_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(Currentpicturepath))
            {
                File.Delete(Currentpicturepath);
                if (rbmale.Checked)
                {
                    pbimage.Image = image.Images[0];
                }
                else
                {
                    pbimage.Image = image.Images[2];

                }
                Currentpicturepath = "";
            }
        }
    }   

}

