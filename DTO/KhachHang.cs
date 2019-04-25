using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string name;
        private string phoneNumber;
        private string address;
        private string id;
		private int loaiKH;
		private string sdt;
        private int tienTichLuy;

        public string Ten
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string SoDT
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Ma
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

		public int LoaiKH
		{
			get
			{
				return loaiKH;
			}
			set
			{
				loaiKH = value;
			}
		}

		public string SDT
		{
			get
			{
				return sdt;
			}
			set
			{
				sdt = value;
			}
		}

        public int TienTichLuy { 
            get
            {
                return tienTichLuy;
            }
            set
            {
                tienTichLuy = value;
            }
        }
    }
}
        

