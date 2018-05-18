using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien
    {
        private string hoTen;
        private string maNV;
        private string soDienThoai;
        private string diaChi;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public NhanVien(string hoTen,string maNV,string soDienThoai,string diaChi)
        {
            this.hoTen = hoTen;
            this.maNV = maNV;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
        }
    }
}
