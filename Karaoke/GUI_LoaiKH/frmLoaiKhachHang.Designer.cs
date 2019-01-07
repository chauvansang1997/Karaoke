namespace Karaoke.GUI_LoaiKH
{
	partial class frmLoaiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiKhachHang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapNhatLoaiKH = new System.Windows.Forms.Button();
            this.btnXoaLoaiKH = new System.Windows.Forms.Button();
            this.btnThemLoaiKH = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDanhSachLoaiKH = new System.Windows.Forms.DataGridView();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoDienTichLuy = new System.Windows.Forms.TextBox();
            this.txtTenLoaiKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiKH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCapNhatLoaiKH);
            this.panel2.Controls.Add(this.btnXoaLoaiKH);
            this.panel2.Controls.Add(this.btnThemLoaiKH);
            this.panel2.Location = new System.Drawing.Point(532, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 735);
            this.panel2.TabIndex = 233;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 33);
            this.label4.TabIndex = 185;
            // 
            // btnCapNhatLoaiKH
            // 
            this.btnCapNhatLoaiKH.FlatAppearance.BorderSize = 0;
            this.btnCapNhatLoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatLoaiKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiKH.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatLoaiKH.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatLoaiKH.Image")));
            this.btnCapNhatLoaiKH.Location = new System.Drawing.Point(4, 177);
            this.btnCapNhatLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhatLoaiKH.Name = "btnCapNhatLoaiKH";
            this.btnCapNhatLoaiKH.Size = new System.Drawing.Size(196, 92);
            this.btnCapNhatLoaiKH.TabIndex = 2;
            this.btnCapNhatLoaiKH.Text = " Cập nhật";
            this.btnCapNhatLoaiKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatLoaiKH.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiKH.Click += new System.EventHandler(this.btnCapNhatLoaiKH_Click);
            // 
            // btnXoaLoaiKH
            // 
            this.btnXoaLoaiKH.FlatAppearance.BorderSize = 0;
            this.btnXoaLoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLoaiKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiKH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLoaiKH.Image")));
            this.btnXoaLoaiKH.Location = new System.Drawing.Point(4, 268);
            this.btnXoaLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaLoaiKH.Name = "btnXoaLoaiKH";
            this.btnXoaLoaiKH.Size = new System.Drawing.Size(196, 92);
            this.btnXoaLoaiKH.TabIndex = 1;
            this.btnXoaLoaiKH.Text = " Xoá";
            this.btnXoaLoaiKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaLoaiKH.UseVisualStyleBackColor = true;
            this.btnXoaLoaiKH.Click += new System.EventHandler(this.btnXoaLoaiKH_Click);
            // 
            // btnThemLoaiKH
            // 
            this.btnThemLoaiKH.FlatAppearance.BorderSize = 0;
            this.btnThemLoaiKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiKH.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiKH.Image")));
            this.btnThemLoaiKH.Location = new System.Drawing.Point(4, 85);
            this.btnThemLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemLoaiKH.Name = "btnThemLoaiKH";
            this.btnThemLoaiKH.Size = new System.Drawing.Size(195, 92);
            this.btnThemLoaiKH.TabIndex = 187;
            this.btnThemLoaiKH.Text = " Thêm";
            this.btnThemLoaiKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemLoaiKH.UseVisualStyleBackColor = true;
            this.btnThemLoaiKH.Click += new System.EventHandler(this.btnThemLoaiKH_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1080, 658);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 31);
            this.label7.TabIndex = 234;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDanhSachLoaiKH
            // 
            this.dgvDanhSachLoaiKH.AllowUserToAddRows = false;
            this.dgvDanhSachLoaiKH.AllowUserToDeleteRows = false;
            this.dgvDanhSachLoaiKH.AllowUserToResizeRows = false;
            this.dgvDanhSachLoaiKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiKH.Location = new System.Drawing.Point(746, 17);
            this.dgvDanhSachLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhSachLoaiKH.Name = "dgvDanhSachLoaiKH";
            this.dgvDanhSachLoaiKH.RowHeadersVisible = false;
            this.dgvDanhSachLoaiKH.Size = new System.Drawing.Size(681, 631);
            this.dgvDanhSachLoaiKH.TabIndex = 241;
            this.dgvDanhSachLoaiKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLoaiKH_CellClick);
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPage.Location = new System.Drawing.Point(1106, 658);
            this.txtTotalPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(54, 30);
            this.txtTotalPage.TabIndex = 236;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPageNumber.Location = new System.Drawing.Point(1022, 658);
            this.txtPageNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(54, 30);
            this.txtPageNumber.TabIndex = 235;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.txtSoDienTichLuy);
            this.panel1.Controls.Add(this.txtTenLoaiKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelLoaiPhong);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 735);
            this.panel1.TabIndex = 231;
            // 
            // txtSoDienTichLuy
            // 
            this.txtSoDienTichLuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienTichLuy.Location = new System.Drawing.Point(44, 374);
            this.txtSoDienTichLuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienTichLuy.Name = "txtSoDienTichLuy";
            this.txtSoDienTichLuy.Size = new System.Drawing.Size(457, 36);
            this.txtSoDienTichLuy.TabIndex = 189;
            // 
            // txtTenLoaiKH
            // 
            this.txtTenLoaiKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiKH.Location = new System.Drawing.Point(44, 269);
            this.txtTenLoaiKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoaiKH.Name = "txtTenLoaiKH";
            this.txtTenLoaiKH.Size = new System.Drawing.Size(457, 36);
            this.txtTenLoaiKH.TabIndex = 189;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 186;
            this.label1.Text = " Số tiền tích lũy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 52);
            this.label5.TabIndex = 185;
            this.label5.Text = "QUẢN LÝ LOẠI KHÁCH";
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.labelLoaiPhong.Location = new System.Drawing.Point(44, 223);
            this.labelLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(175, 29);
            this.labelLoaiPhong.TabIndex = 175;
            this.labelLoaiPhong.Text = "Tên loại khách:";
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.last_page;
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Location = new System.Drawing.Point(1203, 658);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(36, 37);
            this.btnLastPage.TabIndex = 239;
            this.btnLastPage.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.backward;
            this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.Location = new System.Drawing.Point(982, 658);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(36, 37);
            this.btnPrevPage.TabIndex = 238;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.forward1;
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextPage.Location = new System.Drawing.Point(1164, 658);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(36, 37);
            this.btnNextPage.TabIndex = 237;
            this.btnNextPage.UseVisualStyleBackColor = false;
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
            this.btnThoat.Location = new System.Drawing.Point(1276, 663);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 55);
            this.btnThoat.TabIndex = 232;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Location = new System.Drawing.Point(944, 658);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(36, 37);
            this.btnFirstPage.TabIndex = 240;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            // 
            // frmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhSachLoaiKH);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLoaiKhachHang";
            this.Text = "Quản lý loại khách hàng";
            this.Load += new System.EventHandler(this.frmLoaiKhachHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCapNhatLoaiKH;
		private System.Windows.Forms.Button btnXoaLoaiKH;
		private System.Windows.Forms.Button btnThemLoaiKH;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnPrevPage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgvDanhSachLoaiKH;
		private System.Windows.Forms.TextBox txtTotalPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.TextBox txtPageNumber;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtSoDienTichLuy;
		private System.Windows.Forms.TextBox txtTenLoaiKH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelLoaiPhong;
	}
}