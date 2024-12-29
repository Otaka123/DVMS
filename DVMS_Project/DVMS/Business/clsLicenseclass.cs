using dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsLicenseclass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }

        public decimal ClassFees { get; set; }
        public clsLicenseclass()
        {
            LicenseClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
        }
        private clsLicenseclass(int G_LicenseClassID, string G_ClassName, string G_ClassDescription, byte G_MinimumAllowedAge, byte G_DefaultValidityLength, decimal G_ClassFees)
        {
            LicenseClassID = G_LicenseClassID;
            ClassName = G_ClassName;
            ClassDescription = G_ClassDescription;
            MinimumAllowedAge = G_MinimumAllowedAge;
            DefaultValidityLength = G_DefaultValidityLength;
            ClassFees = G_ClassFees;
        }
        public static clsLicenseclass Find(int classtype)
        {
            string G_ClassName = "";
            string G_ClassDescription = "";
            byte G_MinimumAllowedAge = 0;
            byte G_DefaultValidityLength = 0;
            decimal G_ClassFees = 0;
            if (DriversDataacces.findlicenseclass(classtype, ref G_ClassName,ref G_ClassDescription,ref G_MinimumAllowedAge,ref G_DefaultValidityLength,ref G_ClassFees))
            {
                clsLicenseclass newcalss = new clsLicenseclass(classtype, G_ClassName, G_ClassDescription, G_MinimumAllowedAge, G_DefaultValidityLength, G_ClassFees);
                return newcalss;
            }
            else
            {
                return null;
            }
        }
     
        public static clsLicenseclass Findbylocalid(int LocalId)
        {
            int Classid = 0;
            string G_ClassName = "";
            string G_ClassDescription = "";
            byte G_MinimumAllowedAge = 0;
            byte G_DefaultValidityLength = 0;
            decimal G_ClassFees = 0;
            if (DriversDataacces.GetClassID(LocalId,ref Classid, ref G_ClassName, ref G_ClassDescription, ref G_MinimumAllowedAge, ref G_DefaultValidityLength, ref G_ClassFees))
            {
                clsLicenseclass newcalss = new clsLicenseclass(Classid, G_ClassName, G_ClassDescription, G_MinimumAllowedAge, G_DefaultValidityLength, G_ClassFees);
                return newcalss;
            }
            else
            {
                return null;
            }
        }
        public static int getvaildationyears(int classtypeId)
        {
            return DriversDataacces.getvailationyearslenghth(classtypeId);
        }
    }
}
