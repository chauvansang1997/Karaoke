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


        internal static string TaoMaLoaiPhong()
        {
            string maMoi = "";
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaLoaiPhong = karaokeDataContext.TAOMAs.Where(s => s.ID == 14).First();
                taoMaLoaiPhong.MACUOI += 1;
                int maCuoi = taoMaLoaiPhong.MACUOI.Value;
                int soMa = taoMaLoaiPhong.SOMA.Value;
                maMoi = maCuoi.ToString().PadLeft(soMa, '0');
                karaokeDataContext.SubmitChanges();
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
        public static string TaoMaDatPhong()
        {

            string maMoi = "";
         
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 16).First();

                int maCuoi = taoMaHoaDon.MACUOI.Value + 1;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
            }

            return maMoi;
        }
        public static string TaoMaNhanVien()
        {

            string maMoi = "";

            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var taoMaHoaDon = karaokeDataContext.TAOMAs.Where(s => s.ID == 17).First();

                int maCuoi = taoMaHoaDon.MACUOI.Value + 1;
                int soMa = taoMaHoaDon.SOMA.Value;
                string tienTo = taoMaHoaDon.TIENTO;
                maMoi = tienTo + maCuoi.ToString().PadLeft(soMa, '0');
            }

            return maMoi;
        }
    }
}
