using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public static class CaLamViecBUS
	{
		public static DataTable LoadCaLamViec()
		{
			return DAO.QuanLyCaTruc.CaLamViecDAO.LoadLamViec();
		}

		public static bool ThemCaLamViec(CaLamViec ca)
		{
			return DAO.QuanLyCaTruc.CaLamViecDAO.ThemCaLamViec(ca);
		}

		public static bool CapNhatCaLamViec(CaLamViec ca)
		{
			return DAO.QuanLyCaTruc.CaLamViecDAO.CapNhatCaLamViec(ca);
		}

		public static bool XoaCaLamViec(CaLamViec ca)
		{
			return DAO.QuanLyCaTruc.CaLamViecDAO.XoaCaLamViec(ca);
		}
	}
}
