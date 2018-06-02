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

        // Xóa tài khoản
        public static bool XoaTaiKhoan(TaiKhoan taiKhoan)
        {
            string query = "EXEC usp_XoaTaiKhoan @TENTK";

            string tenTaiKhoan = taiKhoan.TenTaiKhoan;

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TENTK", SqlDbType.VarChar) {IsNullable = false, Value = tenTaiKhoan}
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
