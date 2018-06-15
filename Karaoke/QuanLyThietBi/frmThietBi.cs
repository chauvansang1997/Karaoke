﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Karaoke.QuanLyThietBi
{
    public partial class frmThietBi : Form
    {
        private bool bSua;
        private bool bThem;
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private string ma;
        public frmThietBi()
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
            this.dGVDanhSach.Columns["MANCC"].Visible = false;
            this.dGVDanhSach.Columns["MATB"].Visible = false;
            cmbNhaCC.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCC.DisplayMember = "Ten";
            cmbNhaCCTK.DataSource = BUS.NhaCungCapBUS.XemNhaCungCap();
            cmbNhaCCTK.DisplayMember = "Ten";
            //this.dataGrid1.TableStyles.Add(table);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bSua = true;
            txtDonGia.Enabled = true;
            txtDVT.Enabled = true;
            txtTenNL.Enabled = true;
            cmbNhaCC.Enabled = true;
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
            dGVDanhSach.DataSource =BUS.ThietBiBUS.XemThietBi("", "", pageNumber, pageSize);
            AddGridTableStyle();
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
            txtDonGia.Enabled = true;
            txtDVT.Enabled = true;
            txtTenNL.Enabled = true;
            cmbNhaCC.Enabled = true;
            bThem = true;
            txtDonGia.Text = "";
            txtDVT.Text = "";
            txtTenNL.Text = "";
            //btnLuu.Enabled = true;
            //btnXoa.Enabled = false;
            //btnSua.Enabled = false;
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
            if (bThem)
            {
                return;
            }
            if (bSua)
            {
                return;
            }
            if (dGVDanhSach.CurrentCell != null)
            {
                int index = dGVDanhSach.CurrentCell.RowIndex;
                txtTenNL.Text = dGVDanhSach[0, index].Value.ToString();
                txtDVT.Text = dGVDanhSach[1, index].Value.ToString();
                txtDonGia.Text = dGVDanhSach[2, index].Value.ToString();
                for (int i = 0; i < cmbNhaCC.Items.Count; i++)
                {
                    if (((DTO.NhaCungCap)cmbNhaCC.Items[i]).MaNCC == dGVDanhSach[4, index].Value.ToString())
                    {
                        cmbNhaCC.SelectedIndex = i;
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
                    TenThietBi = txtTenNL.Text,
                    DonGia = txtDonGia.Text,
                    DVT = txtDVT.Text,
                    MaNCC = ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC
                }))
                {
                    MessageBox.Show("Thêm nguyên liệu thành công");
                }
                bThem = false;
                txtDonGia.Enabled = false;
                txtDVT.Enabled = false;
                txtTenNL.Enabled = false;
                cmbNhaCC.Enabled = false;
                resetDanhSach();
            }
            else if (bSua)
            {
                if (BUS.ThietBiBUS.ThemThietBi(new DTO.ThietBi()
                {
                    MaThietBi = ma,
                    TenThietBi = txtTenNL.Text,
                    DonGia = txtDonGia.Text,
                    DVT = txtDVT.Text,
                    MaNCC = ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC
                }))
                {
                    MessageBox.Show("Sửa nguyên liệu thành công");
                }
                bSua = false;
                txtDonGia.Enabled = false;
                txtDVT.Enabled = false;
                txtTenNL.Enabled = false;
                cmbNhaCC.Enabled = false;
                resetDanhSach();
            }
        }
        private void resetDanhSach()
        {
            bSua = false;
            bThem = false;
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemThietBi(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSach.DataSource =
    BUS.ThietBiBUS.XemThietBi("", "", pageNumber, pageSize);

            AddGridTableStyle();
        }
        private void loadDanhSach()
        {
            dGVDanhSach.DataSource =
    BUS.ThietBiBUS.XemThietBi(txtTenNguyenLieu.Text, ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC, pageNumber, pageSize);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = "1";
            totalPage = BUS.ThietBiBUS.DemThietBi(txtTenNguyenLieu.Text,((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC);
            totalPage = Utility.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();
            loadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (BUS.ThietBiBUS.XoaThietBi(new DTO.ThietBi()
            {
                MaThietBi = ma,
                TenThietBi = txtTenNL.Text,
                DonGia = txtDonGia.Text,
                DVT = txtDVT.Text,
                MaNCC = ((DTO.NhaCungCap)cmbNhaCC.SelectedValue).MaNCC
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
    }
}