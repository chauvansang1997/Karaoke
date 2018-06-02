using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        private int maChucVu;
        private string tenChucVu;
        private float heSoLuong;

        public int MaChucVu
        {
            get
            {
                return maChucVu;
            }

            set
            {
                maChucVu = value;
            }
        }

        public string TenChucVu 
        {
            get
            {
                return tenChucVu;
            }

            set
            {
                tenChucVu = value;
            }
        }

        public float HeSoLuong
        {
            get
            {
                return heSoLuong;
            }

            set
            {
                heSoLuong = value;
            }
        }
    }
}
