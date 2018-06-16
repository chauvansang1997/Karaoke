using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MonAnDataSource
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Gia { get; set; }
        //Loại món ăn 0, loại sản phẩm 1
    
        //Mã loại theo kết hợp của bảng sản phẩm và bảng món ăn
        public string MaLoaiHangHoa { get; set; }
        //Tên loại theo kết hợp của bảng sản phẩm và bảng món ăn
        public string TenLoaiHangHoa { get; set; }

        public string AnhMinhHoa { get; set; }
    }
}
