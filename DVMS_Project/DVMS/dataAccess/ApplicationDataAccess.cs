using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static dataAccess.DetainedDataAccess;

namespace dataAccess
{
    public class ApplicationDataAccess
    {
        public static DataTable GetAllLocalLicense()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID ,LicenseClasses.ClassName as DrivingClass,
		                        People.NationalNo,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+people.LastName as FullName,
		                        Applications.ApplicationDate,(select count(TestAppointments.TestTypeID)as PassedTestsCount from Tests inner join TestAppointments on Tests.TestAppointmentID=TestAppointments.TestAppointmentID where TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID and Tests.TestResult = 1)
		                        as passedTestcount, case when Applications.ApplicationStatus = 1 THEN 'New' WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled' WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS Status from LocalDrivingLicenseApplications inner JOIN
                                dbo.Applications ON dbo.LocalDrivingLicenseApplications.ApplicationID = dbo.Applications.ApplicationID INNER JOIN
                                dbo.LicenseClasses ON dbo.LocalDrivingLicenseApplications.LicenseClassID = dbo.LicenseClasses.LicenseClassID INNER JOIN
                                dbo.People ON dbo.Applications.ApplicantPersonID = dbo.People.PersonID ;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
        public static bool GetUpdateData_User(int localapplicationId, ref DateTime G_Date, ref string G_Username, ref string G_classname)
        {
          
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" select LicenseClasses.ClassName,Applications.ApplicationDate,Users.UserName from LocalDrivingLicenseApplications
                              inner join Applications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                              inner join Users on Users.UserID = Applications.CreatedByUserID
                              inner join LicenseClasses on LicenseClasses.LicenseClassID =LocalDrivingLicenseApplications.LicenseClassID
                              where LocalDrivingLicenseApplicationID = @localID ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localID", SqlDbType.Int) { Value = localapplicationId });

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    found = true;
                    G_Date = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                    G_Username = reader[reader.GetOrdinal("UserName")] as string ?? "";
                    G_classname = reader[reader.GetOrdinal("ClassName")] as string ?? "";


                }



            }
            catch
            {
                //found = false;
            }
            finally
            {
                connection.Close();
            }


