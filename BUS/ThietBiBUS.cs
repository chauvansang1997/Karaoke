using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public static class ThietBiBUS
    {
        public static bool ThemThietBi(ThietBi thietBi)
        {
            return DAO.ThietBiDAO.ThemThietBi(thietBi);
        }
        public static bool SuaThietBi(ThietBi thietBi)
        {
            return DAO.ThietBiDAO.SuaThietBi(thietBi);
        }

        public static bool CapNhatThietBi(ThietBi thietBi)
        {
            return DAO.ThietBiDAO.CapNhatThietBi(thietBi);
        }

        public static bool XoaThietBi(ThietBi thietBi)
        {
            return DAO.ThietBiDAO.XoaThietBi(thietBi);
        }

        public static DataTable LayMaNCC()
        {
            return DAO.ThietBiDAO.LayMaNCC();
        }

        public static DataTable XemThietBiTable(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize)
        {
            return DAO.ThietBiDAO.LoadThietBi(tenThietBi, maNhaCungCap, pageNumber, pageSize);
        }

        public static int DemThietBi(string tenThietBi, string maNhaCungCap)
        {
            return DAO.ThietBiDAO.DemThietBi(tenThietBi, maNhaCungCap);
        }

        public static List<PhieuNhapHang> XemPhieuNhapHang(int loai, int pageNumber, int pageSize)
        {
            return DAO.ThietBiDAO.XemPhieuNhapHang(loai, pageNumber, pageSize);
        }
        public static int DemPhieuNhapHang(int loai)
        {
            return DAO.ThietBiDAO.DemPhieuNhapHang(loai);
        }
        public static PhieuNhapHang LapPhieuNhap(string nhaCungCap, string maNhanVien)
        {
            return DAO.ThietBiDAO.LapPhieuNhap(nhaCungCap, maNhanVien);
        }

        public static List<ThietBi> XemThietBi(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize)
        {
            return DAO.ThietBiDAO.XemThietBi(tenThietBi, maNhaCungCap, pageNumber, pageSize);
        }
        public static int DemThietBiSuDung(string tenThietBi, string maNhaCungCap, List<string> exceptList = null)
        {
            return DAO.ThietBiDAO.DemThietBiSuDung(tenThietBi, maNhaCungCap, exceptList);
        }
        public static DataTable XemThietBiSuDung(string tenThietBi, string maNhaCungCap, int pageNumber, int pageSize, List<string> exceptList = null)
        {
            return DAO.ThietBiDAO.XemThietBiSuDung( tenThietBi,  maNhaCungCap,  pageNumber,  pageSize, exceptList);
        }

        public static List<PhieuNhapHangDataSource> XemChiTietPhieuNhapThietBi(string soPhieuDat)
        {
            return DAO.ThietBiDAO.XemChiTietPhieuNhapThietBi(soPhieuDat);
        }
        public static bool NhapHang(string soPhieuNhap, List<string> listMa, List<string> listSoLuong, uint thanhTien)
        {
            return DAO.ThietBiDAO.NhapHang(soPhieuNhap, listMa, listSoLuong, thanhTien);
        }
        public static DataTable XemChiTietPhieuNhapThietBiTable(string soPhieuDat)
        {
            return DAO.ThietBiDAO.XemChiTietPhieuNhapThietBiTable(soPhieuDat);
        }
        public static bool GiaoHang(string soPhieuNhap, string nguoiGiao)
        {
            return DAO.ThietBiDAO.GiaoHang(soPhieuNhap, nguoiGiao);
        }
        public static bool ThemSuDungThietBi(string lyDo, List<string> listMa, List<string> listSoLuong)
        {
            return DAO.ThietBiDAO.ThemSuDungThietBi(lyDo, listMa, listSoLuong);
        }
        public static bool CapNhatSuDungThietBi(string maSuDung, string lyDo, List<string> listMa, List<string> listSoLuong)
        {
            return DAO.ThietBiDAO.CapNhatSuDungThietBi(maSuDung, lyDo, listMa, listSoLuong);
        }
        public static DataTable XemSuDungThietBi(string lyDo, string tenThietBi, int pageNumber, int pageSize)
        {
            return DAO.ThietBiDAO.XemSuDungThietBi(lyDo,  tenThietBi,  pageNumber,  pageSize);
        }
        public static int DemSuDungThietBi(string lyDo, string tenThietBi)
        {
            return DAO.ThietBiDAO.DemSuDungThietBi(lyDo, tenThietBi);
        }
        public static List<ThietBiDataSource> XemChiTietSuDungThietBi(string maSuDung)
        {
            return DAO.ThietBiDAO.XemChiTietSuDungThietBi(maSuDung);
        }
        public static bool KiemTraTonThietBi(string maThietBi, int soLuong, int soLuongCu)
        {
            return DAO.ThietBiDAO.KiemTraTonThietBi(maThietBi,  soLuong,  soLuongCu);
        }
    }
}
