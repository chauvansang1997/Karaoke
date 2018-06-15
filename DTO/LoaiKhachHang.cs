using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
	public class LoaiKhachHang
	{
		private int maLoaiKH;
		private string tenLoaiKH;
		private float mucKM;

		public int MaLoaiKH
		{
			get
			{
				return maLoaiKH;
			}
			set
			{
				maLoaiKH = value;
			}
		}

		public string TenLoaiKH
		{
			get
			{
				return tenLoaiKH;
			}
			set
			{
				tenLoaiKH = value;
			}
		}

		public float MucKM
		{
			get
			{
				return mucKM;
			}
			set
			{
				mucKM = value;
			}
		}
	}
}
