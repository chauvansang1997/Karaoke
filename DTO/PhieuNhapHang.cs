using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuNhapHang
    {
        private string soPhieu;
        private string maNhanVien;
        private string ngayDat;
        private string ngayGiao;
        private uint thanhTien;
        private string nguoiGiao;
        private string tenNhanVien;
        private string soDienThoai;

        private string maNhaCungCap;
        private string tenNhaCungCap;
   
        public string SoPhieu
        {
            get
            {
                return soPhieu;
            }

            set
            {
                soPhieu = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }
        public string TenNhanVien { get { return tenNhanVien; } set { tenNhanVien = value; } }
        public string SoDienThoai { get { return soDienThoai; } set { soDienThoai = value; } }
        public string NgayDat
        {
            get
            {
                return ngayDat;
            }

            set
            {
                ngayDat = value;
            }
        }
        public string NgayGiao
        {
            get
            {
                return ngayGiao;
            }

            set
            {
                ngayGiao = value;
            }
        }
        public uint ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }
        public string NguoiGiao
        {
            get
            {
                return nguoiGiao;
            }

            set
            {
                nguoiGiao = value;
            }
        }

        public string TenNhaCungCap
        {
            get
            {
                return tenNhaCungCap;
            }

            set
            {
                tenNhaCungCap = value;
            }
        }
        public string MaNhaCungCap
        {
            get
            {
                return maNhaCungCap;
            }

            set
            {
                maNhaCungCap = value;
            }
        }
    }
}
