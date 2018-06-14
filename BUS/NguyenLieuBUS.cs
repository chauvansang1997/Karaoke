
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
    public class NguyenLieuBUS
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenNguyenLieu">tên nguyên liệu </param>
        /// <param name="maNhaCungCap">mã nhà cung cấp</param>
        /// <returns></returns>
        public static DataTable TiemKiemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu,int pageNumber, int pageSize,
            List<string> exceptList = null)
        {
            DataTable table = NguyenLieuDAO.XemNguyenLieu(tenNguyenLieu, maNhaCungCap, isXemToiThieu,pageNumber,pageSize).
                Select("", "manl,tennl").CopyToDataTable();
            if (exceptList != null)
            {
                foreach (string item in exceptList)
                {
                    table = table.Select("manl <> '" + item + "'").CopyToDataTable();
                }
            }
            return table;
        }

        public static List<NguyenLieu> TimKiemDanhSachNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu, int pageNumber, int pageSize)
        {
            DataTable table = NguyenLieuDAO.XemNguyenLieu(tenNguyenLieu, maNhaCungCap, isXemToiThieu, pageNumber, pageSize);
            List<NguyenLieu> list = table.AsEnumerable().ToList().ConvertAll(x =>
               new NguyenLieu()
               {
                   Ma = x[0].ToString(),
                   Ten = x[1].ToString(),
                   NhaCungCap  = x[2].ToString(),
                   Dongia = uint.Parse(x[4].ToString()),
                   DonViTinh = x[3].ToString(),
                   SoLuongTon = int.Parse(x[5].ToString()),
                   SoLuongToiThieu = int.Parse(x[6].ToString()),
               });
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nguyenLieu"></param>
        /// <returns></returns>
        public static bool ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            return NguyenLieuDAO.NhapNguyenLieu(nguyenLieu);
        }

        public static PhieuNhapHang LapPhieuNhap(string nhaCungCap, string maNhanVien)
        {
            return NguyenLieuDAO.LapPhieuNhap(nhaCungCap, maNhanVien);
        }
        public static bool NhapHangNguyeLieu(string soPhieuNhap, List<string> listMa, List<string> listSoLuong, uint thanhTien)
        {
            return NguyenLieuDAO.NhapHang(soPhieuNhap, listMa, listSoLuong, thanhTien);
        }
        public static List<PhieuNhapHang> XemPhieuNhapHang(int loai,int pageNumber,int pageSize)
        {
            return NguyenLieuDAO.XemPhieuNhapHang(loai,pageNumber,pageSize);
        }
        public static int DemPhieuNhapNguyenLieu(int loai)
        {
            return NguyenLieuDAO.DemPhieuNhapNguyenLieu(loai);
        }
        public static bool GiaoHang(string soPhieuNhap, string nguoiGiao)
        {
            return NguyenLieuDAO.GiaoHang(soPhieuNhap, nguoiGiao);
        }

        public static int DemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu)
        {
            return NguyenLieuDAO.DemNguyenLieu(tenNguyenLieu, maNhaCungCap, isXemToiThieu);
        }
        public static DataTable XemChiTietPhieuNhapHang(string soPhieuDat)
        {
            return NguyenLieuDAO.XemChiTietPhieuNhapHangTable(soPhieuDat);
        }
        public static List<NguyenLieuDataSource> XemChiTietPhieuNhapNguyenlieu(string soPhieuDat)
        {
            return NguyenLieuDAO.XemChiTietPhieuNhapNguyenlieu(soPhieuDat);
        }
    }
}
