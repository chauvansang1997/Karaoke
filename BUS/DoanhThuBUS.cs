using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public class DoanhThuBUS
	{
		public static DataTable LayThangHoaDon()
		{
			return DAO.QuanLyDoanhThu.DoanhThuDAO.LayThangHoaDon();
		}

		public static DataTable LoadDoanhThu(String thangHD)
		{
			return DAO.QuanLyDoanhThu.DoanhThuDAO.LoadDoanhThu(thangHD);
		}
	}
}
