using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.QuanLyHangHoa
{
    public class NguyenLieuDAO
    {
        /// <summary>
        /// Nhập nguyên liệu
        /// </summary>
        /// <param name="nguyenLieu"> các thông tin về nguyên liệu</param>
        /// <returns></returns>
        public static bool NhapNguyenLieu(NguyenLieu nguyenLieu)
        {
            string query = "insert into NGUYENLIEU(manl,mancc,tennl,dvt,dongia,slton,sltoithieu,dongianhap) " +
                "values (@manl,@mancc,@tennl,@dvt,@dongia,0,@sltoithieu,@donGiaNhap)";

            //Tạo mã cho nguyên liệu
            string manl = TaoMa.TaoMaNguyenLieu();

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@manl",SqlDbType.NVarChar){IsNullable=false,Value=manl },
                new SqlParameter("@mancc",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.NhaCungCap },
                new SqlParameter("@tennl",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Ten },
                new SqlParameter("@dvt",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.DonViTinh },
                new SqlParameter("@dongia",SqlDbType.Decimal){IsNullable=false,Value=nguyenLieu.Dongia },
                new SqlParameter("@sltoithieu",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.SoLuongToiThieu },
                new SqlParameter("@donGiaNhap",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.DonGiaNhap },
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Nhập nguyên liệu
        /// </summary>
        /// <param name="nguyenLieu"> các thông tin về nguyên liệu</param>
        /// <returns></returns>
        public static bool CapNhatNguyenLieu(NguyenLieu nguyenLieu)
        {
            string query = "EXEC uspCapNhatNguyenLieu @maNguyenLieu,@tenNguyenLieu,@maNhaCungCap,@donViTinh,@donGia,@slToiThieu,@donGiaNhap";

            

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maNguyenLieu",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Ma },
                new SqlParameter("@maNhaCungCap",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.NhaCungCap },
                new SqlParameter("@tenNguyenLieu",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.Ten },
                new SqlParameter("@donViTinh",SqlDbType.NVarChar){IsNullable=false,Value=nguyenLieu.DonViTinh },
                new SqlParameter("@donGia",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.Dongia },
                new SqlParameter("@slToiThieu",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.SoLuongToiThieu },
                new SqlParameter("@donGiaNhap",SqlDbType.Int){IsNullable=false,Value=nguyenLieu.DonGiaNhap },
            };
            //nếu số dòng thành công trả về lớn hơn 0 thì thành công
            int num = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            if (num == 0)
            {
                return false;
            }
            return true;
        }
        public static bool XoaNguyenLieu(string maNguyenLieu)
        {

            string query = "EXEC uspXoaNguyenLieu @maNguyenLieu";

            //truyền tham số vào câu truy vấn
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maNguyenLieu",SqlDbType.NVarChar){IsNullable=false,Value=maNguyenLieu }
            };
            try
            {
                //nếu số dòng thành công trả về lớn hơn 0 thì thành công
                 Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
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
        public static DataTable XemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemNguyenLieu @tenNguyenLieu,@maNhaCungCap,@isXemToiThieu,@pageNumber,@pageSize";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNguyenLieu",SqlDbType.NVarChar){IsNullable=true,Value=tenNguyenLieu },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap },
                new SqlParameter("@isXemToiThieu",SqlDbType.Bit){IsNullable=true,Value=isXemToiThieu },
                new SqlParameter("@pageNumber",SqlDbType.Int){IsNullable=true,Value=pageNumber },
                new SqlParameter("@pageSize",SqlDbType.Int){IsNullable=true,Value=pageSize },
            };

            return Dataprovider.ExcuteQuery(query, parameters.ToArray());
        }

        public static PhieuNhapHang LapPhieuNhap(string nhaCungCap, string maNhanVien)
        {
            string query = "EXEC uspLapPhieuNhapNguyenLieu @nhaCungCap,@maNhanVien";

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
            string query = "EXEC uspNhapHangNguyenLieu @soPhieuNhap,@danhSachMa,@danhSachSoLuong,@thanhTien";

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
            string query = "EXEC uspGiaoNguyenLieu @soPhieuNhap,@nguoiGiao";


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

        public static List<PhieuNhapHang> XemPhieuNhapHang(int loai, int pageNumber, int pageSize)
        {
            string query = "EXEC uspXemPhieuNhapNguyenlieu @loai,@pageNumber,@pageSize";
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

        public static DataTable XemChiTietPhieuNhapHangTable(string soPhieuDat)
        {
            string query = "EXEC uspXemChiTietPhieuNhapNguyenLieu @soPhieuDat";
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
        public static DataTable DemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu)
        {
            string query = "EXEC uspDemNguyenLieu @tenNguyenLieu,@maNhaCungCap,@isXemToiThieu";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenNguyenLieu",SqlDbType.NVarChar){IsNullable=true,Value=tenNguyenLieu },
                new SqlParameter("@maNhaCungCap",SqlDbType.VarChar){IsNullable=true,Value=maNhaCungCap },
                new SqlParameter("@isXemToiThieu",SqlDbType.Bit){IsNullable=true,Value=isXemToiThieu },

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
        public static int DemPhieuNhapNguyenLieu(int loai)
        {
            string query = "EXEC uspDemPhieuNhapNguyenLieu @loai";
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
        public static List<PhieuNhapHangDataSource> XemChiTietPhieuNhapNguyenlieu(string soPhieuDat)
        {
            string query = "EXEC uspXemChiTietPhieuNhapNguyenLieu @soPhieuDat";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@soPhieuDat",SqlDbType.VarChar){IsNullable=false,Value=soPhieuDat },

            };
            List<PhieuNhapHangDataSource> list = null;
            try
            {
                list = Dataprovider.ExcuteQuery(query,parameters.ToArray()).AsEnumerable().ToList().ConvertAll(x =>
                 new PhieuNhapHangDataSource()
                 {
                     Ma = x[1].ToString(),
                     Ten = x[2].ToString(),
                     Loai = x[3].ToString(),
                     DonViTinh = x[4].ToString(),
                     Gia = x[5].ToString(),
                     Soluong = x[6].ToString(),
                     Thanhtien = x[7].ToString(),
                     
                 });
            }
            catch (Exception ex)
            {
                Utility.Log(ex);
            }
            return list;

        }
        //public static List<LoaiHangHoa> XemLoaiNguyenLieu()
        //{
        //    string query = "SELECT * FROM LOAISANPHAM";

        //    List<NguyenLieuDataSource> list = null;
        //    try
        //    {
        //        list = Dataprovider.ExcuteQuery(query).AsEnumerable().ToList().ConvertAll(x =>
        //          new NguyenLieuDataSource()
        //          {
        //              Ma = x[1].ToString(),
        //              Ten = x[2].ToString(),
        //              Loai = x[3].ToString(),
        //              DonViTinh = x[4].ToString(),
        //              Gia = x[5].ToString(),
        //              Soluong = x[6].ToString(),
        //              Thanhtien = x[7].ToString(),

        //          });
        //    }
        //    catch (Exception ex)
        //    {
        //        Utility.Log(ex);
        //    }
        //    return list;
        //}
    }
}
