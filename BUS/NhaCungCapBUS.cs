using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapBUS() { }
        public static List<NhaCungCap> XemNhaCungCap()
        {
            return DAO.NhaCungCapDAO.XemNhaCungCap();
        }
    }
}
