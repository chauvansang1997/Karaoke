using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
	public static class UserBUS
	{
		public static bool DangNhap()
		{
			return DAO.UserDAO.DangNhap();
		}
	}
}
