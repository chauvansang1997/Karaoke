using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.PhongKaoraoke
{
    public partial class frmQuanLyPhong : Form
    {
        private bool isSua;
        public frmQuanLyPhong()
        {
            InitializeComponent();
            isSua = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isSua = true;
            btnThem.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            isSua = false;
            btnThem.Enabled = true;
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            this.btnThem.FlatAppearance.BorderSize = 2;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            this.btnXoa.FlatAppearance.BorderSize = 2;
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            this.btnSua.FlatAppearance.BorderSize = 2;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
        }
    }
}
