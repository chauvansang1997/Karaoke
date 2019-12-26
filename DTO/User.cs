using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class User
    {
        private static string diaChi;
        public static string UserName { get; set; }

        public static string Password { get; set; }

        public static string TenNhanVien { get; set; }

        public static string CMND { get; set; }

        public static string SoDienThoai { get; set; }

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

        public static NhanVien NhanVien { get; set; }
    }
}
