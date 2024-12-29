using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsApllicationTypes
    {
        public int ApplicaionID {  get; set; }
        public string Applicaiontitle {  get; set; }
        public decimal ApplicaionFees {  get; set; }
        public clsApllicationTypes()
        {
            ApplicaionID = -1;
            Applicaiontitle = "";
            ApplicaionFees = 0;
        }
        private clsApllicationTypes(int G_ApplicaionID, string G_Apptitle, decimal G_fees)
        {
            this.ApplicaionID=G_ApplicaionID;
            Applicaiontitle=G_Apptitle;
            ApplicaionFees=G_fees;
        }
        public static clsApllicationTypes Find(int G_ApplicaionID)
        { string G_Apptitle = "";
            decimal G_ApplicionFees = 0;
            if (ManageApplication.GetApplicationinfo(G_ApplicaionID, ref G_Apptitle, ref G_ApplicionFees))
            {
                clsApllicationTypes app= new clsApllicationTypes(G_ApplicaionID, G_Apptitle, G_ApplicionFees);
                return app;
            }
            else
                { return null; }
        }
        public bool Save()
        {
            return ManageApplication.UpdateApllicationTypes(ApplicaionID, Applicaiontitle, ApplicaionFees);
        }
        public static DataTable GettAllApplicationTypes()
        {
            return ManageApplication.GetAllApplicationTypes();
        }
    }
}
