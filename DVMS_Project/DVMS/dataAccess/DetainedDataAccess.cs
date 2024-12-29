using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class DetainedDataAccess
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public DetainedDataAccess(int G_DetainID, int G_LicenseID, DateTime G_DetainDate, Decimal G_FineFees, int G_CreatedByUserID, bool G_IsReleased, DateTime G_ReleaseDate, int G_ReleasedByUserID, int G_ReleaseApplicationID)
        {
            this.DetainID = G_DetainID;
            this.LicenseID = G_LicenseID;
            this.DetainDate = G_DetainDate;
            this.FineFees = G_FineFees;
            this.CreatedByUserID = G_CreatedByUserID;
            this.IsReleased = G_IsReleased;
            this.ReleaseDate = G_ReleaseDate;
            this.ReleasedByUserID = G_ReleasedByUserID;
            this.ReleaseApplicationID = G_ReleaseApplicationID;

        }
        public class UPDATEDTO
        {
            public int LicenseID { get; set; }
            public DateTime ReleaseDate { get; set; }
            public int ReleasedByUserID { get; set; }
            public int ReleaseApplicationID { get; set; }
            public UPDATEDTO(int C_LincenseID, DateTime G_ReleaseDate, int G_ReleasedByUserID, int G_ReleaseApplicationID)
            {
                this.LicenseID=C_LincenseID;
                this.ReleaseDate = G_ReleaseDate;
                this.ReleasedByUserID = G_ReleasedByUserID;
                this.ReleaseApplicationID = G_ReleaseApplicationID;

            }
        }
        public class ADDDTO
        {
            public int DetainID { get; set; }
            public int LicenseID { get; set; }
            public DateTime DetainDate { get; set; }
            public decimal FineFees { get; set; }
            public int CreatedByUserID { get; set; }
            public ADDDTO(int G_DetainID, int G_LicenseID, DateTime G_DetainDate, decimal G_FineFees, int G_CreatedByUserID)
            {
                this.DetainID = G_DetainID;
                this.LicenseID = G_LicenseID;
                this.DetainDate = G_DetainDate;
                this.FineFees = G_FineFees;
                this.CreatedByUserID = G_CreatedByUserID;
            }

        }
      
        public static int Detain(ADDDTO DTO)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewDetain", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = DTO.LicenseID });
                    command.Parameters.Add(new SqlParameter("@DetainDate", SqlDbType.SmallDateTime) { Value = DTO.DetainDate });
                    command.Parameters.Add(new SqlParameter("@FineFees", SqlDbType.SmallMoney) { Value = DTO.FineFees });
                    command.Parameters.Add(new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = DTO.CreatedByUserID });
                    //command.Parameters.Add(new SqlParameter("@IsReleased", SqlDbType.Bit) { Value = DTO.IsReleased });
                    //command.Parameters.Add(new SqlParameter("@ReleaseDate", SqlDbType.SmallDateTime) { Value = DTO.ReleaseDate });
                    //command.Parameters.Add(new SqlParameter("@ReleasedByUserID", SqlDbType.Int) { Value = DTO.ReleasedByUserID });
                    //command.Parameters.Add(new SqlParameter("@ReleaseApplicationID", SqlDbType.Int) { Value = DTO.LicenseID });
                    var outputIdParam = new SqlParameter("@NewDetainID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);
                    connection.Open();
                    command.ExecuteScalar();

                    return (int)outputIdParam.Value;
                }
            }
        }
        public static int ReleaseDetain(UPDATEDTO DTO)
        {
            // التحقق من صحة الكائن DTO قبل البدء
            if (DTO == null) throw new ArgumentNullException(nameof(DTO));
            if (DTO.LicenseID <= 0) throw new ArgumentException("Invalid LicenseID.");
            if (DTO.ReleaseDate == null) throw new ArgumentException("ReleaseDate cannot be null.");
            if (DTO.ReleasedByUserID <= 0) throw new ArgumentException("Invalid ReleasedByUserID.");
            if (DTO.ReleaseApplicationID <= 0) throw new ArgumentException("Invalid ReleaseApplicationID.");

            // عدد الصفوف المتأثرة
            int rowsAffected = 0;

            // الاتصال بقاعدة البيانات
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateDetain", connection))
                {
                    // تعيين نوع الأمر إلى إجراء مخزن
                    command.CommandType = CommandType.StoredProcedure;

                    // إضافة المعاملات
                    command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = DTO.LicenseID });
                    command.Parameters.Add(new SqlParameter("@ReleaseDate", SqlDbType.SmallDateTime) { Value = DTO.ReleaseDate});
                    command.Parameters.Add(new SqlParameter("@ReleasedByUserID", SqlDbType.Int) { Value = DTO.ReleasedByUserID });
                    command.Parameters.Add(new SqlParameter("@ReleaseApplicationID", SqlDbType.Int) { Value = DTO.ReleaseApplicationID });

                  
                    try
                    {
                        // فتح الاتصال وتنفيذ الأمر
                        connection.Open();
                        rowsAffected =command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // تسجيل الخطأ أو معالجته حسب الحاجة
                        throw new Exception($"Error executing stored procedure: {ex.Message}", ex);
                    }
                }
            }

            // إرجاع عدد الصفوف المتأثرة
            return rowsAffected;
        }

        //public static int ReleaseDetain(UPDATEDTO DTO)
        //{
        //    using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand("SP_UpdateDetain", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = DTO.LicenseID});
        //            command.Parameters.Add(new SqlParameter("@ReleaseDate", SqlDbType.SmallDateTime) { Value = DTO.ReleaseDate });
        //            command.Parameters.Add(new SqlParameter("@ReleasedByUserID", SqlDbType.Int) { Value = DTO.ReleasedByUserID });
        //            command.Parameters.Add(new SqlParameter("@ReleaseApplicationID", SqlDbType.Int) { Value = DTO.ReleaseApplicationID});

        //            connection.Open();
        //            int rowaffected=command.ExecuteNonQuery();

        //            return rowaffected;
        //        }
        //    }
        //}
        public static int GetPersonID(int DetainId)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                int personId = 0;
                string query = @"select Applications.ApplicantPersonID from DetainedLicenses
                        inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
                        inner join Applications on Applications.ApplicationID = Licenses.ApplicationID
                        where DetainedLicenses.DetainID = @DetainId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@DetainId", SqlDbType.Int) { Value = DetainId });
                    
                    connection.Open();
                    object result= command.ExecuteScalar();
                    if(result!=null&&int.TryParse(result.ToString(),out int person))
                    {
                        personId=person;
                    }

                    return personId;
                }
            }
        }
        public static int GetDetainFees(int licenseId)
        {
            // تعريف المتغير للإرجاع
            int fineFees = 0;

            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            {
                // الاستعلام لاسترجاع FineFees
                string query = @"SELECT ISNULL(FineFees, 0) AS FineFees
                                 FROM DetainedLicenses
                                 WHERE LicenseID = @LicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // تمرير المعاملات
                    command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = licenseId });

                    // فتح الاتصال وتنفيذ الاستعلام
                    connection.Open();
                    object result = command.ExecuteScalar();

                    // التحقق من النتيجة
                   

                    // تحويل القيمة إلى decimal أولاً
                    if (decimal.TryParse(result.ToString(), out decimal fees))
                    {
                        // تحويل القيمة إلى int بعد التقريب
                        fineFees = Convert.ToInt32(Math.Round(fees));
                    }
                  
                }
            }

            return fineFees;
        }


        //public static decimal GetDetainFees(int LicenseID)
        //{
        //    decimal personId = 0;

        //    using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
        //    {
        //        string query = @"SELECT ISNULL(FineFees, 0) AS FineFees
        //                         FROM DetainedLicenses
        //                         WHERE LicenseID = @LicenseID";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.Add(new SqlParameter("@LicenseID", SqlDbType.Int) { Value = LicenseID });

        //            connection.Open();
        //            object result = command.ExecuteScalar();
        //            if (result != null && decimal.TryParse(result.ToString(), out decimal person))
        //            {
        //                personId = person;
        //            }

        //        }
        //    }
        //    return personId;

        //}


        public static DataTable GetAllDetain()
        {
            using (SqlConnection connection = new SqlConnection(DatabaseSeittings.ConnectionString))
            { DataTable dt = new DataTable();
                string query = @"select * from DetainedLicenses ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                        reader.Close();
                        return dt;
                    }
                }
            }
        }

    }
}
