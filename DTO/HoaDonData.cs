using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonData
    {
        public string SoHoaDon { get; set; }
        public string GioVao { get; set; }
        public string GioRa { get; set; }
        public float GiamGia { get; set; }
        public string MaPhong { get; set; }
        public string ThanhTien { get; set; }
        public string MaKhachHang { get; set; }

        public string SoDienThoai { get; set; }

        public int TienDatCoc { get; set; }

        public string TinhTrang { get; set; }
        public int TienGio { get; set; }
    }
}
