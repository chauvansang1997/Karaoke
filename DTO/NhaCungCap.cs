using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
		private string maNCC;
		private string tenNCC;
		private string loaiHangCungCap;
		private string sdt;
		private string diaChi;

		public string MaNCC
		{
			get
			{
				return maNCC;
			}

			set
			{
				maNCC = value;
			}
		}

		public string Ten
		{
			get
			{
				return tenNCC;
			}

			set
			{
				tenNCC = value;
			}
		}

		public string LoaiHangCC
		{
			get
			{
				return loaiHangCungCap;
			}

			set
			{
				loaiHangCungCap = value;
			}
		}

		public string SDT
		{
			get
			{
				return sdt;
			}

			set
			{
				sdt = value;
			}
		}

		public string DiaChi
		{
			get
			{
				return diaChi;
			}

			set
			{
				diaChi = value;
			}
		}
	}
}
