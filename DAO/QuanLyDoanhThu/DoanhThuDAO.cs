using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO.QuanLyDoanhThu
{
	public static class DoanhThuDAO
	{
		public static DataTable LayThangHoaDon()
		{
			DataTable data = new DataTable();
			string query = "EXEC usp_LayThangHoaDon";
			try
			{
				data = Dataprovider.ExcuteQuery(query);
			}catch(Exception ex)
			{
				Utility.Log(ex);
			}
			return data;
		}

		public static DataTable LoadDoanhThu(String thangHD)
		{
			DataTable data = new DataTable();
			string query = "EXEC dbo.usp_LoadDoanhThu @thangHD";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				 new SqlParameter("@thangHD",SqlDbType.VarChar){IsNullable=true,Value=thangHD??(Object)DBNull.Value},
			};
			try
			{
				data = Dataprovider.ExcuteQuery(query, parameters.ToArray());

			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}

			return data;
		}

        public static DataTable DoanhThuTheoSanPham()
        {
            using( KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
            {
                try
                {
                   return Utility.ConvertToDataTable( karaokeDataContext.CHITIETGOIMONs
                        .GroupBy(ctgm=> ctgm.MASP).
                        Join(karaokeDataContext.SANPHAMs
                        , ctgm => ctgm.Key,
                        sp => sp.MASP, (ctgm, sp) => new
                        {
                            
                            sp.MASP,
                            SOLUONG = ctgm.Sum(t => t.SOLUONG),
                            GIA = (int)ctgm.Sum(t=> t.GIA),
                            sp.TENSP,
                            DONGIANHAP = (int)ctgm.Sum(t => t.SANPHAM.DONGIANHAP),

                        }).ToList());
                }
                catch(Exception ex)
                {
                    Utility.Log(ex.Message);
                }
            }
            return null;
        }

        public static DataTable XemDoanhThu(String thangHD)
		{
			string query = "EXECUTE usp_LoadDoanhThu @thangHD";
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
	   
				 new SqlParameter("@thangHD",SqlDbType.NVarChar){IsNullable=true,Value=thangHD??(Object)DBNull.Value}
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
	}
}
