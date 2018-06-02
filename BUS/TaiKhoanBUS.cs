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

        public static bool XoaTaiKhoan(TaiKhoan taiKhoan)
        {
            return DAO.QuanLyNhanVien.TaiKhoanDAO.XoaTaiKhoan(taiKhoan);
        }
    }
}
