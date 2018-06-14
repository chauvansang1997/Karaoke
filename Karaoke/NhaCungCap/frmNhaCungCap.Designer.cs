namespace Karaoke.NhaCungCap
{
	partial class frmNhaCungCap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
			this.dgvDanhSachNCC = new System.Windows.Forms.DataGridView();
			this.txtTotalPage = new System.Windows.Forms.TextBox();
			this.btnFirstPage = new System.Windows.Forms.Button();
			this.txtPageNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelTenPhong = new System.Windows.Forms.Label();
			this.labelLoaiPhong = new System.Windows.Forms.Label();
			this.btnPrevPage = new System.Windows.Forms.Button();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCapNhatNCC = new System.Windows.Forms.Button();
			this.btnXoaNCC = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThemNCC = new System.Windows.Forms.Button();
			this.btnLastPage = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThoat = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaNCC = new System.Windows.Forms.TextBox();
			this.txtTenNCC = new System.Windows.Forms.TextBox();
			this.txtLoaiHangCC = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDanhSachNCC
			// 
			this.dgvDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachNCC.Location = new System.Drawing.Point(488, 1);
			this.dgvDanhSachNCC.Name = "dgvDanhSachNCC";
			this.dgvDanhSachNCC.Size = new System.Drawing.Size(665, 459);
			this.dgvDanhSachNCC.TabIndex = 219;
			// 
			// txtTotalPage
			// 
			this.txtTotalPage.Location = new System.Drawing.Point(846, 475);
			this.txtTotalPage.Name = "txtTotalPage";
			this.txtTotalPage.ReadOnly = true;
			this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
			this.txtTotalPage.TabIndex = 214;
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
			this.btnFirstPage.Location = new System.Drawing.Point(738, 475);
			this.btnFirstPage.Name = "btnFirstPage";
			this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
			this.btnFirstPage.TabIndex = 218;
			this.btnFirstPage.UseVisualStyleBackColor = false;
			// 
			// txtPageNumber
			// 
			this.txtPageNumber.Location = new System.Drawing.Point(790, 475);
			this.txtPageNumber.Name = "txtPageNumber";
			this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
			this.txtPageNumber.TabIndex = 213;
			this.txtPageNumber.Text = "1";
			this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 277);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 19);
			this.label1.TabIndex = 186;
			this.label1.Text = "Loại hàng cung cấp:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(55, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(214, 33);
			this.label5.TabIndex = 185;
			this.label5.Text = "QUẢN LÝ NCC";
			// 
			// labelTenPhong
			// 
			this.labelTenPhong.AutoSize = true;
			this.labelTenPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTenPhong.ForeColor = System.Drawing.Color.White;
			this.labelTenPhong.Location = new System.Drawing.Point(22, 115);
			this.labelTenPhong.Name = "labelTenPhong";
			this.labelTenPhong.Size = new System.Drawing.Size(134, 19);
			this.labelTenPhong.TabIndex = 177;
			this.labelTenPhong.Text = "Mã nhà cung cấp:";
			// 
			// labelLoaiPhong
			// 
			this.labelLoaiPhong.AutoSize = true;
			this.labelLoaiPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLoaiPhong.ForeColor = System.Drawing.Color.White;
			this.labelLoaiPhong.Location = new System.Drawing.Point(23, 196);
			this.labelLoaiPhong.Name = "labelLoaiPhong";
			this.labelLoaiPhong.Size = new System.Drawing.Size(141, 19);
			this.labelLoaiPhong.TabIndex = 175;
			this.labelLoaiPhong.Text = "Tên nhà cung cấp:";
			// 
			// btnPrevPage
			// 
			this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
			this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
			this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnPrevPage.Location = new System.Drawing.Point(764, 475);
			this.btnPrevPage.Name = "btnPrevPage";
			this.btnPrevPage.Size = new System.Drawing.Size(24, 24);
			this.btnPrevPage.TabIndex = 216;
			this.btnPrevPage.UseVisualStyleBackColor = false;
			// 
			// btnNextPage
			// 
			this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
			this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.forward1;
			this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnNextPage.Location = new System.Drawing.Point(885, 475);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(24, 24);
			this.btnNextPage.TabIndex = 215;
			this.btnNextPage.UseVisualStyleBackColor = false;
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
			// btnCapNhatNCC
			// 
			this.btnCapNhatNCC.FlatAppearance.BorderSize = 0;
			this.btnCapNhatNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapNhatNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhatNCC.ForeColor = System.Drawing.Color.White;
			this.btnCapNhatNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatNCC.Image")));
			this.btnCapNhatNCC.Location = new System.Drawing.Point(11, 265);
			this.btnCapNhatNCC.Name = "btnCapNhatNCC";
			this.btnCapNhatNCC.Size = new System.Drawing.Size(146, 60);
			this.btnCapNhatNCC.TabIndex = 2;
			this.btnCapNhatNCC.Text = "Cập nhật";
			this.btnCapNhatNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhatNCC.UseVisualStyleBackColor = true;
			this.btnCapNhatNCC.Click += new System.EventHandler(this.btnCapNhatNCC_Click);
			// 
			// btnXoaNCC
			// 
			this.btnXoaNCC.FlatAppearance.BorderSize = 0;
			this.btnXoaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoaNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaNCC.ForeColor = System.Drawing.Color.White;
			this.btnXoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNCC.Image")));
			this.btnXoaNCC.Location = new System.Drawing.Point(11, 324);
			this.btnXoaNCC.Name = "btnXoaNCC";
			this.btnXoaNCC.Size = new System.Drawing.Size(146, 60);
			this.btnXoaNCC.TabIndex = 1;
			this.btnXoaNCC.Text = "Xoá";
			this.btnXoaNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoaNCC.UseVisualStyleBackColor = true;
			this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.btnCapNhatNCC);
			this.panel2.Controls.Add(this.btnXoaNCC);
			this.panel2.Controls.Add(this.btnThemNCC);
			this.panel2.Location = new System.Drawing.Point(323, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(159, 511);
			this.panel2.TabIndex = 211;
			// 
			// btnThemNCC
			// 
			this.btnThemNCC.FlatAppearance.BorderSize = 0;
			this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemNCC.ForeColor = System.Drawing.Color.White;
			this.btnThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.Image")));
			this.btnThemNCC.Location = new System.Drawing.Point(13, 205);
			this.btnThemNCC.Name = "btnThemNCC";
			this.btnThemNCC.Size = new System.Drawing.Size(143, 60);
			this.btnThemNCC.TabIndex = 187;
			this.btnThemNCC.Text = "Thêm";
			this.btnThemNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemNCC.UseVisualStyleBackColor = true;
			this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
			// 
			// btnLastPage
			// 
			this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
			this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
			this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
			this.btnLastPage.Location = new System.Drawing.Point(911, 475);
			this.btnLastPage.Name = "btnLastPage";
			this.btnLastPage.Size = new System.Drawing.Size(24, 24);
			this.btnLastPage.TabIndex = 217;
			this.btnLastPage.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(829, 475);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 20);
			this.label7.TabIndex = 212;
			this.label7.Text = "/";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.panel1.Controls.Add(this.txtDiaChi);
			this.panel1.Controls.Add(this.txtSDT);
			this.panel1.Controls.Add(this.txtLoaiHangCC);
			this.panel1.Controls.Add(this.txtTenNCC);
			this.panel1.Controls.Add(this.txtMaNCC);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.labelTenPhong);
			this.panel1.Controls.Add(this.labelLoaiPhong);
			this.panel1.Location = new System.Drawing.Point(-10, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(332, 511);
			this.panel1.TabIndex = 209;
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
			this.btnThoat.Location = new System.Drawing.Point(1006, 465);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 36);
			this.btnThoat.TabIndex = 210;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(23, 426);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 19);
			this.label2.TabIndex = 188;
			this.label2.Text = "Địa chỉ:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(23, 345);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 19);
			this.label3.TabIndex = 187;
			this.label3.Text = "Số điện thoại:";
			// 
			// txtMaNCC
			// 
			this.txtMaNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNCC.Location = new System.Drawing.Point(23, 138);
			this.txtMaNCC.Name = "txtMaNCC";
			this.txtMaNCC.Size = new System.Drawing.Size(306, 27);
			this.txtMaNCC.TabIndex = 189;
			// 
			// txtTenNCC
			// 
			this.txtTenNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNCC.Location = new System.Drawing.Point(22, 218);
			this.txtTenNCC.Name = "txtTenNCC";
			this.txtTenNCC.Size = new System.Drawing.Size(306, 27);
			this.txtTenNCC.TabIndex = 189;
			// 
			// txtLoaiHangCC
			// 
			this.txtLoaiHangCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLoaiHangCC.Location = new System.Drawing.Point(21, 299);
			this.txtLoaiHangCC.Name = "txtLoaiHangCC";
			this.txtLoaiHangCC.Size = new System.Drawing.Size(306, 27);
			this.txtLoaiHangCC.TabIndex = 189;
			// 
			// txtSDT
			// 
			this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(21, 367);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(306, 27);
			this.txtSDT.TabIndex = 189;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(21, 448);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(306, 27);
			this.txtDiaChi.TabIndex = 189;
			// 
			// frmNhaCungCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 507);
			this.Controls.Add(this.dgvDanhSachNCC);
			this.Controls.Add(this.txtTotalPage);
			this.Controls.Add(this.btnFirstPage);
			this.Controls.Add(this.txtPageNumber);
			this.Controls.Add(this.btnPrevPage);
			this.Controls.Add(this.btnNextPage);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnLastPage);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnThoat);
			this.Name = "frmNhaCungCap";
			this.Text = "frmNhaCungCap";
			this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDanhSachNCC;
		private System.Windows.Forms.TextBox txtTotalPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.TextBox txtPageNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelTenPhong;
		private System.Windows.Forms.Label labelLoaiPhong;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCapNhatNCC;
		private System.Windows.Forms.Button btnXoaNCC;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnThemNCC;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtLoaiHangCC;
		private System.Windows.Forms.TextBox txtTenNCC;
		private System.Windows.Forms.TextBox txtMaNCC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}