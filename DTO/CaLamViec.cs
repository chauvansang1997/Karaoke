using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
	public class CaLamViec
	{
		int maCa;
		string tenCa;
		DateTime gioBD;
		DateTime gioKT;
		int tienLuong;
		public int MaCa
		{
			get
			{
				return maCa;
			}

			set
			{
				maCa = value;
			}
		}

		public string TenCa
		{
			get
			{
				return tenCa;
			}

			set
			{
				tenCa = value;
			}
		}

		public DateTime GioBD
		{
			get
			{
				return gioBD;
			}

			set
			{
				gioBD = value;
			}
		}

		public DateTime GioKT
		{
			get
			{
				return gioKT;
			}

			set
			{
				gioKT = value;
			}
		}

		public int TienLuong
		{
			get
			{
				return tienLuong;
			}

			set
			{
				tienLuong = value;
			}
		}
	}
}
