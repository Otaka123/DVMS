using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsTestType
    {
        public int ApplicaionID { get; set; }
        public string Applicaiontitle { get; set; }
        public decimal ApplicaionFees { get; set; }
        public string testDescription {  get; set; }
        public clsTestType()
        {
            ApplicaionID = -1;
            Applicaiontitle = "";
            ApplicaionFees = 0;
            testDescription = "";
        }
        private clsTestType(int G_ApplicaionID, string G_Apptitle,string G_Appdescription, decimal G_fees)
        {
            this.ApplicaionID = G_ApplicaionID;
            Applicaiontitle = G_Apptitle;
            ApplicaionFees = G_fees;
            testDescription=G_Appdescription;
        }
        public static clsTestType Find(int G_testtypeId)
        {
            string Apptitle = "";
            string Appdescription = "";

            decimal ApplicionFees = 0;
            if (clsManageTestTypesdataAccess.GetApplicationinfo(G_testtypeId, ref Apptitle,ref Appdescription, ref ApplicionFees))
            {
                clsTestType test = new clsTestType(G_testtypeId, Apptitle, Appdescription, ApplicionFees);
                return test;
            }
            else
            { return null; }
        }
        public bool Save()
        {
            return clsManageTestTypesdataAccess.UpdateApllicationTypes(ApplicaionID, Applicaiontitle,testDescription ,ApplicaionFees);
        }
        public static DataTable GettAllTestTypes()
        {
            return clsManageTestTypesdataAccess.GetAllApplicationTypes();
        }
    }
}
