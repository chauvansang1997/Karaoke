using Karaoke.GuiMonAn;
using Karaoke.GUI_QuanLyNhanVien;
using Karaoke.PhongKaoraoke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.QuanLyPhanCong;
using Karaoke.NhaCungCap;
using Karaoke.ThietBi;
using Karaoke.GUI_LoaiKH;
using Karaoke.KhachHang;

namespace Karaoke
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmKhachHang());
        }
    }
}
