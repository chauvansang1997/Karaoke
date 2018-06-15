using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamBUS() { }
        public static List<HangHoa> XemSanPham(string nhaCungCap, int loai, int pageNumber, int pageSize)
        {
            return DAO.SanPhamDAO.XemSanPham(nhaCungCap, loai, pageNumber, pageSize);
        }
        public static PhieuNhapHang LapPhieuNhap(string nhaCungCap, string maNhanVien)
        {
            return DAO.SanPhamDAO.LapPhieuNhap(nhaCungCap, maNhanVien);
        }
        public static bool NhapHangSanPham(string soPhieuNhap, List<string> listMa, List<string> listSoLuong, uint thanhTien)
        {
            return DAO.SanPhamDAO.NhapHang(soPhieuNhap, listMa, listSoLuong, thanhTien);
        }
        public static List<PhieuNhapHang> XemPhieuNhapHang(int loai, int pageNumber, int pageSize)
        {
            return DAO.SanPhamDAO.XemPhieuNhapHang(loai, pageNumber, pageSize);
        }
        public static bool GiaoSanPham(string soPhieuNhap, string nguoiGiao)
        {
            return DAO.SanPhamDAO.GiaoHang(soPhieuNhap, nguoiGiao);
        }
        public static int DemPhieuNhapSanPham(int loai)
        {
            return DAO.SanPhamDAO.DemPhieuNhapSanPham(loai);
        }
        public static DataTable XemChiTietPhieuNhapSanPhamTable(string soPhieuDat)
        {
            return DAO.SanPhamDAO.XemChiTietPhieuNhapSanPhamTable(soPhieuDat);
        }

        public static List<HangHoaDataSource> XemChiTietPhieuNhapSanPham(string soPhieuDat)
        {
            return DAO.SanPhamDAO.XemChiTietPhieuNhapSanPham(soPhieuDat);
        }
    }
}

