using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GuiMonAn
{
    public partial class frmSoLuong : Form
    {
        private int soLuong;
        public frmSoLuong()
        {
            InitializeComponent();
        }

        public int SoLuong { get { return soLuong; } set { soLuong = value; } }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                SoLuong = int.Parse(txtTenPhong.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Số lượng không hợp lệ");
            }
        }
    }
}
