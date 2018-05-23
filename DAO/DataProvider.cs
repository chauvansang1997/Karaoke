using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    /// <summary>
    /// Lớp được tạo với cấu trúc singleton
    /// </summary>
    public static class Dataprovider
    {
        //Chuổi kết nối với sql
        private static string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=dbQuanLyKaraoke;Integrated Security=True";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }


        /// <summary>
        /// Phương thức này có vai trò lấy dữ liệu là các bảng trong SQL
        /// </summary>
        /// <param name="query">Chuỗi truy vấn được đưa xuống SQL</param>
        /// <param name="sqlparameters"> mảng tham số được thêm vào command(có thể không có)</param>
        /// <returns>Phương thức trả về kiểu dũ liệu DataTable</returns>
        public static DataTable ExcuteQuery(string query, SqlParameter[] sqlparameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                if (sqlparameters != null)
                    command.Parameters.AddRange(sqlparameters);

                SqlDataAdapter adapter = new SqlDataAdapter(command);



                adapter.Fill(table);

                con.Close();
            }


            return table;
        }

        /// <summary>
        /// Phương thức thực hiện truy vấn xuống SQL và trả về số dòng thành công
        /// </summary>
        /// <param name="query">Chuỗi truy vấn được đưa xuống SQL</param>
        /// <returns>Số dòng thành công</returns>
        public static int ExcuteNonQuery(string query, SqlParameter[] sqlparameters = null)
        {
            int temp = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                if (sqlparameters != null)
                    command.Parameters.AddRange(sqlparameters);

                temp = command.ExecuteNonQuery();

            }
            return temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sqlparameters"></param>
        /// <returns></returns>
        public static object ExcuteScalar(string query, SqlParameter[] sqlparameters = null)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                if (sqlparameters != null)
                    command.Parameters.AddRange(sqlparameters);


                object temp = command.ExecuteScalar();

                return temp;
            }
        }

       // public static bool ExcuteNonQueryWithMore(SqlCommand)
    }
}