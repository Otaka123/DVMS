using dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsUpdateApp
    {
       
        public string username {  get; set; }
        public string classname {  get; set; }
        public DateTime Date { get; set; }
        public clsUpdateApp()
        {
            username = "";
            classname = "";
            Date= DateTime.MinValue;
        }
        
        public clsUpdateApp(string G_username,string G_classname,DateTime Applicationdate)
        {
            username = G_username;
            classname = G_classname;
            Date = Applicationdate;
        }
        public static clsUpdateApp GetUpdate(int LocalapplcationID)
        {
            string G_username = "";
            string G_classname = "";
            DateTime Applicationdate= DateTime.MinValue;
            if (ApplicationDataAccess.GetUpdateData_User(LocalapplcationID,ref Applicationdate,ref G_username, ref G_classname))
            {
                clsUpdateApp app = new clsUpdateApp(G_username, G_classname, Applicationdate);
                return app;

            }
            else
            {
                return null;
            }
        }
       public static string Getclassname(int LocalId)
        {
            return ApplicationDataAccess.GetClassName(LocalId); 
        }
        public static int Getpassedtests(int LocalapplcationID)
        {
            int passedtest = 0;
            if ( ApplicationDataAccess.Getpassedtests(LocalapplcationID,ref passedtest))
            {
                return passedtest;
            }
            else
            {
                return 0;
            }
        }
    }
}
