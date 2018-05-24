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
    }
}
