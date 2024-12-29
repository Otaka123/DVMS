using dataAccess;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsPerson
    {

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.Address = "";
            this.Phone = "";
            this.Gendor = true;
            this.DateOfBirth = DateTime.Now;
            this.ImagePath = "";
            this.NationalityCountryID = -1;
            this.Mode = enMode.AddNew;

        }
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public clsCountry country ;
       
        private clsPerson(int spersonID, string snationalno, string sfirstname, string ssecondname, string sthirdname, string slastname, string semail, string saddress, string sphone, bool sgendor, DateTime sbirthdate, int countryid, string sImagepath)
        {
            this.PersonID = spersonID;
            this.NationalNo = snationalno;
            this.FirstName = sfirstname;
            this.SecondName = ssecondname;
            this.ThirdName = sthirdname;
            this.LastName = slastname;
            this.DateOfBirth = sbirthdate;
            this.Email = semail;
            this.Gendor = sgendor;
            this.Address = saddress;
            this.Phone = sphone;
            this.NationalityCountryID = countryid;
            this.ImagePath = sImagepath;
            this.country=clsCountry.Find(NationalityCountryID);
            this.Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.PersonID = clsPesronsdataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Email, this.Address, this.Phone, this.Gendor, this.DateOfBirth, this.NationalityCountryID, this.ImagePath);
            return (PersonID != -1);
        }
        private bool _Update()
        {
            return clsPesronsdataAccess.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Email, this.Address, this.Phone, this.Gendor, this.DateOfBirth, this.NationalityCountryID, this.ImagePath);

        }
        //public static DataTable search(string searchby,string textbar)
        //{

        //    return clsPesronsdataAccess.search(searchby,textbar);

        //}
        public static bool Delete(int personID)
        {
            return clsPesronsdataAccess.DeletePerson(personID);
        }
        public static bool IsExinst(int personId)
        {
            return clsPesronsdataAccess.IsExit(personId);
        }
        public static bool IsExinst(string NationalNo)
        {
            return clsPesronsdataAccess.IsExit(NationalNo);
        }
        public static DataTable GetAllpersons()
        {
           
            return clsPesronsdataAccess.GetAllpersons();
           
        }
        public static clsPerson Find(string nationalno)
        {
            int PersonID = -1;
            DateTime birthdate2 = DateTime.MinValue;
            int nationalitycountryId2 = -1;
            string firstname = string.Empty, secondname = string.Empty, thirdname = string.Empty, lastname = string.Empty, email = string.Empty, address = string.Empty, phone = string.Empty, Imagepath = string.Empty;
            bool gendor = true;
            bool found = clsPesronsdataAccess.GetPersonByNationalNo(nationalno, ref PersonID, ref firstname, ref secondname, ref thirdname, ref lastname, ref email, ref address, ref phone, ref gendor, ref birthdate2, ref nationalitycountryId2, ref Imagepath);
            if (found)
            {
              clsPerson person   = new clsPerson(PersonID, nationalno, firstname, secondname, thirdname, lastname, email, address, phone, gendor, birthdate2, nationalitycountryId2, Imagepath);
                return person;
            }
            else
            {
                return null;
            }
        }
        public static clsPerson Find(int PersonID)
        {
          
            DateTime birthdate2 = DateTime.MinValue;
            int nationalitycountryId2 = 0;
            string firstname = string.Empty, nationalno= string.Empty, secondname = string.Empty, thirdname = string.Empty, lastname = string.Empty, email = string.Empty, address = string.Empty, phone = string.Empty, Imagepath = string.Empty;
            bool gendor = true;
            bool found = clsPesronsdataAccess.GetPersonByPersonID(PersonID, ref nationalno, ref firstname, ref secondname
                                                         , ref thirdname, ref lastname, ref email,ref address, ref phone, ref gendor, ref birthdate2
                                                          , ref nationalitycountryId2, ref Imagepath);
            if (found)
            {
               
               
                clsPerson person = new clsPerson(PersonID, nationalno, firstname, secondname, thirdname, lastname, email, address, phone, gendor, birthdate2, nationalitycountryId2, Imagepath);
                return person;
            }
            else
            {
                return null;
            }
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.AddNew;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _Update();


            }
            return false;
        }


    }

}
