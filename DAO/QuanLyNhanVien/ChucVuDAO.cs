using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO.QuanLyNhanVien
{
    public static class ChucVuDAO
    {
        // Load mã chức vụ 
        public static DataTable LoadMaChucVu()
        {
            string query = "SELECT MACV,TENCV FROM CHUCVU";
            return Dataprovider.ExcuteQuery(query);
        }
    }
}
