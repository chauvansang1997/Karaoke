using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ThietBi
    {
        private string tenThietBi;
        private string maThietBi;
        private string gia;

        public string TenThietBi
        {
            get
            {
                return tenThietBi;
            }

            set
            {
                tenThietBi = value;
            }
        }

        public string MaThietBi
        {
            get
            {
                return maThietBi;
            }

            set
            {
                maThietBi = value;
            }
        }

        public string Gia
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
    }
}
