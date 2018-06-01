using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuDatTiecBUS
    {
        public static List<PhieuDatTiec> XemPhieuDatCho(string maPhong, int pageNumber, int pageSize)
        {
            return DAO.PhieuDatTiecDAO.XemPhieuDatCho(maPhong, pageNumber, pageSize);
        }
        public static int DemMonAn(string maPhong)
        {
            return DAO.PhieuDatTiecDAO.DemPhieuDatTiec(maPhong);
        }
        public static bool GhiNhanDatTiec(KhachHang khachHang, string maPhong, string maNV, DateTime ngayNhanPhong, DateTime ngayDat, DateTime ngayGioKetThuc)
        {
            return DAO.PhieuDatTiecDAO.GhiNhanDatTiec(khachHang, maPhong, maNV, ngayNhanPhong, ngayDat, ngayGioKetThuc);
        }
        public static bool KiemTraPhieuDatTiec(string maPhong, DateTime ngayNhanPhong, DateTime ngayGioKetThuc)
        {
            return DAO.PhieuDatTiecDAO.KiemTraPhieuDatTiec(maPhong, ngayNhanPhong, ngayGioKetThuc);
        }
    }
}
