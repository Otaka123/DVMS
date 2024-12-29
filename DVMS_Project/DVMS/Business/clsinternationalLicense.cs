using dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsinternationalLicense
    {
        public int internationalLicenseID {  get; set; }
        public int PersoID {  get; set; }
        public int createdbyuserID {  get; set; }
        public int DriverID {  get; set; }
        public int LocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal fees { get; set; }
        public bool IsActive {  get; set; }
        public int ApplicationId {  get; set; }

        public clsinternationalLicense()
        {
            this.ApplicationId = 0;
            this.internationalLicenseID = 0;
            this.PersoID = 0;
            this.createdbyuserID=0; 
            this.DriverID= 0;
            this.LocalLicenseID=0;
            this.IssueDate=DateTime.Now;
            this.ExpireDate= DateTime.Now;
            this.fees = 0;
            this.IsActive=true;
        }
        private clsinternationalLicense(int G_internationalid,int G_PersoID, int G_createdbyuserID, int G_DriverID, int G_LocalLicenseID,
            DateTime G_IssueDate, DateTime G_ExpireDate, decimal G_fees, bool G_IsActive ,int G_AppID)
        {
            this.ApplicationId = G_AppID;
            this.internationalLicenseID = G_internationalid;
            this.PersoID = G_PersoID;
            this.createdbyuserID = G_createdbyuserID;
            this.DriverID = G_DriverID;
            this.LocalLicenseID = G_LocalLicenseID;
            this.IssueDate = G_IssueDate;
            this.ExpireDate = G_ExpireDate;
            this.fees = G_fees;
            this.IsActive = G_IsActive;
        }
        public bool AddNew()
        {
            this.internationalLicenseID = InternationalLicenseDataAccess.ADDNewLinternationalicense(this.PersoID, this.createdbyuserID, this.DriverID,
                                                                                                    this.LocalLicenseID, this.IssueDate, this.ExpireDate, this.fees,
                                                                                                    this.IsActive);
            if (this.internationalLicenseID > 0)
            {
                this.ApplicationId = InternationalLicenseDataAccess.GetApplicationID(this.internationalLicenseID);
                clsApplications.updatestatApplication(ApplicationId, 3);
            }
            return (this.internationalLicenseID > 0);
        }
        //    public  int AddNew(int G_PersoID, int G_createdbyuserID, int G_DriverID, int G_LocalLicenseID,
        //DateTime G_IssueDate, DateTime G_ExpireDate, decimal G_fees, bool G_IsActive)
        //    {
        //        this.internationalLicenseID = InternationalLicenseDataAccess.ADDNewLinternationalicense(G_PersoID, G_createdbyuserID, G_DriverID, G_LocalLicenseID, G_IssueDate, G_ExpireDate, G_fees, G_IsActive);
        //        if(internationalLicenseID!=)
        //        {
        //            this.ApplicationId = clsApplicationCard.GerApplicationID(this.LocalLicenseID);
        //            clsApplications.updatestatApplication(ApplicationId, 3);
        //        }
        //    }
        public static bool IsLocalLicenseActive(int LocalLicenseID)
        {
            return InternationalLicenseDataAccess.IsActive(LocalLicenseID);
        }
        public static int HaveAntherLicense(int LocalLicenseID)
        {
            return InternationalLicenseDataAccess.HaveAnotherLicense(LocalLicenseID);
        }

    }
}
