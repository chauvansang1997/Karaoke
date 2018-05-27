using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class PhongBUS
    {
        public static List<Phong> XemPhong(int trangThai,int pageSize,int pageNumber)
        {
            return DAO.PhongDAO.XemPhong(trangThai, pageSize, pageNumber);
        }
        public static int DemPhong(int trangThai)
        {
            return DAO.PhongDAO.DemPhong(trangThai);
        }

        public static bool GhiNhanDatPhong(KhachHang khachHang, string maPhong, string maNV)
        {
            return DAO.PhongDAO.GhiNhanDatPhong(khachHang, maPhong, maNV, 
                DAO.KhachHangDAO.KiemTraKhachHang(khachHang.Ten, khachHang.SoDT));
        }
    }
}
