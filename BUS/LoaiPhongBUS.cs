using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public static class LoaiPhongBUS
    {
        public static bool ThemLoaiPhong(LoaiPhong loaiPhong)
        {
            return DAO.LoaiPhongDAO.ThemLoaiPhong(loaiPhong);
        }
        public static bool CapNhatLoaiPhong(LoaiPhong loaiPhong)
        {
            return DAO.LoaiPhongDAO.CapNhatLoaiPhong(loaiPhong);
        }

        public static bool KiemTraLoaiPhong(string tenLoaiPhong)
        {
            return DAO.LoaiPhongDAO.KiemTraLoaiPhong(tenLoaiPhong);
        }

        public static object TraCuuLoaiPhong(string tuKhoa)
        {
            return DAO.LoaiPhongDAO.TraCuuLoaiPhong(tuKhoa);
        }

        public static object XemLoaiPhong()
        {
            return DAO.LoaiPhongDAO.XemLoaiPhong();
        }

        public static bool XoaLoaiPhong(string maLoaiPhong)
        {
            return DAO.LoaiPhongDAO.XoaLoaiPhong(maLoaiPhong);
        }
    }
}