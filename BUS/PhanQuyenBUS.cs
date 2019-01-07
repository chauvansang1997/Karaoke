using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class PhanQuyenBUS
    {
        public static List<Quyen> XemQuyen()
        {
            return DAO.PhanQuyenDAO.XemQuyen();
        }

    }
}
