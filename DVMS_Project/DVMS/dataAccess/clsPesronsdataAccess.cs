using System;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Policy;

namespace dataAccess
{
    public class clsPesronsdataAccess
    {


        public static bool GetPersonByPersonID(int G_personID,ref string G_nationalno, ref string G_firstname
                                               , ref string G_secondname, ref string G_thirdname, ref string G_lastname
                                               , ref string G_email, ref string G_address, ref string G_phone, ref bool G_gendor,
                                               ref DateTime G_birthdate, ref int G_nationalitycountryId, ref string G_Imagepath)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM People WHERE PersonID = @personId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@personId", SqlDbType.Int) { Value = G_personID });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التحقق إذا كان هناك صفوف في النتيجة
                        {
                            found = true;
                            G_nationalno = reader.GetString(reader.GetOrdinal("NationalNo"));
                            G_firstname = reader.GetString(reader.GetOrdinal("FirstName"));
                            G_secondname = reader.GetString(reader.GetOrdinal("SecondName"));
                            G_thirdname = reader.GetString(reader.GetOrdinal("ThirdName"));
                            G_lastname = reader.GetString(reader.GetOrdinal("LastName"));
                            G_birthdate = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                            G_gendor = reader.GetBoolean(reader.GetOrdinal("Gendor"));
                            G_address = reader.GetString(reader.GetOrdinal("Address"));
                            G_phone = reader.GetString(reader.GetOrdinal("Phone"));
                            G_email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                            G_nationalitycountryId = reader.GetInt32(reader.GetOrdinal("NationalityCountryID"));
                            G_Imagepath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? "null" : reader.GetString(reader.GetOrdinal("ImagePath"));

                        }
                    }
                }
            }

            return found;
        }
        //public static bool GetPersonByPersonID(int sPersonID, ref string snationalno, ref string sfirstname,
        //                                        ref string ssecondname, ref string sthirdname, ref string slastname,
        //                                        ref string semail,ref DateTime sbirthdate, ref string sphone, 
        //                                        ref bool sgendor, ref string saddress , 
        //                                        ref int snationalitycountryId, ref string sImagepath)
        //{
        //    bool found = false;
        //    SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
        //    string query = "SELECT * FROM People WHERE PersonID = @personId;";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@personId", sPersonID);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            sImagepath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";

        //            snationalitycountryId = (int)reader["NationalityCountryID"];

        //            found = true;
        //            snationalno = (string)reader["NationalNo"];
        //            semail = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";

        //            sfirstname = (string)reader["FirstName"];
        //            ssecondname = (string)reader["SecondName"];
        //            saddress = (string)reader["Address"];
        //            sphone = (string)reader["Phone"];
        //            sthirdname = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "";
        //            slastname = (string)reader["LastName"];
        //            sgendor = (bool)reader["Gendor"];



        //            sbirthdate = (DateTime)reader["DateOfBirth"];

        //        }

        //        reader.Close();
        //    }
        //    catch 
        //    {
        //        // في حالة وجود خطأ يمكنك معالجة الخطأ هنا مثل طباعة رسالة الخطأ
        //        //Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return found;
        //}
        //public static bool GetPersonByNationalNo( string nationalno,ref int personID,ref string firstname,ref string secondname,ref string thirdname,ref string lastname,ref string email,ref string address,ref string phone,ref short gendor,ref DateTime birthdate,ref int nationalitycountryId,ref string Imagepath)
        //{
        //    bool found = false;
        //    SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
        //    string query = "select * from People where NationalNo = @nationalId ;";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@nationalId", nationalno);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            found = true;
        //            personID = (int)reader["PersonID"];
        //            firstname = (string)reader["FirstName"];
        //            secondname = (string)reader["SecondName"];
        //            thirdname = (string)reader["ThirdName"];
        //            lastname = (string)reader["LastName"];
        //            if (reader["Email"] != DBNull.Value)
        //            {
        //                email = (string)reader["Email"];

        //            }
        //            else
        //            {
        //                email = "";
        //            }
        //            address = (string)reader["Address"];
        //            phone = (string)reader["Phone"];
        //            gendor = (short)reader["Gendor"];
        //            birthdate = (DateTime)reader["DateOfBirth"];
        //            nationalitycountryId = (int)reader["NationalityCountryID"];
        //            if (reader["ImagePath"] != DBNull.Value)
        //            {
        //                Imagepath = (string)reader["ImagePath"];


        //            }
        //            else
        //            {
        //                Imagepath = "";
        //            }
        //        }
        //        else { found = false; }

        //        reader.Close();

        //    }
        //    catch
        //    {
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }


        //    return found;

        //}
        public static bool GetPersonByNationalNo(string G_nationalno, ref int G_personID, ref string G_firstname
                                                , ref string G_secondname, ref string G_thirdname, ref string G_lastname
                                                , ref string G_email, ref string G_address, ref string G_phone, ref bool G_gendor,
                                                ref DateTime G_birthdate, ref int G_nationalitycountryId, ref string G_Imagepath)
        {
            bool found = false;
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                connection.Open();
                string query = "select * from People where NationalNo = @nationalId ;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@nationalId", SqlDbType.NVarChar,20) { Value = G_nationalno });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // التحقق إذا كان هناك صفوف في النتيجة
                        {
                            found = true;
                            G_personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            G_firstname = reader.GetString(reader.GetOrdinal("FirstName"));
                            G_secondname = reader.GetString(reader.GetOrdinal("SecondName"));
                            G_thirdname = reader.GetString(reader.GetOrdinal("ThirdName"));
                            G_lastname = reader.GetString(reader.GetOrdinal("LastName"));
                            G_birthdate = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                            G_gendor = reader.GetBoolean(reader.GetOrdinal("Gendor"));
                            G_address = reader.GetString(reader.GetOrdinal("Address"));
                            G_phone = reader.GetString(reader.GetOrdinal("Phone"));
                            G_email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email"));
                            G_nationalitycountryId = reader.GetInt32(reader.GetOrdinal("NationalityCountryID"));
                            G_Imagepath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? "null" : reader.GetString(reader.GetOrdinal("ImagePath"));

                        }
                    }
                }
            }

            return found;
        }
        public static int AddNewPerson(string nationalno, string firstname, string secondname, string thirdname, string lastname, string email, string address, string phone, bool gendor, DateTime birthdate, int nationalitycountryId, string Imagepath)
        {
            int personID = -1;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"INSERT INTO People (NationalNo, FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor ,Address,Phone,Email, NationalityCountryID, ImagePath)
                             VALUES (@nationalno, @firstname,@secondname,@thirdname,@LastName,@DateOfBirth,@Gendor ,@Address,@Phone,@Email, @NationalityCountryID, @ImagePath);    SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nationalno", nationalno);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@secondname", secondname);
            //if (thirdname != string.Empty)
            //{
                command.Parameters.AddWithValue("@thirdname", thirdname);

            //}
            //else
            //{
            //    command.Parameters.AddWithValue("@thirdname", DBNull.Value);

            //}
            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@DateOfBirth", birthdate);
            command.Parameters.AddWithValue("@Gendor", gendor);
            command.Parameters.AddWithValue("@Address", address);
            if (email != string.Empty)
            {
                command.Parameters.AddWithValue("@Email", email);

            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            }
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@NationalityCountryID", nationalitycountryId);
            if (Imagepath != string.Empty)
            {
                command.Parameters.AddWithValue("@ImagePath", Imagepath);

            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personID = insertedID;
                }
            }
            catch
            {
                personID = -1;
            }
            finally
            {
                connection.Close();
            }


            return personID;

        }
        public static bool UpdatePerson(int PersonID, string nationalno, string firstname, string secondname, string thirdname, string lastname, string email, string address, string phone, bool gendor, DateTime birthdate, int nationalitycountryId, string Imagepath)
        {
            int rowsAffected = 0;
            bool Updatesuccess = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = @"update People
                                set  NationalNo = @Nationalno
                                 ,FirstName = @firstname
                                 ,SecondName = @secondname
                                 ,ThirdName = @thirdname
                                 ,LastName =  @lastname
                                 ,DateOfBirth = @DateOfBirth
                                 ,Gendor = @Gendor
                                 ,Address = @Address
                                 ,Phone = @Phone
                                 ,Email = @Email
                                 ,NationalityCountryID = @NationalityCountryID
                                 ,ImagePath = @ImagePath
                                 where PersonID = @personid ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nationalno", nationalno);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@secondname", secondname);
            command.Parameters.AddWithValue("@thirdname", thirdname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@DateOfBirth", birthdate);
            command.Parameters.AddWithValue("@Gendor", gendor);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            if (email != string.Empty)
            {
                command.Parameters.AddWithValue("@Email", email);

            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            }
            command.Parameters.AddWithValue("@NationalityCountryID", nationalitycountryId);
            if (Imagepath != string.Empty)
            {
                command.Parameters.AddWithValue("@ImagePath", Imagepath);

            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            }
            command.Parameters.AddWithValue("@personid", PersonID);

           
           
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                Updatesuccess = (rowsAffected > 0);


            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return Updatesuccess;

        }
        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;
            bool Updatesuccess = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);

            string query = @"Delete People 
                                where PersonID = @personid";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personid", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                Updatesuccess = (rowsAffected > 0);
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

        public static DataTable GetAllpersons()
        {
            DataTable personsdt = new DataTable();
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select * from People  ;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    personsdt.Load(reader);
                }
                reader.Close();

            }
            catch
            {
                personsdt = null;
            }
            finally
            {
                connection.Close();
            }


            return personsdt;

        }
        //public static DataTable search(string searchby, string textbar)
        //{
        //    DataTable personsdt = new DataTable();
        //    SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
        //    string query = "select * from People where @searchby  like '%' & @textbar & '%' ;";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@searchby", searchby);
        //    command.Parameters.AddWithValue("@textbar", searchby);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            personsdt.Load(reader);
        //        }
        //        reader.Close();

        //    }
        //    catch
        //    {
        //        personsdt = null;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }


        //    return personsdt;

        //}
       
        public static bool IsExit(int PersonID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select found=1 from People where PersonID = @Id ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", PersonID);
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
        public static bool IsExit(string nationalno)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select found=1 from People where NationalNo = @nationalno ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@nationalno", nationalno);
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


    }


}
