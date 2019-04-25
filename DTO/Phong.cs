using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum TrangThai
    {
        DaDat,
        KhongDat
    }
    public class Phong
    {
        public string Ten{ get; set; }

        public int TinhTrang { get; set; }

        public uint Gia { get; set; }
        public string TenLoai  { get; set; }

        public KhachHang GetKhachHang { get; set; }
    }
}
