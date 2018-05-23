using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ThucAn
    {
        private String ten;
        private List<NguyenLieu> listNguyenLieu;

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

        public List<NguyenLieu> ListNguyenLieu
        {
            get
            {
                return listNguyenLieu;
            }

            set
            {
                listNguyenLieu = value;
            }
        }
    }
}
