using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class PhongBUS
    {
        public static List<Phong> XemPhong(string trangThai)
        {
            return DAO.PhongDAO.XemPhong(trangThai);
        }
    }
}
