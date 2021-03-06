﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

		public static bool ThemKhachHangThanhVien(KhachHang khachHang)
		{
			return DAO.KhachHangDAO.ThemKhachHangThanhVien(khachHang);
		}

		public static bool CapNhatKhachHang(KhachHang khachHang)
		{
			return DAO.KhachHangDAO.CapNhatKhachHang(khachHang);
		}

		public static bool XoaKhachHang(KhachHang khachHang)
		{
			return DAO.KhachHangDAO.XoaKhachHang(khachHang);
		}

		public static DataTable XemThongTinKhachHang(KhachHang khachHang)
		{
			return DAO.KhachHangDAO.XemThongTinKhachHang(khachHang);
		}


    }

}
