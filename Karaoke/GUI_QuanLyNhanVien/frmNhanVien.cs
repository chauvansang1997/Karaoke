using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.GUI_QuanLyNhanVien
{
    public partial class frmNhanVien : Form
    {
        private DataTable dtDSNV;

        private void KhoiTao()
        {
            dtDSNV = new DataTable();
            dGVDSNV.DataSource = dtDSNV;
        }

        public frmNhanVien()
        {
            InitializeComponent();
            KhoiTao();
        }


    }
}
