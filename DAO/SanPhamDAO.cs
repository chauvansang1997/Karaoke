using DAO.QuanLyHangHoa;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class SanPhamDAO
    {
        private SanPhamDAO()
        {

        }
        /// <summary>
        /// Nhập nguyên liệu
        /// </summary>
        /// <param name="sanPham"> các thông tin về nguyên liệu</param>
        /// <returns></returns>
        public static bool ThemSanPham(SanPham sanPham)
        {
            string query = "EXEC uspThemSanPham @ten,@maNhaCungCap,@maLoai,@donViTinh,@donGia,@soLuongToiThieu,@anhMinhHoa,@donGiaNhap";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ten",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.Ten },
                new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.NhaCungCap },
                new SqlParameter("@maLoai",SqlDbType.VarChar){IsNullable=false,Value=sanPham.Loai },
                new SqlParameter("@donViTinh",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.DonViTinh },
                new SqlParameter("@donGia",SqlDbType.Int){IsNullable=false,Value=sanPham.Gia },
                new SqlParameter("@soLuongToiThieu",SqlDbType.Int){IsNullable=false,Value=sanPham.SoLuongToiThieu },
                new SqlParameter("@anhMinhHoa",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.TenHinhAnh },
                new SqlParameter("@donGiaNhap",SqlDbType.Int){IsNullable=false,Value=sanPham.DonGiaNhap },
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
        public static bool CapNhatSanPham(SanPham sanPham)
        {
            string query = "EXEC uspCapNhatSanPham @ma,@ten,@maNhaCungCap,@maLoai,@donViTinh,@donGia,@soLuongToiThieu,@anhMinhHoa,@donGiaNhap";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@ma",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.Ma },
                new SqlParameter("@ten",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.Ten },
                new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.NhaCungCap },
                new SqlParameter("@maLoai",SqlDbType.VarChar){IsNullable=false,Value=sanPham.Loai },
                new SqlParameter("@donViTinh",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.DonViTinh },
                new SqlParameter("@donGia",SqlDbType.Int){IsNullable=false,Value=sanPham.Gia },
                new SqlParameter("@soLuongToiThieu",SqlDbType.Int){IsNullable=false,Value=sanPham.SoLuongToiThieu },
                new SqlParameter("@anhMinhHoa",SqlDbType.NVarChar){IsNullable=false,Value=sanPham.TenHinhAnh },
                new SqlParameter("@donGiaNhap",SqlDbType.Int){IsNullable=false,Value=sanPham.DonGiaNhap },
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
        public static bool XoaMonAn(string ma)
        {
            return false;
        }
        /// <summary>
        /// Xem danh sách nguyên liệu
        /// </summary>
        /// <param name="maNhaCungCap">mã nhà cung cấp</param>
        /// <param name="loaiNL">loại nguyên liệu</param>
        /// <param name="isXemToiThieu">nếu true thì ta xem các nguyên liệu đạt ngưỡng tối thiểu</param>
        /// <returns></returns>
        public static DataTable XemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu)
        {
            string query = "EXEC uspXemNguyenLieu @tenNguyenLieu,@maNhaCungCap,@isXemToiThieu";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNguyenLieu",SqlDbType.NVarChar){IsNullable=true,Value=tenNguyenLieu },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap },
                new SqlParameter("@isXemToiThieu",SqlDbType.Bit){IsNullable=true,Value=isXemToiThieu },

            };

            return Dataprovider.ExcuteQuery(query, parameters.ToArray());
        }
        public static List<HangHoa> XemSanPham(string nhaCungCap, int loai, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemSanPham @nhaCungCap,@loai,@pageNumber,@pageSize";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@nhaCungCap",SqlDbType.VarChar){IsNullable=false,Value=nhaCungCap},
                 new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                 new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber},
                 new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },

            };
            List<HangHoa> list = new List<HangHoa>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                        new HangHoa()
                        {
                            Ma = x[0].ToString(),
                            Ten = x[1].ToString(),
                            Loai = loai.ToString(),
                            Gia = uint.Parse(x[4].ToString()),
                            TenHinhAnh = x[5].ToString(),
                            DonViTinh = x[3].ToString(),
                            LoaiHangHoa = new LoaiHangHoa() { Ma = x[2].ToString(), Ten = x[6].ToString() },

                        });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }

        public static DataTable XemSanPhamTable(string nhaCungCap, int loai, string ten, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemSanPham @nhaCungCap,@loai,@ten,@pageNumber,@pageSize";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@nhaCungCap",SqlDbType.VarChar){IsNullable=false,Value=nhaCungCap},
                 new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                 new SqlParameter("@ten",SqlDbType.NVarChar){IsNullable=false,Value=ten },
                 new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber},
                 new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize },

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
        public static int DemSanPham(string nhaCungCap, int loai, string ten)
        {
            string query = "EXEC uspDemSanPham  @nhaCungCap,@loai,@ten";
            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                 new SqlParameter("@nhaCungCap",SqlDbType.VarChar){IsNullable=false,Value=nhaCungCap},
                 new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                 new SqlParameter("@ten",SqlDbType.NVarChar){IsNullable=false,Value=ten },

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
        public static List<LoaiHangHoa> XemLoai()
        {
            string query = "SELECT * FROM LOAISANPHAM";


            List<LoaiHangHoa> list = new List<LoaiHangHoa>();
            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query);
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                       new LoaiHangHoa()
                       {
                           Ma = x[0].ToString(),
                           Ten = x[1].ToString()
                       });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }

            return list;
        }
        public static PhieuNhapHang LapPhieuNhap(string nhaCungCap, string maNhanVien)
        {
            string query = "EXEC uspLapPhieuNhapSanPham @nhaCungCap,@maNhanVien";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@nhaCungCap",SqlDbType.VarChar){IsNullable=false,Value=nhaCungCap },
                new SqlParameter("@maNhanVien",SqlDbType.VarChar){IsNullable=false,Value=maNhanVien },

            };
            DataRow result = null;
            PhieuNhapHang phieuNhapHang = null;
            try
            {
                result = Dataprovider.ExcuteQuery(query, parameters.ToArray()).Rows[0];
                phieuNhapHang = new PhieuNhapHang()
                {
                    SoPhieu = result[0].ToString(),
                    MaNhanVien = result[1].ToString(),
                    TenNhanVien = result[2].ToString(),
                    SoDienThoai = result[3].ToString(),
                    NgayDat = result[4].ToString(),
                };
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return phieuNhapHang;
        }
        public static bool NhapHang(string soPhieuNhap, List<string> listMa, List<string> listSoLuong, uint thanhTien)
        {
            string query = "EXEC uspNhapHangSanPham @soPhieuNhap,@danhSachMa,@danhSachSoLuong,@thanhTien";

            string danhSachMa = String.Join("|", listMa);
            string danhSachSoLuong = String.Join("|", listSoLuong);

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuNhap",SqlDbType.NVarChar){IsNullable=false,Value=soPhieuNhap },
                new SqlParameter("@danhSachMa",SqlDbType.NVarChar){IsNullable=false,Value=danhSachMa },
                new SqlParameter("@danhSachSoLuong",SqlDbType.NVarChar){IsNullable=false,Value=danhSachSoLuong },
                new SqlParameter("@thanhTien",SqlDbType.Int){IsNullable=false,Value=thanhTien },

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
        public static bool GiaoHang(string soPhieuNhap, string nguoiGiao)
        {
            string query = "EXEC uspGiaoSanPham @soPhieuNhap,@nguoiGiao";


            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuNhap",SqlDbType.NVarChar){IsNullable=false,Value=soPhieuNhap },
                new SqlParameter("@nguoiGiao",SqlDbType.NVarChar){IsNullable=false,Value=nguoiGiao },

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
        public static string LayMaHoaDon(string maPhong)
        {
            string query = "EXEC uspLayHoaDon @maPhong";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhong",SqlDbType.VarChar){IsNullable=false,Value=maPhong }

            };
            string result = "";
            try
            {
                result = Dataprovider.ExcuteScalar(query, parameters.ToArray()).ToString();
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return result;
        }
        public static List<PhieuNhapHang> XemPhieuNhapHang(int loai, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemPhieuNhapSanPham @loai,@pageNumber,@pageSize";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },
                new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=false,Value=pageNumber },
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=false,Value=pageSize }

            };
            DataTable table = Dataprovider.ExcuteQuery(query, parameters.ToArray());
            List<PhieuNhapHang> list = null;


            try
            {
                list = table.AsEnumerable().ToList().ConvertAll(x =>
                new PhieuNhapHang()
                {
                    SoPhieu = x[0].ToString(),
                    MaNhanVien = x[1].ToString(),
                    NgayDat = x[2].ToString(),
                    NgayGiao = x[3].ToString(),
                    ThanhTien = uint.Parse(x[4].ToString()),
                    NguoiGiao = x[5].ToString(),
                    TenNhanVien = x[6].ToString(),
                    SoDienThoai = x[7].ToString(),
                });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            //Chuyển Table thành List tên hành khách
            return list;

        }
        public static int DemPhieuNhapSanPham(int loai)
        {
            string query = "EXEC uspDemPhieuNhapSanPham @loai";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@loai",SqlDbType.Int){IsNullable=false,Value=loai },

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
        public static DataTable XemChiTietPhieuNhapSanPhamTable(string soPhieuDat)
        {
            string query = "EXEC uspXemChiTietPhieuNhapSanPham @soPhieuDat";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuDat",SqlDbType.VarChar){IsNullable=false,Value=soPhieuDat },

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

        public static List<HangHoaDataSource> XemChiTietPhieuNhapSanPham(string soPhieuDat)
        {
            string query = "EXEC uspXemChiTietPhieuNhapSanPham @soPhieuDat";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuDat",SqlDbType.VarChar){IsNullable=false,Value=soPhieuDat },

            };
            List<HangHoaDataSource> list = null;
            try
            {
                list = Dataprovider.ExcuteQuery(query, parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                  new HangHoaDataSource()
                  {
                      Ma = x[1].ToString(),
                      Ten = x[2].ToString(),
                      Loai = x[3].ToString(),
                      DonViTinh = x[4].ToString(),
                      Gia = x[5].ToString(),
                      Soluong = x[6].ToString(),
                      Thanhtien = x[7].ToString(),
                      MaLoaiHangHoa = x[3].ToString(),
                      TenLoaiHangHoa = x[8].ToString(),
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
