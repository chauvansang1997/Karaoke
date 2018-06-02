using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class HoaDonBUS
    {
        public static bool ThemChiTietHoaDon(string maHD, List<string> listMa, List<string> listSoLuongMa, List<string> listSp, List<string> listSoLuongSp)
        {
            return DAO.HoaDonDAO.ThemChiTietHoaDon(maHD, listMa, listSoLuongMa, listSp, listSoLuongSp);
        }
        public static string LayMaHoaDon(string maPhong)
        {
            return DAO.HoaDonDAO.LayMaHoaDon(maPhong);
        }
        public static List<GoiMonDataSource> XemChiTietHoaDon(string soHoaDon)
        {
            return DAO.HoaDonDAO.XemChiTietHoaDon(soHoaDon);
        }
        public static bool DatCocTien(uint tienDatCoc, string soHD)
        {
            return DAO.HoaDonDAO.DatCocTien(tienDatCoc, soHD);
        }
        public static List<GoiMonDataSource> XemChiTietHoaDonDatTiec(string soHoaDon)
        {
            return DAO.HoaDonDAO.XemChiTietHoaDonDatTiec(soHoaDon);
        }
        public static string LayMaHoaDonDatTiec(string maPhong, string tenKhachHang, string soDienThoai, DateTime ngayNhanPhong)
        {
            return DAO.HoaDonDAO.LayMaHoaDonDatTiec(maPhong,tenKhachHang,soDienThoai,ngayNhanPhong);
        }
    }
}
