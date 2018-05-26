using DTO;
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
    public partial class frmPhongKaraoke : Form
    {
        private List<PhongLayout> listLayout;

        private List<Phong> listPhong;
        public frmPhongKaraoke()
        {
            InitializeComponent();
            khoiTao();
        }
        public void khoiTao()
        {
            listLayout = new List<PhongLayout>();
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void frmPhongKaraoke_Load(object sender, EventArgs e)
        {
            listPhong = BUS.PhongBUS.XemPhong("");

        }
    }
}
