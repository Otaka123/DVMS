using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class clsUserDataAccess
    {
        public static string GetUserPasswordByuserName(string UserName, ref string Password)
        {
            
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "select Password from Users where UserName = @userName ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlParameter parusername = new SqlParameter("@userName", SqlDbType.NVarChar, 20);
                    parusername.Value = UserName;
                    command.Parameters.Add(parusername);
                    var result = command.ExecuteScalar();
                    Password = result as string;
                }

            }
          
           
          
            return Password;

        }
        public static int GetUserID(string G_UserName)
        {
            int UserId = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select UserID from Users where UserName = @user ;  ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user", G_UserName);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int num))
                {
                    UserId=num;

                }

            }
            catch
            {

            }
            finally
            {
               connection.Close();
            }
            return UserId;
        }
        public static bool UpdateUser(int G_UserID ,int G_personID, string G_UserName, string G_Password, bool G_IsActive)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"Update Users set PersonID = @personid ,UserName = @username,Password = @password ,IsActive = @isactive where UserID = @userid ;";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@userid", SqlDbType.Int) { Value = G_UserID });
                    command.Parameters.Add(new SqlParameter("@personid", SqlDbType.Int) { Value = G_personID });
                    command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 20) { Value = G_UserName });
                    command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 20) { Value = G_Password });
                    command.Parameters.Add(new SqlParameter("@isactive", SqlDbType.Bit) { Value = G_IsActive });



                     result = command.ExecuteNonQuery();
                    

                }
            }
            return (result>0);
        }
        public static bool DeleteUser(int G_UserID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"Delete Users where UserID = @userid ;";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@userid", SqlDbType.Int) { Value = G_UserID });
                   



                    result = command.ExecuteNonQuery();


                }
            }
            return (result > 0);
        }
        public static int AddNewUser(int G_personID,  string G_UserName,  string G_Password,  bool G_IsActive)
        {
            int insertedID = 0;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"insert into Users (PersonID,UserName,Password,IsActive)
                         values (@personid,@username,@password,@isactive) SELECT SCOPE_IDENTITY(); ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@personid", SqlDbType.Int) { Value = G_personID });
                    command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 20) { Value = G_UserName });
                    command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 20) { Value = G_Password });
                    command.Parameters.Add(new SqlParameter("@isactive", SqlDbType.Bit) { Value = G_IsActive });



                    var result = command.ExecuteScalar();
                    if (result != null)
                    { int.TryParse(result.ToString(), out insertedID);
                    }
                  
                }
            }
            return insertedID;
        }
    
        public static bool GetUserByUserID(int G_UserID, ref int G_personID, ref string G_UserName, ref string G_Password, ref bool G_IsActive)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE UserID = @userID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@userID", SqlDbType.Int) { Value = G_UserID });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التحقق إذا كان هناك صفوف في النتيجة
                        {
                            found = true;
                            G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            G_UserName = reader.GetString(reader.GetOrdinal("UserName"));
                            G_Password = reader.GetString(reader.GetOrdinal("Password"));
                            G_IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")); // قراءة IsActive كـ bool
                        }
                    }
                }
            }

            return found;
        }
        public static bool IsExistByUserName_Password( string G_UserName,  string G_Password,ref int G_UserID,ref int G_personID ,ref bool G_IsActive)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE UserName = @username and Password = @password;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar,20) { Value = G_UserName });
                    command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 20) { Value = G_Password });


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التحقق إذا كان هناك صفوف في النتيجة
                        {
                            found = true;
                            G_UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            G_IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")); // قراءة IsActive كـ bool
                        }
                    }
                }
            }

            return found;
        }
        public static bool IsExist(string G_UserName, string G_Password, ref int G_UserID)
        {
            bool found = false;
            bool G_isactive=true;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE UserName = @username and Password = @password and IsActive = @isactive;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 20) { Value = G_UserName });
                    command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 20) { Value = G_Password });
                    command.Parameters.Add(new SqlParameter("@isactive", SqlDbType.Bit) { Value = G_isactive });



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التحقق إذا كان هناك صفوف في النتيجة
                        {
                            found = true;
                            G_UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            //G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            //G_IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")); // قراءة IsActive كـ bool
                        }
                    }
                }
            }

            return found;
        }
        public static bool IsExist( int G_PersonID)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE PersonID = @personid ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@personid", SqlDbType.Int) { Value = G_PersonID });
             



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التحقق إذا كان هناك صفوف في النتيجة
                        {
                            found = true;
                            //G_UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            //G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            //G_IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")); // قراءة IsActive كـ bool
                        }
                    }
                }
            }

            return found;
        }
        public static bool IsExist(string G_username)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "SELECT UserID FROM Users WHERE UserName = @username ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 20) { Value = G_username });


                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        found = true;
                    }
                }
            }

            return found;
        }
        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = @"select UserID,Users.PersonID,UserName,People.FirstName+' '+People.SecondName+' '+People.ThirdName+' '+People.LastName as fullName,
                            case when Users.IsActive=1 then 'Yes'
                             when Users.IsActive=0 then 'No' end as IsActive from Users 
                            join people on Users.PersonID=People.PersonID;
                            ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
