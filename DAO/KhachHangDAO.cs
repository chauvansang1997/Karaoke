using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class KhachHangDAO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<KhachHang> LoadHanhKhach()
        {
            string query = "select * from khachhang";

            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List tên hành khách
            return table.AsEnumerable().ToList().ConvertAll(x =>
                new KhachHang() { Ten = x[0].ToString(), SoDT = x[1].ToString(), Address = x[2].ToString(), Ma = x[2].ToString() });
        }
        /// <summary>
        /// Nhập khách hàng
        /// </summary>
        /// <param name="khachHang">Thông tin khách hàng</param>a
        public static void NhapKhachHang(KhachHang khachHang)
        {
            string query = "insert into KhachHang(tenkhachhang,sodt,diachi) values (@TenKH,@SoDT,@diaChi)";
        }

        //public static void Nhap

        public static List<KhachHang> LoadCustomerWithType(string type)
        {
            string query = "EXEC usp_LoadHanhKhach @type";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@type",SqlDbType.NVarChar){IsNullable=true,Value=type?? (Object)DBNull.Value },
            };
            DataTable table = Dataprovider.ExcuteQuery(query);


            //Chuyển Table thành List tên hành khách
            return table.AsEnumerable().ToList().ConvertAll(x =>
                new KhachHang() { Ten = x[0].ToString(), SoDT = x[1].ToString(), Address = x[2].ToString(), Ma = x[2].ToString() });

        }

        public static bool KiemTraKhachHang(string ten, string soDienThoai)
        {
            string query = "select COUNT(*) from KHACHHANG where SDT=@soDienThoai AND TENKH=@tenKhachHang";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soDienThoai",SqlDbType.VarChar){Value=soDienThoai  },


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
            return count == 0 ? false : true;
        }

        public static bool ThemKhachHangThanhVien(KhachHang khachHang)
        {
            int rowNum = 0;
            string query = "EXEC usp_ThemKhachHangThanhVien @tenKH,@sdt";
            string tenKH = khachHang.Ten;
            int loaiKH = khachHang.LoaiKH;
            string sdt = khachHang.SDT;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@tenKH",SqlDbType.NVarChar){IsNullable=false,Value=tenKH },
                new SqlParameter("@sdt",SqlDbType.NVarChar){IsNullable=true,Value=sdt??(Object)DBNull.Value}
            };

            try
            {
                rowNum = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (SqlException ex)
            {
                Utility.Log(ex);
            }
            return rowNum > 0 ? true : false;
        }

        public static bool CapNhatKhachHang(KhachHang khachHang)
        {
            int rowNum = 0;
            string query = "EXEC usp_CapNhatKhachHang @maKH,@tenKH,@sdt";
            string maKH = khachHang.Ma;
            string tenKH = khachHang.Ten;
            int loaiKH = khachHang.LoaiKH;
            string sdt = khachHang.SDT;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maKH",SqlDbType.NVarChar){IsNullable=false,Value=maKH },
                new SqlParameter("@tenKH",SqlDbType.NVarChar){IsNullable=false,Value=tenKH },
                new SqlParameter("@sdt",SqlDbType.NVarChar){IsNullable=true,Value=sdt??(Object)DBNull.Value}
            };

            try
            {
                rowNum = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (SqlException ex)
            {
                Utility.Log(ex);
            }
            return rowNum > 0 ? true : false;
        }

        public static bool XoaKhachHang(KhachHang khachHang)
        {
            int rowNum = 0;
            string query = "EXEC usp_XoaKhachHang @maKH";
            string maKH = khachHang.Ma;

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maKH",SqlDbType.NVarChar){IsNullable=false,Value=maKH },
            };

            try
            {
                rowNum = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (SqlException ex)
            {
                Utility.Log(ex);
            }
            return rowNum > 0 ? true : false;
        }

        public static DataTable XemThongTinKhachHang(KhachHang khachHang)
        {
            DataTable data = new DataTable();
            string query = "EXEC usp_LoadKhachHang @tenKhachHang,@soDienThoai";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@tenKhachHang",SqlDbType.NVarChar){IsNullable=false,Value=khachHang.Ten },
                new SqlParameter("@soDienThoai",SqlDbType.NVarChar){IsNullable=false,Value=khachHang.SoDT },
            };
            try
            {
                data = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return data;
        }
    }
}
