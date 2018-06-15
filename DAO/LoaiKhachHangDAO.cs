﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
	public static class LoaiKhachHangDAO
	{
		public static bool ThemLoaiKH(LoaiKhachHang loaiKhach)
		{
			int rowNum = 0;
			int maLoaiKH = loaiKhach.MaLoaiKH;
			string tenLoaiKH = loaiKhach.TenLoaiKH;
			float mucKM = loaiKhach.MucKM;
			string query = "EXEC usp_ThemLoaiKH @maLoaiKH,@tenLoaiKH,@mucKM";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maLoaiKH",SqlDbType.Int){Value=maLoaiKH},
				new SqlParameter("@tenLoaiKH",SqlDbType.VarChar){Value=tenLoaiKH},
				new SqlParameter("@mucKM",SqlDbType.Float){Value=mucKM},
			};

			try
			{
				rowNum=Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
			}
			catch(Exception ex)
			{
				Utility.Log(ex);
			}
			return rowNum > 0 ? true : false;
		}

		public static bool CapNhatLoaiKH(LoaiKhachHang loaiKhach)
		{
			int rowNum = 0;
			int maLoaiKH = loaiKhach.MaLoaiKH;
			string tenLoaiKH = loaiKhach.TenLoaiKH;
			float mucKM = loaiKhach.MucKM;
			string query = "EXEC usp_CapNhatLoaiKH @maLoaiKH,@tenLoaiKH,@mucKM";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maLoaiKH",SqlDbType.Int){Value=maLoaiKH  },
				new SqlParameter("@tenLoaiKH",SqlDbType.VarChar){Value=tenLoaiKH  },
				new SqlParameter("@mucKM",SqlDbType.Float){Value=mucKM  },
			};

			try
			{
				rowNum = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}
			return rowNum > 0 ? true : false;
		}

		public static bool XoaLoaiKH(LoaiKhachHang loaiKhach)
		{
			int rowNum = 0;
			int maLoaiKH = loaiKhach.MaLoaiKH;
			string query = "EXEC usp_XoaLoaiKH @maLoaiKH";
			List<SqlParameter> parameters = new List<SqlParameter>
			{
				new SqlParameter("@maLoaiKH",SqlDbType.Int){Value=maLoaiKH },
			};

			try
			{
				rowNum = Dataprovider.ExcuteNonQuery(query, parameters.ToArray());
			}
			catch (Exception ex)
			{
				Utility.Log(ex);
			}
			return rowNum > 0 ? true : false;
		}

		public static DataTable LoadLoaiKH()
		{
			string query = "EXEC usp_LoadLoaiKH";
			DataTable data = new DataTable();
			try
			{
				data = Dataprovider.ExcuteQuery(query);
			}
			catch(Exception ex)
			{
				Utility.Log(ex.Message.ToString());
			}
			return data;
		}
	}
}