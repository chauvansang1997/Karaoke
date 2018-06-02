using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO.QuanLyNhanVien
{
    public static class NhanVienDAO
    {
        // Thêm nhân viên mới
        public static bool ThemNhanVien(NhanVien nv, ChucVu cv, TaiKhoan tk)
        {
            string query = "EXEC usp_ThemNhanVien @MANV, @TENTK, @MACV, @TENNV, @SDT, @DIACHI";

            string maNV = nv.MaNV;
            string tenNV = nv.HoTen;
            string sdt = nv.SoDienThoai;
            string diaChi = nv.DiaChi;
            string tenTK = tk.TenTaiKhoan;
            int maCV = cv.MaChucVu;

            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MANV", SqlDbType.Char) {IsNullable = false, Value = maNV},
                new SqlParameter("@TENTK", SqlDbType.VarChar) {IsNullable = false, Value = tenTK},
                new SqlParameter("@MACV", SqlDbType.Int) {IsNullable = false, Value = maCV},
                new SqlParameter("@TENNV", SqlDbType.NVarChar) {IsNullable = false, Value = tenNV},
                new SqlParameter("@SDT", SqlDbType.NVarChar) {IsNullable = false, Value = sdt},
                new SqlParameter("@DIACHI", SqlDbType.NVarChar) {IsNullable = false, Value = diaChi},
            };
            try
            {
                Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }

        // Cập nhật thông tin nhân viên
        public static bool CapNhatNhanVien(NhanVien nv, ChucVu cv)
        {
            string query = "EXEC usp_CapNhatNhanVien @MANV, @MACV, @TENNV, @SDT, @DIACHI";

            string maNV = nv.MaNV;
            string tenNV = nv.HoTen;
            string sdt = nv.SoDienThoai;
            string diaChi = nv.DiaChi;
            int maCV = cv.MaChucVu;

            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MANV", SqlDbType.Char) {IsNullable = false, Value = maNV},
                new SqlParameter("@MACV", SqlDbType.Int) {IsNullable = false, Value = maCV},
                new SqlParameter("@TENNV", SqlDbType.NVarChar) {IsNullable = false, Value = tenNV},
                new SqlParameter("@SDT", SqlDbType.NVarChar) {IsNullable = false, Value = sdt},
                new SqlParameter("@DIACHI", SqlDbType.NVarChar) {IsNullable = false, Value = diaChi},
            };
            try
            {
                Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }

        // Xóa nhân viên
        public static bool XoaNhanVien(NhanVien nv)
        {
            string query = "EXEC usp_XoaNhanVien @MANV";

            string maNV = nv.MaNV;

            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MANV", SqlDbType.Char) {IsNullable = false, Value = maNV},
            };
            try
            {
                Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }

        // Kiểm tra thông tin nhân viên
        public static bool KiemTraNhanVien(string maNV)
        {
            string query = "select COUNT(*) from NHANVIEN where MANV = @MANV";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MANV",SqlDbType.Char){Value = maNV },
            };
            int count = 0;
            try
            {
                count = int.Parse(Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            if (count == 0)
                return false;
            else
                return true;
        }
    }
}
