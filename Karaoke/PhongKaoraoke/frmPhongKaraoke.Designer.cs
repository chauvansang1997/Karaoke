namespace Karaoke.PhongKaoraoke
{
    partial class frmPhongKaraoke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongKaraoke));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.flowPhongLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.phongKaraoke1 = new Karaoke.PhongLayout();
            this.phongKaraoke2 = new Karaoke.PhongLayout();
            this.phongKaraoke3 = new Karaoke.PhongLayout();
            this.phongKaraoke4 = new Karaoke.PhongLayout();
            this.phongKaraoke5 = new Karaoke.PhongLayout();
            this.phongKaraoke6 = new Karaoke.PhongLayout();
            this.phongKaraoke7 = new Karaoke.PhongLayout();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnDaDat = new System.Windows.Forms.Button();
            this.btnTrong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelChoice = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐătkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsXemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.settingXemDanhSachDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowPhongLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 465);
            this.panel1.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFind.Location = new System.Drawing.Point(227, 116);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 27);
            this.btnFind.TabIndex = 188;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 33);
            this.label5.TabIndex = 185;
            this.label5.Text = "ĐẶT PHÒNG";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(27, 183);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(295, 27);
            this.txtSDT.TabIndex = 182;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 181;
            this.label2.Text = "Số điện thoại:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.White;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachHang.Location = new System.Drawing.Point(27, 116);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(194, 27);
            this.txtTenKhachHang.TabIndex = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 179;
            this.label1.Text = "Tên khách hàng:";
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
            this.btnThoat.Location = new System.Drawing.Point(1104, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 36);
            this.btnThoat.TabIndex = 183;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // flowPhongLayout
            // 
            this.flowPhongLayout.BackColor = System.Drawing.Color.White;
            this.flowPhongLayout.Controls.Add(this.phongKaraoke1);
            this.flowPhongLayout.Controls.Add(this.phongKaraoke2);
            this.flowPhongLayout.Controls.Add(this.phongKaraoke3);
            this.flowPhongLayout.Controls.Add(this.phongKaraoke4);
            this.flowPhongLayout.Controls.Add(this.phongKaraoke5);
            this.flowPhongLayout.Controls.Add(this.phongKaraoke6);
            this.flowPhongLayout.Controls.Add(this.phongKaraoke7);
            this.flowPhongLayout.Location = new System.Drawing.Point(512, 8);
            this.flowPhongLayout.Name = "flowPhongLayout";
            this.flowPhongLayout.Size = new System.Drawing.Size(692, 354);
            this.flowPhongLayout.TabIndex = 0;
            // 
            // phongKaraoke1
            // 
            this.phongKaraoke1.IndexDict = 0;
            this.phongKaraoke1.IndexList = 0;
            this.phongKaraoke1.KhachHang = null;
            this.phongKaraoke1.Loai = null;
            this.phongKaraoke1.Location = new System.Drawing.Point(4, 5);
            this.phongKaraoke1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke1.Name = "phongKaraoke1";
            this.phongKaraoke1.Phong = null;
            this.phongKaraoke1.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke1.TabIndex = 0;
            this.phongKaraoke1.Ten = null;
            // 
            // phongKaraoke2
            // 
            this.phongKaraoke2.IndexDict = 0;
            this.phongKaraoke2.IndexList = 0;
            this.phongKaraoke2.KhachHang = null;
            this.phongKaraoke2.Loai = null;
            this.phongKaraoke2.Location = new System.Drawing.Point(112, 5);
            this.phongKaraoke2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke2.Name = "phongKaraoke2";
            this.phongKaraoke2.Phong = null;
            this.phongKaraoke2.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke2.TabIndex = 1;
            this.phongKaraoke2.Ten = null;
            // 
            // phongKaraoke3
            // 
            this.phongKaraoke3.IndexDict = 0;
            this.phongKaraoke3.IndexList = 0;
            this.phongKaraoke3.KhachHang = null;
            this.phongKaraoke3.Loai = null;
            this.phongKaraoke3.Location = new System.Drawing.Point(220, 5);
            this.phongKaraoke3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke3.Name = "phongKaraoke3";
            this.phongKaraoke3.Phong = null;
            this.phongKaraoke3.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke3.TabIndex = 2;
            this.phongKaraoke3.Ten = null;
            // 
            // phongKaraoke4
            // 
            this.phongKaraoke4.IndexDict = 0;
            this.phongKaraoke4.IndexList = 0;
            this.phongKaraoke4.KhachHang = null;
            this.phongKaraoke4.Loai = null;
            this.phongKaraoke4.Location = new System.Drawing.Point(328, 5);
            this.phongKaraoke4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke4.Name = "phongKaraoke4";
            this.phongKaraoke4.Phong = null;
            this.phongKaraoke4.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke4.TabIndex = 3;
            this.phongKaraoke4.Ten = null;
            // 
            // phongKaraoke5
            // 
            this.phongKaraoke5.IndexDict = 0;
            this.phongKaraoke5.IndexList = 0;
            this.phongKaraoke5.KhachHang = null;
            this.phongKaraoke5.Loai = null;
            this.phongKaraoke5.Location = new System.Drawing.Point(436, 5);
            this.phongKaraoke5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke5.Name = "phongKaraoke5";
            this.phongKaraoke5.Phong = null;
            this.phongKaraoke5.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke5.TabIndex = 4;
            this.phongKaraoke5.Ten = null;
            // 
            // phongKaraoke6
            // 
            this.phongKaraoke6.IndexDict = 0;
            this.phongKaraoke6.IndexList = 0;
            this.phongKaraoke6.KhachHang = null;
            this.phongKaraoke6.Loai = null;
            this.phongKaraoke6.Location = new System.Drawing.Point(544, 5);
            this.phongKaraoke6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke6.Name = "phongKaraoke6";
            this.phongKaraoke6.Phong = null;
            this.phongKaraoke6.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke6.TabIndex = 5;
            this.phongKaraoke6.Ten = null;
            // 
            // phongKaraoke7
            // 
            this.phongKaraoke7.IndexDict = 0;
            this.phongKaraoke7.IndexList = 0;
            this.phongKaraoke7.KhachHang = null;
            this.phongKaraoke7.Loai = null;
            this.phongKaraoke7.Location = new System.Drawing.Point(4, 115);
            this.phongKaraoke7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phongKaraoke7.Name = "phongKaraoke7";
            this.phongKaraoke7.Phong = null;
            this.phongKaraoke7.Size = new System.Drawing.Size(100, 100);
            this.phongKaraoke7.TabIndex = 6;
            this.phongKaraoke7.Ten = null;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(900, 375);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 190;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(844, 375);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 189;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNumber.TextChanged += new System.EventHandler(this.txtPageNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(883, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 188;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Location = new System.Drawing.Point(792, 375);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
            this.btnFirstPage.TabIndex = 194;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Location = new System.Drawing.Point(965, 375);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(24, 24);
            this.btnLastPage.TabIndex = 193;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
            this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.Location = new System.Drawing.Point(818, 375);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(24, 24);
            this.btnPrevPage.TabIndex = 192;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.forward1;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextPage.Location = new System.Drawing.Point(939, 375);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 24);
            this.btnNextPage.TabIndex = 191;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnGoiMon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGoiMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.ForeColor = System.Drawing.Color.White;
            this.btnGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiMon.Image")));
            this.btnGoiMon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGoiMon.Location = new System.Drawing.Point(802, 415);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(130, 36);
            this.btnGoiMon.TabIndex = 186;
            this.btnGoiMon.Text = " Gọi món";
            this.btnGoiMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoiMon.UseVisualStyleBackColor = false;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Image")));
            this.btnDatPhong.Location = new System.Drawing.Point(512, 415);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(128, 36);
            this.btnDatPhong.TabIndex = 184;
            this.btnDatPhong.Text = " Đặt phòng";
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.FlatAppearance.BorderSize = 0;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnTatCa.Image")));
            this.btnTatCa.Location = new System.Drawing.Point(2, 67);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(145, 60);
            this.btnTatCa.TabIndex = 187;
            this.btnTatCa.Text = " Tất cả";
            this.btnTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnDaDat
            // 
            this.btnDaDat.FlatAppearance.BorderSize = 0;
            this.btnDaDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaDat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaDat.ForeColor = System.Drawing.Color.White;
            this.btnDaDat.Image = ((System.Drawing.Image)(resources.GetObject("btnDaDat.Image")));
            this.btnDaDat.Location = new System.Drawing.Point(3, 185);
            this.btnDaDat.Name = "btnDaDat";
            this.btnDaDat.Size = new System.Drawing.Size(145, 60);
            this.btnDaDat.TabIndex = 1;
            this.btnDaDat.Text = "  Đã đặt";
            this.btnDaDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDaDat.UseVisualStyleBackColor = true;
            this.btnDaDat.Click += new System.EventHandler(this.btnDaDat_Click);
            // 
            // btnTrong
            // 
            this.btnTrong.FlatAppearance.BorderSize = 0;
            this.btnTrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrong.ForeColor = System.Drawing.Color.White;
            this.btnTrong.Image = ((System.Drawing.Image)(resources.GetObject("btnTrong.Image")));
            this.btnTrong.Location = new System.Drawing.Point(3, 126);
            this.btnTrong.Name = "btnTrong";
            this.btnTrong.Size = new System.Drawing.Size(145, 60);
            this.btnTrong.TabIndex = 2;
            this.btnTrong.Text = "  Chưa đặt";
            this.btnTrong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrong.UseVisualStyleBackColor = true;
            this.btnTrong.Click += new System.EventHandler(this.btnTrong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 185;
            // 
            // panelChoice
            // 
            this.panelChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.panelChoice.Location = new System.Drawing.Point(3, 67);
            this.panelChoice.Name = "panelChoice";
            this.panelChoice.Size = new System.Drawing.Size(10, 60);
            this.panelChoice.TabIndex = 186;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panelChoice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnTrong);
            this.panel2.Controls.Add(this.btnDaDat);
            this.panel2.Controls.Add(this.btnTatCa);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 465);
            this.panel2.TabIndex = 187;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐătkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(150, 24);
            this.menuStrip1.TabIndex = 188;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐătkToolStripMenuItem
            // 
            this.càiĐătkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsXemPhong,
            this.settingXemDanhSachDatPhong});
            this.càiĐătkToolStripMenuItem.Name = "càiĐătkToolStripMenuItem";
            this.càiĐătkToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.càiĐătkToolStripMenuItem.Text = "Cài đặt";
            // 
            // settingsXemPhong
            // 
            this.settingsXemPhong.Name = "settingsXemPhong";
            this.settingsXemPhong.Size = new System.Drawing.Size(213, 22);
            this.settingsXemPhong.Text = "Xem phòng";
            this.settingsXemPhong.Click += new System.EventHandler(this.settingsXemPhong_Click);
            // 
            // settingXemDanhSachDatPhong
            // 
            this.settingXemDanhSachDatPhong.Name = "settingXemDanhSachDatPhong";
            this.settingXemDanhSachDatPhong.Size = new System.Drawing.Size(213, 22);
            this.settingXemDanhSachDatPhong.Text = "Xem danh sách đặt phòng";
            this.settingXemDanhSachDatPhong.Click += new System.EventHandler(this.settingXemDanhSachDatPhong_Click);
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnChuyenPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChuyenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhong.ForeColor = System.Drawing.Color.White;
            this.btnChuyenPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenPhong.Image")));
            this.btnChuyenPhong.Location = new System.Drawing.Point(646, 415);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(150, 36);
            this.btnChuyenPhong.TabIndex = 195;
            this.btnChuyenPhong.Text = "Chuyển phòng";
            this.btnChuyenPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChuyenPhong.UseVisualStyleBackColor = false;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.Location = new System.Drawing.Point(938, 415);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(159, 36);
            this.btnThanhToan.TabIndex = 196;
            this.btnThanhToan.Text = " Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmPhongKaraoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1226, 463);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnChuyenPhong);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGoiMon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.flowPhongLayout);
            this.Controls.Add(this.btnDatPhong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPhongKaraoke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.frmPhongKaraoke_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPhongLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.FlowLayoutPanel flowPhongLayout;
        private PhongLayout phongKaraoke1;
        private PhongLayout phongKaraoke2;
        private PhongLayout phongKaraoke3;
        private PhongLayout phongKaraoke4;
        private PhongLayout phongKaraoke5;
        private PhongLayout phongKaraoke6;
        private PhongLayout phongKaraoke7;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnDaDat;
        private System.Windows.Forms.Button btnTrong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelChoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChuyenPhong;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐătkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsXemPhong;
        private System.Windows.Forms.ToolStripMenuItem settingXemDanhSachDatPhong;
    }
}