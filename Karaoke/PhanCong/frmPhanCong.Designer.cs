namespace Karaoke.QuanLyPhanCong
{
	partial class frmPhanCong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
			this.btnLastPage = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.btnPrevPage = new System.Windows.Forms.Button();
			this.labelLoaiPhong = new System.Windows.Forms.Label();
			this.labelTenPhong = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbTenCa = new System.Windows.Forms.ComboBox();
			this.cbTenNV = new System.Windows.Forms.ComboBox();
			this.cbMaNV = new System.Windows.Forms.ComboBox();
			this.dtpNgayPhanCong = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPageNumber = new System.Windows.Forms.TextBox();
			this.btnFirstPage = new System.Windows.Forms.Button();
			this.txtTotalPage = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvDanhSachPhanCong = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhanCong)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLastPage
			// 
			this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
			this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
			this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnLastPage.Location = new System.Drawing.Point(881, 500);
			this.btnLastPage.Name = "btnLastPage";
			this.btnLastPage.Size = new System.Drawing.Size(24, 24);
			this.btnLastPage.TabIndex = 206;
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
			this.btnThoat.Location = new System.Drawing.Point(976, 490);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 36);
			this.btnThoat.TabIndex = 197;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnThem
			// 
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.Location = new System.Drawing.Point(13, 205);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(143, 60);
			this.btnThem.TabIndex = 187;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.btnCapNhat);
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Location = new System.Drawing.Point(335, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(159, 535);
			this.panel2.TabIndex = 200;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(65, 337);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 21);
			this.label4.TabIndex = 185;
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.FlatAppearance.BorderSize = 0;
			this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhat.ForeColor = System.Drawing.Color.White;
			this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
			this.btnCapNhat.Location = new System.Drawing.Point(11, 265);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(146, 60);
			this.btnCapNhat.TabIndex = 2;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
			this.btnXoa.Location = new System.Drawing.Point(11, 324);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(146, 60);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnNextPage
			// 
			this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
			this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.forward1;
			this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnNextPage.Location = new System.Drawing.Point(855, 500);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(24, 24);
			this.btnNextPage.TabIndex = 204;
			this.btnNextPage.UseVisualStyleBackColor = false;
			// 
			// btnPrevPage
			// 
			this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
			this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
			this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnPrevPage.Location = new System.Drawing.Point(734, 500);
			this.btnPrevPage.Name = "btnPrevPage";
			this.btnPrevPage.Size = new System.Drawing.Size(24, 24);
			this.btnPrevPage.TabIndex = 205;
			this.btnPrevPage.UseVisualStyleBackColor = false;
			// 
			// labelLoaiPhong
			// 
			this.labelLoaiPhong.AutoSize = true;
			this.labelLoaiPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLoaiPhong.ForeColor = System.Drawing.Color.White;
			this.labelLoaiPhong.Location = new System.Drawing.Point(14, 246);
			this.labelLoaiPhong.Name = "labelLoaiPhong";
			this.labelLoaiPhong.Size = new System.Drawing.Size(116, 19);
			this.labelLoaiPhong.TabIndex = 175;
			this.labelLoaiPhong.Text = "Tên nhân viên:";
			// 
			// labelTenPhong
			// 
			this.labelTenPhong.AutoSize = true;
			this.labelTenPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTenPhong.ForeColor = System.Drawing.Color.White;
			this.labelTenPhong.Location = new System.Drawing.Point(13, 165);
			this.labelTenPhong.Name = "labelTenPhong";
			this.labelTenPhong.Size = new System.Drawing.Size(109, 19);
			this.labelTenPhong.TabIndex = 177;
			this.labelTenPhong.Text = "Mã nhân viên:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(70, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(191, 33);
			this.label5.TabIndex = 185;
			this.label5.Text = "PHÂN CÔNG";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.panel1.Controls.Add(this.cbTenCa);
			this.panel1.Controls.Add(this.cbTenNV);
			this.panel1.Controls.Add(this.cbMaNV);
			this.panel1.Controls.Add(this.dtpNgayPhanCong);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.labelTenPhong);
			this.panel1.Controls.Add(this.labelLoaiPhong);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(332, 535);
			this.panel1.TabIndex = 196;
			// 
			// cbTenCa
			// 
			this.cbTenCa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTenCa.FormattingEnabled = true;
			this.cbTenCa.Location = new System.Drawing.Point(17, 349);
			this.cbTenCa.Name = "cbTenCa";
			this.cbTenCa.Size = new System.Drawing.Size(309, 27);
			this.cbTenCa.TabIndex = 190;
			// 
			// cbTenNV
			// 
			this.cbTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTenNV.FormattingEnabled = true;
			this.cbTenNV.Location = new System.Drawing.Point(18, 268);
			this.cbTenNV.Name = "cbTenNV";
			this.cbTenNV.Size = new System.Drawing.Size(309, 27);
			this.cbTenNV.TabIndex = 190;
			// 
			// cbMaNV
			// 
			this.cbMaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMaNV.FormattingEnabled = true;
			this.cbMaNV.Location = new System.Drawing.Point(18, 188);
			this.cbMaNV.Name = "cbMaNV";
			this.cbMaNV.Size = new System.Drawing.Size(309, 27);
			this.cbMaNV.TabIndex = 190;
			// 
			// dtpNgayPhanCong
			// 
			this.dtpNgayPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgayPhanCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayPhanCong.Location = new System.Drawing.Point(13, 420);
			this.dtpNgayPhanCong.Name = "dtpNgayPhanCong";
			this.dtpNgayPhanCong.Size = new System.Drawing.Size(318, 26);
			this.dtpNgayPhanCong.TabIndex = 189;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(14, 398);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 19);
			this.label3.TabIndex = 188;
			this.label3.Text = "Ngày:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 327);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 19);
			this.label1.TabIndex = 186;
			this.label1.Text = "Tên ca:";
			// 
			// txtPageNumber
			// 
			this.txtPageNumber.Location = new System.Drawing.Point(760, 500);
			this.txtPageNumber.Name = "txtPageNumber";
			this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
			this.txtPageNumber.TabIndex = 202;
			this.txtPageNumber.Text = "1";
			this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnFirstPage
			// 
			this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
			this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
			this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnFirstPage.Location = new System.Drawing.Point(708, 500);
			this.btnFirstPage.Name = "btnFirstPage";
			this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
			this.btnFirstPage.TabIndex = 207;
			this.btnFirstPage.UseVisualStyleBackColor = false;
			// 
			// txtTotalPage
			// 
			this.txtTotalPage.Location = new System.Drawing.Point(816, 500);
			this.txtTotalPage.Name = "txtTotalPage";
			this.txtTotalPage.ReadOnly = true;
			this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
			this.txtTotalPage.TabIndex = 203;
			this.txtTotalPage.Text = "1";
			this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(799, 500);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 20);
			this.label7.TabIndex = 201;
			this.label7.Text = "/";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvDanhSachPhanCong
			// 
			this.dgvDanhSachPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachPhanCong.Location = new System.Drawing.Point(500, 1);
			this.dgvDanhSachPhanCong.Name = "dgvDanhSachPhanCong";
			this.dgvDanhSachPhanCong.Size = new System.Drawing.Size(586, 483);
			this.dgvDanhSachPhanCong.TabIndex = 208;
			// 
			// frmPhanCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 536);
			this.Controls.Add(this.dgvDanhSachPhanCong);
			this.Controls.Add(this.txtTotalPage);
			this.Controls.Add(this.btnFirstPage);
			this.Controls.Add(this.txtPageNumber);
			this.Controls.Add(this.btnLastPage);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnPrevPage);
			this.Controls.Add(this.btnNextPage);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnThoat);
			this.Name = "frmPhanCong";
			this.Text = "Phân công ca làm việc";
			this.Load += new System.EventHandler(this.frmPhanCong_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhanCong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Label labelLoaiPhong;
		private System.Windows.Forms.Label labelTenPhong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpNgayPhanCong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPageNumber;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.TextBox txtTotalPage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvDanhSachPhanCong;
		private System.Windows.Forms.ComboBox cbTenCa;
		private System.Windows.Forms.ComboBox cbTenNV;
		private System.Windows.Forms.ComboBox cbMaNV;
	}
}