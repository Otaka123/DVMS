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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class personCard : UserControl
    {
        public clsPerson person;

        public delegate void databackhandler(int personId);
        public databackhandler PersonIDHandler;
        private int personID = 0;
        public personCard()
        {
           

            InitializeComponent();
        }

        private void Mouseenter()
        {
            //if (person.ImagePath == "")
            //{
            //    if (person.Gendor == 0)
            //    {
            //        pbImage.Image = image.Images[1];

            //    }
            //    else
            //    {
            //        pbImage.Image = image.Images[3];

            //    }
            //}
            //else
            //{
            //    return;
            //}
        }
        private void defultpic()
        {
            //if (string.IsNullOrEmpty(person.ImagePath))
            //{
            //    if (person.Gendor == 0)
            //    {
            //        pbImage.Image = image.Images[0];

            //    }
            //    else
            //    {
            //        pbImage.Image = image.Images[2];

            //    }
            //}
            //else
            //{
            //    return;
            //}
        }
        public void loadinfo(int personid)
        {
            person=clsPerson.Find(personid);
            if (person != null)
            {
                personID = person.PersonID;
                lbPersonId.Text = person.PersonID.ToString();
                lbPhone.Text = person.Phone;
                lbnationalId.Text = person.NationalNo;
                lbname.Text = person.FirstName;
                lbsecodname.Text = person.SecondName;
                lbthirdname.Text = person.ThirdName;
                lblastname.Text = person.LastName;
                lbEmail.Text = person.Email;
                lbaddress.Text = person.Address;
                lbcountry.Text = person.country.CountryName;
                if (person.Email != string.Empty)
                {
                    lbEmail.Text = person.Email;

                }
                else
                {
                    lbEmail.Text = "N/A";
                }

                if (person.Gendor == false)
                {
                    lbGendor.Text = "ذكر";
                }
                else { lbGendor.Text = "انثي"; }

                if(person.ImagePath != null)
                {
                    pbImage.ImageLocation = person.ImagePath;
                }

                lbBirthofdate.Text=person.DateOfBirth.ToString();
            }
            else
            {
                MessageBox.Show("حصل مشكله واحنا بندور علي بيانات الشخص دا");
            }
        }
        public void loadinfo(string Nationalno)
        {
            person = clsPerson.Find(Nationalno);
            if (person != null)
            {
                personID = person.PersonID;
                PersonIDHandler?.Invoke(person.PersonID);
                lbPersonId.Text = person.PersonID.ToString();
                lbPhone.Text = person.Phone;
                lbnationalId.Text = person.NationalNo;
                lbname.Text = person.FirstName;
                lbsecodname.Text = person.SecondName;
                lbthirdname.Text = person.ThirdName;
                lblastname.Text = person.LastName;
                lbEmail.Text = person.Email;
                lbaddress.Text = person.Address;
                lbcountry.Text = person.country.CountryName;
                if (person.Email != string.Empty)
                {
                    lbEmail.Text = person.Email;

                }
                else
                {
                    lbEmail.Text = "N/A";
                }

                if (person.Gendor == false)
                {
                    lbGendor.Text = "ذكر";
                }
                else { lbGendor.Text = "انثي"; }

                if (person.ImagePath != null)
                {
                    pbImage.ImageLocation = person.ImagePath;
                }

                lbBirthofdate.Text = person.DateOfBirth.ToString();
            }
            else
            {
                MessageBox.Show("حصل مشكله واحنا بندور علي بيانات الشخص دا");
            }
        }
        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            Mouseenter();
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            defultpic();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (personID != 0)
            {
                AddNewPerson addNewPerson = new AddNewPerson(personID);
                addNewPerson.ShowDialog();
            }
        }
    }
}

