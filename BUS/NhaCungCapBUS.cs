using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public class NhaCungCapBUS
	{
		public static bool ThemNCC(DTO.NhaCungCap ncc)
		{
			return DAO.QuanLyNCC.NhaCungCapDAO.ThemNCC(ncc);
		}

		public static bool CapNhatNCC(DTO.NhaCungCap ncc)
		{
			return DAO.QuanLyNCC.NhaCungCapDAO.CapNhatNCC(ncc);
		}

		public static bool XoaNCC(DTO.NhaCungCap ncc)
		{
			return DAO.QuanLyNCC.NhaCungCapDAO.XoaNCC(ncc);
		}

		public static DataTable LoadNCC()
		{
			return DAO.QuanLyNCC.NhaCungCapDAO.LoadNCC();
		}
	}
}
