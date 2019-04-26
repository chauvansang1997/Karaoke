﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        public static bool ThemPhong(Phong phong)
        {
            KaraokeDataContext karaokeDataContext = new KaraokeDataContext();
            string ma = TaoMa.TaoMaPhong();
            //Truy vấn thêm phòng

            try
            {
                karaokeDataContext.PHONGs.InsertOnSubmit(new PHONG()
                {
                    MAPHONG = ma,
                    MALOAIPHONG = Int32.Parse(phong.TenLoai),
                    TINHTRANG ="1"
                });
                ChangeSet cs = karaokeDataContext.GetChangeSet();
                if (cs.Inserts.Count() == 1)
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
            //string query = "EXEC uspTaoPhong @maloaiphong";

            //string ma = TaoMa.TaoMaPhong();

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.TenLoai }

            //};

            //return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;

        }

        public static bool CapNhatPhong(Phong phong)
        {
            //string query = "EXEC uspCapNhatPhong @maphong,@maloaiphong";

            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@maphong",SqlDbType.NVarChar){ Value=phong.Ten  },
            //    new SqlParameter("@maloaiphong",SqlDbType.NVarChar){Value=phong.TenLoai }

            //};
            //return Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0;
            using (KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                    karaokeDataContext.PHONGs.Single(phg => phg.MAPHONG == phong.Ten).MALOAIPHONG= Int32.Parse(phong.TenLoai);

                    ChangeSet cs = karaokeDataContext.GetChangeSet();
                    if (cs.Updates.Count() == 1)
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
        public static bool GhiNhanDatPhong(KhachHang khachHang, string maPhong, string maNV)
        {
            string query = "EXEC uspGhiNhanDatPhong @maPhong,@tenKhachHang,@soDienThoai,@soHoaDon,@maNV";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                 new SqlParameter("@tenKhachHang",SqlDbType.NVarChar){ Value=khachHang.Ten  },
                  new SqlParameter("@soDienThoai",SqlDbType.VarChar){ Value=khachHang.SoDT  },
                  new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=""  },
                  new SqlParameter("@maNV",SqlDbType.VarChar){ Value=maNV  },

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
        public static bool NhanPhongDatTruoc(string soHoaDon)
        {
            string query = "EXEC uspNhanPhong @soHoaDon,@NgayNhan";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                  new SqlParameter("@soHoaDon",SqlDbType.VarChar){ Value=soHoaDon  },
                  new SqlParameter("@soHoaDon",SqlDbType.DateTime){ Value=DateTime.Now  },


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
        public static List<Phong> XemPhong(int trangThai, int pageSize, int pageNumber)
        {
            string query = "EXEC uspTraCuuPhong @trangThai,@pageSize,@pageNumber";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@trangThai",SqlDbType.Int){ Value=trangThai  },
                 new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  },
                  new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber  }
            };
            List<Phong> list = new List<Phong>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new Phong()
                        {
                            Ten = x[0].ToString(),
                            TenLoai = x[1].ToString(),
                            Gia = uint.Parse(x[2].ToString()),
                            TinhTrang = int.Parse(x[3].ToString()),
                            GetKhachHang = new KhachHang() { Ma = x[4].ToString(), Ten = x[5].ToString(), SoDT = x[6].ToString() }
                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }

        public static int DemPhong(int trangThai)
        {
            string query = "EXEC uspDemPhong @trangThai";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@trangThai",SqlDbType.Int){IsNullable=false,Value=trangThai }

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

        public static bool ChuyenPhong(string phongHienTai,string phongChuyen)
        {
            string query = "EXEC uspChuyenPhong @maPhongHienTai,@maPhongChuyen ";


            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                  new SqlParameter("@maPhongHienTai",SqlDbType.VarChar){ Value=phongHienTai  },
                  new SqlParameter("@maPhongChuyen",SqlDbType.VarChar){ Value=phongChuyen },


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

        public static DataTable XemLichSuPhong(int pageNumber,int pageSize)
        {
            string query = "EXEC uspXemLichSuDatPhong @pageNumber,@pageSize";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber  },
                new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  },

            };
            DataTable table = null;
            try
            {
                table = Dataprovider.ExcuteQuery(query,parameters.ToArray());

            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return table;
        }
        public static int DemLichSuPhong()
        {
            string query = "EXEC uspDemLichSuDatPhong ";

            //truyền tham số vào câu truy vấn
            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter("@trangThai",SqlDbType.Int){IsNullable=false,Value=trangThai }

            //};
            int count = 0;
            try
            {
                count = int.Parse(Dataprovider.ExcuteScalar(query).ToString());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return count;
        }
        public static DataTable XemLoaiPhong()
        {
            //string query = "SELECT * FROM LOAIPHONG";
            using( KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                //DataTable table = null;
                //try
                //{
                //    table = Dataprovider.ExcuteQuery(query);

                //}
                //catch (Exception ex)
                //{
                //    Utility.Log(ex);
                //}
                var select = from loaiPhong in karaokeDataContext.LOAIPHONGs
                             select loaiPhong;
                DataTable table = Utility.ConvertToDataTable(select.ToList());
                return table;
            }
        }
        public static DataTable XemPhongQuanLy(string maPhong,int loaiPhong, int pageNumber,int pageSize)
        {
            string query = "EXEC uspXemPhong @maPhong,@loaiPhong,@pageNumber,@pageSize";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                new SqlParameter("@loaiPhong",SqlDbType.Int){ Value=loaiPhong  },
    
                new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber  },
                new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize  },
            };
            DataTable table = null;
            try
            {
                table = Dataprovider.ExcuteQuery(query, parameters.ToArray());

            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return table;
        }
        public static int DemPhongQuanLy(string maPhong, int loaiPhong)
        {
            string query = "EXEC uspDemPhongQuanLy @maPhong,@loaiPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){ Value=maPhong  },
                new SqlParameter("@loaiPhong",SqlDbType.Int){ Value=loaiPhong  },
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
    }
}
