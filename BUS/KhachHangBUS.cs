using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class KhachHangBUS
    {
        public static bool KiemTraKhachHang(string tenKhachHang,string soDienThoai)
        {
            return DAO.KhachHangDAO.KiemTraKhachHang(tenKhachHang, soDienThoai);
        }
    }
}
