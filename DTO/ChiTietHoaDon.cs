using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
<<<<<<< HEAD
    public class ChiTietHoaDon 
    {

        public string Ma { get ; set ; }
        public uint Soluong { get; set; }
=======
    
    public class ChiTietHoaDon 
    {
        public enum Loai
        {
            MonAn = 0,
            Sanham = 1
        }
        public string Ma { get ; set ; }
        public int Soluong { get; set; }

        public Loai LoaiHangHoa{ get; set; }
>>>>>>> 684ccd889c3e5ec955668cac43100cb4812b2990
    }
}
