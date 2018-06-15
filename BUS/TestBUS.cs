using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public static class TestBUS
    {
        public static DataTable XemHangHoa()
        {
            return DAO.TestDAO.XemHangHoa();
        }
        public static DataTable Xemnl()
        {
            return DAO.TestDAO.Xemnl();
        }
    }
}
