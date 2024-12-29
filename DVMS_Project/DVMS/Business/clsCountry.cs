using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsCountry
    {
        public string CountryName { get; set; }
        public int CountryID { get; set; }

        private clsCountry(int countryid, string countryname)
        {
            CountryID = countryid;
            CountryName = countryname;


        }
        public static clsCountry Find(string countryname)
        {
            int countryID = 0;

            if (countriesdataAccess.GetCountryID(countryname, ref countryID))
            {
                clsCountry newcountry = new clsCountry(countryID, countryname);
                return newcountry;
            }
            else
            {
                return null;
            }

        }
        public static clsCountry Find(int countryID)
        {
            string countryname = "";

            if (countriesdataAccess.GetCountryName(countryID, ref countryname))
            {
                clsCountry newcountry = new clsCountry(countryID, countryname);
                return newcountry;
            }
            else
            {
                return null;
            }

        }
        public static bool IsExist(int countryId)
        {
            return countriesdataAccess.IsExit(countryId);
        }

        public static DataTable GetAllCountryName()
        {
            return countriesdataAccess.GetAllCountry();
        }
    }
}
