using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;

namespace dataAccess
{
    public  class DriversDataacces
    {
        public static int AddNewLicense(int G_personiD, int G_ApplictionID, int G_LicenseClass, DateTime G_IssueDate,
           DateTime G_ExpirationDate, string G_Notes, decimal G_PaidFees, bool G_IsActive, byte G_IssueReason, int G_CreatedByUserID)
        {
            int licenseID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"DECLARE @driver INT;
                             IF NOT EXISTS (SELECT DriverID FROM Drivers WHERE PersonID = @personId)
                             BEGIN
                                 INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                                 VALUES (@personId, @creatbyuserid, @issueDate);
                                 
                                 SET @driver = SCOPE_IDENTITY();

                                 INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                                 VALUES (@applicationid, @driver, @licenseclass, @issueDate, @expiredate, @Note, @fees, @isActive, @reson, @creatbyuserid);
                                 
                                 SELECT SCOPE_IDENTITY();
                             END
                             ELSE
                             BEGIN
                                 SET @driver = (SELECT DriverID FROM Drivers WHERE PersonID = @personId);

                                 INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                                 VALUES (@applicationid, @driver, @licenseclass, @issueDate, @expiredate, @Note, @fees, @isActive, @reson, @creatbyuserid);

                                 SELECT SCOPE_IDENTITY();
                             END ;";  //^AS LicenseID
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.Add(new SqlParameter("@personId", SqlDbType.Int) { Value = G_personiD });
                command.Parameters.Add(new SqlParameter("@creatbyuserid", SqlDbType.Int) { Value = G_CreatedByUserID });
                command.Parameters.Add(new SqlParameter("@issueDate", SqlDbType.DateTime) { Value = G_IssueDate });
                command.Parameters.Add(new SqlParameter("@applicationid", SqlDbType.Int) { Value = G_ApplictionID });
                command.Parameters.Add(new SqlParameter("@licenseclass", SqlDbType.Int) { Value = G_LicenseClass });
                command.Parameters.Add(new SqlParameter("@expiredate", SqlDbType.DateTime) { Value = G_ExpirationDate });
                command.Parameters.Add(new SqlParameter("@Note", SqlDbType.NVarChar, 500) { Value = G_Notes ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@fees", SqlDbType.SmallMoney) { Value = G_PaidFees });
                command.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit) { Value = G_IsActive });
                command.Parameters.Add(new SqlParameter("@reson", SqlDbType.TinyInt) { Value = G_IssueReason });


                try
                {
                    connection.Open();

                    object obj = command.ExecuteScalar();
                    if (obj != null && int.TryParse(obj.ToString(), out int num))
                    {
                        licenseID = num;
                    }


                }
                catch
                {

                }

            }

            return licenseID;
        }
        public static bool ReNeWLicense(int licenseid,DateTime Newissudate,DateTime newexpiredate)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"update Licenses
                                 set IssueDate = @ishu,
                                 ExpirationDate = @exp,
                                 IssueReason = 2
                                 where LicenseID = @licenseID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@licenseID", SqlDbType.Int) { Value = licenseid });
                    command.Parameters.Add(new SqlParameter("@ishu", SqlDbType.DateTime) { Value = Newissudate });
                    command.Parameters.Add(new SqlParameter("@exp", SqlDbType.DateTime) { Value = newexpiredate });

