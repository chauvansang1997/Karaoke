using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public static class TaiKhoanBUS
    {
        public static bool TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            return DAO.QuanLyNhanVien.TaiKhoanDAO.TaoTaiKhoan(taiKhoan);
        }

        public static bool KiemTraTaiKhoan(string tentk)
        {
            return DAO.QuanLyNhanVien.TaiKhoanDAO.KiemTraTaiKhoan(tentk);
        }

        public static bool XoaTaiKhoan(string tentk)
        {
            return DAO.QuanLyNhanVien.TaiKhoanDAO.XoaTaiKhoan(tentk);
        }
    }
}
