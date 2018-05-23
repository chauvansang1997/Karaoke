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

        public string NhaCungCap
        {
            get
            {
                return nhaCungCap;
            }

            set
            {
                nhaCungCap = value;
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

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }

        public decimal Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public int SoLuongTon
        {
            get
            {
                return soLuongTon;
            }

            set
            {
                soLuongTon = value;
            }
        }

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
    }
}
