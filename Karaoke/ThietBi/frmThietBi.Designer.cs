namespace Karaoke.ThietBi
{
	partial class frmThietBi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietBi));
			this.txtPageNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTotalPage = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabQuanLyThietBi = new System.Windows.Forms.TabControl();
			this.tpNhapThietBi = new System.Windows.Forms.TabPage();
			this.lblPhieuNhap = new System.Windows.Forms.Label();
			this.lblDanhMucThietBi = new System.Windows.Forms.Label();
			this.dgvPhieuNhapTB = new System.Windows.Forms.DataGridView();
			this.dgvDanhSachThietBi = new System.Windows.Forms.DataGridView();
			this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
			this.tpkNgayDat = new System.Windows.Forms.DateTimePicker();
			this.txtTenNguoiGiaoHang = new System.Windows.Forms.TextBox();
			this.txtThanhTien = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSoPhieuNhap = new System.Windows.Forms.TextBox();
			this.txtMaTB = new System.Windows.Forms.TextBox();
			this.txtTenTB = new System.Windows.Forms.TextBox();
			this.txtDonGiaTB = new System.Windows.Forms.TextBox();
			this.lblDVT = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbTenNV = new System.Windows.Forms.ComboBox();
			this.cbMaNV = new System.Windows.Forms.ComboBox();
			this.cbMaNCC = new System.Windows.Forms.ComboBox();
			this.cbMaTB = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lblMaThietBi = new System.Windows.Forms.Label();
			this.labelLoaiPhong = new System.Windows.Forms.Label();
			this.tpTonhoThietBi = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnCapNhatPhieuNhapTB = new System.Windows.Forms.Button();
			this.btnXoaPhieuNhapTB = new System.Windows.Forms.Button();
			this.btnCapNhatTB = new System.Windows.Forms.Button();
			this.btnThemPhieuNhapTB = new System.Windows.Forms.Button();
			this.btnXoaTB = new System.Windows.Forms.Button();
			this.btnThemTB = new System.Windows.Forms.Button();
			this.btnThemNCC = new System.Windows.Forms.Button();
			this.btnFirstPage = new System.Windows.Forms.Button();
			this.btnPrevPage = new System.Windows.Forms.Button();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.btnLastPage = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.txtDVT = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.tabQuanLyThietBi.SuspendLayout();
			this.tpNhapThietBi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapTB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPageNumber
			// 
			this.txtPageNumber.Location = new System.Drawing.Point(437, 1107);
			this.txtPageNumber.Name = "txtPageNumber";
			this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
			this.txtPageNumber.TabIndex = 222;
			this.txtPageNumber.Text = "1";
			this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(480, 1107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 20);
			this.label7.TabIndex = 221;
			this.label7.Text = "/";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTotalPage
			// 
			this.txtTotalPage.Location = new System.Drawing.Point(495, 1107);
			this.txtTotalPage.Name = "txtTotalPage";
			this.txtTotalPage.ReadOnly = true;
			this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
			this.txtTotalPage.TabIndex = 223;
			this.txtTotalPage.Text = "1";
			this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Controls.Add(this.tabQuanLyThietBi);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1061, 749);
			this.panel1.TabIndex = 228;
			// 
			// tabQuanLyThietBi
			// 
			this.tabQuanLyThietBi.Controls.Add(this.tpNhapThietBi);
			this.tabQuanLyThietBi.Controls.Add(this.tpTonhoThietBi);
			this.tabQuanLyThietBi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabQuanLyThietBi.Location = new System.Drawing.Point(0, 3);
			this.tabQuanLyThietBi.Name = "tabQuanLyThietBi";
			this.tabQuanLyThietBi.SelectedIndex = 0;
			this.tabQuanLyThietBi.Size = new System.Drawing.Size(1086, 746);
			this.tabQuanLyThietBi.TabIndex = 187;
			// 
			// tpNhapThietBi
			// 
			this.tpNhapThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.tpNhapThietBi.Controls.Add(this.lblPhieuNhap);
			this.tpNhapThietBi.Controls.Add(this.lblDanhMucThietBi);
			this.tpNhapThietBi.Controls.Add(this.dgvPhieuNhapTB);
			this.tpNhapThietBi.Controls.Add(this.btnCapNhatPhieuNhapTB);
			this.tpNhapThietBi.Controls.Add(this.btnXoaPhieuNhapTB);
			this.tpNhapThietBi.Controls.Add(this.btnCapNhatTB);
			this.tpNhapThietBi.Controls.Add(this.btnThemPhieuNhapTB);
			this.tpNhapThietBi.Controls.Add(this.btnXoaTB);
			this.tpNhapThietBi.Controls.Add(this.btnThemTB);
			this.tpNhapThietBi.Controls.Add(this.dgvDanhSachThietBi);
			this.tpNhapThietBi.Controls.Add(this.dtpNgayGiao);
			this.tpNhapThietBi.Controls.Add(this.dtpNgayLap);
			this.tpNhapThietBi.Controls.Add(this.tpkNgayDat);
			this.tpNhapThietBi.Controls.Add(this.txtTenNguoiGiaoHang);
			this.tpNhapThietBi.Controls.Add(this.txtThanhTien);
			this.tpNhapThietBi.Controls.Add(this.label12);
			this.tpNhapThietBi.Controls.Add(this.label13);
			this.tpNhapThietBi.Controls.Add(this.label14);
			this.tpNhapThietBi.Controls.Add(this.label9);
			this.tpNhapThietBi.Controls.Add(this.label11);
			this.tpNhapThietBi.Controls.Add(this.label8);
			this.tpNhapThietBi.Controls.Add(this.btnThemNCC);
			this.tpNhapThietBi.Controls.Add(this.textBox1);
			this.tpNhapThietBi.Controls.Add(this.txtSoPhieuNhap);
			this.tpNhapThietBi.Controls.Add(this.txtDVT);
			this.tpNhapThietBi.Controls.Add(this.txtMaTB);
			this.tpNhapThietBi.Controls.Add(this.txtTenTB);
			this.tpNhapThietBi.Controls.Add(this.txtDonGiaTB);
			this.tpNhapThietBi.Controls.Add(this.lblDVT);
			this.tpNhapThietBi.Controls.Add(this.label10);
			this.tpNhapThietBi.Controls.Add(this.label4);
			this.tpNhapThietBi.Controls.Add(this.label5);
			this.tpNhapThietBi.Controls.Add(this.label6);
			this.tpNhapThietBi.Controls.Add(this.cbTenNV);
			this.tpNhapThietBi.Controls.Add(this.cbMaNV);
			this.tpNhapThietBi.Controls.Add(this.cbMaNCC);
			this.tpNhapThietBi.Controls.Add(this.cbMaTB);
			this.tpNhapThietBi.Controls.Add(this.label1);
			this.tpNhapThietBi.Controls.Add(this.label15);
			this.tpNhapThietBi.Controls.Add(this.lblMaThietBi);
			this.tpNhapThietBi.Controls.Add(this.labelLoaiPhong);
			this.tpNhapThietBi.Location = new System.Drawing.Point(4, 28);
			this.tpNhapThietBi.Name = "tpNhapThietBi";
			this.tpNhapThietBi.Padding = new System.Windows.Forms.Padding(3);
			this.tpNhapThietBi.Size = new System.Drawing.Size(1078, 714);
			this.tpNhapThietBi.TabIndex = 0;
			this.tpNhapThietBi.Text = "Nhập thiết bị";
			this.tpNhapThietBi.Click += new System.EventHandler(this.tpNhapThietBi_Click);
			// 
			// lblPhieuNhap
			// 
			this.lblPhieuNhap.AutoSize = true;
			this.lblPhieuNhap.ForeColor = System.Drawing.Color.White;
			this.lblPhieuNhap.Location = new System.Drawing.Point(531, 307);
			this.lblPhieuNhap.Name = "lblPhieuNhap";
			this.lblPhieuNhap.Size = new System.Drawing.Size(142, 19);
			this.lblPhieuNhap.TabIndex = 235;
			this.lblPhieuNhap.Text = "Phiếu nhập thiết bị";
			// 
			// lblDanhMucThietBi
			// 
			this.lblDanhMucThietBi.AutoSize = true;
			this.lblDanhMucThietBi.ForeColor = System.Drawing.Color.White;
			this.lblDanhMucThietBi.Location = new System.Drawing.Point(41, 307);
			this.lblDanhMucThietBi.Name = "lblDanhMucThietBi";
			this.lblDanhMucThietBi.Size = new System.Drawing.Size(135, 19);
			this.lblDanhMucThietBi.TabIndex = 235;
			this.lblDanhMucThietBi.Text = "Danh mục thiết bị";
			// 
			// dgvPhieuNhapTB
			// 
			this.dgvPhieuNhapTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhieuNhapTB.Location = new System.Drawing.Point(535, 342);
			this.dgvPhieuNhapTB.Name = "dgvPhieuNhapTB";
			this.dgvPhieuNhapTB.Size = new System.Drawing.Size(523, 364);
			this.dgvPhieuNhapTB.TabIndex = 234;
			// 
			// dgvDanhSachThietBi
			// 
			this.dgvDanhSachThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachThietBi.Location = new System.Drawing.Point(10, 342);
			this.dgvDanhSachThietBi.Name = "dgvDanhSachThietBi";
			this.dgvDanhSachThietBi.Size = new System.Drawing.Size(508, 364);
			this.dgvDanhSachThietBi.TabIndex = 230;
			// 
			// dtpNgayGiao
			// 
			this.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayGiao.Location = new System.Drawing.Point(529, 214);
			this.dtpNgayGiao.Name = "dtpNgayGiao";
			this.dtpNgayGiao.Size = new System.Drawing.Size(132, 27);
			this.dtpNgayGiao.TabIndex = 229;
			// 
			// dtpNgayLap
			// 
			this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayLap.Location = new System.Drawing.Point(201, 213);
			this.dtpNgayLap.Name = "dtpNgayLap";
			this.dtpNgayLap.Size = new System.Drawing.Size(133, 27);
			this.dtpNgayLap.TabIndex = 229;
			// 
			// tpkNgayDat
			// 
			this.tpkNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tpkNgayDat.Location = new System.Drawing.Point(360, 214);
			this.tpkNgayDat.Name = "tpkNgayDat";
			this.tpkNgayDat.Size = new System.Drawing.Size(135, 27);
			this.tpkNgayDat.TabIndex = 229;
			// 
			// txtTenNguoiGiaoHang
			// 
			this.txtTenNguoiGiaoHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNguoiGiaoHang.Location = new System.Drawing.Point(795, 163);
			this.txtTenNguoiGiaoHang.Name = "txtTenNguoiGiaoHang";
			this.txtTenNguoiGiaoHang.Size = new System.Drawing.Size(248, 27);
			this.txtTenNguoiGiaoHang.TabIndex = 227;
			// 
			// txtThanhTien
			// 
			this.txtThanhTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThanhTien.Location = new System.Drawing.Point(682, 214);
			this.txtThanhTien.Name = "txtThanhTien";
			this.txtThanhTien.Size = new System.Drawing.Size(180, 27);
			this.txtThanhTien.TabIndex = 227;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(540, 192);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(86, 19);
			this.label12.TabIndex = 226;
			this.label12.Text = "Ngày giao:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(791, 141);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(183, 19);
			this.label13.TabIndex = 226;
			this.label13.Text = "Họ tên người giao hàng:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(679, 192);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 19);
			this.label14.TabIndex = 226;
			this.label14.Text = "Thành tiền:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(520, 141);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(136, 19);
			this.label9.TabIndex = 226;
			this.label9.Text = "Họ tên nhân viên:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(360, 192);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 19);
			this.label11.TabIndex = 224;
			this.label11.Text = "Ngày đặt:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(365, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 19);
			this.label8.TabIndex = 224;
			this.label8.Text = "Mã nhân viên:";
			// 
			// txtSoPhieuNhap
			// 
			this.txtSoPhieuNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoPhieuNhap.Location = new System.Drawing.Point(203, 162);
			this.txtSoPhieuNhap.Name = "txtSoPhieuNhap";
			this.txtSoPhieuNhap.Size = new System.Drawing.Size(133, 27);
			this.txtSoPhieuNhap.TabIndex = 221;
			// 
			// txtMaTB
			// 
			this.txtMaTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaTB.Location = new System.Drawing.Point(41, 36);
			this.txtMaTB.Name = "txtMaTB";
			this.txtMaTB.Size = new System.Drawing.Size(201, 27);
			this.txtMaTB.TabIndex = 221;
			// 
			// txtTenTB
			// 
			this.txtTenTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTB.Location = new System.Drawing.Point(272, 36);
			this.txtTenTB.Name = "txtTenTB";
			this.txtTenTB.Size = new System.Drawing.Size(308, 27);
			this.txtTenTB.TabIndex = 221;
			// 
			// txtDonGiaTB
			// 
			this.txtDonGiaTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonGiaTB.Location = new System.Drawing.Point(272, 93);
			this.txtDonGiaTB.Name = "txtDonGiaTB";
			this.txtDonGiaTB.Size = new System.Drawing.Size(308, 27);
			this.txtDonGiaTB.TabIndex = 221;
			// 
			// lblDVT
			// 
			this.lblDVT.AutoSize = true;
			this.lblDVT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDVT.ForeColor = System.Drawing.Color.White;
			this.lblDVT.Location = new System.Drawing.Point(37, 72);
			this.lblDVT.Name = "lblDVT";
			this.lblDVT.Size = new System.Drawing.Size(93, 19);
			this.lblDVT.TabIndex = 219;
			this.lblDVT.Text = "Đơn vị tính:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(199, 192);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(121, 19);
			this.label10.TabIndex = 218;
			this.label10.Text = "Ngày lập phiếu:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(199, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 19);
			this.label5.TabIndex = 218;
			this.label5.Text = "Số phiếu nhập:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(268, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 19);
			this.label6.TabIndex = 218;
			this.label6.Text = "Đơn giá:";
			// 
			// cbTenNV
			// 
			this.cbTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTenNV.FormattingEnabled = true;
			this.cbTenNV.Location = new System.Drawing.Point(524, 162);
			this.cbTenNV.Name = "cbTenNV";
			this.cbTenNV.Size = new System.Drawing.Size(246, 27);
			this.cbTenNV.TabIndex = 217;
			// 
			// cbMaNV
			// 
			this.cbMaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaNV.FormattingEnabled = true;
			this.cbMaNV.Location = new System.Drawing.Point(369, 162);
			this.cbMaNV.Name = "cbMaNV";
			this.cbMaNV.Size = new System.Drawing.Size(133, 27);
			this.cbMaNV.TabIndex = 217;
			// 
			// cbMaNCC
			// 
			this.cbMaNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaNCC.FormattingEnabled = true;
			this.cbMaNCC.Location = new System.Drawing.Point(598, 36);
			this.cbMaNCC.Name = "cbMaNCC";
			this.cbMaNCC.Size = new System.Drawing.Size(401, 27);
			this.cbMaNCC.TabIndex = 216;
			// 
			// cbMaTB
			// 
			this.cbMaTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaTB.FormattingEnabled = true;
			this.cbMaTB.Location = new System.Drawing.Point(47, 164);
			this.cbMaTB.Name = "cbMaTB";
			this.cbMaTB.Size = new System.Drawing.Size(130, 27);
			this.cbMaTB.TabIndex = 215;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(595, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 19);
			this.label1.TabIndex = 214;
			this.label1.Text = "Tên nhà cung cấp:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(42, 141);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(89, 19);
			this.label15.TabIndex = 213;
			this.label15.Text = "Mã thiết bị:";
			// 
			// lblMaThietBi
			// 
			this.lblMaThietBi.AutoSize = true;
			this.lblMaThietBi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaThietBi.ForeColor = System.Drawing.Color.White;
			this.lblMaThietBi.Location = new System.Drawing.Point(36, 14);
			this.lblMaThietBi.Name = "lblMaThietBi";
			this.lblMaThietBi.Size = new System.Drawing.Size(89, 19);
			this.lblMaThietBi.TabIndex = 213;
			this.lblMaThietBi.Text = "Mã thiết bị:";
			// 
			// labelLoaiPhong
			// 
			this.labelLoaiPhong.AutoSize = true;
			this.labelLoaiPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLoaiPhong.ForeColor = System.Drawing.Color.White;
			this.labelLoaiPhong.Location = new System.Drawing.Point(268, 14);
			this.labelLoaiPhong.Name = "labelLoaiPhong";
			this.labelLoaiPhong.Size = new System.Drawing.Size(96, 19);
			this.labelLoaiPhong.TabIndex = 212;
			this.labelLoaiPhong.Text = "Tên thiết bị:";
			// 
			// tpTonhoThietBi
			// 
			this.tpTonhoThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.tpTonhoThietBi.Location = new System.Drawing.Point(4, 28);
			this.tpTonhoThietBi.Name = "tpTonhoThietBi";
			this.tpTonhoThietBi.Padding = new System.Windows.Forms.Padding(3);
			this.tpTonhoThietBi.Size = new System.Drawing.Size(1078, 714);
			this.tpTonhoThietBi.TabIndex = 1;
			this.tpTonhoThietBi.Text = "Tồn kho thiết bị";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(43, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 19);
			this.label4.TabIndex = 218;
			this.label4.Text = "Số lượng:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(47, 215);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(133, 27);
			this.textBox1.TabIndex = 221;
			// 
			// btnCapNhatPhieuNhapTB
			// 
			this.btnCapNhatPhieuNhapTB.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCapNhatPhieuNhapTB.FlatAppearance.BorderSize = 0;
			this.btnCapNhatPhieuNhapTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapNhatPhieuNhapTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhatPhieuNhapTB.ForeColor = System.Drawing.Color.White;
			this.btnCapNhatPhieuNhapTB.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatPhieuNhapTB.Image")));
			this.btnCapNhatPhieuNhapTB.Location = new System.Drawing.Point(145, 261);
			this.btnCapNhatPhieuNhapTB.Name = "btnCapNhatPhieuNhapTB";
			this.btnCapNhatPhieuNhapTB.Size = new System.Drawing.Size(110, 31);
			this.btnCapNhatPhieuNhapTB.TabIndex = 232;
			this.btnCapNhatPhieuNhapTB.Text = "Cập nhật";
			this.btnCapNhatPhieuNhapTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhatPhieuNhapTB.UseVisualStyleBackColor = true;
			this.btnCapNhatPhieuNhapTB.Click += new System.EventHandler(this.btnCapNhatPhieuNhapTB_Click);
			// 
			// btnXoaPhieuNhapTB
			// 
			this.btnXoaPhieuNhapTB.FlatAppearance.BorderSize = 0;
			this.btnXoaPhieuNhapTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoaPhieuNhapTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaPhieuNhapTB.ForeColor = System.Drawing.Color.White;
			this.btnXoaPhieuNhapTB.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuNhapTB.Image")));
			this.btnXoaPhieuNhapTB.Location = new System.Drawing.Point(279, 261);
			this.btnXoaPhieuNhapTB.Name = "btnXoaPhieuNhapTB";
			this.btnXoaPhieuNhapTB.Size = new System.Drawing.Size(88, 31);
			this.btnXoaPhieuNhapTB.TabIndex = 231;
			this.btnXoaPhieuNhapTB.Text = "Xoá";
			this.btnXoaPhieuNhapTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoaPhieuNhapTB.UseVisualStyleBackColor = true;
			this.btnXoaPhieuNhapTB.Click += new System.EventHandler(this.btnXoaPhieuNhapTB_Click);
			// 
			// btnCapNhatTB
			// 
			this.btnCapNhatTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCapNhatTB.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCapNhatTB.FlatAppearance.BorderSize = 0;
			this.btnCapNhatTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapNhatTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhatTB.ForeColor = System.Drawing.Color.White;
			this.btnCapNhatTB.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatTB.Image")));
			this.btnCapNhatTB.Location = new System.Drawing.Point(698, 89);
			this.btnCapNhatTB.Name = "btnCapNhatTB";
			this.btnCapNhatTB.Size = new System.Drawing.Size(110, 31);
			this.btnCapNhatTB.TabIndex = 232;
			this.btnCapNhatTB.Text = "Cập nhật";
			this.btnCapNhatTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhatTB.UseVisualStyleBackColor = true;
			// 
			// btnThemPhieuNhapTB
			// 
			this.btnThemPhieuNhapTB.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnThemPhieuNhapTB.FlatAppearance.BorderSize = 0;
			this.btnThemPhieuNhapTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemPhieuNhapTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemPhieuNhapTB.ForeColor = System.Drawing.Color.White;
			this.btnThemPhieuNhapTB.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuNhapTB.Image")));
			this.btnThemPhieuNhapTB.Location = new System.Drawing.Point(46, 261);
			this.btnThemPhieuNhapTB.Name = "btnThemPhieuNhapTB";
			this.btnThemPhieuNhapTB.Size = new System.Drawing.Size(93, 31);
			this.btnThemPhieuNhapTB.TabIndex = 233;
			this.btnThemPhieuNhapTB.Text = "Thêm";
			this.btnThemPhieuNhapTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemPhieuNhapTB.UseVisualStyleBackColor = true;
			this.btnThemPhieuNhapTB.Click += new System.EventHandler(this.btnThemPhieuNhapTB_Click);
			// 
			// btnXoaTB
			// 
			this.btnXoaTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnXoaTB.FlatAppearance.BorderSize = 0;
			this.btnXoaTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoaTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaTB.ForeColor = System.Drawing.Color.White;
			this.btnXoaTB.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTB.Image")));
			this.btnXoaTB.Location = new System.Drawing.Point(832, 89);
			this.btnXoaTB.Name = "btnXoaTB";
			this.btnXoaTB.Size = new System.Drawing.Size(88, 31);
			this.btnXoaTB.TabIndex = 231;
			this.btnXoaTB.Text = "Xoá";
			this.btnXoaTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoaTB.UseVisualStyleBackColor = true;
			// 
			// btnThemTB
			// 
			this.btnThemTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnThemTB.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnThemTB.FlatAppearance.BorderSize = 0;
			this.btnThemTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemTB.ForeColor = System.Drawing.Color.White;
			this.btnThemTB.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTB.Image")));
			this.btnThemTB.Location = new System.Drawing.Point(599, 89);
			this.btnThemTB.Name = "btnThemTB";
			this.btnThemTB.Size = new System.Drawing.Size(93, 31);
			this.btnThemTB.TabIndex = 233;
			this.btnThemTB.Text = "Thêm";
			this.btnThemTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemTB.UseVisualStyleBackColor = true;
			this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
			// 
			// btnThemNCC
			// 
			this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemNCC.ForeColor = System.Drawing.Color.White;
			this.btnThemNCC.Image = global::Karaoke.Properties.Resources.plus1;
			this.btnThemNCC.Location = new System.Drawing.Point(1005, 37);
			this.btnThemNCC.Name = "btnThemNCC";
			this.btnThemNCC.Size = new System.Drawing.Size(39, 26);
			this.btnThemNCC.TabIndex = 222;
			this.btnThemNCC.UseVisualStyleBackColor = true;
			this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
			// 
			// btnFirstPage
			// 
			this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
			this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
			this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnFirstPage.Location = new System.Drawing.Point(385, 1105);
			this.btnFirstPage.Name = "btnFirstPage";
			this.btnFirstPage.Size = new System.Drawing.Size(24, 22);
			this.btnFirstPage.TabIndex = 227;
			this.btnFirstPage.UseVisualStyleBackColor = false;
			// 
			// btnPrevPage
			// 
			this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
			this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
			this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnPrevPage.Location = new System.Drawing.Point(411, 1105);
			this.btnPrevPage.Name = "btnPrevPage";
			this.btnPrevPage.Size = new System.Drawing.Size(24, 22);
			this.btnPrevPage.TabIndex = 225;
			this.btnPrevPage.UseVisualStyleBackColor = false;
			// 
			// btnNextPage
			// 
			this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
			this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.forward1;
			this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnNextPage.Location = new System.Drawing.Point(532, 1105);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(24, 22);
			this.btnNextPage.TabIndex = 224;
			this.btnNextPage.UseVisualStyleBackColor = false;
			// 
			// btnLastPage
			// 
			this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
			this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
			this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnLastPage.Location = new System.Drawing.Point(558, 1105);
			this.btnLastPage.Name = "btnLastPage";
			this.btnLastPage.Size = new System.Drawing.Size(24, 22);
			this.btnLastPage.TabIndex = 226;
			this.btnLastPage.UseVisualStyleBackColor = false;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnThoat.Location = new System.Drawing.Point(632, 1099);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 34);
			this.btnThoat.TabIndex = 220;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoat.UseVisualStyleBackColor = false;
			// 
			// txtDVT
			// 
			this.txtDVT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDVT.Location = new System.Drawing.Point(40, 92);
			this.txtDVT.Name = "txtDVT";
			this.txtDVT.Size = new System.Drawing.Size(201, 27);
			this.txtDVT.TabIndex = 221;
			// 
			// frmThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 749);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnFirstPage);
			this.Controls.Add(this.txtPageNumber);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnPrevPage);
			this.Controls.Add(this.btnNextPage);
			this.Controls.Add(this.txtTotalPage);
			this.Controls.Add(this.btnLastPage);
			this.Controls.Add(this.btnThoat);
			this.Name = "frmThietBi";
			this.Text = "frmThietBi";
			this.Load += new System.EventHandler(this.frmThietBi_Load);
			this.panel1.ResumeLayout(false);
			this.tabQuanLyThietBi.ResumeLayout(false);
			this.tpNhapThietBi.ResumeLayout(false);
			this.tpNhapThietBi.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapTB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThietBi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.TextBox txtPageNumber;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.TextBox txtTotalPage;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabQuanLyThietBi;
		private System.Windows.Forms.TabPage tpNhapThietBi;
		private System.Windows.Forms.Button btnThemNCC;
		private System.Windows.Forms.TextBox txtDonGiaTB;
		private System.Windows.Forms.Label lblDVT;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbMaNCC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMaThietBi;
		private System.Windows.Forms.Label labelLoaiPhong;
		private System.Windows.Forms.TabPage tpTonhoThietBi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSoPhieuNhap;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker tpkNgayDat;
		private System.Windows.Forms.TextBox txtTenNguoiGiaoHang;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpNgayGiao;
		private System.Windows.Forms.DateTimePicker dtpNgayLap;
		private System.Windows.Forms.TextBox txtThanhTien;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbTenNV;
		private System.Windows.Forms.ComboBox cbMaNV;
		private System.Windows.Forms.DataGridView dgvDanhSachThietBi;
		private System.Windows.Forms.Label lblPhieuNhap;
		private System.Windows.Forms.Label lblDanhMucThietBi;
		private System.Windows.Forms.DataGridView dgvPhieuNhapTB;
		private System.Windows.Forms.Button btnCapNhatPhieuNhapTB;
		private System.Windows.Forms.Button btnXoaPhieuNhapTB;
		private System.Windows.Forms.Button btnCapNhatTB;
		private System.Windows.Forms.Button btnThemPhieuNhapTB;
		private System.Windows.Forms.Button btnXoaTB;
		private System.Windows.Forms.Button btnThemTB;
		private System.Windows.Forms.ComboBox cbMaTB;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMaTB;
		private System.Windows.Forms.TextBox txtTenTB;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDVT;
	}
}