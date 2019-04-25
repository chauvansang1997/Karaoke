using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class User2
    {
        private  NhanVien nhanVien;
        private  string userName;
        private  string password;
        private  string tenNhanVien;
        private  string cMND;

        private  string soDienThoai;

        private  string diaChi;
        public  string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public  string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public  string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }

            set
            {
                tenNhanVien = value;
            }
        }

        public  string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
            }
        }

        public  string SoDienThoai
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

        public  string DiaChi
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

        public  NhanVien NhanVien
        {
            get
            {
                return nhanVien;
            }


            set
            {
                nhanVien = value;
            }
        }
    }
}
