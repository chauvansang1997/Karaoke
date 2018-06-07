using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAO.QuanLyNhanVien
{
    public static class TaiKhoanDAO
    {
        // Tạo tài khoản mới
        public static bool TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = "EXEC usp_TaoTaiKhoan @TENTK, @MATKHAU";

            string tenTaiKhoan = taiKhoan.TenTaiKhoan;
            string matKhau = taiKhoan.MatKhau;

            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TENTK", SqlDbType.VarChar) {IsNullable = false, Value = tenTaiKhoan},
                new SqlParameter("@MATKHAU", SqlDbType.VarChar) {IsNullable = false, Value = matKhau }
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }

        // Kiểm tra tài khoản
        public static bool KiemTraTaiKhoan(string tenTaiKhoan)
        {
            string query = "select COUNT(*) from TAIKHOAN where TENTK = @TENTK";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TENTK",SqlDbType.VarChar){Value = tenTaiKhoan },
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


        // Xóa tài khoản
        public static bool XoaTaiKhoan(string tentk)
        {
            string query = "EXEC usp_XoaTaiKhoan @TENTK";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TENTK", SqlDbType.VarChar) {IsNullable = false, Value = tentk}
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }

            return true;
        }


    }
}
