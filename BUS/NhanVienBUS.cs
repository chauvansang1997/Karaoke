using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public static class NhanVienBUS
    {
        public static bool ThemNhanVien(NhanVien nv, ChucVu cv, TaiKhoan tk)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.ThemNhanVien(nv, cv, tk);
        }

        public static bool CapNhatNhanVien(NhanVien nv, ChucVu cv, TaiKhoan tk)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.CapNhatNhanVien(nv, cv);
        }

        public static bool XoaNhanVien(NhanVien nv)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.XoaNhanVien(nv);
        }

        public static bool KiemTraNhanVien(NhanVien nv)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.KiemTraNhanVien(nv.MaNV);
        }
    }
}
