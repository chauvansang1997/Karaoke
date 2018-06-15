using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLySanPham
{
    public partial class frmSamPham : Form
    {
        public frmSamPham()
        {
            InitializeComponent();
        }

        private void AddGridTableStyle()
        {
            DataGridTableStyle table = new DataGridTableStyle
            {
                // MappingName = this.dtct.TableName,
                AlternatingBackColor = Color.Beige,
                BackColor = Color.GhostWhite,
                ForeColor = Color.MidnightBlue,
                GridLineColor = Color.RoyalBlue,
                HeaderBackColor = Color.MidnightBlue,
                HeaderForeColor = Color.Lavender,
                SelectionBackColor = Color.Teal,
                SelectionForeColor = Color.PaleGreen,
                ReadOnly = false,
                RowHeaderWidth = 10
            };
            DataGridTextBoxColumn column = new DataGridTextBoxColumn
            {
                MappingName = "stt",
                HeaderText = "Stt",
                Width = 30
            };
            table.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn
            {
                MappingName = "ma",
                HeaderText = "Mã số",
                Width = 50
            };



            table.GridColumnStyles.Add(column);
            //this.dataGrid1.TableStyles.Add(table);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void frmNguyenLieu_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind_MouseHover(object sender, EventArgs e)
        {
            this.btnFind.FlatAppearance.BorderSize = 2;
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

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dGVDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
