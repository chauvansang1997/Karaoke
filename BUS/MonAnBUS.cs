using DAO.QuanLyHangHoa;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class MonAnBUS
    {
        public static bool ThemMonAn(MonAn monAn,List<string> listMaNguyenLieu)
        {
            string listNguyenLieu = String.Join("|", listMaNguyenLieu);
            return MonAnDAO.ThemMonAn(monAn, listNguyenLieu);
        }
        public static List<MonAn> XemMonAn(string tenMonAn,string loaiMonAn,uint donGia=0)
        {
            return MonAnDAO.XemMonAn(tenMonAn, loaiMonAn, donGia);
        }
        public static List<MonAn> XemMonAn(string tenMonAn, string loaiMonAn, int pageNumber,int pageSize,uint donGia = 0)
        {
            return MonAnDAO.XemMonAn(tenMonAn, loaiMonAn,pageNumber,pageSize, donGia);
        }
        public static int DemMonAn(string tenMonAn, string loaiMonAn, uint donGia = 0)
        {
            return MonAnDAO.DemMonAn(tenMonAn, loaiMonAn, donGia);
        }
    }
}
