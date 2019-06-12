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
            string maMoi = "";
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 2).First();

                int maCuoi = taoMaHoaDon.MACUOI.Value + 1;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
            }

            return maMoi;
        }
        public static string TaoMaKhachHang()
        {
            string maMoi = "";
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 4).First();

                int maCuoi = taoMaHoaDon.MACUOI.Value + 1;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
            }

            return maMoi;
        }
        public static string TaoMaMonAn()
        {
            string maMoi = "";
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 1).First();
                taoMaHoaDon.MACUOI += 1;
                int maCuoi = taoMaHoaDon.MACUOI.Value ;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
                karaokeDataContext.SubmitChanges();
            }

            return maMoi;
        }

        public static string TaoMaPhong()
        {
            string maMoi = "";
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 12).First();
                taoMaHoaDon.MACUOI += 1;
                int maCuoi = taoMaHoaDon.MACUOI.Value;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
                karaokeDataContext.SubmitChanges();
            }

            return maMoi;
        }
        public static string TaoHoaDon()
        {

            string maMoi = "";
         
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 3).First();

                int maCuoi = taoMaHoaDon.MACUOI.Value + 1;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
            }

            return maMoi;
        }
        public static string TaoMaSanPham()
        {
            string query = "select macuoi,soma,tiento from taoma where id=5";
            DataTable table = Dataprovider.ExcuteQuery(query);
            DataRow row = table.Rows[0];

            int maCuoi = int.Parse(row["macuoi"].ToString()) + 1;
            int soMa = int.Parse(row["soma"].ToString());
            string tienTo = row["tiento"].ToString();
            string maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');

            query = "update taoma set macuoi=macuoi+1 where id=5";
            int num = Dataprovider.ExcuteNonQuery(query);
            if (num == 0)
            {
                maMoi = "";
            }
            return maMoi;
        }
    }
}
