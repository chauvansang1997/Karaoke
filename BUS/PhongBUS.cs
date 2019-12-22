using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class PhongBUS
    {
        public static bool ThemPhong(Phong phong)
        {
            return DAO.PhongDAO.ThemPhong(phong);
        }
        public static bool CapNhatPhong(Phong phong)
        {
            return DAO.PhongDAO.CapNhatPhong(phong);
        }
        public static List<Phong> XemPhong(int trangThai, int pageSize, int pageNumber)
        {
            return DAO.PhongDAO.XemPhong(trangThai, pageSize, pageNumber);
        }
        public static int DemPhong(int trangThai)
        {
            return DAO.PhongDAO.DemPhong(trangThai);
        }

        public static bool GhiNhanDatPhong(KhachHang khachHang, string maPhong, string maNV)
        {
            return DAO.PhongDAO.GhiNhanDatPhong(khachHang, maPhong, maNV);
        }
        public static bool NhanPhongDatTruoc(string soHoaDon)
        {
            return DAO.PhongDAO.NhanPhongDatTruoc(soHoaDon);
        }

        public static bool ChuyenPhong(string phongHienTai, string phongChuyen)
        {
            return DAO.PhongDAO.ChuyenPhong(phongHienTai, phongChuyen);
        }

        public static DataTable XemLichSuPhong(int pageNumber, int pageSize)
        {
            return DAO.PhongDAO.XemLichSuPhong(pageNumber, pageSize);
        }
        public static int DemLichSuPhong()
        {
            return DAO.PhongDAO.DemLichSuPhong();
        }
        public static DataTable XemLoaiPhong()
        {
            return DAO.PhongDAO.XemLoaiPhong();
        }
        public static DataTable XemPhongQuanLy(string maPhong, int loaiPhong, int pageNumber, int pageSize)
        {
            return DAO.PhongDAO.XemPhongQuanLy(maPhong, loaiPhong, pageNumber, pageSize);
        }
        public static int DemPhongQuanLy(string maPhong, int loaiPhong)
        {
            return DAO.PhongDAO.DemPhongQuanLy(maPhong, loaiPhong);
        }

        public static bool XoaPhong(Phong phong)
        {
            return DAO.PhongDAO.XoaPhong(phong);
        }

        public static object XemPhongTheoLoai(string loaiPhong, string tuKhoa, int pageNumber, int pageSize)
        {
            return DAO.PhongDAO.XemPhongTheoLoai(loaiPhong, tuKhoa, pageNumber, pageSize);
        }
    }
}