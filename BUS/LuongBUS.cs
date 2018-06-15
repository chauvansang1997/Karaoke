using DAO.TinhLuong;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public static class LuongBUS
	{
		public static DataTable XemLuong(String maNV,String thangLuong)
		{
			return LuongDAO.XemLuong(maNV,thangLuong);
		}
		public static DataTable table_Select(String sql)
		{
			return LuongDAO.table_Select(sql);
		}

		public static DataTable XemLuongTong(String maNV,String thangLuong)
		{
			return LuongDAO.XemLuongTong(maNV, thangLuong);
		}

		public static DataTable LoadNhanVienPhanCong()
		{
			return DAO.TinhLuong.LuongDAO.LoadNhanVienPhanCong();
		}

		public static DataTable LoadThangLuongDesc()
		{
			return DAO.TinhLuong.LuongDAO.LoadThangLuongDesc();
		}
	}
}
