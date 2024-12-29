using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business
{
    public class clsLicense
    {

        public int LicensesID { get; set; }
        public int personiD {  get; set; }
        public int DriverID {  get; set; }
        public int ApplictionID {  get; set; }
        public int LicenseClass {  get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public string Notes {  get; set; }
        public decimal PaidFees {  get; set; }
        public bool IsActive {  get; set; }
        public byte IssueReason {  get; set; }
        public int CreatedByUserID {  get; set; }
       


        public clsLicense()
        {
            LicensesID = 0;
            personiD = -1;
            ApplictionID = -1;
            LicenseClass = -1;
            IssueDate= DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            Notes=string.Empty;
            PaidFees = 0;
            IsActive=true;
            IssueReason = 0;
            CreatedByUserID = 0;
            DriverID = 0;


        }
        private clsLicense(int G_LIcenseID,int G_personiD, int G_ApplictionID, int G_LicenseClass, DateTime G_IssueDate,
            DateTime G_ExpirationDate, string G_Notes, decimal G_PaidFees, bool G_IsActive, byte G_IssueReason, int G_CreatedByUserID ,int G_DriverId)
        {
            LicensesID = G_LIcenseID;
            personiD = G_personiD;
            ApplictionID = G_ApplictionID;
            LicenseClass = G_LicenseClass;
            IssueDate = G_IssueDate;
            ExpirationDate = G_ExpirationDate;
            Notes = G_Notes;
            PaidFees = G_PaidFees;
            IsActive = G_IsActive;
            IssueReason = G_IssueReason;
            CreatedByUserID = G_CreatedByUserID;
            DriverID = G_DriverId;
        }
        public static DataTable GetAllLicense()
        {
            return DriversDataacces.GetAlllicense();
        }
        public static int GetDriverID(int G_personId)
        {
            return DriversDataacces.FindDriverId(G_personId);
        }
        public static clsLicense FindbyApplicationID(int G_ApplictionID)
        {
            int G_personiD = -1;
            int G_LicensesID = -1;
            int G_LicenseClass = -1;
            DateTime G_IssueDate = DateTime.MinValue;
            DateTime G_ExpirationDate = DateTime.MinValue;
            string G_Notes = string.Empty;
            decimal G_PaidFees = 0;
            bool G_IsActive = false;
            byte G_IssueReason = 0;
            int G_CreatedByUserID = 0;
            int G_DriverID = 0;
            if (DriversDataacces.FindLicensebyApplictionID(G_ApplictionID, ref G_LicensesID, ref G_DriverID, ref G_LicenseClass, ref G_IssueDate, ref G_ExpirationDate,
                ref G_Notes, ref G_PaidFees, ref G_IsActive, ref G_IssueReason, ref G_CreatedByUserID, ref G_personiD))
            {
                clsLicense newLicense = new clsLicense(G_LicensesID, G_personiD, G_ApplictionID, G_LicenseClass, G_IssueDate, G_ExpirationDate, G_Notes, G_PaidFees, G_IsActive, G_IssueReason, G_CreatedByUserID, G_DriverID);
                return newLicense;
            }
            else
            {
                return null;

            }
        }
        public static clsLicense Find (int G_LicensesID)
        {
           int G_personiD = -1;
           int G_ApplictionID = -1;
           int G_LicenseClass = -1;
           DateTime G_IssueDate = DateTime.MinValue;
           DateTime G_ExpirationDate = DateTime.MinValue;
           string G_Notes = string.Empty;
           decimal G_PaidFees = 0;
           bool G_IsActive = false;
           byte G_IssueReason = 0;
           int G_CreatedByUserID = 0;
            int G_DriverID = 0;
            if (DriversDataacces.FindLicense(G_LicensesID, ref G_ApplictionID, ref G_DriverID, ref G_LicenseClass, 
                ref G_IssueDate, ref G_ExpirationDate, ref G_Notes, ref G_PaidFees, ref G_IsActive, ref G_IssueReason, ref G_CreatedByUserID, ref G_personiD))
            {
                clsLicense newLicense = new clsLicense(G_LicensesID,G_personiD, G_ApplictionID, G_LicenseClass, G_IssueDate, G_ExpirationDate, G_Notes, G_PaidFees, G_IsActive, G_IssueReason, G_CreatedByUserID, G_DriverID);
                return newLicense;
            }
            else
            {
                return null;

            }
        }
        public static bool IsDetain(int LicenseID)
        {
            return DriversDataacces.IsDetian(LicenseID);
        }
        public static DataTable GetAllDrivers()
        {
            return DriversDataacces.GetAllDrivers();    
        }
        public static DataTable GetLocallicnse(int DriverID)
        {
            return DriversDataacces.GetLocalLicense(DriverID);
        }
        public static DataTable GetinternationalLicense(int DriverID)
        {
            return DriversDataacces.GetInternationalLicense(DriverID);
        }
        public static DataTable GetAllinternationalLicense()
        {
            return DriversDataacces.GetAllInternationalLicense();
        }
        public bool _AddNewLicense()
        {
            
            this.LicensesID= DriversDataacces.AddNewLicense(this.personiD,this.ApplictionID,this.LicenseClass,this.IssueDate,this.ExpirationDate,this.Notes,this.PaidFees,this.IsActive,this.IssueReason,this.CreatedByUserID);
            if(this.LicensesID > 0 )
            {
                this.DriverID= DriversDataacces.FindDriverId(this.personiD);
                clsApplications.updatestatApplication(ApplictionID, 3);
            }
            return (this.LicensesID > 0);
        }
        public bool renewlicense()
        {
            return DriversDataacces.ReNeWLicense(this.LicensesID, this.IssueDate, this.ExpirationDate);
        }
        public bool deActivetlicense(int licensesID)
        {
            return DriversDataacces.deActivetlicense(licensesID);
        }
        public bool Replace(byte issuereson)
        {
            if(deActivetlicense(this.LicensesID))
            {
                this.IssueReason = issuereson;
                return _AddNewLicense();

            }
            else
            {
                return false;
            }
        }

    }
}
