using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class TaoMa
    {
        public static string TaoMaNguyenLieu()
        {
            string query = "select macuoi,soma,tiento from taoma where id=1";
            DataTable table = Dataprovider.ExcuteQuery(query);
            DataRow row = table.Rows[0];

            int maCuoi = int.Parse(row["macuoi"].ToString())+1;
            int soMa= int.Parse(row["soma"].ToString());
            string tienTo = row["tiento"].ToString();
            string maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');

            query = "update taoma set macuoi=macuoi+1 where id=1";
            int num = Dataprovider.ExcuteNonQuery(query);
            if (num == 0)
            {
                maMoi = "";
            }
            return maMoi;
        }
        public static string TaoMaKhachHang()
        {
            string query = "select macuoi,soma,tiento from taoma where id=2";
            DataTable table = Dataprovider.ExcuteQuery(query);
            DataRow row = table.Rows[0];

            int maCuoi = int.Parse(row["macuoi"].ToString()) + 1;
            int soMa = int.Parse(row["soma"].ToString());
            string tienTo = row["tiento"].ToString();
            string maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');

            query = "update taoma set macuoi=macuoi+1 where id=1";
            int num = Dataprovider.ExcuteNonQuery(query);
            if (num == 0)
            {
                maMoi = "";
            }
            return maMoi;
        }
        public static string TaoMaMonAn()
        {
            string query = "select macuoi,soma,tiento from taoma where id=3";
            DataTable table = Dataprovider.ExcuteQuery(query);
            DataRow row = table.Rows[0];

            int maCuoi = int.Parse(row["macuoi"].ToString()) + 1;
            int soMa = int.Parse(row["soma"].ToString());
            string tienTo = row["tiento"].ToString();
            string maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');

            query = "update taoma set macuoi=macuoi+1 where id=1";
            int num = Dataprovider.ExcuteNonQuery(query);
            if (num == 0)
            {
                maMoi = "";
            }
            return maMoi;
        }
    }
}
