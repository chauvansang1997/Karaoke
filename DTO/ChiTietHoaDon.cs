using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class ChiTietHoaDon 
    {
        public enum Loai
        {
            MonAn = 0,
            Sanpham = 1
        }
        public string Ma { get ; set ; }
        public int Soluong { get; set; }

        public Loai LoaiHangHoa{ get; set; }
    }
}
