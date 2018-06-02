using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private string soDienThoai;
        private string diaChi;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public NhanVien(string hoTen,string maNV,string soDienThoai,string diaChi)
        {
            this.HoTen = hoTen;
            this.MaNV = maNV;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
        }
    }
}
