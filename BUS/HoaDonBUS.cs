using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class HoaDonBUS
    {

        public static bool ThemChiTietHoaDon(string maHD, List<ChiTietHoaDon> chiTietHoaDons)
        {
            return DAO.HoaDonDAO.ThemChiTietHoaDon(maHD, chiTietHoaDons);
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
            return DAO.HoaDonDAO.XemChiTietHoaDon(soHoaDon);
        }
        public static List<GoiMonDataSource> XemChiTietHoaDonGoiMon(string soHoaDon)
        {
            return DAO.HoaDonDAO.XemChiTietHoaDon(soHoaDon);
        }
        public static string LayMaHoaDonDatTiec(string maPhong, string tenKhachHang, string soDienThoai, DateTime ngayNhanPhong)
        {
            return DAO.HoaDonDAO.LayMaHoaDonDatTiec(maPhong,tenKhachHang,soDienThoai,ngayNhanPhong);
        }
        public static bool ThanhToan(string soHoaDon, DateTime gioRa, int thanhTien, int giamGia)
        {
            return DAO.HoaDonDAO.ThanhToan(soHoaDon, gioRa, thanhTien, giamGia);
        }
        public static bool HoaDonDatTiec(string soHoaDon)
        {
            return DAO.HoaDonDAO.HoaDonDatTiec(soHoaDon);
        }


        public static DataTable XemHoaDonBaoCao(string soHoaDon)
        {
            return DAO.HoaDonDAO.XemHoaDonBaoCao(soHoaDon);
        }

        public static bool KiemTraGoiMon(string ma, int soLuong, int soLuongCu=0)
        {
            return DAO.HoaDonDAO.KiemTraSoLuongHangHoa(ma, soLuong, soLuongCu);
        }

        public static bool CapNhatTon(string soHoaDon, string ma, int soLuongCu, int soLuongMoi)
        {
            return DAO.HoaDonDAO.CapNhatTon(soHoaDon,  ma,  soLuongCu,  soLuongMoi);
        }

        public static bool ThemHoaDonMonAn(string soHoaDon, string ma, int soLuong)
        {
            return DAO.HoaDonDAO.ThemHoaDonMonAn(soHoaDon, ma, soLuong);
        }

        public static HoaDon LayThongTinHoaDon(string soHoaDon)
        {
            return DAO.HoaDonDAO.LayThongTinHoaDon(soHoaDon);
        }
    }
}
