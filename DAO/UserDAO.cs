using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAO
{
    public class UserDAO
    {
        public static bool DangNhap()
        {
            string username = User.UserName;
            string password = User.Password;

            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            var user = from tk in karaokeDataContext.TAIKHOANs
                       join nv in karaokeDataContext.NHANVIENs on tk.TENTK equals nv.TENTK
                       where tk.TENTK == username && tk.MATKHAU == MaHoaMatKhau.maHoa(password)
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
}
