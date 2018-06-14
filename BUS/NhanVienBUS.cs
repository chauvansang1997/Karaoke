using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public static class NhanVienBUS
    {
        public static bool ThemNhanVien(NhanVien nv, string macv, string tentk)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.ThemNhanVien(nv, macv, tentk);
        }

        public static bool CapNhatNhanVien(NhanVien nv, string macv)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.CapNhatNhanVien(nv, macv);
        }

        public static bool XoaNhanVien(string manv, string tentk)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.XoaNhanVien(manv, tentk);
        }

        public static bool KiemTraNhanVien(string manv)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.KiemTraNhanVien(manv);
        }

        public static DataTable LoadNhanVien()
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.LoadNhanVien();
        }

        public static DataTable TraCuuNhanVien(NhanVien nv, string macv, string tentk)
        {
            return DAO.QuanLyNhanVien.NhanVienDAO.TraCuuNhanVien(nv, macv, tentk);
        }
    }
}
