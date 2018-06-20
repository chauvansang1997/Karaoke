using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class KhuyenMaiBUS
    {
        private KhuyenMaiBUS() { }
        public static bool ThemkhuyenMai(KhuyenMai khuyenMai,List<int> listLoaiKhachHang,List<float> listMucKhuyenMai)
        {
            return DAO.KhuyenMaiDAO.ThemkhuyenMai(khuyenMai,listLoaiKhachHang,listMucKhuyenMai);
        }
        public static bool CapNhatkhuyenMai(KhuyenMai khuyenMai, List<int> listLoaiKhachHang, List<float> listMucKhuyenMai)
        {
            return DAO.KhuyenMaiDAO.CapNhatkhuyenMai(khuyenMai, listLoaiKhachHang, listMucKhuyenMai);
        }
        public static List<KhuyenMai> XemKhuyenMai(string tenKhuyenMai, int loaiKhachHang, int pageNumber, int pageSize)
        {
            return DAO.KhuyenMaiDAO.XemKhuyenMai(tenKhuyenMai,  loaiKhachHang ,pageNumber, pageSize);
        }
        public static int DemKhuyenMai(string tenKhuyenMai, int loaiKhachHang)
        {
            return DAO.KhuyenMaiDAO.DemKhuyenMai(tenKhuyenMai, loaiKhachHang);
        }
        public static DataTable XemChiTiet(int maKhuyenMai, List<int> listMaLoaiKhachHang)
        {
            return DAO.KhuyenMaiDAO.XemChiTiet(maKhuyenMai, listMaLoaiKhachHang);
        }
        public static bool XoaKhuyenMai(int maKhuyenMai)
        {
            return DAO.KhuyenMaiDAO.XoaKhuyenMai(maKhuyenMai);
        }
    }
}