            return found;
        }

        public static int FindClassID(string classname)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select LicenseClassID from LicenseClasses where ClassName = @name;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar,50) { Value = classname });
      
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }
            catch
            {
                ApplicationID = -1;
            }
            finally
            {
                connection.Close();
            }


            return ApplicationID;

        }
        //public static byte FindClassIDbylocalid(int localid)
        //{
        //    byte ApplicationID =0;
        //    SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
        //    string query = @"select LicenseClasses.ClassName from LocalDrivingLicenseApplications
			     //           inner join LicenseClasses on LicenseClasses.LicenseClassID =LocalDrivingLicenseApplications.LicenseClassID
			     //           where LocalDrivingLicenseApplicationID = @local";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.Add(new SqlParameter("@local", SqlDbType.Int) { Value = localid });

        //    try
        //    {
        //        connection.Open();
        //        object result = command.ExecuteScalar();
        //        if (result != null )
        //        {
        //            ApplicationID= Convert.ToByte(result);
        //        }
        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }


        //    return ApplicationID;

        //}


        public static string GetClassName(int localID)
        {
            string classname = "";
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select LicenseClasses.ClassName from LocalDrivingLicenseApplications
                             inner join  LicenseClasses on LicenseClasses.LicenseClassID = LocalDrivingLicenseApplications.LicenseClassID
                             where LocalDrivingLicenseApplicationID =  @appid;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@appid", SqlDbType.Int) { Value = localID });

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result!= null)
                {
                    classname= result.ToString();
                }
            }
            catch
            {
                classname = "";
            }
            finally
            {
                connection.Close();
            }


            return classname;

        }
       
        public static bool Getpassedtests(int localapplicationId,ref int PassedTests)
        { 
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" select(select count(Tests.TestID) as passedtests from Tests 
                              inner join TestAppointments on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
                              where Tests.TestResult=1 and TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID)as PassedTests from Applications
                              inner join LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                              where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @localID ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localID", SqlDbType.Int) { Value = localapplicationId });

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PassedTests = insertedID;
                    found = true;

                }

            }
            catch
            {
                //found = false;
            }
            finally
            {
                connection.Close();
            }


            return found;
        }
        public static int GetApplicationID(int localdrivinglicenseApplication)
        {
            int applicationID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @localID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localID", SqlDbType.Int) { Value = localdrivinglicenseApplication });

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    applicationID = insertedID;
                }
               
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return applicationID;
        }
        public static bool changestatApplication(int G_applicationId,int G_state)
        {
            bool iscancel = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"UPDATE Applications
                             SET Applications.ApplicationStatus = @stat,
                             LastStatusDate =GETDATE()
                             WHERE Applications.ApplicationID = @Appid;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@Appid", SqlDbType.Int) { Value = G_applicationId });
            command.Parameters.Add(new SqlParameter("@stat", SqlDbType.Int) { Value = G_state });


            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                iscancel = (result > 0);
            }
            catch
            {
                iscancel = false;
            }
            finally
            {
                connection.Close();
            }


            return iscancel;
        }
        public static bool Delete(int G_applicationId)
        {
             bool iscancel=false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"delete Applications 
                             where ApplicationID = @Appid;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@Appid", SqlDbType.Int) { Value = G_applicationId });
      
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                iscancel=(result>0);
            }
            catch
            {
                iscancel = false;
            }
            finally
            {
                connection.Close();
            }


            return iscancel;
        }
        public static int AddNewApplication(int G_ApplicantPersonID, DateTime G_ApplicationDate, int G_ApplicationTypeID, short G_ApplicationStatus, DateTime G_LastStatusDate, double G_PaidFees, int G_CreatedByUserID)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                int APPID = -1;
                string query = @"INSERT INTO Applications ( ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees ,CreatedByUserID)
                             VALUES ( @persoId, @Date , @type , @stats , @laststatsdate , @fees , @createdby ) SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand("query", connection))
                {
                    command.Parameters.Add(new SqlParameter("@persoId", SqlDbType.Int) { Value = G_ApplicantPersonID });
                    command.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = G_ApplicationDate });
                    command.Parameters.Add(new SqlParameter("@type", SqlDbType.Int) { Value = G_ApplicationTypeID });
                    command.Parameters.Add(new SqlParameter("@stats", SqlDbType.TinyInt) { Value = G_ApplicationStatus });
                    command.Parameters.Add(new SqlParameter("@laststatsdate", SqlDbType.DateTime) { Value = G_LastStatusDate });
                    command.Parameters.Add(new SqlParameter("@fees", SqlDbType.SmallMoney) { Value = G_PaidFees });
                    command.Parameters.Add(new SqlParameter("@createdby", SqlDbType.Int) { Value = G_CreatedByUserID });
              
                    connection.Open();
                  object resulte=  command.ExecuteScalar();
                    if (resulte != null&&int.TryParse(resulte.ToString(),out int appid))
                    {
                        APPID=appid;
                    }
                    return APPID;
                }
            }
        }
      
        public static int AddNewLocalDrivingApplication(int G_ApplicantPersonID, DateTime G_ApplicationDate, int G_ApplicationTypeID, short G_ApplicationStatus, DateTime G_LastStatusDate, decimal G_PaidFees, int G_CreatedByUserID ,int G_classntypeid)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"INSERT INTO Applications ( ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees ,CreatedByUserID)
                             VALUES ( @persoId, @Date , @type , @stats , @laststatsdate , @fees , @createdby ); 
                             DECLARE @ApplicationId INT;
                             SET @ApplicationId = SCOPE_IDENTITY();
                             INSERT INTO LocalDrivingLicenseApplications ( ApplicationID,LicenseClassID)
                             VALUES (@ApplicationId , @classid ); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@persoId", SqlDbType.Int) { Value = G_ApplicantPersonID });
            command.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = G_ApplicationDate });
            command.Parameters.Add(new SqlParameter("@type", SqlDbType.Int) { Value = G_ApplicationTypeID });
            command.Parameters.Add(new SqlParameter("@stats", SqlDbType.TinyInt) { Value = G_ApplicationStatus });
            command.Parameters.Add(new SqlParameter("@laststatsdate", SqlDbType.DateTime) { Value = G_LastStatusDate });
            command.Parameters.Add(new SqlParameter("@fees", SqlDbType.SmallMoney) { Value = G_PaidFees });
            command.Parameters.Add(new SqlParameter("@createdby", SqlDbType.Int) { Value = G_CreatedByUserID });
            command.Parameters.Add(new SqlParameter("@classid", SqlDbType.Int) { Value = G_classntypeid });


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }
            catch
            {
                ApplicationID = -1;
            }
            finally
            {
                connection.Close();
            }


            return ApplicationID;

        }
        public static bool UpdateLocalApplication(int G_LocalapplicationId ,int classID)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"UPDATE LocalDrivingLicenseApplications
                             set LicenseClassID = @classid
                             WHERE LocalDrivingLicenseApplicationID = @Appid;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@classid", SqlDbType.Int) { Value = classID });
            command.Parameters.Add(new SqlParameter("@Appid", SqlDbType.Int) { Value = G_LocalapplicationId });


            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                isUpdated = (result > 0);
            }
            catch
            {
                isUpdated = false;
            }
            finally
            {
                connection.Close();
            }


            return isUpdated;
        }
        public static int AddNewApplication(int G_ApplicantPersonID, DateTime G_ApplicationDate, int G_ApplicationTypeID, short G_ApplicationStatus, DateTime G_LastStatusDate, decimal G_PaidFees, int G_CreatedByUserID)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                int ApplicationID = -1;
                string query = @"INSERT INTO Applications ( ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate,PaidFees ,CreatedByUserID)
                             VALUES ( @persoId, @Date , @type , @stats , @laststatsdate , @fees , @createdby )
                          SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@persoId", SqlDbType.Int) { Value = G_ApplicantPersonID });
                    command.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime) { Value = G_ApplicationDate });
                    command.Parameters.Add(new SqlParameter("@type", SqlDbType.Int) { Value = G_ApplicationTypeID });
                    command.Parameters.Add(new SqlParameter("@stats", SqlDbType.TinyInt) { Value = G_ApplicationStatus });
                    command.Parameters.Add(new SqlParameter("@laststatsdate", SqlDbType.DateTime) { Value = G_LastStatusDate });
                    command.Parameters.Add(new SqlParameter("@fees", SqlDbType.SmallMoney) { Value = G_PaidFees });
                    command.Parameters.Add(new SqlParameter("@createdby", SqlDbType.Int) { Value = G_CreatedByUserID });


                    connection.Open();
                    object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ApplicationID = insertedID;
                        }
                


                    return ApplicationID;
                }
                    
            }
               

        }
        public static bool HaveOpenApp(int personid, int apptypeID)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"SELECT ApplicationID FROM Applications 
                         WHERE ApplicantPersonID = @persoId 
                         AND ApplicationTypeID = @apptyeid 
                         AND Applications.ApplicationStatus = 1;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@persoId", SqlDbType.Int) { Value = personid });
                    command.Parameters.Add(new SqlParameter("@apptyeid", SqlDbType.Int) { Value = apptypeID });

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null;
                }
            }
        }
        public static bool IsExit(int personid,int classtype)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select *  from LocalDrivingLicenseApplications inner join Applications on  Applications.ApplicationID=LocalDrivingLicenseApplications.ApplicationID 
                            where Applications.ApplicantPersonID = @persoId  and LocalDrivingLicenseApplications.LicenseClassID = @class and Applications.ApplicationStatus in (1, 3)  ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@persoId", SqlDbType.Int) { Value = personid });
            command.Parameters.Add(new SqlParameter("@class", SqlDbType.Int) { Value = classtype });

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    found = true;
                }

            }
            catch
            {
                found = false;
            }
            finally
            {
                connection.Close();
            }


            return found;

        }
        public static bool GetApplicationCard(int Appid,ref string G_personNo,ref string G_Applicant,
            ref string G_ApplicationType,ref DateTime G_ApplicationDate,ref DateTime G_LastStatusDate,
           ref string G_status,ref decimal G_AppFees,ref decimal G_PaidFees, ref string G_CreatedByUserName)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select People.NationalNo,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+people.LastName as FullName,
                            ApplicationTypes.ApplicationTypeTitle,Applications.ApplicationDate,Applications.LastStatusDate,
                            case when Applications.ApplicationStatus = 1 THEN 'New' WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled' WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS Status,
                            Applications.PaidFees ,ApplicationTypes.ApplicationFees,Users.UserName from Applications
                            inner join People On People.PersonID=Applications.ApplicantPersonID
                            inner join ApplicationTypes on ApplicationTypes.ApplicationTypeID = Applications.ApplicationTypeID
                            inner join Users on Users.UserID = Applications.CreatedByUserID
                            where Applications.ApplicationID = @Appid";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@Appid", SqlDbType.Int) { Value = Appid });
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    found = true;
                    G_personNo = reader.GetString(reader.GetOrdinal("NationalNo"));
                    G_Applicant = reader.GetString(reader.GetOrdinal("FullName"));
                    G_ApplicationType = reader.GetString(reader.GetOrdinal("ApplicationTypeTitle"));
                    G_ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                    G_LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate"));
                    G_status = reader.GetString(reader.GetOrdinal("Status"));
                    G_PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                    G_AppFees = reader.GetDecimal(reader.GetOrdinal("ApplicationFees"));
                    //G_CreatedByUserName = reader.GetString(reader.GetOrdinal("UserName"));
                    //if (!reader.IsDBNull(reader.GetOrdinal("ApplicationFees")))
                    //    G_AppFees =Convert.ToDouble(reader.GetOrdinal("ApplicationFees"));
                    //else
                    //    G_AppFees = 0.0; // أو أي قيمة افتراضية مناسبة

                    //if (!reader.IsDBNull(reader.GetOrdinal("PaidFees")))
                    //    G_PaidFees = reader.GetDouble(reader.GetOrdinal("PaidFees"));
                    //else
                    //    G_PaidFees = 0.0; // أو أي قيمة افتراضية مناسبة

                    //if (!reader.IsDBNull(reader.GetOrdinal("UserName")))
                    //    G_CreatedByUserName = reader.GetString(reader.GetOrdinal("UserName"));
                    //else
                    //    G_CreatedByUserName = ""; // أو قيمة نصية افتراضية

                    //G_AppFees = reader["ApplicationFees"] != DBNull.Value ? Convert.ToDouble(reader["ApplicationFees"]) : 0.0;
                    //G_PaidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToDouble(reader["PaidFees"]) : 0.0;
                    G_CreatedByUserName = reader["UserName"] as string ?? "";


                }
                reader.Close();

            }
            catch
            {
                //found = false;
            }
            finally
            {
                connection.Close();
            }


            return found;

        }
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"select ClassName from LicenseClasses ;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
       
    }
}
