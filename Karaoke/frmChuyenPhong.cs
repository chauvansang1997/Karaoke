using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class frmChuyenPhong : Form
    {
        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        private void btnLuu_MouseHover(object sender, EventArgs e)
        {
            this.btnLuu.FlatAppearance.BorderSize = 2;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            this.btnThoat.FlatAppearance.BorderSize = 2;
        }
    }
}