                    connection.Open();
                    object result = command.ExecuteNonQuery();
                    return result != null;
                }
            }
        }
      
        public static bool deActivetlicense(int licenseid)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"update Licenses
                                 set IsActive = 0
                                 where LicenseID = @licenseID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@licenseID", SqlDbType.Int) { Value = licenseid });
                
                    connection.Open();
                    object result = command.ExecuteNonQuery();
                    return result != null;
                }
            }
        }
        public static DataTable GetLocalLicense(int G_driverId)
        {
          
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
                {
                    connection.Open();
                    string query = @"select * from Licenses 
                                     where DriverID = @driverid;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@driverid", G_driverId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                    }
                    }

                }



                return dataTable;

            
        }
        public static DataTable GetAllInternationalLicense()
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"select * from InternationalLicenses ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

            }



            return dataTable;


        }
        public static DataTable GetInternationalLicense(int G_driverId)
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"select * from InternationalLicenses 
                                     where DriverID = @driverid;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@driverid", G_driverId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataTable.Load(reader);
                        }
                    }
                }

            }



            return dataTable;


        }
        public static bool FindLicensebyApplictionID(int G_ApplicationId, ref int G_LicenseID, ref int DriverID, ref int G_LicenseClass, ref DateTime G_IssueDate,
        ref DateTime G_ExpirationDate, ref string G_Notes, ref decimal G_PaidFees, ref bool G_IsActive, ref byte G_IssueReason, ref int G_CreatedByUserID, ref int G_personID)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"select * ,Drivers.PersonID from Licenses 
			                inner join Drivers on  Drivers.DriverID=Licenses.DriverID
			                where ApplicationID = @ApplicationID ;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = G_ApplicationId });
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                            while (reader.Read())
                            {
                                G_LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                                DriverID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                                G_LicenseClass = reader.GetInt32(reader.GetOrdinal("LicenseClass"));
                                G_IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                                G_ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                                G_Notes = reader["Notes"] as string ?? "";
                                G_PaidFees = Convert.ToDecimal(reader.GetDecimal(reader.GetOrdinal("PaidFees")));
                                G_IsActive = Convert.ToBoolean(reader.GetOrdinal("IsActive"));
                                G_IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason"));
                                G_CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                                G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                                found = true;

                            }
                      




                           return found;


                    }


                }
            }
              
        }
        public static bool GetClassID(int localID,ref int G_classID, ref string G_Classname, ref string G_ClassDescription, ref byte G_MinimumAllowedAge, ref byte G_DefaultValidityLength, ref decimal G_ClassFees)
        {
            bool found =false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" select LicenseClasses.LicenseClassID,LicenseClasses.ClassName,LicenseClasses.ClassDescription,LicenseClasses.MinimumAllowedAge,
			                    LicenseClasses.DefaultValidityLength,LicenseClasses.ClassFees from LocalDrivingLicenseApplications
			                    inner join LicenseClasses on LicenseClasses.LicenseClassID= LocalDrivingLicenseApplications.LicenseClassID
                             where LocalDrivingLicenseApplicationID = @localLicense;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@localLicense", SqlDbType.Int) { Value = localID });
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        found = true;
                        G_classID = reader.GetInt32(reader.GetOrdinal("LicenseClassID"));
                        G_Classname = reader.GetString(reader.GetOrdinal("Classname"));
                        G_ClassDescription = reader.GetString(reader.GetOrdinal("CreatedByUserID"));
                        G_MinimumAllowedAge = reader.GetByte(reader.GetOrdinal("MinimumAllowedAge"));
                        G_DefaultValidityLength = reader.GetByte(reader.GetOrdinal("DefaultValidityLength"));
                        G_ClassFees = Convert.ToDecimal(reader.GetDecimal(reader.GetOrdinal("ClassFees")));

                    }
                }
                catch
                {

                }
            }  
           


            return found;

        }

        public static bool findlicenseclass(int G_classtype,ref string G_Classname,ref string G_ClassDescription,ref byte G_MinimumAllowedAge, ref byte G_DefaultValidityLength,ref decimal G_ClassFees)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" select * from LicenseClasses where LicenseClassID = @LIcenseid";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(new SqlParameter("@LIcenseid", SqlDbType.Int) { Value = G_classtype });
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            found = true;
                            G_Classname = reader.GetString(reader.GetOrdinal("Classname"));
                            G_ClassDescription = reader.GetString(reader.GetOrdinal("CreatedByUserID"));
                            G_MinimumAllowedAge = reader.GetByte(reader.GetOrdinal("MinimumAllowedAge"));
                            G_DefaultValidityLength = reader.GetByte(reader.GetOrdinal("DefaultValidityLength"));
                            G_ClassFees = Convert.ToDecimal(reader.GetDecimal(reader.GetOrdinal("ClassFees")));


                        }
                    }
                    catch
                    {

                    }
               }
            }
            return found;

        }
        public static int getvailationyearslenghth(int classypeid)
        {int validyears = 0;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"select DefaultValidityLength from LicenseClasses 
                                 where LicenseClassID= @classid;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@classid", SqlDbType.Int) { Value = classypeid });
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if(result != null&&int.TryParse(result.ToString(),out int years))
                     {
                        validyears = years;
                    }
                    return validyears;
                }
            }
        }
        public static bool FindLicense(int G_LicenseID, ref int G_ApplictionID,ref int DriverID,ref int G_LicenseClass,ref DateTime G_IssueDate,
          ref  DateTime G_ExpirationDate,ref string G_Notes,ref decimal G_PaidFees,ref bool G_IsActive,ref byte G_IssueReason,ref int G_CreatedByUserID, ref int G_personID)
        {
          bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select * ,Drivers.PersonID from Licenses 
			                inner join Drivers on  Drivers.DriverID=Licenses.DriverID
			                where LicenseID = @LIcenseid ;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(new SqlParameter("@LIcenseid", SqlDbType.Int) { Value = G_LicenseID });
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            found=true;
                            G_ApplictionID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                            DriverID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                            G_LicenseClass = reader.GetInt32(reader.GetOrdinal("LicenseClass"));
                            G_IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                            G_ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                            G_Notes = reader["Notes"] as string ?? "";
                            G_PaidFees = Convert.ToDecimal(reader.GetDecimal(reader.GetOrdinal("PaidFees")));
                            G_IsActive = (bool)reader["IsActive"];
                            G_IssueReason = reader.GetByte(reader.GetOrdinal("IssueReason"));
                            G_CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                        }
                    }
                    catch
                    {

                    }
                   
                    




                }


            }
            return found;
        }
        public static bool IsDetian(int licenseid)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"select DetainID from DetainedLicenses
                            where LicenseID =@licensid and IsReleased=0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@licensid", SqlDbType.Int) { Value = licenseid });

                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null;
                }
            }
        }
        
        public static int FindDriverId(int G_personId)
        {
            int DriverID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"SELECT DriverID FROM Drivers WHERE PersonID = @personId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@personId", SqlDbType.Int) { Value = G_personId });
                try
                {
                    connection.Open();

                    object obj = command.ExecuteScalar();
                    if (obj != null && int.TryParse(obj.ToString(), out int num))
                    {
                        DriverID = num;
                    }
                  

                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

            
            return DriverID;
        }
       
        public static DataTable GetAllDrivers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select * from Drivers;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dataTable.Load(reader);

                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();

            }

            return dataTable;




        }

        public static DataTable GetAlllicense()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select * from Licenses;";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dataTable.Load(reader);

                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();

            }

            return dataTable;




        }
    }
}
