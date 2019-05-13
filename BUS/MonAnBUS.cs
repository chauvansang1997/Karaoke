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
        public static bool ThemMonAn(MonAn monAn,List<string> listMaNguyenLieu, List<string> listSoLuongNL)
        {
            //string listNguyenLieu = String.Join("|", listMaNguyenLieu);
            //string listSoLuong = String.Join("|", listSoLuongNL);
            return MonAnDAO.ThemMonAn(monAn, listMaNguyenLieu, listSoLuongNL);
        }
        public static bool SuaMonAn(MonAn monAn, List<string> listMaNguyenLieu, List<string> listSoLuongNL)
        {
            //string listNguyenLieu = String.Join("|", listMaNguyenLieu);
            //string listSoLuong = String.Join("|", listSoLuongNL);
            return MonAnDAO.SuaMonAn(monAn, listMaNguyenLieu, listSoLuongNL);
        }
        public static bool CapNhatMonAn(MonAn monAn, List<string> listMaNguyenLieu)
        {
            string listNguyenLieu = String.Join("|", listMaNguyenLieu);
            return MonAnDAO.CapNhatMonAn(monAn, listNguyenLieu);
        }
        public static List<MonAn> XemMonAn(string tenMonAn,int loaiMonAn,uint donGia=0)
        {
            return MonAnDAO.XemMonAn(tenMonAn, loaiMonAn, donGia);
        }
        public static List<MonAn> XemMonAn(string tenMonAn, int loaiMonAn, int pageNumber,int pageSize,uint donGia = 0)
        {
            return MonAnDAO.XemMonAn(tenMonAn, loaiMonAn,pageNumber,pageSize, donGia);
        }
        public static int DemMonAn(string tenMonAn, string loaiMonAn, uint donGia = 0)
        {
            return MonAnDAO.DemMonAn(tenMonAn, loaiMonAn, donGia);
        }
        public static List<LoaiMon> XemLoaiMon(string type)
        {
            return MonAnDAO.XemLoaiMon(type);
        }

        public static List<NguyenLieuMADataSource> XemNguyenLieuMonAn(string maMonAn)
        {
            return MonAnDAO.XemNguyenLieuMonAn(maMonAn);
        }
        public static List<MonAnDataSource> XemMonAnDataSource(string tenMonAn, int loaiMonAn, int pageNumber, int pageSize)
        {
            return MonAnDAO.XemMonAnDataSource(tenMonAn,  loaiMonAn,  pageNumber,  pageSize);
        }
    }
}
