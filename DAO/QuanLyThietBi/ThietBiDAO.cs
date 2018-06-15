using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class ThietBiDAO
    {
        public static bool ThemThietBi(ThietBi thietBi)
        {
            string query = "EXEC usp_ThemThietBi @tenTB,@maNCC,@dvt ,@donGia";
            string tenTB = thietBi.TenThietBi;
            string maNCC = thietBi.MaNCC;
            string dvt = thietBi.DVT;
            string donGia = thietBi.DonGia;
            bool rs = false;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenTB", SqlDbType.NVarChar) {IsNullable = false, Value = tenTB},
                new SqlParameter("@maNCC", SqlDbType.NVarChar) {IsNullable = false, Value = maNCC},
                new SqlParameter("@dvt", SqlDbType.NVarChar) {IsNullable = false, Value = dvt},
                new SqlParameter("@donGia", SqlDbType.BigInt) {IsNullable = false, Value = donGia},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                rs = true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                rs = false;
            }

            return rs;
        }

        public static bool CapNhatThietBi(ThietBi thietBi)
        {
            string query = "EXCUTE usp_CapNhatThietBi @maTB,@tenTB,@maNCC,@dvt ,@donGia";
            string maTB = thietBi.MaThietBi;
            string tenTB = thietBi.TenThietBi;
            string maNCC = thietBi.MaNCC;
            string dvt = thietBi.DVT;
            string donGia = thietBi.DonGia;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maTB", SqlDbType.Char) {IsNullable = false, Value = maTB},
                new SqlParameter("@tenTB", SqlDbType.Char) {IsNullable = false, Value = tenTB},
                new SqlParameter("@maNCC", SqlDbType.NVarChar) {IsNullable = false, Value = maNCC},
                new SqlParameter("@dvt", SqlDbType.NVarChar) {IsNullable = false, Value = dvt},
                new SqlParameter("@donGia", SqlDbType.BigInt) {IsNullable = false, Value = donGia},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                return true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
        }

        public static bool XoaThietBi(ThietBi thietBi)
        {
            string query = "EXCUTE usp_XoaThietBi @maTB";
            string maTB = thietBi.MaThietBi;
            // Truyền tham số
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maTB", SqlDbType.Char) {IsNullable = false, Value = maTB},
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
                return true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
        }

        public static DataTable LayMaNCC()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "EXEC usp_LoadNCC";
                data = Dataprovider.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }

        public static DataTable LoadThietBi(string tenThietBi,string maNhaCungCap,int pageNumber, int pageSize)
        {
            DataTable data = new DataTable();
            try
            {
                string query = "EXEC usp_LoadThietBi @tenThietBi,@maNhaCungCap,@pageNumber,@pageSize";


                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                     new SqlParameter("@tenThietBi",SqlDbType.NVarChar){IsNullable=false,Value=tenThietBi },
                    new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=maNhaCungCap },
                    new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                    new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
                };
                data = Dataprovider.ExcuteQuery(query,parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }
        public static int DemThietBi(string tenThietBi, string maNhaCungCap)
        {
            string query = "EXEC uspDemThietBi @uspDemNguyenLieu,@maNhaCungCap";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNguyenLieu",SqlDbType.NVarChar){IsNullable=true,Value=tenThietBi },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap }

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
            return count;
        }
    }
}
