using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static dataAccess.DetainedDataAccess;

namespace Business
{
    public class clsdetain
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public ADDDTO addDTO { get { return new ADDDTO(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID); } }
        public UPDATEDTO updateDTO {  get { return new UPDATEDTO( this.LicenseID,this.ReleaseDate,
                                        this.ReleasedByUserID,
                                        this.ReleaseApplicationID); } }
    

    
        //public clsdetain(DetainedDataAccess DTO, enMode cMode=enMode.AddNew)
        //{
        //    this.DetainID = DTO.DetainID;
        //    this.LicenseID = DTO.LicenseID;
        //    this.DetainDate = DTO.DetainDate;
        //    this.FineFees = DTO.FineFees;
        //    this.CreatedByUserID = DTO.CreatedByUserID;
        //    this.IsReleased = DTO.IsReleased;
        //    this.ReleaseDate = DTO.ReleaseDate;
        //    this.ReleasedByUserID = DTO.ReleasedByUserID;
        //    this.ReleaseApplicationID = DTO.ReleaseApplicationID;
        //    this.Mode=cMode;

        //}
        private bool _AddNew()
        {
            this.DetainID = DetainedDataAccess.Detain(addDTO);
                return (this.DetainID != 1);
        }
        public bool Update()
        {
            return (DetainedDataAccess.ReleaseDetain(updateDTO) != 0);
        }
        public static DataTable GetallDetain()
        {
            return DetainedDataAccess.GetAllDetain();
        }
        public static int GetPersonID(int DetainId)
        {
            return DetainedDataAccess.GetPersonID(DetainId);
        }
        public static decimal Getfees(int LicenseID)
        {
            return DetainedDataAccess.GetDetainFees(LicenseID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return Update();

            }

            return false;
        }
    }

}
