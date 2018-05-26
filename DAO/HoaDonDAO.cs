using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public static class HoaDonDAO
    {
        public static bool ThemChiTietHoaDon(string mahd,List<string> listMa,List<string> listSoLuongMa, List<string> listSp, List<string> listSoLuongSp)
        {
            string query = "EXEC uspThemChiTietHoaDon @maHD,@danhSachMa,@danhSachSoLuongMa,@danhSachSp,@danhSachSoLuongSp";

            string danhSachMa= String.Join("|", listMa);
            string danhSachSoLuongMa = String.Join("|", listSoLuongMa);
            string danhSachSp = String.Join("|", listSp);
            string danhSachSoLuongSp = String.Join("|", listSoLuongSp);
            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maHD",SqlDbType.NVarChar){IsNullable=false,Value=mahd },
                new SqlParameter("@danhSachMa",SqlDbType.NVarChar){IsNullable=false,Value=danhSachMa },
                new SqlParameter("@danhSachSoLuongMa",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuongMa },
                new SqlParameter("@danhSachSp",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSp },
                new SqlParameter("@danhSachSoLuongSp",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuongSp },

            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }
    }
}
