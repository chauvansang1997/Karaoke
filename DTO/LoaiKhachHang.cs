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
		private int soTienTichLuy;

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

		public int SoTienTichLuy
		{
			get
			{
				return soTienTichLuy;
			}
			set
			{
				soTienTichLuy = value;
			}
		}
	}
}
