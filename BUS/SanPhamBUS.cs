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
            return DAO.SanPhamDAO.DemPhieuNhapHang(loai);
        }
        public static DataTable XemChiTietPhieuNhapSanPhamTable(string soPhieuDat)
        {
            return DAO.SanPhamDAO.XemChiTietPhieuNhapSanPhamTable(soPhieuDat);
        }

        public static List<HangHoaDataSource> XemChiTietPhieuNhapSanPham(string soPhieuDat)
        {
            return DAO.SanPhamDAO.XemChiTietPhieuNhapSanPham(soPhieuDat);
        }
        public static List<DonViTinh> XemDonViTinh()
        {
            return DAO.SanPhamDAO.XemDonViTinh();
        }
        public static DataTable XemSanPhamTable(string nhaCungCap, int loai,string ten, int pageNumber, int pageSize)
        {
            return DAO.SanPhamDAO.XemSanPhamTable(nhaCungCap, loai, ten,pageNumber, pageSize);
        }

        public static int DemSanPham(string nhaCungCap, int loai, string ten)
        {
            return DAO.SanPhamDAO.DemSanPham(nhaCungCap, loai, ten);
        }

        public static List<LoaiHangHoa> XemLoai()
        {
            return DAO.SanPhamDAO.XemLoai();
        }
        public static bool ThemSanPham(SanPham sanPham)
        {
            return DAO.SanPhamDAO.ThemSanPham(sanPham);
        }
        public static bool CapNhatSanPham(SanPham sanPham)
        {
            return DAO.SanPhamDAO.CapNhatSanPham(sanPham);
        }
    }
}

