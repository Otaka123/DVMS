using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsApplications
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }
        public short ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int ClassTypeid { get; set; }
        public enum enmode { AddNew = 0, Update = 1 }
        public enmode _Mode;
        public clsApplications()
        {
            ApplicationID = 0;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeID = -1;
            ApplicationStatus = -1;
            LastStatusDate = DateTime.MinValue;
            PaidFees = -1;
            CreatedByUserID = -1;
            ClassTypeid = -1;
            _Mode = enmode.AddNew;


        }
        private clsApplications(int G_ApplicationID, int G_ApplicantPersonID, DateTime G_ApplicationDate, int G_ApplicationTypeID, short G_ApplicationStatus, DateTime G_LastStatusDate, decimal G_PaidFees, int G_CreatedByUserID , int G_classtype)
        {
            ApplicationID = G_ApplicationID;
            ApplicantPersonID = G_ApplicantPersonID;
            ApplicationDate = G_ApplicationDate;
            ApplicationTypeID = G_ApplicationTypeID;
            ApplicationStatus = G_ApplicationStatus;
            LastStatusDate = G_LastStatusDate;
            PaidFees = G_PaidFees;
            CreatedByUserID = G_CreatedByUserID;
            ClassTypeid = G_classtype;
            _Mode = enmode.Update;



        }
        //public static string getClassId(int localid)
        //{
        //   return ApplicationDataAccess.FindClassIDbylocalid(localid);
        //}
        public static bool UpdateClass(int localappId,int classID)
        {
            return ApplicationDataAccess.UpdateLocalApplication(localappId, classID);
        }
        public static bool updatestatApplication(int G_ApplicationID,int G_stat)
        {
            return ApplicationDataAccess.changestatApplication(G_ApplicationID, G_stat);
        }
        public static bool IsExist(int personId ,int classId)
        {
            return ApplicationDataAccess.IsExit(personId, classId);
        }
        public static bool haveopenapp(int personId, int applictiontypeID)
        {
            return ApplicationDataAccess.HaveOpenApp(personId, applictiontypeID);
        }
        public static int GetClassId(string classname)
        {
            return ApplicationDataAccess.FindClassID(classname);
        }
        public static bool delete (int ApplicationID)
        {
            return ApplicationDataAccess.Delete(ApplicationID);
        }
        private bool _AddNew()
        {
            this.ApplicationID = ApplicationDataAccess.AddNewLocalDrivingApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID, this.ClassTypeid);
            return (this.ApplicationID > 0);
        }
        public static DataTable GetLicenseClasses()
        {
            return ApplicationDataAccess.GetAllLicenseClasses();
        }
        public static DataTable GetlocalApplication()
        {
            return ApplicationDataAccess.GetAllLocalLicense();
        }
        public int AppSave()
        {
            return ApplicationDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        public bool AddNewApp()
        {
            this.ApplicationID = ApplicationDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus,
                                                                        this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID > 0);
        }
        public bool Save()
        {
            
                    if (_AddNew())
                    {
                        _Mode = enmode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    //case enMode.Update:
                    //    return _UpdateUser();


        }

    }
}
