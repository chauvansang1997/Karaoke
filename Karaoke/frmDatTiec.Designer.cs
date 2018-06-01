namespace Karaoke
{
    partial class frmDatTiec
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
            this.dGVDatTiec = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dTPNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPhongLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.txtThoiGianDat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatTiec)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVDatTiec
            // 
            this.dGVDatTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDatTiec.Location = new System.Drawing.Point(12, 390);
            this.dGVDatTiec.Name = "dGVDatTiec";
            this.dGVDatTiec.ReadOnly = true;
            this.dGVDatTiec.RowHeadersVisible = false;
            this.dGVDatTiec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDatTiec.Size = new System.Drawing.Size(816, 144);
            this.dGVDatTiec.TabIndex = 2;
            this.dGVDatTiec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDatTiec_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách đặt tiệc";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDatPhong.Image = global::Karaoke.Properties.Resources.plus1;
            this.btnDatPhong.Location = new System.Drawing.Point(449, 561);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(117, 30);
            this.btnDatPhong.TabIndex = 185;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Karaoke.Properties.Resources.plus1;
            this.button1.Location = new System.Drawing.Point(583, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 186;
            this.button1.Text = "Chọn món";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dTPNgayNhanPhong
            // 
            this.dTPNgayNhanPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNgayNhanPhong.Location = new System.Drawing.Point(24, 43);
            this.dTPNgayNhanPhong.Name = "dTPNgayNhanPhong";
            this.dTPNgayNhanPhong.Size = new System.Drawing.Size(165, 26);
            this.dTPNgayNhanPhong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(241, 43);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(200, 26);
            this.txtTenPhong.TabIndex = 178;
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.Location = new System.Drawing.Point(242, 17);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(76, 19);
            this.labelTenPhong.TabIndex = 179;
            this.labelTenPhong.Text = "Tên phòng:";
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiPhong.Location = new System.Drawing.Point(242, 92);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(80, 19);
            this.labelLoaiPhong.TabIndex = 185;
            this.labelLoaiPhong.Text = "Loại phòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(241, 127);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(200, 26);
            this.txtLoaiPhong.TabIndex = 186;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 187;
            this.label4.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(24, 200);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(165, 26);
            this.txtGia.TabIndex = 188;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 189;
            this.label6.Text = "Tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(237, 200);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(204, 26);
            this.txtTenKhachHang.TabIndex = 190;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 191;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(24, 281);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(165, 26);
            this.txtSDT.TabIndex = 192;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtThoiGianDat);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenKhachHang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Controls.Add(this.labelLoaiPhong);
            this.panel1.Controls.Add(this.labelTenPhong);
            this.panel1.Controls.Add(this.txtTenPhong);
            this.panel1.Controls.Add(this.dTPNgayNhanPhong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 342);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 195;
            this.label2.Text = "Thời gian:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 194;
            this.label1.Text = "Ngày nhận phòng:";
            // 
            // flowPhongLayout
            // 
            this.flowPhongLayout.Location = new System.Drawing.Point(491, 38);
            this.flowPhongLayout.Name = "flowPhongLayout";
            this.flowPhongLayout.Size = new System.Drawing.Size(338, 316);
            this.flowPhongLayout.TabIndex = 187;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(668, 10);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 197;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Location = new System.Drawing.Point(560, 8);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
            this.btnFirstPage.TabIndex = 201;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(613, 10);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 196;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Location = new System.Drawing.Point(734, 8);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(24, 24);
            this.btnLastPage.TabIndex = 200;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(652, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 195;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
            this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.Location = new System.Drawing.Point(583, 8);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(24, 24);
            this.btnPrevPage.TabIndex = 199;
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
            this.btnNextPage.Location = new System.Drawing.Point(711, 8);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 24);
            this.btnNextPage.TabIndex = 198;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhanPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhanPhong.Image = global::Karaoke.Properties.Resources.plus1;
            this.btnNhanPhong.Location = new System.Drawing.Point(712, 561);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(117, 30);
            this.btnNhanPhong.TabIndex = 202;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            // 
            // txtThoiGianDat
            // 
            this.txtThoiGianDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianDat.Location = new System.Drawing.Point(24, 127);
            this.txtThoiGianDat.Name = "txtThoiGianDat";
            this.txtThoiGianDat.Size = new System.Drawing.Size(128, 26);
            this.txtThoiGianDat.TabIndex = 193;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 196;
            this.label8.Text = "Giờ";
            // 
            // frmDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 603);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.flowPhongLayout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGVDatTiec);
            this.Name = "frmDatTiec";
            this.Text = "frmDatTiec";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDatTiec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVDatTiec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dTPNgayNhanPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.Label labelLoaiPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPhongLayout;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.TextBox txtThoiGianDat;
        private System.Windows.Forms.Label label8;
    }
}