using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class BaoCaoDAO
    {
        private BaoCaoDAO() { }

        public static DataTable XemTonKho(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string query = "EXEC uspXemTonKho @ngayBatDau,@ngayKetThuc";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ngayBatDau",SqlDbType.DateTime){IsNullable=false,Value=ngayBatDau },
                new SqlParameter("@ngayKetThuc",SqlDbType.DateTime){IsNullable=false,Value=ngayKetThuc },


            };

            return Dataprovider.ExcuteQuery(query, parameters.ToArray());
        }
    }
}
