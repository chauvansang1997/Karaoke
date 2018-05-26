using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.GuiMonAn
{
    public partial class frmThemNguyenLieuMonAn : Form
    {
        private DataTable dtNguyenLieu;
        private DataTable dtNguyeLieuMonAn;
        private List<String> listMaNguyenLieu;

        public DataTable DtNguyeLieuMonAn { get => dtNguyeLieuMonAn; set => dtNguyeLieuMonAn = value; }

        public frmThemNguyenLieuMonAn(DataTable dtNguyeLieuMonAn)
        {
            InitializeComponent();
            this.DtNguyeLieuMonAn = dtNguyeLieuMonAn;

                listMaNguyenLieu = dtNguyeLieuMonAn.AsEnumerable().Select(r => r.Field<string>("manl"))
                      .ToList();

       
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            dtNguyenLieu = BUS.NguyenLieuBUS.TiemKiemNguyenLieu(txtTenNguyenLieu.Text, cmbNhaCungCap.Text, false, listMaNguyenLieu);
           // if (this.DtNguyeLieuMonAn == null)
            //{
             this.DtNguyeLieuMonAn = dtNguyenLieu.Clone();
             this.DtNguyeLieuMonAn.Clear();
           // }
            dGVNguyenLieu.DataSource = dtNguyenLieu;
            AddGridTableStyle();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           if(dGVNguyenLieu.CurrentCell != null)
           {
                DataRow row = dtNguyenLieu.Rows[dGVNguyenLieu.CurrentCell.RowIndex];
                DtNguyeLieuMonAn.Rows.Add(row.ItemArray);
                this.Close();
           }
        }
        private void AddGridTableStyle()
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle
            {
                BackColor = Color.Bisque,
                //  SelectionBackColor = Color.Teal,
                //   SelectionForeColor = Color.PaleGreen,
            };
            this.dGVNguyenLieu.BackColor = Color.GhostWhite;
            this.dGVNguyenLieu.ForeColor = Color.MidnightBlue;
            this.dGVNguyenLieu.BackgroundColor = Color.GhostWhite;
            this.dGVNguyenLieu.GridColor = Color.RoyalBlue;
            this.dGVNguyenLieu.AlternatingRowsDefaultCellStyle = cell;
            this.dGVNguyenLieu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            //this.dGVNguyenLieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Lavender;

            dGVNguyenLieu.EnableHeadersVisualStyles = false;

            this.dGVNguyenLieu.Columns["manl"].HeaderText = "Mã nguyên liệu";
            this.dGVNguyenLieu.Columns["manl"].Width = 50;


            this.dGVNguyenLieu.Columns["tennl"].HeaderText = "Tên nguyên liệu";
            this.dGVNguyenLieu.Columns["tennl"].Width = 50;

            this.dGVNguyenLieu.Columns["TENNCC"].HeaderText = "Nhà cung cấp";
            this.dGVNguyenLieu.Columns["TENNCC"].Width = 50;

            this.dGVNguyenLieu.Columns["DVT"].HeaderText = "Đơn vị tính";
            this.dGVNguyenLieu.Columns["DVT"].Width = 50;

            this.dGVNguyenLieu.Columns["DONGIA"].HeaderText = "Đơn giá";
            this.dGVNguyenLieu.Columns["DONGIA"].Width = 50;


            this.dGVNguyenLieu.Columns["SLTON"].HeaderText = "Số lượng";
            this.dGVNguyenLieu.Columns["SLTON"].Width = 50;

            this.dGVNguyenLieu.Columns["SLTOITHIEU"].HeaderText = "Số lượng tối thiểu";
            this.dGVNguyenLieu.Columns["SLTOITHIEU"].Width = 50;


        }

    }
}
