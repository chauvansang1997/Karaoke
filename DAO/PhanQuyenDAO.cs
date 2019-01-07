using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
namespace DAO
{
    public static class PhanQuyenDAO
    {
        public static List<Quyen> XemQuyen()
        {
            List<Quyen> list = null;

            string query = "EXEC uspXemQuyen";

            try
            {
                list = Dataprovider.ExcuteQuery(query).AsEnumerable().ToList().ConvertAll(x =>
                  new Quyen()
                  {
                      Ma = int.Parse(x[0].ToString()),
                      Ten = x[1].ToString(),

                  });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;
        }

        
    }
}
