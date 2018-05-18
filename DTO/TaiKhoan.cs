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

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MaKhau { get => maKhau; set => maKhau = value; }
    }
}
