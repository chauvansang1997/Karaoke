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
            string query = "select* from khachhang";

            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List tên hành khách
            return table.AsEnumerable().ToList().ConvertAll(x =>
                new KhachHang() { Name = x[0].ToString(), PhoneNumber = x[1].ToString(), Address = x[2].ToString(), Id = x[2].ToString() });
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
                new KhachHang() { Name = x[0].ToString(), PhoneNumber = x[1].ToString(), Address = x[2].ToString(), Id = x[2].ToString() });

            return null;
        }

        public static bool KiemTraSoDienThoai(string soDienThoai)
        {
            string query = "select * from KHACHHANG where SDT=@soDienThoai";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soDienThoai",SqlDbType.VarChar){Value=soDienThoai  },


            };
            DataTable table = Dataprovider.ExcuteQuery(query);
            if (table.Rows.Count == 0)
            {
                return true;
            }
            return false;
        } 
    }
}
