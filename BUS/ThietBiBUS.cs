using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public static class ThietBiBUS
	{
		public static bool ThemThietBi(ThietBi thietBi)
		{
			return DAO.ThietBiDAO.ThemThietBi(thietBi);
		}

		public static bool CapNhatThietBi(ThietBi thietBi)
		{
			return DAO.ThietBiDAO.CapNhatThietBi(thietBi);
		}

		public static bool XoaThietBi(ThietBi thietBi)
		{
			return DAO.ThietBiDAO.XoaThietBi(thietBi);
		}

		public static DataTable LayMaNCC()
		{
			return DAO.ThietBiDAO.LayMaNCC();
		}

        public static DataTable XemThietBi(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize)
        {
			return DAO.ThietBiDAO.LoadThietBi(tenThietBi, maNhaCungCap, pageNumber, pageSize);
		}

        public static int DemThietBi(string tenThietBi, string maNhaCungCap)
        {
            return DAO.ThietBiDAO.DemThietBi(tenThietBi, maNhaCungCap);
        }

    }
}
