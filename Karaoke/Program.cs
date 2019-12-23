using Karaoke.GuiMonAn;
using Karaoke.GUI_QuanLyNhanVien;
using Karaoke.NguyenLieu;
using Karaoke.PhongKaoraoke;
using Karaoke.QuanLySanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.QuanLyPhanCong;
using Karaoke.NhaCungCap;
using Karaoke.QuanLyThietBi;
using Karaoke.GUI_DangNhap;
using Karaoke.GUI_LoaiKH;

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
            Application.Run(new frmChonPhongKaraoke());
        }
    }
}
