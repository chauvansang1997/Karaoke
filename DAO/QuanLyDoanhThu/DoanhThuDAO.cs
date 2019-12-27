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

		public static DataTable DoanhThuTheoSanPham(DateTime date)
		{
			var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
			var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
			using ( KaraokeDataContext karaokeDataContext = new KaraokeDataContext())
			{
				try
				{
					return Utility.ConvertToDataTable(karaokeDataContext.THONGTINDATPHONGs.Where(

							ttdp => ttdp.DATHANHTOAN == 1 &&
							ttdp.NGAYNHAN.Value <= lastDayOfMonth
							&& ttdp.NGAYNHAN.Value >= firstDayOfMonth).
					 Join(karaokeDataContext.CHITIETDATPHONGs, ttdp => ttdp.MADATPHONG,
					 ctdp => ctdp.MADATPHONG,
					 (ttdp, ctdp) => new
					 {
						  ttdp.MADATPHONG,
						  ttdp.NGAYNHAN,
						  ctdp.MAPHONG
						   
					 }
						).Join(karaokeDataContext.CHITIETGOIMONs, tt => new {tt.MADATPHONG,
							tt.MAPHONG
						} , ctgm => new { ctgm.MADATPHONG,ctgm.MAPHONG}, 
						(tt,ctgm) => new
						{
							tt.MADATPHONG,
							tt.MAPHONG,
							ctgm.MASP,
							ctgm.GIA,
							ctgm.SOLUONG,
							TONG = ctgm.GIA*ctgm.SOLUONG,
							ctgm.SANPHAM,
                            ctgm.GIANHAP


						}
						).GroupBy( t=> new { t.MASP, t.GIA,t.GIANHAP }).Join(
							karaokeDataContext.SANPHAMs, gr=>gr.Key.MASP,
							sp =>sp.MASP, (gr,sp) => new
							{
								sp.MASP,
								SOLUONG = gr.Sum(t => t.SOLUONG),
								GIA = (int)gr.Key.GIA* gr.Sum(t => t.SOLUONG),
								sp.TENSP,
								DONGIA = (int)gr.Key.GIA,
								DONGIANHAP = (int)gr.Key.GIANHAP,
							}
						).ToList());


	  //             return Utility.ConvertToDataTable( karaokeDataContext.CHITIETGOIMONs
						//.GroupBy(ctgm=> ctgm.MASP).
						//Join(karaokeDataContext.SANPHAMs
						//, ctgm => ctgm.Key,
						//sp => sp.MASP, (ctgm, sp) => new
						//{
							
						//	sp.MASP,
						//	SOLUONG = ctgm.Sum(t => t.SOLUONG),
						//	GIA = (int)ctgm.Sum(t=> t.GIA),
						//	sp.TENSP,
						//	DONGIANHAP = (int)ctgm.Sum(t => t.SANPHAM.DONGIANHAP),

						//}).ToList());
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
