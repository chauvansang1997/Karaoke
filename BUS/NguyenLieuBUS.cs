
using DAO.QuanLyHangHoa;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class NguyenLieuBUS
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenNguyenLieu">tên nguyên liệu </param>
        /// <param name="maNhaCungCap">mã nhà cung cấp</param>
        /// <returns></returns>
        public static DataTable TiemKiemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu,
            List<string> exceptList = null)
        {
            DataTable table = NguyenLieuDAO.XemNguyenLieu(tenNguyenLieu, maNhaCungCap, isXemToiThieu).
                Select("", "manl,tennl").CopyToDataTable();
            if (exceptList != null)
            {
                foreach (string item in exceptList)
                {
                    table = table.Select("manl <> '" + item + "'").CopyToDataTable();
                }
            }
            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nguyenLieu"></param>
        /// <returns></returns>
        public static bool ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            return NguyenLieuDAO.NhapNguyenLieu(nguyenLieu);
        }
    }
}
