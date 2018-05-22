
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
        public static DataTable TiemKiemNguyenLieu(string tenNguyenLieu, string maNhaCungCap, bool isXemToiThieu)
        {
            return NguyenLieuDAO.XemNguyenLieu(tenNguyenLieu, maNhaCungCap, isXemToiThieu);
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
