using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAO
{
    public static class MaHoaMatKhau
    {
        public static string maHoa(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hashData)
            {
                hasPass += item;
            }
            return hasPass;
        }
    }
}
