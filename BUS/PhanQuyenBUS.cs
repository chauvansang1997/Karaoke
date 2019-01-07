using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class PhanQuyenBUS
    {
        public static List<Quyen> XemQuyen()
        {
            return DAO.PhanQuyenDAO.XemQuyen();
        }
        public static bool CapNhatPhanQuyen(ChucVu chucVu, Quyen quyen, int bThem)
        {
            return DAO.PhanQuyenDAO.CapNhatPhanQuyen(chucVu, quyen, bThem);
        }
        public static List<PhanQuyen> XemPhanQuyen()
        {
            return DAO.PhanQuyenDAO.XemPhanQuyen();
        }
        public static List<int> LayQuyen(NhanVien nhanVien)
        {
            return DAO.PhanQuyenDAO.LayQuyen(nhanVien);
        }
    }
}
