using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public static class PhanCongBUS
	{
		public static DataTable LoadPhanCong()
		{
			return DAO.PhanCong.PhanCongDAO.LoadPhanCong();
		}
		public static DataTable SelectAll(String query)
		{
			return DAO.PhanCong.PhanCongDAO.SelectAll(query);
		}
	}
}
