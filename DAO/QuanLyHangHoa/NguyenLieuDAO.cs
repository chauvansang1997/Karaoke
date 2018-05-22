using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.QuanLyHangHoa
{
    public class NguyenLieuDAO
    {
        /// <summary>
        /// Nhập nguyên liệu
        /// </summary>
        /// <param name="nguyenLieu"> các thông tin về nguyên liệu</param>
        /// <returns></returns>
        public static bool NhapNguyenLieu(NguyenLieu nguyenLieu)
        {
            string query = "insert into NGUYENLIEU(manl,mancc,tennl,loainl,dvt,dongia,slton,sltoithieu) " +
                "values (@manl,@mancc,@tennl,@loainl,@dvt,@dongia,@slton,@sltoithieu)";

            //Tạo mã cho nguyên liệu
            string manl = TaoMa.TaoMaNguyenLieu();

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@manl",SqlDbType.NVarChar){IsNullable=false,Value=manl },
                new SqlParameter("@mancc",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.NhaCungCap },
                new SqlParameter("@tennl",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Ten },
                new SqlParameter("@loainl",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Loai },
                new SqlParameter("@dvt",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.DonViTinh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=nguyenLieu.Dongia },
                new SqlParameter("@slton",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.SoLuongTon },
                new SqlParameter("@sltoithieu",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.SoLuongToiThieu },
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }

        public static bool XoaMonAn(string ma)
        {
            return false;
        }
        /// <summary>
        /// Xem danh sách nguyên liệu
        /// </summary>
        /// <param name="maNhaCungCap">mã nhà cung cấp</param>
        /// <param name="loaiNL">loại nguyên liệu</param>
        /// <param name="isXemToiThieu">nếu true thì ta xem các nguyên liệu đạt ngưỡng tối thiểu</param>
        /// <returns></returns>
        public static DataTable XemNguyenLieu( string tenNguyenLieu,string maNhaCungCap, bool isXemToiThieu)
        {
            string query = "EXEC uspXemNguyenLieu @tenNguyenLieu,@maNhaCungCap,@isXemToiThieu";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNguyenLieu",SqlDbType.NVarChar){IsNullable=true,Value=tenNguyenLieu },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap },
                new SqlParameter("@isXemToiThieu",SqlDbType.Bit){IsNullable=true,Value=isXemToiThieu },

            };

            return Dataprovider.ExcuteQuery(query,parameters.ToArray());
        }
    }
}
