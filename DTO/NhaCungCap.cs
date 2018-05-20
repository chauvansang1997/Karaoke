using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string ten;
        private string ma;
        private string soDienThoai;
        private string diaChi;

        public string Ten { get => ten; set => ten = value; }
        public string Ma { get => ma; set => ma = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
