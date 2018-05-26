﻿using DTO;
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
                new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.TenLoai },
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

        public static List<Phong> XemPhong(string trangThai)
        {
            string query = "EXEC uspTraCuuPhong @trangThai";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@trangThai",SqlDbType.VarChar){ Value=trangThai  }
            };
            List<Phong> list = new List<Phong>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new Phong()
                        {
                            Ten = x[0].ToString(),
                            TenLoai = x[1].ToString(),
                            Gia = uint.Parse(x[2].ToString()),
                            TinhTrang = int.Parse(x[3].ToString())
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
