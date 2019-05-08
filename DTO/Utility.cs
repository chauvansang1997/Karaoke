using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace DTO
{
    public enum State{
        Add,
        Fix
    }
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
        /// <param name="rowCount">tổng cộng số dòng</param>
        /// <param name="pageSize">kích thước từng trang </param>
        /// <returns></returns>
        public static int TinhKichThuocTrang(int rowCount, int pageSize)
        {
            if (rowCount <= pageSize)
            {
                return 1;
            }
            if (rowCount * 1.0 % pageSize != 0   )
            {
                rowCount = (rowCount / pageSize) + 1;
            }
            else
            {
                rowCount = rowCount / pageSize;
            }
       

            return rowCount;
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
            File.WriteAllText("crashlog"+ DateTime.Now.ToString(@"dd_MM_yyyy_HH_mm") + ".txt",  e.Message
                + Environment.NewLine + e.StackTrace + Environment.NewLine + e.TargetSite + Environment.NewLine + e.GetType());
        }
        /// <summary>
        /// Ghi file log
        /// </summary>
        /// <param name="msg">error message</param>
        public static void Log(string msg)
        {
            File.WriteAllText("crashlog" + DateTime.Now.ToString(@"dd\/MM\/yyyy HH:mm") + ".txt",  msg);
        }

        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"
        };

        public static string convertUnsign(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
