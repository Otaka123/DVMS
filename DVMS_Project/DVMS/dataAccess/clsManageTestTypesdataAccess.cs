using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class clsManageTestTypesdataAccess
    {
        
            public static bool GetApplicationinfo(int G_AppId, ref string G_Apllicationtitle, ref string G_ApllicationDescription, ref decimal G_fees)
            {
                bool found = false;
                using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
                {
                    string query = @"SELECT * FROM TestTypes  where TestTypeID = @AppId ; ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@AppId", SqlDbType.Int) { Value = G_AppId });
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // التأكد من وجود صفوف
                            {
                                found = true;
                                G_Apllicationtitle = reader.GetString(reader.GetOrdinal("TestTypeTitle"));
                                G_ApllicationDescription =reader.GetString(reader.GetOrdinal("TestTypeDescription"));
                                G_fees = reader.GetDecimal(reader.GetOrdinal("TestTypeFees"));

                        }

                    }
                    }

                }
                return found;
            }
            public static bool UpdateApllicationTypes(int G_ApplicationID, string G_Apllicationtitle,  string G_ApllicationDescription, decimal G_fees)
            {
                bool Updatesuccess = false;
                SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
                string query = @" UPDATE TestTypes 
                               SET TestTypeTitle = @newAppTitle 
                                  ,TestTypeDescription = @testdescription
                                  ,TestTypeFees   =    @newAppfees where TestTypeID = @AppId ; ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@AppId", SqlDbType.Int) { Value = G_ApplicationID });
                command.Parameters.Add(new SqlParameter("@newAppTitle", SqlDbType.NVarChar, 150) { Value = G_Apllicationtitle });
                command.Parameters.Add(new SqlParameter("@testdescription", SqlDbType.NVarChar, 500) { Value = G_ApllicationDescription });

                command.Parameters.Add(new SqlParameter("@newAppfees", SqlDbType.SmallMoney) { Value = G_fees });
                try
                {
                    connection.Open();
                    int Rowsaffeted = command.ExecuteNonQuery();
                    Updatesuccess = (Rowsaffeted > 0);




                }
                catch
                {
                    Updatesuccess = false;
                }
                finally
                {
                    connection.Close();
                }
                return Updatesuccess;

            }
            public static DataTable GetAllApplicationTypes()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM TestTypes ;";
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



