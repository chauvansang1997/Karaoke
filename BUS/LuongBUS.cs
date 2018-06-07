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
		public static DataTable XemLuong(String maNV)
		{
			return LuongDAO.XemLuong(maNV);
		}
	}
}
