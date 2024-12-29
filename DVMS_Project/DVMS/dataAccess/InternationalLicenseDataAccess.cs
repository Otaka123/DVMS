using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class InternationalLicenseDataAccess
    {
        public static int GetApplicationID(int G_inernationalLicenseID)
        {
            int internationalID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select ApplicationID from InternationalLicenses
                             where InternationalLicenseID = @liseneId ;
                              ";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(new SqlParameter("@liseneId", SqlDbType.Int) { Value = G_inernationalLicenseID });
                try
                {
                    connection.Open();

                    object obj = command.ExecuteScalar();
                    if (obj != null && int.TryParse(obj.ToString(), out int num))
                    {
                        internationalID = num;
                    }


                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }

            return internationalID;

        }
        public static int HaveAnotherLicense(int G_LocalLicenseID)
        {
            int internationalID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" select InternationalLicenseID from InternationalLicenses
                               where IssuedUsingLocalLicenseID = @liseneId ";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(new SqlParameter("@liseneId", SqlDbType.Int) { Value = G_LocalLicenseID });
                try
                {
                    connection.Open();

                    object obj = command.ExecuteScalar();
                    if (obj != null && int.TryParse(obj.ToString(), out int num))
                    {
                        internationalID = num;
                    }


                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }

            return internationalID;
          
        }
        public static bool IsActive(int G_LocalLicenseID)
        {
            bool valied = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"select found = 1 from Licenses
                            where LicenseID = @liseneId and  IsActive = 0";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add(new SqlParameter("@liseneId", SqlDbType.Int) { Value = G_LocalLicenseID });
                try
                {
                    connection.Open();

                    object obj = command.ExecuteScalar();
                    if (obj == null)
                    {
                        valied = true;
                    }

                }
                catch
                {

                }
                finally
                { 
                    connection.Close(); 
                }

            }

            return valied;
        }
        //    public static int ADDNewLinternationalicense(int G_PersoID, int G_createdbyuserID, int G_DriverID, int G_LocalLicenseID,
        //DateTime G_IssueDate, DateTime G_ExpireDate, decimal G_fees, bool G_IsActive)
        //    {
        //        string ApplicationID = "";
        //        string query = @"DECLARE @AppId INT;
        //                 INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        //                 VALUES (@personId, @edate, 6, 1, @edate, @fees, @creatbyuserid);
        //                 SET @AppId = SCOPE_IDENTITY();

        //                 INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
        //                 VALUES (@AppId, @Driverid, @LocallicenseId, @edate, @expiredate, @isActive, @creatbyuserid);

        //                 SELECT SCOPE_IDENTITY() AS InternationalLicenseid;"; 

        //        using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.Add(new SqlParameter("@personId", SqlDbType.Int) { Value = G_PersoID });
        //            command.Parameters.Add(new SqlParameter("@edate", SqlDbType.DateTime) { Value = G_IssueDate });
        //            command.Parameters.Add(new SqlParameter("@fees", SqlDbType.SmallMoney) { Value = G_fees });
        //            command.Parameters.Add(new SqlParameter("@creatbyuserid", SqlDbType.Int) { Value = G_createdbyuserID });
        //            command.Parameters.Add(new SqlParameter("@Driverid", SqlDbType.Int) { Value = G_DriverID });
        //            command.Parameters.Add(new SqlParameter("@LocallicenseId", SqlDbType.Int) { Value = G_LocalLicenseID });
        //            command.Parameters.Add(new SqlParameter("@expiredate", SqlDbType.DateTime) { Value = G_ExpireDate });
        //            command.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit) { Value = G_IsActive });

        //            try
        //            {
        //                connection.Open();
        //                object result = command.ExecuteScalar();
        //                if (result != null && int.TryParse(result.ToString(), out int insertedID))
        //                {
        //                    ApplicationID= insertedID.ToString();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                ApplicationID=ex.Message;
        //                Console.WriteLine(ex.ToString());
        //            }
        //        }

        //        return ApplicationID;
        //    }

        public static int ADDNewLinternationalicense(int G_PersoID, int G_createdbyuserID, int G_DriverID, int G_LocalLicenseID,
     DateTime G_IssueDate, DateTime G_ExpireDate, decimal G_fees, bool G_IsActive)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" DECLARE @AppId INT;
                        INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                        VALUES (@personId, @edate, 6, 1, @edate, @fees,@creatbyuserid);
                        SET @AppId = SCOPE_IDENTITY();
                        INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                        VALUES (@AppId, @Driverid, @LocallicenseId,@edate, @expiredate, @isActive, @creatbyuserid);
                        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@personId", SqlDbType.Int) { Value = G_PersoID });
            command.Parameters.Add(new SqlParameter("@edate", SqlDbType.DateTime) { Value = G_IssueDate });
            command.Parameters.Add(new SqlParameter("@fees", SqlDbType.SmallMoney) { Value = G_fees });
            command.Parameters.Add(new SqlParameter("@creatbyuserid", SqlDbType.Int) { Value = G_createdbyuserID });
            command.Parameters.Add(new SqlParameter("@Driverid", SqlDbType.Int) { Value = G_DriverID });
            command.Parameters.Add(new SqlParameter("@LocallicenseId", SqlDbType.Int) { Value = G_LocalLicenseID });
            command.Parameters.Add(new SqlParameter("@expiredate", SqlDbType.DateTime) { Value = G_ExpireDate });
            command.Parameters.Add(new SqlParameter("@isActive", SqlDbType.Bit) { Value = G_IsActive });

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
             
            }
            finally
            {
                connection.Close();
            }


            return ApplicationID;

        }

    }
}
