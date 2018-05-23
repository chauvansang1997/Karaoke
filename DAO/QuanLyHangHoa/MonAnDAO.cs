using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO.QuanLyHangHoa
{
    public static class MonAnDAO
    {
        public static bool ThemMonAn(MonAn monAn)
        {
           

            string query = "insert into MONAN(mamon,tenmon,loaimon,anhminhhoa,dongia) " +
               "values (@mamon,@tenmon,@loaimon,@anhminhhoa,@dongia)";

            //Tạo mã cho món ăn
            string maMonAn = TaoMa.TaoMaMonAn();

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@mamon",SqlDbType.NVarChar){IsNullable=false,Value=maMonAn },
                new SqlParameter("@tenmon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.TenMonAn },
                new SqlParameter("@loaimon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.LoaiMonAn },
                new SqlParameter("@anhminhhoa",SqlDbType.NVarChar){IsNullable=false,Value=monAn.TenHinhAnh },

                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=monAn.Gia },
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }

        public static DataTable XemMonAn(string tenMonAn,string loaiMonAn,string donGia)
        {
            DataTable table = null;
            return table;
        }
    }
}
