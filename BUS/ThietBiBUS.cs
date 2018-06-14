using DTO;
using System;
using System.Collections.Generic;
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
	}
}
