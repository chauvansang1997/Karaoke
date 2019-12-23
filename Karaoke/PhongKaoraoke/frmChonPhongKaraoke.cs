using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.PhongKaoraoke
{
    public partial class frmChonPhongKaraoke : Form
    {
        const int pageSize = 10;
        int pageNumber = 1;
        public frmChonPhongKaraoke()
        {
            InitializeComponent();
            Init();
        }

        void Init() {
            //lấy tất cả phòng đang trống hiện thị lên giao diện
            List<Phong> phongs = PhongBUS.XemPhong(0, pageSize, pageNumber);
            dGVDanhSachPhong.DataSource = phongs;

        }
    }
}
