using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
	public class Luong
	{
		private String maNV, tenNV,thangLuong, soTien;

		public string MaNV
		{
			get
			{
				return maNV;
			}

			set
			{
				maNV = value;
			}
		}

		public string ThangLuong
		{
			get
			{
				return thangLuong;
			}

			set
			{
				thangLuong = value;
			}
		}

		public string SoTien
		{
			get
			{
				return soTien;
			}
			set
			{
				soTien = value;
			}
		}

		public string TenNV
		{
			get
			{
				return tenNV;
			}
			set
			{
				tenNV = value;
			}
		}

	}
}
