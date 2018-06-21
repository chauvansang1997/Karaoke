namespace Karaoke.GUI_QuanLyNhanVien
{
    partial class frmNhanVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
			this.lblTaiKhoan = new System.Windows.Forms.Label();
			this.lblSDT = new System.Windows.Forms.Label();
			this.lblMaCVu = new System.Windows.Forms.Label();
			this.lblMaNV = new System.Windows.Forms.Label();
			this.lblTenNV = new System.Windows.Forms.Label();
			this.lblDiaChi = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTraCuu = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.cbxMaCVU = new System.Windows.Forms.ComboBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.btnTaoTK = new System.Windows.Forms.Button();
			this.dGVDSNV = new System.Windows.Forms.DataGridView();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVDSNV)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTaiKhoan
			// 
			this.lblTaiKhoan.AutoSize = true;
			this.lblTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaiKhoan.ForeColor = System.Drawing.Color.White;
			this.lblTaiKhoan.Location = new System.Drawing.Point(12, 385);
			this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTaiKhoan.Name = "lblTaiKhoan";
			this.lblTaiKhoan.Size = new System.Drawing.Size(79, 19);
			this.lblTaiKhoan.TabIndex = 1;
			this.lblTaiKhoan.Text = "Tài khoản";
			// 
			// lblSDT
			// 
			this.lblSDT.AutoSize = true;
			this.lblSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSDT.ForeColor = System.Drawing.Color.White;
			this.lblSDT.Location = new System.Drawing.Point(12, 205);
			this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSDT.Name = "lblSDT";
			this.lblSDT.Size = new System.Drawing.Size(102, 19);
			this.lblSDT.TabIndex = 2;
			this.lblSDT.Text = "Số điện thoại";
			// 
			// lblMaCVu
			// 
			this.lblMaCVu.AutoSize = true;
			this.lblMaCVu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaCVu.ForeColor = System.Drawing.Color.White;
			this.lblMaCVu.Location = new System.Drawing.Point(12, 325);
			this.lblMaCVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaCVu.Name = "lblMaCVu";
			this.lblMaCVu.Size = new System.Drawing.Size(89, 19);
			this.lblMaCVu.TabIndex = 3;
			this.lblMaCVu.Text = "Mã chức vụ";
			// 
			// lblMaNV
			// 
			this.lblMaNV.AutoSize = true;
			this.lblMaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaNV.ForeColor = System.Drawing.Color.White;
			this.lblMaNV.Location = new System.Drawing.Point(12, 85);
			this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMaNV.Name = "lblMaNV";
			this.lblMaNV.Size = new System.Drawing.Size(103, 19);
			this.lblMaNV.TabIndex = 4;
			this.lblMaNV.Text = "Mã nhân viên";
			// 
			// lblTenNV
			// 
			this.lblTenNV.AutoSize = true;
			this.lblTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTenNV.ForeColor = System.Drawing.Color.White;
			this.lblTenNV.Location = new System.Drawing.Point(12, 145);
			this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTenNV.Name = "lblTenNV";
			this.lblTenNV.Size = new System.Drawing.Size(110, 19);
			this.lblTenNV.TabIndex = 5;
			this.lblTenNV.Text = "Tên nhân viên";
			// 
			// lblDiaChi
			// 
			this.lblDiaChi.AutoSize = true;
			this.lblDiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiaChi.ForeColor = System.Drawing.Color.White;
			this.lblDiaChi.Location = new System.Drawing.Point(12, 265);
			this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDiaChi.Name = "lblDiaChi";
			this.lblDiaChi.Size = new System.Drawing.Size(57, 19);
			this.lblDiaChi.TabIndex = 6;
			this.lblDiaChi.Text = "Địa chỉ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.panel1.Controls.Add(this.btnTraCuu);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtTaiKhoan);
			this.panel1.Controls.Add(this.cbxMaCVU);
			this.panel1.Controls.Add(this.txtDiaChi);
			this.panel1.Controls.Add(this.txtSDT);
			this.panel1.Controls.Add(this.txtTenNV);
			this.panel1.Controls.Add(this.txtMaNV);
			this.panel1.Controls.Add(this.lblMaNV);
			this.panel1.Controls.Add(this.lblTaiKhoan);
			this.panel1.Controls.Add(this.lblDiaChi);
			this.panel1.Controls.Add(this.lblTenNV);
			this.panel1.Controls.Add(this.lblMaCVu);
			this.panel1.Controls.Add(this.lblSDT);
			this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, -2);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(317, 518);
			this.panel1.TabIndex = 7;
			// 
			// btnTraCuu
			// 
			this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnTraCuu.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTraCuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTraCuu.ForeColor = System.Drawing.Color.White;
			this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
			this.btnTraCuu.Location = new System.Drawing.Point(92, 460);
			this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
			this.btnTraCuu.Name = "btnTraCuu";
			this.btnTraCuu.Size = new System.Drawing.Size(137, 38);
			this.btnTraCuu.TabIndex = 19;
			this.btnTraCuu.Text = "Tìm kiếm";
			this.btnTraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTraCuu.UseVisualStyleBackColor = false;
			this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Vni 13 Annabelle", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(26, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(252, 38);
			this.label1.TabIndex = 18;
			this.label1.Text = "Quản lý nhân viên";
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
			this.txtTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaiKhoan.Location = new System.Drawing.Point(12, 411);
			this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(288, 27);
			this.txtTaiKhoan.TabIndex = 12;
			// 
			// cbxMaCVU
			// 
			this.cbxMaCVU.BackColor = System.Drawing.Color.White;
			this.cbxMaCVU.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxMaCVU.FormattingEnabled = true;
			this.cbxMaCVU.Location = new System.Drawing.Point(12, 351);
			this.cbxMaCVU.Margin = new System.Windows.Forms.Padding(2);
			this.cbxMaCVU.Name = "cbxMaCVU";
			this.cbxMaCVU.Size = new System.Drawing.Size(288, 27);
			this.cbxMaCVU.TabIndex = 11;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.BackColor = System.Drawing.Color.White;
			this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.Location = new System.Drawing.Point(12, 291);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(288, 27);
			this.txtDiaChi.TabIndex = 10;
			// 
			// txtSDT
			// 
			this.txtSDT.BackColor = System.Drawing.Color.White;
			this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSDT.Location = new System.Drawing.Point(12, 231);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(288, 27);
			this.txtSDT.TabIndex = 9;
			// 
			// txtTenNV
			// 
			this.txtTenNV.BackColor = System.Drawing.Color.White;
			this.txtTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenNV.Location = new System.Drawing.Point(12, 171);
			this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(288, 27);
			this.txtTenNV.TabIndex = 8;
			// 
			// txtMaNV
			// 
			this.txtMaNV.BackColor = System.Drawing.Color.White;
			this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNV.Location = new System.Drawing.Point(12, 111);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(288, 27);
			this.txtMaNV.TabIndex = 7;
			// 
			// btnTaoTK
			// 
			this.btnTaoTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnTaoTK.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTaoTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTaoTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaoTK.ForeColor = System.Drawing.Color.White;
			this.btnTaoTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.Image")));
			this.btnTaoTK.Location = new System.Drawing.Point(325, 470);
			this.btnTaoTK.Margin = new System.Windows.Forms.Padding(2);
			this.btnTaoTK.Name = "btnTaoTK";
			this.btnTaoTK.Size = new System.Drawing.Size(162, 36);
			this.btnTaoTK.TabIndex = 17;
			this.btnTaoTK.Text = "Tạo tài khoản";
			this.btnTaoTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTaoTK.UseVisualStyleBackColor = false;
			this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
			// 
			// dGVDSNV
			// 
			this.dGVDSNV.BackgroundColor = System.Drawing.Color.White;
			this.dGVDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGVDSNV.Location = new System.Drawing.Point(325, 11);
			this.dGVDSNV.Margin = new System.Windows.Forms.Padding(2);
			this.dGVDSNV.Name = "dGVDSNV";
			this.dGVDSNV.RowTemplate.Height = 24;
			this.dGVDSNV.Size = new System.Drawing.Size(616, 454);
			this.dGVDSNV.TabIndex = 8;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
			this.btnThoat.Location = new System.Drawing.Point(841, 470);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 36);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhat.ForeColor = System.Drawing.Color.White;
			this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
			this.btnCapNhat.Location = new System.Drawing.Point(737, 470);
			this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(100, 36);
			this.btnCapNhat.TabIndex = 20;
			this.btnCapNhat.Text = "Sửa";
			this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhat.UseVisualStyleBackColor = false;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
			this.btnXoa.Location = new System.Drawing.Point(633, 470);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(100, 36);
			this.btnXoa.TabIndex = 19;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
			this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.Location = new System.Drawing.Point(529, 470);
			this.btnThem.Margin = new System.Windows.Forms.Padding(2);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(100, 36);
			this.btnThem.TabIndex = 18;
			this.btnThem.Text = "Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// frmNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 512);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnTaoTK);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.dGVDSNV);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmNhanVien";
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.frmNhanVien_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVDSNV)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblMaCVu;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cbxMaCVU;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dGVDSNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTraCuu;
    }
}