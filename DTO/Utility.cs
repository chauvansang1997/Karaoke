using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{
    public static class Utility
    {
        public static void setRowNumber(this DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        public static bool Contains(this DataGridView target, string _item, int cellNumber)
        {
            if (cellNumber >= target.ColumnCount)
            {
                return false;
            }
            foreach (DataGridViewRow item in target.Rows)
            {
                if (item.Cells[cellNumber].Value.ToString() == _item)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static TimeSpan ConvertHoursToTotalDays(double hours)
        {

            TimeSpan result = TimeSpan.FromHours(hours);

            return result;
        }
        public static bool IsContainsText(string text)
        {
            Regex regex = new Regex(@"^\d+$");
            return !regex.IsMatch(text);
        }
        /// <summary>
        /// Kiểm tra số điện thoại có hợp lệ
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPhoneNumber(string phone_number)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(phone_number);
        }
        /// <summary>
        /// Tính thổng số trang
        /// </summary>
        /// <param name="totalPage">tổng cộng số dòng</param>
        /// <param name="pageSize">kích thước từng trang </param>
        /// <returns></returns>
        public static int TinhKichThuocTrang(int totalPage, int pageSize)
        {

            if (totalPage * 1.0 % pageSize > 1)
            {
                totalPage = (totalPage / pageSize) + 1;
            }
            else
            {
                totalPage = totalPage / pageSize;
            }
            if (totalPage == 0)
            {
                totalPage = 1;
            }

            return totalPage;
        }
        /// <summary>
        /// Kiểm tra xem chuỗi có chứa số
        /// </summary>
        /// <param name="str">chuỗi đầu vào</param>
        /// <returns></returns>
        public static bool isContainsNumber(string str)
        {
            return Regex.IsMatch(str, @"\d");
        }
        /// <summary>
        /// Ghi file log
        /// </summary>
        /// <param name="e"> Ngoại lệ</param>
        public static void Log(Exception e)
        {
            File.WriteAllText("crashlog.txt", DateTime.Now.ToString(@"dd\/MM\/yyyy HH:mm") + Environment.NewLine + e.Message
                + Environment.NewLine + e.StackTrace + Environment.NewLine + e.TargetSite + Environment.NewLine + e.GetType());
        }
        /// <summary>
        /// Ghi file log
        /// </summary>
        /// <param name="msg">error message</param>
        public static void Log(string msg)
        {
            File.WriteAllText("crashlog.txt", DateTime.Now.ToString(@"dd\/MM\/yyyy HH:mm") + Environment.NewLine + msg);
        }
    }
}
