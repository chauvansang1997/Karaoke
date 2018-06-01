using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GoiMonDataSource
    {


        public string Ten { get ; set ; }
        public string Gia { get ; set ; }
        public string Soluong { get; set; }
        public string Thanhtien { get; set; }
        //Loại món ăn 0, loại sản phẩm 1
        public string Loai { get; set ; }
        public int IndexDict { get; set; }
        public string Ma { get; set; }
        public int IndexList { get; set; }
        //Mã loại theo kết hợp của bảng sản phẩm và bảng món ăn
        public string MaLoaiHangHoa { get; set; }
        //Tên loại theo kết hợp của bảng sản phẩm và bảng món ăn
        public string TenLoaiHangHoa { get; set; }

        
    }
}
