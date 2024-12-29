using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace dataAccess
{
    public class testAppointmentDataAccess
    {
        public static int AddNewTestAppointment( int G_TestTypeID, int G_LocalDrivingLicenseApplicationID, DateTime G_AppointmentDate, decimal G_PaidFees, int G_CreatedByUserID, bool G_IsLocked)
        {
            int G_AppointmentId = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"insert into TestAppointments
                             values
                             (@Testtypeid,@LocalLicenseApplicationID,@AppointDate,@paidfees,@creatby,@islocked) SELECT SCOPE_IDENTITY(); ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@Testtypeid", SqlDbType.Int) { Value = G_TestTypeID });
            command.Parameters.Add(new SqlParameter("@LocalLicenseApplicationID", SqlDbType.Int) { Value = G_LocalDrivingLicenseApplicationID });
            command.Parameters.Add(new SqlParameter("@AppointDate", SqlDbType.SmallDateTime) { Value = G_AppointmentDate });
            command.Parameters.Add(new SqlParameter("@paidfees", SqlDbType.SmallMoney) { Value = G_PaidFees });
            command.Parameters.Add(new SqlParameter("@creatby", SqlDbType.Int) { Value = G_CreatedByUserID });
            command.Parameters.Add(new SqlParameter("@islocked", SqlDbType.Bit) { Value = G_IsLocked });




            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    G_AppointmentId = insertedID;
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return G_AppointmentId;
        }
        public static int AddNewTaketest(int G_testapointmentid, bool G_testresult, string G_Note, int G_CreatedByUserID)
        {
            int G_AppointmentId = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"insert into Tests
                             values
                             (@testAppointmentid,@testresult,@note,@creatby) SELECT SCOPE_IDENTITY(); ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@testAppointmentid", SqlDbType.Int) { Value = G_testapointmentid });
            command.Parameters.Add(new SqlParameter("@testresult", SqlDbType.Bit) { Value = G_testresult });
            command.Parameters.AddWithValue("@note", string.IsNullOrEmpty(G_Note) ? (object)DBNull.Value : G_Note);
            command.Parameters.Add(new SqlParameter("@creatby", SqlDbType.Int) { Value = G_CreatedByUserID });

       




            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    G_AppointmentId = insertedID;
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return G_AppointmentId;
        }
        public static int GetTrialNum(int G_localID, int G_testtypeId)
        {
            int trial = 0;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select count(LocalDrivingLicenseApplicationID) as trial from TestAppointments
                            where TestTypeID = @testtypenum and LocalDrivingLicenseApplicationID = @localid ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@testtypenum", SqlDbType.Int) { Value = G_testtypeId });
            command.Parameters.Add(new SqlParameter("@localid", SqlDbType.Int) { Value = G_localID });


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null&&int.TryParse(result.ToString(), out int num))
                {
                    trial=num;
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return trial;

        }
        public static bool UpdateApponitmentState(int G_localID)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"Update TestAppointments 
                             set IsLocked = 1 
                             where LocalDrivingLicenseApplicationID = @localid ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localid", SqlDbType.Int) { Value = G_localID });

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                isUpdated = (result > 0);
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return isUpdated;
        }
        public static bool UpdateApponitmentDate(int G_localID,DateTime G_newdate)
        {
            bool isUpdated=false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"Update TestAppointmentID 
                              set AppointmentDate = @newdate 
                               where LocalDrivingLicenseApplicationID = @localid ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localid", SqlDbType.Int) { Value = G_localID });
            command.Parameters.Add(new SqlParameter("@newdate", SqlDbType.SmallDateTime) { Value = G_newdate });


            try
            {
                connection.Open();
               int result = command.ExecuteNonQuery();
                isUpdated=(result>=0);
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return isUpdated;
        }
        public static bool IsExist(int G_localID, int G_testtypeId)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select TestAppointments.TestAppointmentID from TestAppointments inner join Tests on Tests.TestAppointmentID =TestAppointments.TestAppointmentID
							   where LocalDrivingLicenseApplicationID= @localid and TestTypeID= @testtypenum and (IsLocked = 0 or Tests.TestResult=1) ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localid", SqlDbType.Int) { Value = G_localID });
            command.Parameters.Add(new SqlParameter("@testtypenum", SqlDbType.Int) { Value = G_testtypeId });


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                isUpdated = (result != null);
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return isUpdated;
        }
        public static bool IsSucces(int G_localID, int G_testtypeId)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select count(LocalDrivingLicenseApplicationID) as trial from TestAppointments
                            inner join Tests on Tests.TestAppointmentID=TestAppointments.TestAppointmentID
                            where LocalDrivingLicenseApplicationID = @localid and TestTypeID = @testtypenum and Tests.TestResult =1 ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localid", SqlDbType.Int) { Value = G_localID });
            command.Parameters.Add(new SqlParameter("@testtypenum", SqlDbType.Int) { Value = G_testtypeId });


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int num) )
                {
                    if (num == 3)
                    {
                        isUpdated = true;
                    }

                }
                
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return isUpdated;
        }
        public static DataTable GetAppointment(int G_localId,int G_testtypeId)
        {
            
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments where LocalDrivingLicenseApplicationID= @localid and TestTypeID = @testtypenum ; ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    command.Parameters.Add(new SqlParameter("@localid", SqlDbType.Int) { Value = G_localId });
                    command.Parameters.Add(new SqlParameter("@testtypenum", SqlDbType.Int) { Value = G_testtypeId });
                    using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                }



                return dataTable;

            }
        }
}
