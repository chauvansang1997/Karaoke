using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class User
    {
        private static NhanVien nhanVien;
        private static string userName;
        private static string password;
        private static string tenNhanVien;
        private static string cMND;

        private static string soDienThoai;

        private static string diaChi;
        public static string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public static string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public static string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }

            set
            {
                tenNhanVien = value;
            }
        }

        public static string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
            }
        }

        public static string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public static string DiaChi
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

        public static NhanVien NhanVien
        {
            get
            {
                return nhanVien;
            }


            set
            {
                nhanVien = value;
            }
        }
    }
}
