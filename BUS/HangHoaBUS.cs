using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class HangHoaBUS
    {
        public static List<HangHoa> XemHangHoa(int loai, int pageNumber, int pageSize)
        {
            return DAO.HangHoaDAO.XemHangHoa(loai, pageNumber, pageSize);
        }
        public static int DemHangHoa(int loai)
        {
            return DAO.HangHoaDAO.DemHangHoa(loai);
        }
    }
}
