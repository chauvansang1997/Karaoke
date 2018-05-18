using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MonAn
    {
        private string maMonAn;
        private string tenMonAn;
        private string gia;
        private string tenHinhAnh;

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string Gia { get => gia; set => gia = value; }
        public string TenHinhAnh { get => tenHinhAnh; set => tenHinhAnh = value; }
    }
}
