using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class countriesdataAccess
    {
        public static bool GetCountryID(string countryName, ref int countryId)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select * from Countries where CountryName = @Id ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", countryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    found = true;
                    countryId = (int)reader["CountryID"];
                    reader.Close();
                }
                else
                    { found = false; }



            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return found;

        }
        public static bool GetCountryName(int CountryID, ref string CountryName)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select * from Countries where CountryID = @Id ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", CountryID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    found = true;
                }


                reader.Close();

            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }


            return found;

        }
        public static bool IsExit(int CountryID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select found=1 from Countries where CountryID = @Id ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", CountryID);
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
            }
            finally
            {
                connection.Close();
            }


            return found;

        }
        public static DataTable GetAllCountry()
        {
            DataTable countrysdt = new DataTable();
            SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString);
            string query = "select * from Countries  ;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    countrysdt.Load(reader);
                }

                reader.Close();

            }
            catch
            {
                countrysdt = null;
            }
            finally
            {
                connection.Close();
            }


            return countrysdt;

        }
    }
}
