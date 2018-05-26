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
    }
}
