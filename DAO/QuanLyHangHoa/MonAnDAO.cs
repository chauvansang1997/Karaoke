using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO.QuanLyHangHoa
{
    public static class MonAnDAO
    {
        public static bool ThemMonAn(MonAn monAn, List<string> listNguyenLieu, List<string> listSoLuong)
        {
            try
            {
                //Dataprovider.ExcuteNonQuery(query, parameters.ToArray());

                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    // Thêm món ăn
                    var Ma = TaoMa.TaoMaMonAn();
                    MONAN monan = new MONAN()
                    {
                        MAMON = Ma,
                        TENMON = monAn.Ten,
                        LOAIMON = Convert.ToInt32(monAn.Loai),
                        ANHMINHHOA = monAn.TenHinhAnh,
                        DONGIA = monAn.Gia
                    };
                    karaokeDataContext.MONANs.InsertOnSubmit(monan);

                    // Thêm thành phần món ăn 
                    for (int i = 0; i < listNguyenLieu.Count(); i++)
                    {
                        TPMONAN m = new TPMONAN()
                        {
                            MAMON = Ma,
                            MANL = listNguyenLieu[i],
                            SOLUONG = Convert.ToInt32(listSoLuong[i])
                        };
                        karaokeDataContext.TPMONANs.InsertOnSubmit(m);
                    }

                    karaokeDataContext.SubmitChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
        }
        public static bool SuaMonAn(MonAn monAn, List<string> listNguyenLieu, List<string> listSoLuong)
        {
            try
            {
                //Dataprovider.ExcuteNonQuery(query, parameters.ToArray());

                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    // Cập nhật thông tin món ăn
                    var monan = karaokeDataContext.MONANs.Where(m => m.MAMON.Equals(monAn.Ma)).SingleOrDefault();
                    monan.TENMON = monAn.Ten;
                    monan.LOAIMON = Convert.ToInt32(monAn.Loai);
                    monan.ANHMINHHOA = monAn.TenHinhAnh;
                    monan.DONGIA = monAn.Gia;

                    // Xóa tất cả thành phần món ăn
                    var tpmonan = karaokeDataContext.TPMONANs.Where(t => t.MAMON.Equals(monAn.Ma));
                    foreach (var tp in tpmonan)
                    {
                        karaokeDataContext.TPMONANs.DeleteOnSubmit(tp);
                    }

                    // Thêm lại thành phần món ăn 
                    for (int i = 0; i < listNguyenLieu.Count(); i++)
                    {
                        TPMONAN m = new TPMONAN()
                        {
                            MAMON = monAn.Ma,
                            MANL = listNguyenLieu[i],
                            SOLUONG = Convert.ToInt32(listSoLuong[i])
                        };
                        karaokeDataContext.TPMONANs.InsertOnSubmit(m);
                    }

                    karaokeDataContext.SubmitChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }
        }
        public static bool CapNhatMonAn(MonAn monAn, string listNguyenLieu)
        {

            //Thêm món ăn
            string query = " EXEC uspThemMonAn @maMonAn,@listNguyenLieu,@mamon,@tenmon,@loaimon,@anhminhhoa,@dongia";



            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn", SqlDbType.VarChar) { IsNullable = false, Value = monAn.Ma },
                new SqlParameter("@listNguyenLieu", SqlDbType.VarChar) { IsNullable = false, Value = listNguyenLieu },
                new SqlParameter("@tenmon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Ten },
                new SqlParameter("@loaimon",SqlDbType.NVarChar){IsNullable=false,Value=monAn.Loai },
                new SqlParameter("@anhminhhoa",SqlDbType.VarChar){IsNullable=false,Value=monAn.TenHinhAnh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=monAn.Gia },
            };
            try
            {
                Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
                return false;
            }


            return true;
        }
        public static List<MonAn> XemMonAn(string tenMonAn, int loaiMonAn, int pageNumber, int pageSize, uint donGia = 0)
        {
            string query = "EXEC uspXemMonAn @tenMonAn,@loaiMonAn,@donGia,@pageNumber,@pageSize";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.Int){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },
                 new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber},
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },
            };
            List<MonAn> list = new List<MonAn>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new MonAn()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Loai = x[2].ToString(),
                            TenHinhAnh = x[3].ToString(),
                            Gia = uint.Parse(x[4].ToString())
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }

        public static List<MonAnDataSource> XemMonAnDataSource(string tenMonAn, int loaiMonAn, int pageNumber, int pageSize)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();

            var listMonAn = from monan in karaokeDataContext.MONANs.AsEnumerable()
                            join loaimon in karaokeDataContext.LOAIMONANs
                                on monan.LOAIMON equals loaimon.MA
                            where (Utility.convertUnsign(monan.TENMON).Contains(Utility.convertUnsign(tenMonAn)) && (loaiMonAn == 0 ? monan.LOAIMON == monan.LOAIMON : monan.LOAIMON == loaiMonAn))
                            select new MonAnDataSource()
                            {
                                Ma = monan.MAMON,
                                Ten = monan.TENMON,
                                MaLoaiHangHoa = loaimon.MA.ToString(),
                                TenLoaiHangHoa = loaimon.TENLOAI.ToString(),
                                Gia = monan.DONGIA.ToString(),
                                AnhMinhHoa = monan.ANHMINHHOA
                            };

            var listMonAn2 = (karaokeDataContext.MONANs.AsEnumerable().Where(s =>
            Utility.convertUnsign(s.TENMON.ToLower()).Contains(Utility.convertUnsign(tenMonAn).ToLower())

            && (loaiMonAn == 0 ? s.LOAIMON == s.LOAIMON : s.LOAIMON == loaiMonAn)).Select(

                t => new MonAnDataSource()
                {
                    Ma = t.MAMON,
                    Ten = t.TENMON,
                    MaLoaiHangHoa = t.LOAIMONAN.MA.ToString(),
                    TenLoaiHangHoa = t.LOAIMONAN.TENLOAI.ToString(),
                    Gia = t.DONGIA.ToString(),
                    AnhMinhHoa = t.ANHMINHHOA
                }).Skip((pageNumber-1)*pageSize).Take(pageSize)).ToList();
            return listMonAn2;
        }

        public static List<MonAn> XemMonAn(string tenMonAn, int loaiMonAn, uint donGia = 0)
        {
            string query = "EXEC uspXemMonAn @tenMonAn,@loaiMonAn,@donGia";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.Int){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },

            };
            List<MonAn> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new MonAn()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Loai = x[2].ToString(),
                            Gia = uint.Parse(x[3].ToString()),
                            TenHinhAnh = x[4].ToString()
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }

        public static bool XoaMonAn(string maMonAn)
        {

            string query = "delete from MONAN where mamon =@maMonAn";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn",SqlDbType.VarChar){IsNullable=false,Value=maMonAn }
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
        public static int DemMonAn(string tenMonAn, string loaiMonAn, uint donGia = 0)
        {
            string query = "EXEC uspDemMonAn @tenMonAn,@loaiMonAn,@donGia";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenMonAn",SqlDbType.NVarChar){IsNullable=false,Value=tenMonAn },
                new SqlParameter("@loaiMonAn",SqlDbType.NVarChar){IsNullable=false,Value=loaiMonAn},
                new SqlParameter("@donGia",SqlDbType.Decimal){IsNullable=false,Value=donGia },

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
        public static List<LoaiMon> XemLoaiMon(string type)
        {
            // string query = "SELECT * FROM LOAIMONAN";
            List<LoaiMon> list = null;
            try
            {
                //DataTable table = Dataprovider.ExcuteQuery(query);
                //list = table.AsEnumerable().ToList().ConvertAll(x =>
                //        new LoaiMon()
                //        {
                //            Ma = x[0].ToString(),
                //            Ten = x[1].ToString()
                //        });
                using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
                {
                    list = (from loaimon in karaokeDataContext.LOAIMONANs
                            select new LoaiMon()
                            {
                                Ma = loaimon.MA.ToString(),
                                Ten = loaimon.TENLOAI
                            }).ToList();
                }
                if (type == "view")
                    list.Add(new LoaiMon() { Ma = "0", Ten = "Tất cả" });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static List<NguyenLieuMADataSource> XemNguyenLieuMonAn(string maMonAn)
        {
            string query = "EXEC uspXemChiTietMonAn @maMonAn";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maMonAn",SqlDbType.NVarChar){IsNullable=false,Value=maMonAn },


            };
            List<NguyenLieuMADataSource> list = null;
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new NguyenLieuMADataSource()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            DonViTinh = x[2].ToString(),
                            Gia = x[3].ToString(),
                            SoLuong = x[4].ToString(),
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
