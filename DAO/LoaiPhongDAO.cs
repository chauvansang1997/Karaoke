using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class LoaiPhongDAO
    {
        public static bool ThemLoaiPhong(LoaiPhong loaiPhong)
        {
            //string query = "EXEC uspThemLoaiPhong  @tenLoaiPhong,@gia";

            //string ma = TaoMa.TaoMaPhong();

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=loaiPhong.Ten },

            //    new SqlParameter("@gia",SqlDbType.Int){Value=loaiPhong.Gia }

            //};

            //return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    string ma = TaoMa.TaoMaLoaiPhong();
                    karaokeDataContext.LOAIPHONGs.InsertOnSubmit(new LOAIPHONG()
                    {
                        MALOAIPHONG= Int32.Parse(ma),
                        TENLOAIPHONG = loaiPhong.Ten,
                        GIA = loaiPhong.Gia
                    });
                    ChangeSet cs = karaokeDataContext.GetChangeSet();
                    if (cs.Inserts.Count() == 1)
                    {
                        karaokeDataContext.SubmitChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return false;
            }
        }

        public static bool XoaLoaiPhong(string maLoaiPhong)
        {
           using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    var loaiPhong = karaokeDataContext.LOAIPHONGs.Single(lPhong => lPhong.MALOAIPHONG == Int32.Parse(maLoaiPhong));
                    karaokeDataContext.LOAIPHONGs.DeleteOnSubmit(loaiPhong);
                    ChangeSet cs = karaokeDataContext.GetChangeSet();
                    if (cs.Deletes.Count() == 1)
                    {
                        karaokeDataContext.SubmitChanges();
                        return true;
                    }
                }
                catch(Exception ex)
                {
                    Utility.Log(ex);
                }
                return false;
            }
        }

        public static DataTable XemLoaiPhong()
        {
            DataTable dtLoaiPhong = null;
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var loaiPhongs = from loaiPhong in karaokeDataContext.LOAIPHONGs
                             select loaiPhong;
                dtLoaiPhong = Utility.ConvertToDataTable(loaiPhongs.ToList());
                return dtLoaiPhong;
            }
        }

        public static bool CapNhatLoaiPhong(LoaiPhong loaiPhong)
        {
            //string query = "EXEC uspCapNhatLoaiPhong  @tenLoaiPhong,@gia";

            //string ma = TaoMa.TaoMaPhong();

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=loaiPhong.Ten },

            //    new SqlParameter("@gia",SqlDbType.Int){Value=loaiPhong.Gia }

            //};

            //return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    var lPhongItem = karaokeDataContext.LOAIPHONGs.Single(lPhong => lPhong.MALOAIPHONG == Int32.Parse(loaiPhong.Ma));
                    lPhongItem.MALOAIPHONG = Int32.Parse(loaiPhong.Ma);
                    lPhongItem.TENLOAIPHONG = loaiPhong.Ten;
                    lPhongItem.GIA = loaiPhong.Gia;
                    karaokeDataContext.SubmitChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return false;
            }
        }
        public static bool KiemTraLoaiPhong(string tenLoaiPhong)
        {
            //string query = "EXEC uspKiemTraLoaiPhong  @tenLoaiPhong";

            ////string ma = TaoMa.TaoMaPhong();

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=tenLoaiPhong}
            //};

            //return (int)Dataprovider.ExcuteScalar(query, parameters.ToArray()) != 0 ;
            using(KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var queryCount = 0;
                try
                {
                    var querySelect = from loaiPhong in karaokeDataContext.LOAIPHONGs
                                      where loaiPhong.TENLOAIPHONG == tenLoaiPhong
                                      select loaiPhong;
                    queryCount = querySelect.Count();
                    
                }
                catch (Exception ex)
                {
                    Utility.Log(ex);
                }
                return queryCount > 0;
            }
        }



        public static DataTable TraCuuLoaiPhong(string tuKhoa)
        {
            //string query = "EXEC uspXemLoaiPhong  @tenLoaiPhong,@gia";

            //string ma = TaoMa.TaoMaPhong();

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@tenLoaiPhong",SqlDbType.NVarChar){Value=loaiPhong.Ten },

            //    new SqlParameter("@gia",SqlDbType.Int){Value=loaiPhong.Gia }

            //};
            //List<LoaiPhong> list = new List<LoaiPhong>();
            //try
            //{
            //    DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            //    list = table.AsEnumerable().ToList().ConvertAll(x =>
            //            new LoaiPhong()
            //            {
            //                Ma = x[0].ToString(),
            //                Ten = x[1].ToString(),
            //                Gia = int.Parse(x[2].ToString())
            //            });
            //}
            //catch (Exception ex)
            //{
            //    Utility.Log(ex);
            //}

            //return list;
            using(KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                var loaiPhongs = (from loaiPhong in karaokeDataContext.LOAIPHONGs
                                  where (loaiPhong.MALOAIPHONG.ToString().Contains(tuKhoa.ToLower()) || 
                                  loaiPhong.TENLOAIPHONG.ToLower().Contains( tuKhoa.ToLower()) || 
                                  loaiPhong.GIA.ToString().ToLower().Contains(tuKhoa.ToLower()))
                                  select loaiPhong).ToList();
                DataTable loaiPhongTable = Utility.ConvertToDataTable(loaiPhongs);
                return loaiPhongTable;
            }
        }
    }
}
