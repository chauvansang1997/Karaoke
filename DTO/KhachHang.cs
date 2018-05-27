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
    }
}
        

