﻿namespace Karaoke.GUI_LoaiKH
{
    partial class frmApDungKhuyenMai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApDungKhuyenMai));
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dGVDanhSach = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLoaiKHTK = new System.Windows.Forms.ComboBox();
            this.txtTenKMTK = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dGVLoaiKhachHang = new System.Windows.Forms.DataGridView();
            this.btnThemLoaiKH = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSach)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLoaiKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(573, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 36);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPage.Location = new System.Drawing.Point(367, 78);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(37, 23);
            this.txtTotalPage.TabIndex = 140;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageNumber.Location = new System.Drawing.Point(311, 78);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 23);
            this.txtPageNumber.TabIndex = 139;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNumber.TextChanged += new System.EventHandler(this.txtPageNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(350, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 28);
            this.label6.TabIndex = 138;
            this.label6.Text = "/";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dGVDanhSach
            // 
            this.dGVDanhSach.AllowUserToAddRows = false;
            this.dGVDanhSach.AllowUserToDeleteRows = false;
            this.dGVDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSach.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSach.Location = new System.Drawing.Point(11, 107);
            this.dGVDanhSach.MultiSelect = false;
            this.dGVDanhSach.Name = "dGVDanhSach";
            this.dGVDanhSach.RowHeadersVisible = false;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.dGVDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dGVDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDanhSach.Size = new System.Drawing.Size(651, 283);
            this.dGVDanhSach.TabIndex = 149;
            this.dGVDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSach_CellClick);
            this.dGVDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDanhSach_CellContentClick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(7, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 22);
            this.label11.TabIndex = 158;
            this.label11.Text = "Tên khuyến mãi:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(321, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 156;
            this.label7.Text = "Loại khách hàng:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLoaiKHTK
            // 
            this.cmbLoaiKHTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoaiKHTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLoaiKHTK.BackColor = System.Drawing.Color.White;
            this.cmbLoaiKHTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiKHTK.FormattingEnabled = true;
            this.cmbLoaiKHTK.Location = new System.Drawing.Point(462, 24);
            this.cmbLoaiKHTK.Name = "cmbLoaiKHTK";
            this.cmbLoaiKHTK.Size = new System.Drawing.Size(188, 27);
            this.cmbLoaiKHTK.TabIndex = 160;
            // 
            // txtTenKMTK
            // 
            this.txtTenKMTK.BackColor = System.Drawing.Color.White;
            this.txtTenKMTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKMTK.Location = new System.Drawing.Point(147, 24);
            this.txtTenKMTK.Name = "txtTenKMTK";
            this.txtTenKMTK.Size = new System.Drawing.Size(164, 27);
            this.txtTenKMTK.TabIndex = 161;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 45);
            this.panel1.TabIndex = 1;
            // 
            // btnAn
            // 
            this.btnAn.BackColor = System.Drawing.Color.Transparent;
            this.btnAn.FlatAppearance.BorderSize = 0;
            this.btnAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAn.ForeColor = System.Drawing.Color.Transparent;
            this.btnAn.Image = global::Karaoke.Properties.Resources.rewind;
            this.btnAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAn.Location = new System.Drawing.Point(5, 470);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(41, 29);
            this.btnAn.TabIndex = 163;
            this.btnAn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1117, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "     QUẢN LÝ KHUYẾN MÃI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, 45);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.splitContainer.Panel1.Controls.Add(this.dGVLoaiKhachHang);
            this.splitContainer.Panel1.Controls.Add(this.btnThemLoaiKH);
            this.splitContainer.Panel1.Controls.Add(this.label12);
            this.splitContainer.Panel1.Controls.Add(this.label5);
            this.splitContainer.Panel1.Controls.Add(this.dTPNgayKetThuc);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.dTPNgayBatDau);
            this.splitContainer.Panel1.Controls.Add(this.label9);
            this.splitContainer.Panel1.Controls.Add(this.txtTenKM);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer.Panel2.Controls.Add(this.btnFind);
            this.splitContainer.Panel2.Controls.Add(this.txtTotalPage);
            this.splitContainer.Panel2.Controls.Add(this.cmbLoaiKHTK);
            this.splitContainer.Panel2.Controls.Add(this.label7);
            this.splitContainer.Panel2.Controls.Add(this.btnFirstPage);
            this.splitContainer.Panel2.Controls.Add(this.btnSua);
            this.splitContainer.Panel2.Controls.Add(this.btnHuy);
            this.splitContainer.Panel2.Controls.Add(this.btnThoat);
            this.splitContainer.Panel2.Controls.Add(this.btnLuu);
            this.splitContainer.Panel2.Controls.Add(this.txtTenKMTK);
            this.splitContainer.Panel2.Controls.Add(this.label11);
            this.splitContainer.Panel2.Controls.Add(this.txtPageNumber);
            this.splitContainer.Panel2.Controls.Add(this.btnThem);
            this.splitContainer.Panel2.Controls.Add(this.btnLastPage);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.dGVDanhSach);
            this.splitContainer.Panel2.Controls.Add(this.btnPrevPage);
            this.splitContainer.Panel2.Controls.Add(this.btnNextPage);
            this.splitContainer.Panel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.Size = new System.Drawing.Size(1117, 461);
            this.splitContainer.SplitterDistance = 394;
            this.splitContainer.TabIndex = 163;
            // 
            // dGVLoaiKhachHang
            // 
            this.dGVLoaiKhachHang.AllowUserToAddRows = false;
            this.dGVLoaiKhachHang.AllowUserToDeleteRows = false;
            this.dGVLoaiKhachHang.AllowUserToOrderColumns = true;
            this.dGVLoaiKhachHang.AllowUserToResizeColumns = false;
            this.dGVLoaiKhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dGVLoaiKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dGVLoaiKhachHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVLoaiKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dGVLoaiKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLoaiKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVLoaiKhachHang.DefaultCellStyle = dataGridViewCellStyle24;
            this.dGVLoaiKhachHang.Location = new System.Drawing.Point(16, 235);
            this.dGVLoaiKhachHang.Name = "dGVLoaiKhachHang";
            this.dGVLoaiKhachHang.RowHeadersVisible = false;
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dGVLoaiKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dGVLoaiKhachHang.Size = new System.Drawing.Size(361, 159);
            this.dGVLoaiKhachHang.TabIndex = 203;
            this.dGVLoaiKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVLoaiKhachHang_CellClick);
            // 
            // btnThemLoaiKH
            // 
            this.btnThemLoaiKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnThemLoaiKH.Enabled = false;
            this.btnThemLoaiKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThemLoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiKH.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiKH.Image")));
            this.btnThemLoaiKH.Location = new System.Drawing.Point(16, 400);
            this.btnThemLoaiKH.Name = "btnThemLoaiKH";
            this.btnThemLoaiKH.Size = new System.Drawing.Size(208, 36);
            this.btnThemLoaiKH.TabIndex = 201;
            this.btnThemLoaiKH.Text = "Thêm loại khách hàng";
            this.btnThemLoaiKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLoaiKH.UseVisualStyleBackColor = false;
            this.btnThemLoaiKH.Click += new System.EventHandler(this.btnThemLoaiKhachHang_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 19);
            this.label12.TabIndex = 200;
            this.label12.Text = "Danh sách loại khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 197;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // dTPNgayKetThuc
            // 
            this.dTPNgayKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTPNgayKetThuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayKetThuc.Location = new System.Drawing.Point(16, 182);
            this.dTPNgayKetThuc.Name = "dTPNgayKetThuc";
            this.dTPNgayKetThuc.Size = new System.Drawing.Size(208, 27);
            this.dTPNgayKetThuc.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 195;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // dTPNgayBatDau
            // 
            this.dTPNgayBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTPNgayBatDau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayBatDau.Location = new System.Drawing.Point(16, 127);
            this.dTPNgayBatDau.Name = "dTPNgayBatDau";
            this.dTPNgayBatDau.Size = new System.Drawing.Size(208, 27);
            this.dTPNgayBatDau.TabIndex = 194;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 19);
            this.label9.TabIndex = 173;
            this.label9.Text = "Tên khuyến mãi:";
            // 
            // txtTenKM
            // 
            this.txtTenKM.Enabled = false;
            this.txtTenKM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKM.Location = new System.Drawing.Point(16, 73);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(318, 27);
            this.txtTenKM.TabIndex = 162;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(341, 396);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 36);
            this.btnXoa.TabIndex = 156;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFind.Location = new System.Drawing.Point(11, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(116, 30);
            this.btnFind.TabIndex = 67;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirstPage.FlatAppearance.BorderSize = 0;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Location = new System.Drawing.Point(259, 77);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
            this.btnFirstPage.TabIndex = 148;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(457, 396);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 36);
            this.btnSua.TabIndex = 155;
            this.btnSua.Text = " Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(114, 396);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 36);
            this.btnHuy.TabIndex = 193;
            this.btnHuy.Text = " Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(10, 396);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 36);
            this.btnLuu.TabIndex = 162;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(225, 396);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 36);
            this.btnThem.TabIndex = 153;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseHover += new System.EventHandler(this.btnThem_MouseHover);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLastPage.FlatAppearance.BorderSize = 0;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Location = new System.Drawing.Point(432, 77);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(24, 24);
            this.btnLastPage.TabIndex = 147;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
            this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevPage.FlatAppearance.BorderSize = 0;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.Location = new System.Drawing.Point(285, 77);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(24, 24);
            this.btnPrevPage.TabIndex = 146;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.forward1;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextPage.Location = new System.Drawing.Point(406, 77);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 24);
            this.btnNextPage.TabIndex = 145;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(106, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 171;
            this.button1.Text = " Lưu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Xóa";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // frmApDungKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 506);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApDungKhuyenMai";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVLoaiKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridView dGVDanhSach;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLoaiKHTK;
        private System.Windows.Forms.TextBox txtTenKMTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTPNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPNgayBatDau;
        private System.Windows.Forms.Button btnThemLoaiKH;
        private System.Windows.Forms.DataGridView dGVLoaiKhachHang;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}