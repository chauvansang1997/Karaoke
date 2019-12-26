using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public static class DatPhongBUS
    {
        public static int DemThongTinDatPhong(int thanhToan)
        {
            return DAO.DatPhongDao.DemThongTinDatPhong(thanhToan);
        }
        public static List<ThongTinDatPhong> XemThongTinDatPhong(int thanhToan, int pageSize, int pageNumber)
        {
            return DAO.DatPhongDao.XemThongTinDatPhong(thanhToan, pageSize, pageNumber);
        }
        public static DataTable XemDanhSachDatPhong(int thanhToan,int pageSize, int pageNumber)
        {
            return DAO.DatPhongDao.XemDanhSachDatPhong(thanhToan,pageSize,pageNumber);
        }
        public static int DemDanhSachDatPhong(int thanhToan)
        {
            return DAO.DatPhongDao.DemDanhSachDatPhong(thanhToan);
        }
        public static string LayMaDatPhong(string maPhong)
        {
            return DAO.DatPhongDao.LayMaDatPhong(maPhong);
        }
        public static bool ThanhToanHoaDon(string maDatPhong)
        {
            return DAO.DatPhongDao.ThanhToanHoaDon(maDatPhong);
        }
    }
}
