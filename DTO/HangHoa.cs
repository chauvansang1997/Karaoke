using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa
    {
        private string ten;
        private string ma;
        private string tenHinhAnh;
        private string loaiChiTiet;
        private LoaiHangHoa loaiHangHoa;
        private string loai;
        private uint gia;
        private string donViTinh;
        private int donGiaNhap;
        private int soLuongToiThieu;
        public int SoLuongToiThieu
        {
            get
            {
                return soLuongToiThieu;
            }

            set
            {
                soLuongToiThieu = value;
            }
        }
        public int DonGiaNhap
        {
            get
            {
                return donGiaNhap;
            }

            set
            {
                donGiaNhap = value;
            }
        }
        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }
        public string Loai
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
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

        public string LoaiChiTiet
        {
            get
            {
                return loaiChiTiet;
            }

            set
            {
                loaiChiTiet = value;
            }
        }

        public LoaiHangHoa LoaiHangHoa
        {
            get
            {
                return loaiHangHoa;
            }

            set
            {
                loaiHangHoa = value;
            }
        }

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
    }
}
