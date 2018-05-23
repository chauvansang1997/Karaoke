using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {
        private string maMonAn;
        private string tenMonAn;
        private uint gia;
        private string tenHinhAnh;
        private string loaiMonAn;
        public string MaMonAn
        {
            get
            {
                return maMonAn;
            }

            set
            {
                maMonAn = value;
            }
        }

        public string TenMonAn
        {
            get
            {
                return tenMonAn;
            }

            set
            {
                tenMonAn = value;
            }
        }

        public uint Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public string TenHinhAnh
        {
            get
            {
                return tenHinhAnh;
            }

            set
            {
                tenHinhAnh = value;
            }
        }

        public string LoaiMonAn { get => loaiMonAn; set => loaiMonAn = value; }
    }
}
