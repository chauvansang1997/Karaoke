﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.GUI_LoaiKH
{
    public partial class frmKhuyenMai : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {

        }
        private void AddGridTableStyle()
        {
            DataGridViewCellStyle cell = new DataGridViewCellStyle
            {
                BackColor = Color.Bisque,
                //  SelectionBackColor = Color.Teal,
                //   SelectionForeColor = Color.PaleGreen,
            };
            this.dGVDanhSach.BackColor = Color.GhostWhite;
            this.dGVDanhSach.ForeColor = Color.MidnightBlue;
            this.dGVDanhSach.BackgroundColor = Color.GhostWhite;
            this.dGVDanhSach.GridColor = Color.RoyalBlue;
            this.dGVDanhSach.AlternatingRowsDefaultCellStyle = cell;
            this.dGVDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            this.dGVDanhSach.Columns["TENKM"].HeaderText = "Tên khuyến mãi";
            this.dGVDanhSach.Columns["MUCKM"].HeaderText = "Mức khuyến mãi";

            this.dGVDanhSach.Columns["MAKM"].Visible = false;
            this.dGVDanhSach.Columns["MATB"].Visible = false;
            cmbLoaiKH.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbLoaiKH.DisplayMember = "Ten";
            cmbLoaiKHTK.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbLoaiKHTK.DisplayMember = "Ten";
            //this.dataGrid1.TableStyles.Add(table);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            enableButton(false);

            enableControls(true);
        }
        private void frmThietBi_Load(object sender, EventArgs e)
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemThietBi("", "");
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            dGVDanhSach.DataSource = BUS.ThietBiBUS.XemThietBiTable("", "", pageNumber, pageSize);
            AddGridTableStyle();
        }

        private void enableButton1(bool enable)
        {
            btnHuy.Enabled = enable;
            btnLuu.Enabled = enable;
        }
        private void enableButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnXoa.Enabled = enable;
            btnSua.Enabled = enable;
        }
        private void enableControls(bool enable)
        {
            txtTenKM.Enabled = enable;
            cmbLoaiKH.Enabled = enable;
            txtMucKM.Enabled = enable;
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
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
            enableControls(true);
            enableButton(false);
            enableButton1(true);
            bThem = true;
            txtMucKM.Text = "";
            txtTenKM.Text = "";

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNumber + 1 > totalPage)
            {
                pageNumber = 1;
            }
            else
            {
                ++pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();

            loadDanhSach();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 == 0)
            {
                pageNumber = 1;
            }
            else
            {
                --pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            loadDanhSach();
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(txtPageNumber.Text) <= totalPage)
                {
                    pageNumber = (int)Convert.ToUInt32(txtPageNumber.Text);

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                txtPageNumber.Text = pageNumber.ToString();
            }
            loadDanhSach();
        }

        private void dGVDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dGVDanhSach.CurrentCell != null)
            {
                int index = dGVDanhSach.CurrentCell.RowIndex;
                ma = dGVDanhSach[5, index].Value.ToString();
                txtTenKM.Text = dGVDanhSach[0, index].Value.ToString();
                txtMucKM.Text = dGVDanhSach[2, index].Value.ToString();
                for (int i = 0; i < cmbLoaiKH.Items.Count; i++)
                {
                    if (((DTO.NhaCungCap)cmbLoaiKH.Items[i]).MaNCC == dGVDanhSach[4, index].Value.ToString())
                    {
                        cmbLoaiKH.SelectedIndex = i;
                    }
                }
                ma = dGVDanhSach[5, index].Value.ToString();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (bThem)
            {
                if (BUS.ThietBiBUS.ThemThietBi(new DTO.ThietBi()
                {
                    Ma = ma,
                    Ten = txtTenKM.Text,
                    DonGia = txtMucKM.Text,
                    MaNCC = ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC
                }))
                {
                    MessageBox.Show("Thêm nguyên liệu thành công");
                }
                bThem = false;
                enableControls(false);
                enableButton(true);
                resetDanhSach();
            }
            else if (bSua)
            {
                if (BUS.ThietBiBUS.SuaThietBi(new DTO.ThietBi()
                {
                    Ma = ma,
                    Ten = txtTenKM.Text,
                    DonGia = txtMucKM.Text,
                    MaNCC = ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC
                }))
                {
                    MessageBox.Show("Sửa nguyên liệu thành công");
                }
                bSua = false;
                enableControls(false);
                enableButton(true);
                resetDanhSach();
            }
        }
        private void resetDanhSach()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemThietBi(txtTenKMTK.Text, ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSach.DataSource = BUS.ThietBiBUS.XemThietBiTable("", "", pageNumber, pageSize);

            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            dGVDanhSach.DataSource = BUS.ThietBiBUS.XemThietBiTable(txtTenKMTK.Text, ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC, pageNumber, pageSize);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbLoaiKH.SelectedValue != null)
            {
                pageNumber = 1;
                txtPageNumber.Text = "1";
                totalPage = BUS.ThietBiBUS.DemThietBi(txtTenKMTK.Text, ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC);
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSach.DataSource =
       BUS.ThietBiBUS.XemThietBiTable(txtTenKMTK.Text, ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC, pageNumber, pageSize);
            }
            else
            {
                pageNumber = 1;
                txtPageNumber.Text = "1";
                totalPage = BUS.ThietBiBUS.DemThietBi(txtTenKMTK.Text, "");
                totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSach.DataSource =
       BUS.ThietBiBUS.XemThietBiTable(txtTenKMTK.Text, "", pageNumber, pageSize);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.ThietBiBUS.XoaThietBi(new DTO.ThietBi()
            {
                Ma = ma,
                Ten = txtTenKM.Text,
                DonGia = txtMucKM.Text,
                MaNCC = ((DTO.NhaCungCap)cmbLoaiKH.SelectedValue).MaNCC
            }))
            {
                MessageBox.Show("Xóa thiết bị thành công");
                resetDanhSach();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            enableControls(false);
            enableButton(true);
        }

        private void dGVDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
