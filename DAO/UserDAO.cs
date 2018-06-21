using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
	public class UserDAO
	{
		public static bool DangNhap()
		{
			int row = 0;
			string username = User.UserName;
			string password = User.Password;
			string query = "EXEC usp_DangNhap @username,@password";
			DataTable data = new DataTable();
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@username",System.Data.SqlDbType.VarChar){IsNullable=false,Value=username},
				new  SqlParameter("@password",System.Data.SqlDbType.VarChar){IsNullable=false,Value=password},
			};
			try
			{
				data = Dataprovider.ExcuteQuery(query, parameters.ToArray());
			}
			catch(Exception ex)
			{
				Utility.Log(ex);
			}
			if (data.Rows.Count > 0)
			{
				User.NhanVien = new NhanVien();
				User.NhanVien.HoTen = data.Rows[0].ItemArray[0].ToString();
				User.UserName = data.Rows[0].ItemArray[1].ToString();
				User.Password = data.Rows[0].ItemArray[2].ToString();
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
