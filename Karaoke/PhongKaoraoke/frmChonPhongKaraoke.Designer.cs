namespace Karaoke.PhongKaoraoke
{
    partial class frmChonPhongKaraoke
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
            this.dGVDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dGVDanhSachChonPhong = new System.Windows.Forms.DataGridView();
            this.btnDatPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachChonPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDanhSachPhong
            // 
            this.dGVDanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVDanhSachPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachPhong.Location = new System.Drawing.Point(18, 42);
            this.dGVDanhSachPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dGVDanhSachPhong.MultiSelect = false;
            this.dGVDanhSachPhong.Name = "dGVDanhSachPhong";
            this.dGVDanhSachPhong.ReadOnly = true;
            this.dGVDanhSachPhong.RowHeadersVisible = false;
            this.dGVDanhSachPhong.RowTemplate.Height = 33;
            this.dGVDanhSachPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDanhSachPhong.Size = new System.Drawing.Size(484, 371);
            this.dGVDanhSachPhong.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(272, 430);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 36);
            this.btnXoa.TabIndex = 158;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(127, 430);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 36);
            this.btnThem.TabIndex = 157;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dGVDanhSachChonPhong
            // 
            this.dGVDanhSachChonPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachChonPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVDanhSachChonPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVDanhSachChonPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachChonPhong.Location = new System.Drawing.Point(534, 42);
            this.dGVDanhSachChonPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dGVDanhSachChonPhong.MultiSelect = false;
            this.dGVDanhSachChonPhong.Name = "dGVDanhSachChonPhong";
            this.dGVDanhSachChonPhong.ReadOnly = true;
            this.dGVDanhSachChonPhong.RowHeadersVisible = false;
            this.dGVDanhSachChonPhong.RowTemplate.Height = 33;
            this.dGVDanhSachChonPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDanhSachChonPhong.Size = new System.Drawing.Size(487, 371);
            this.dGVDanhSachChonPhong.TabIndex = 159;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(726, 430);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(110, 36);
            this.btnDatPhong.TabIndex = 160;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // frmChonPhongKaraoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 489);
            this.Controls.Add(this.dGVDanhSachPhong);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.dGVDanhSachChonPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChonPhongKaraoke";
            this.Text = "frmChonPhongKaraoke";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachChonPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDanhSachPhong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dGVDanhSachChonPhong;
        private System.Windows.Forms.Button btnDatPhong;
    }
}