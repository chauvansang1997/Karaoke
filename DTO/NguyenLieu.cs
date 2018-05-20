using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu
    {
        private string ten;
        private string ma;
        private string nhaCungCap;
        private string loai;
        private string donViTinh;
        private decimal dongia;
        private int soLuongTon;
        private int soLuongToiThieu;

        public string Ten { get => ten; set => ten = value; }
        public string Ma { get => ma; set => ma = value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }
        public string Loai { get => loai; set => loai = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public decimal Dongia { get => dongia; set => dongia = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public int SoLuongToiThieu { get => soLuongToiThieu; set => soLuongToiThieu = value; }


    }
}
