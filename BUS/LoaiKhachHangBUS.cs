using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public static class LoaiKhachHangBUS
	{

		public static DataTable LoadLoaiKH()
		{
		    return DAO.LoaiKhachHangDAO.LoadLoaiKH();
		}

        public static bool ThemLoaiKH(LoaiKhachHang loaiKhach)
		{
			return DAO.LoaiKhachHangDAO.ThemLoaiKH(loaiKhach);
		}

		public static bool CapNhatLoaiKH(LoaiKhachHang loaiKhach)
		{
			return DAO.LoaiKhachHangDAO.CapNhatLoaiKH(loaiKhach);
		}

		public static bool XoaLoaiKH(LoaiKhachHang loaiKhach)
		{
			return DAO.LoaiKhachHangDAO.XoaLoaiKH(loaiKhach);
		}

        public static DataTable XemLoaiKhachHang(List<int> danhSachLoaiTru)
        {
            return DAO.LoaiKhachHangDAO.XemLoaiKhachHang(danhSachLoaiTru);
        }

    }
}
