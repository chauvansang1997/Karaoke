using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class TaiKhoan
    {
        private string tenDangNhap;
        private string maKhau;

        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }

        public string MaKhau
        {
            get
            {
                return maKhau;
            }

            set
            {
                maKhau = value;
            }
        }
    }
}
