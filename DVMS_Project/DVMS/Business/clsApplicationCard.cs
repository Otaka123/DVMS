using dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsApplicationCard
    {
        public int ApplicationID { get; set; }
        public string personNo {  get; set; }
        public string Applicant { get; set; }
        public string ApplicationType { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastStatusDate { get; set; }

        public string status {  get; set; }
        public decimal AppFees {  get; set; }
        public decimal PaidFees { get; set; }
        public string CreatedByUserName { get; set; }
        public enum enmode { AddNew = 0, Update = 1 }
        public enmode _Mode;
        public clsApplicationCard()
        {
            ApplicationID = 0;
            personNo = "";
            Applicant = "";
            ApplicationType = "";
            ApplicationDate = DateTime.MinValue;
            LastStatusDate = DateTime.MinValue;
            status = "";
            AppFees = -1;
            PaidFees = -1;
            CreatedByUserName = "";
            _Mode = enmode.AddNew;


        }
        private clsApplicationCard(int G_ApplicationID, string G_personNo ,string G_Applicant,
            string G_ApplicationType,DateTime G_ApplicationDate,DateTime G_LastStatusDate,
            string G_status, decimal G_AppFees, decimal G_PaidFees ,string G_CreatedByUserName)
                                        
        {
            ApplicationID = G_ApplicationID;
            personNo = G_personNo;
            Applicant = G_Applicant;
            ApplicationType = G_ApplicationType;
            ApplicationDate = G_ApplicationDate;
            LastStatusDate = G_LastStatusDate;
            status = G_status;
            AppFees = G_AppFees;
            PaidFees = G_PaidFees;
            CreatedByUserName = G_CreatedByUserName;
            _Mode = enmode.Update;



        }
        public static clsApplicationCard Find(int G_ApplicationID)
        {
            string G_personNo = "";
            string G_Applicant = "";
            string  G_ApplicationType = "";
            DateTime G_ApplicationDate =DateTime.Now;
            DateTime G_LastStatusDate = DateTime.Now;
            string G_status = "";
            decimal G_AppFeess = 0;
            decimal G_PaidFeess = 0;
            string G_CreatedByUserName = "";
            if (ApplicationDataAccess.GetApplicationCard(G_ApplicationID,ref G_personNo, ref G_Applicant, ref G_ApplicationType, ref G_ApplicationDate,
                                                        ref G_LastStatusDate, ref G_status, ref G_AppFeess, ref G_PaidFeess, ref G_CreatedByUserName))
            {
                clsApplicationCard ApplicationCard = new clsApplicationCard(G_ApplicationID, G_personNo, G_Applicant, G_ApplicationType, G_ApplicationDate,
                                                                                G_LastStatusDate, G_status, G_AppFeess, G_PaidFeess, G_CreatedByUserName);
                return ApplicationCard;
            }
            else
                return null;
        }
        public static int GerApplicationID(int LocalApplicationlicenseID)
        {
            return ApplicationDataAccess.GetApplicationID(LocalApplicationlicenseID);
        }
    }
}
