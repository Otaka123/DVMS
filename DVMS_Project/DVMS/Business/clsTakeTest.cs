using dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsTakeTest
    {
       

            public int TestID { get; set; }
            public int TestAppointmentID { get; set; }
            public bool TestResult { get; set; }
            public string Notes { get; set; }
            public int CreatedByUserID { get; set; }



        public clsTakeTest()
        {
            TestID = 0;
            TestAppointmentID = 0;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = 0;
        }
        private clsTakeTest(int G_TestID, int G_TestAppointmentID, bool G_TestResult, string G_Notes, int G_CreatedByUserID)
        {
            TestID = G_TestID;
            TestAppointmentID = G_TestAppointmentID;
            TestResult = G_TestResult;
            Notes = G_Notes;
            CreatedByUserID = G_CreatedByUserID;
        }

        //public static bool Updatastat(int G_localid)
        //{
        //    return 
        //}
        public bool _AddNewTaketest(int G_localid)
        {
            
            this.TestID=testAppointmentDataAccess.AddNewTaketest(this.TestAppointmentID,this.TestResult,this.Notes,this.CreatedByUserID);
            if (this.TestID > 0)
            {
                testAppointmentDataAccess.UpdateApponitmentState(G_localid);
            }
            return (this.TestID > 0);
        }
       
    }
}
