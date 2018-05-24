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
        public static bool ThemMonAn(MonAn monAn,string listNguyenLieu)
        {
           
            //Thêm món ăn
            string query = "uspThemMonAn @listNguyenLieu,@mamon,@tenmon,@loaimon,@anhminhhoa,@dongia";

            //Tạo mã cho món ăn
            string maMonAn = TaoMa.TaoMaMonAn();

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            { 
                new SqlParameter("@listNguyenLieu", SqlDbType.VarChar) { IsNullable = false, Value = listNguyenLieu },
                new SqlParameter("@mamon",SqlDbType.VarChar){IsNullable=false,Value=maMonAn },
                new SqlParameter("@tenmon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.TenMonAn },
                new SqlParameter("@loaimon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.LoaiMonAn },
                new SqlParameter("@anhminhhoa",SqlDbType.VarChar){IsNullable=false,Value=monAn.TenHinhAnh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=monAn.Gia },
            };
            try
            {
                //nếu số dòng thành công trả về lớn hơn 0 thì thành công
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
          

            return true;
        }

        public static DataTable XemMonAn(string tenMonAn,string loaiMonAn,uint donGia = 0)
        {
            string query = "EXEC uspXemMonAn @tenMonAn,@loaiMonAn,@donGia";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.NVarChar){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },

            };
            DataTable table = Dataprovider.ExcuteQuery(query,parameters.ToArray());
            return table;
        }
        public static bool XoaMonAn(string maMonAn)
        {

            string query = "delete from MONAN where mamon =@maMonAn";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn",SqlDbType.VarChar){IsNullable=false,Value=maMonAn }
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
    }
}
