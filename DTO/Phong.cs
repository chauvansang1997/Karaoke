using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private string ten;
        private string maLoai;
        private uint gia;
        private string status;
        private string ma;
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

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
        public string MaLoai
        {
            get
            {
                return maLoai;
            }

            set
            {
                maLoai = value;
            }
        }

    }
}
