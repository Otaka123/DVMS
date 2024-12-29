using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsTestAppointment
    {
       
        public int AppointmentId {  get; set; }
        public int TestTypeID {  get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }   
        public DateTime AppointmentDate {  get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID {  get; set; }
        public bool IsLocked { get; set; }
        public enum enMode { AddNew=0, Update=1 }
        public enMode Mode = enMode.AddNew;
        public clsTestAppointment()
        {
            AppointmentId = -1;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
        }
        private clsTestAppointment(int G_AppointmentId,int G_TestTypeID,int G_LocalDrivingLicenseApplicationID,DateTime G_AppointmentDate, decimal G_PaidFees,int G_CreatedByUserID,bool G_IsLocked)
        {
            AppointmentId = G_AppointmentId;
            TestTypeID = G_TestTypeID;
            LocalDrivingLicenseApplicationID = G_LocalDrivingLicenseApplicationID;
            AppointmentDate = G_AppointmentDate;
            PaidFees = G_PaidFees;
            CreatedByUserID = G_CreatedByUserID;
            IsLocked = G_IsLocked;
            Mode = enMode.Update;
        }
       
        private bool _AddNewUser()
        {
            this.AppointmentId= testAppointmentDataAccess.AddNewTestAppointment(this.TestTypeID,this.LocalDrivingLicenseApplicationID,this.AppointmentDate,this.PaidFees,this.CreatedByUserID,this.IsLocked);
            return (this.AppointmentId>0);
        }
        public static int GetTrialNum(int G_localid, int G_testTypeID)
        {
            return testAppointmentDataAccess.GetTrialNum(G_localid, G_testTypeID);
        }
        public static bool IsSucced(int G_localid, int G_testTypeID)
        {
            return testAppointmentDataAccess.IsSucces(G_localid, G_testTypeID);
        }
        public static bool HaveAntherAppointment(int G_localid, int G_testTypeID)
        {
            return testAppointmentDataAccess.IsExist(G_localid, G_testTypeID);
        }
        public static bool editDate(int G_localId,DateTime G_newdate)
        {
            return testAppointmentDataAccess.UpdateApponitmentDate(G_localId, G_newdate);
        }
        public static DataTable GetAlltestAppointments(int G_localid, int G_testTypeID)
        {
            return testAppointmentDataAccess.GetAppointment(G_localid, G_testTypeID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                //case enMode.Update:
                //    //return _UpdateUser();


            }
            return false;
        }
    }
}
