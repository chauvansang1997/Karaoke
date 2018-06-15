using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class TestDAO
    {
        public static DataTable XemHangHoa()
        {
            string query = "SELECT MAMON AS Ma,TENMON AS Ten FROM MONAN";


            return Dataprovider.ExcuteQuery(query); 
        }
        public static DataTable Xemnl()
        {
            string query = "SELECT B.MANL AS MaNguyenLieu ,B.TENNL as TenNguyenLieu,A.MAMON AS Ma FROM TPMONAN A INNER JOIN NGUYENLIEU B ON A.MANL=B.MANL";


            return Dataprovider.ExcuteQuery(query);
        }
    }
}
