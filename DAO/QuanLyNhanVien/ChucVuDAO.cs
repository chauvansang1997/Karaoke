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
            string query = "SELECT DISTINCT MACV,TENCV FROM CHUCVU";
            return Dataprovider.ExcuteQuery(query);
        }
        public static List<ChucVu> XemChucVu()
        {
            string query = "EXEC uspXemChucVu";
            List<ChucVu> list = null;
            try
            {
                list = Dataprovider.ExcuteQuery(query).AsEnumerable().ToList().ConvertAll(x =>
                  new ChucVu()
                  {
                     MaChucVu = x[0].ToString(),
                     TenChucVu = x[1].ToString(),
                     HeSoLuong = float.Parse(x[2].ToString())

                  });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }

    }
}
