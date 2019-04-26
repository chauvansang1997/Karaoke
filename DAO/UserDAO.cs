using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
<<<<<<< HEAD
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
                User.NhanVien.MaNV = data.Rows[0].ItemArray[3].ToString();
                return true;
			}
			else
			{
				return false;
			}
		}
	}
=======
    public class UserDAO
    {
        public static bool DangNhap()
        {
            string username = User.UserName;
            string password = User.Password;


            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            var user = from tk in karaokeDataContext.TAIKHOANs
                       join nv in karaokeDataContext.NHANVIENs on tk.TENTK equals nv.TENTK
                       where tk.TENTK == username && tk.MATKHAU == password
                       select new User2()
                       {
                           Password = tk.MATKHAU,
                           TenNhanVien = nv.TENNV,
                           UserName = tk.TENTK,
                           NhanVien = new NhanVien() { MaNV = nv.MANV }
                       };

            if (user.Count() > 0)
            {
                User.NhanVien = new NhanVien();

                User.NhanVien.HoTen = user.First().TenNhanVien;
                User.UserName = user.First().UserName;
                User.Password = user.First().Password;
                User.NhanVien.MaNV = user.First().NhanVien.MaNV;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
>>>>>>> 684ccd889c3e5ec955668cac43100cb4812b2990
}
