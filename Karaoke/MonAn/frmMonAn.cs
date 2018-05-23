using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.MonAn
{
    public partial class frmMonAn : Form
    {
        private DataTable dtNguyenLieu;
        public frmMonAn()
        {
            InitializeComponent();
            khoiTao();
        }

        private void khoiTao()
        {
            dtNguyenLieu = new DataTable();
            dGVMonAn.DataSource = dtNguyenLieu;
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNguyenLieu_Click_1(object sender, EventArgs e)
        {
            frmThemNguyenLieuMonAn nguyenLieuMonAn = new frmThemNguyenLieuMonAn(dtNguyenLieu);
            nguyenLieuMonAn.ShowDialog();
            if (dtNguyenLieu.Rows.Count == 0)
            {
                dtNguyenLieu = nguyenLieuMonAn.DtNguyeLieuMonAn.Clone();
                // dtNguyenLieu.AcceptChanges();
                //return;
            }
            foreach (DataRow dr in nguyenLieuMonAn.DtNguyeLieuMonAn.Rows)
            {
                dtNguyenLieu.Rows.Add(dr.ItemArray);
            }
            dGVMonAn.DataSource = dtNguyenLieu;
        }

        private void btnLayAnh_Click(object sender, EventArgs e)
        {
            oFDLayAnh = new OpenFileDialog();
            // image filters  
            oFDLayAnh.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (oFDLayAnh.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pBAnhMinhHoa.Image = new Bitmap(oFDLayAnh.FileName);
                // image file path  
                txtAnhMinhHoa.Text = oFDLayAnh.FileName;
            }
        }
    }
}
