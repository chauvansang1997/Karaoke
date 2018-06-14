using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class NhaCungCapDAO
    {
        public static List<NhaCungCap> XemNhaCungCap()
        {
            string query = "SELECT * FROM NHACUNGCAP";

            DataTable table = Dataprovider.ExcuteQuery(query);
            List<NhaCungCap> list = null;
            try
            {
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                new NhaCungCap() { Ten = x[1].ToString(), SDT = x[2].ToString(), DiaChi = x[3].ToString(), MaNCC = x[0].ToString() });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            //Chuyển Table thành List tên hành khách
            return list;

        }
    }
}
