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

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@manl",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Ma },
                new SqlParameter("@mancc",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.NhaCungCap },
                new SqlParameter("@tennl",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Ten },
                new SqlParameter("@loainl",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Loai },
                new SqlParameter("@dvt",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.DonViTinh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=nguyenLieu.Dongia },
                new SqlParameter("@slton",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.SoLuongTon },
                new SqlParameter("@sltoithieu",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.SoLuongToiThieu },
            };
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
        public static NguyenLieu XemNguyenLieu(string isXemToiThieu, string maNhaCungCap=null)
        {
            string query = "EXEC uspXemNguyenLieu @maNhaCungCap,@loaiNguyenLieu,@isXemToiThieu";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@manl",SqlDbType.NVarChar){IsNullable=false,Value=maNhaCungCap },
                new SqlParameter("@tennl",SqlDbType.Bit){IsNullable=false,Value=isXemToiThieu },

            };

            DataTable table = Dataprovider.ExcuteQuery(query,parameters.ToArray());
            //Chuyển Table thành List tên hành khách
            return table.AsEnumerable().ToList().ConvertAll(x =>
                new NguyenLieu() { Ma = x[0].ToString(), Ten = x[1].ToString(), NhaCungCap = x[2].ToString(), Id = x[2].ToString() });
        }
    }
}
