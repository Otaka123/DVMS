using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class ManageApplication
    {
        public static bool GetApplicationinfo(int G_AppId, ref string G_Apllicationtitle, ref decimal G_fees)
        {
            bool found=false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                string query = @"SELECT * FROM ApplicationTypes  where ApplicationTypeID = @AppId ; ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@AppId", SqlDbType.Int) { Value = G_AppId });
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التأكد من وجود صفوف
                        {
                            found = true;
                            G_Apllicationtitle = reader.GetString(reader.GetOrdinal("ApplicationTypeTitle"));
                            G_fees =Convert.ToDecimal( reader[(reader.GetOrdinal("ApplicationFees"))]);
                        }

                    }
                }

            }
            return found;
        }
        public static bool UpdateApllicationTypes( int G_ApplicationID ,string G_Apllicationtitle , decimal G_fees)
        {   bool Updatesuccess=false;
            SqlConnection connection=new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @" UPDATE ApplicationTypes 
                               SET ApplicationTypeTitle = @newAppTitle 
                                  ,ApplicationFees   =    @newAppfees where ApplicationTypeID = @AppId ; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@AppId", SqlDbType.Int) { Value = G_ApplicationID });
            command.Parameters.Add(new SqlParameter("@newAppTitle", SqlDbType.NVarChar, 150) { Value = G_Apllicationtitle });
            command.Parameters.Add(new SqlParameter("@newAppfees",SqlDbType.SmallMoney) { Value = G_fees });
            try
            {
                connection.Open();
                int Rowsaffeted = command.ExecuteNonQuery();
                Updatesuccess = (Rowsaffeted > 0);




            }
            catch
            {
                Updatesuccess=false;
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
                string query = @"SELECT * FROM ApplicationTypes ;";
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
