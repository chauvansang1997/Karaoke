using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class BaoCaoBUS
    {
        public static DataTable XemTonKho(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return DAO.BaoCaoDAO.XemTonKho(ngayBatDau, ngayKetThuc);
        }
    }
}
