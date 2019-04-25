using DTO;
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

		public static bool XoaNhaCungCap(string maNhaCungCap)
		{
			return DAO.QuanLyNCC.NhaCungCapDAO.XoaNCC(maNhaCungCap);
		}

        public static DataTable XemNhaCungCap(string tenNhaCungCap, int pageNumber, int pageSize)
        {
			return DAO.QuanLyNCC.NhaCungCapDAO.XemNhaCungCap(tenNhaCungCap, pageNumber,pageSize);
		}
        private NhaCungCapBUS() { }
        public static List<NhaCungCap> XemNhaCungCap()
        {
            return DAO.QuanLyNCC.NhaCungCapDAO.XemNhaCungCap();
        }
        public static int DemNhaCungCap(string tenNhaCungCap)
        {
            return DAO.QuanLyNCC.NhaCungCapDAO.DemNhaCungCap(tenNhaCungCap);

        }
    }
}
