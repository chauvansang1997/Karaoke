using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuNhapDataSource
    {
        public string SoPhieuNhap { get; set; }
        public string MaNhanVien { get; set; }
        public string Soluong { get; set; }
        public string Thanhtien { get; set; }
        //Loại món ăn 0, loại sản phẩm 1
        public string Loai { get; set; }
        public int IndexDict { get; set; }
        public string Ma { get; set; }
        public int IndexList { get; set; }
        //Mã loại theo kết hợp của bảng sản phẩm và bảng món ăn
        public string MaLoaiHangHoa { get; set; }
        //Tên loại theo kết hợp của bảng sản phẩm và bảng món ăn
        public string TenLoaiHangHoa { get; set; }

        public string AnhMinhHoa { get; set; }
    }
}
