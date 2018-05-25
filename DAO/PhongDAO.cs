using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        public static bool ThemPhong(Phong phong)
        {
            string query = "insert into PHONG(MAPHONG,MALOAIPHONG,TINHTRANG) VALUES(@maphong,@maloaiphong,@tinhtrang)";

            string ma = TaoMa.TaoMaPhong();

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maphong",SqlDbType.NVarChar){ Value=ma  },
                new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.MaLoai },
                new SqlParameter("@tinhtrang",SqlDbType.NVarChar){Value=phong.TinhTrang }

            };

            return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0; 
        }

        public static bool GhiNhanDatPhong(KhachHang khachHang,string maPhong,string maNV)
        {
            string query = "EXEC uspGhiNhanDatPhong @maPhong,@maKhachHang,@tenKhachHang,@soDienThoai,@soHoaDon,@maNV";
            //Tạo mã hóa đơn và mã khách hàng
            string maKhachHang = TaoMa.TaoMaKhachHang();
            string maHoaDon = TaoMa.TaoHoaDon();

            return true;
        }
    }
}
