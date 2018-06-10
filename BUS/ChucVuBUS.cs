using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public static class ChucVuBUS
    {
        public static DataTable LoadMaChucVu()
        {
            return DAO.QuanLyNhanVien.ChucVuDAO.LoadMaChucVu();
        }
    }
}
