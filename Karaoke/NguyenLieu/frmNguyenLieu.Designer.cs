namespace Karaoke.NguyenLieu
{
    partial class frmNguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dGVNguyenLieu = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSoLuong = new System.Windows.Forms.RadioButton();
            this.rbTatCa = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNguyenLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(520, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(101, 26);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 140;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(65, 26);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 139;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 138;
            this.label6.Text = "Trang:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dGVNguyenLieu
            // 
            this.dGVNguyenLieu.AllowUserToAddRows = false;
            this.dGVNguyenLieu.AllowUserToDeleteRows = false;
            this.dGVNguyenLieu.AllowUserToResizeColumns = false;
            this.dGVNguyenLieu.AllowUserToResizeRows = false;
            this.dGVNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNguyenLieu.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVNguyenLieu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVNguyenLieu.Location = new System.Drawing.Point(5, 48);
            this.dGVNguyenLieu.Name = "dGVNguyenLieu";
            this.dGVNguyenLieu.ReadOnly = true;
            this.dGVNguyenLieu.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dGVNguyenLieu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVNguyenLieu.Size = new System.Drawing.Size(647, 342);
            this.dGVNguyenLieu.TabIndex = 149;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(405, 396);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 155;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(292, 396);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 33);
            this.btnThem.TabIndex = 153;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 158;
            this.label11.Text = "Tên nguyên liệu:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 156;
            this.label7.Text = "Nhà cung cấp:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(135, 86);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(179, 23);
            this.cmbNhaCungCap.TabIndex = 160;
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(135, 45);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(179, 20);
            this.txtTenNguyenLieu.TabIndex = 161;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSoLuong);
            this.groupBox1.Controls.Add(this.rbTatCa);
            this.groupBox1.Location = new System.Drawing.Point(29, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 57);
            this.groupBox1.TabIndex = 162;
            this.groupBox1.TabStop = false;
            // 
            // rbSoLuong
            // 
            this.rbSoLuong.AutoSize = true;
            this.rbSoLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbSoLuong.Location = new System.Drawing.Point(138, 19);
            this.rbSoLuong.Name = "rbSoLuong";
            this.rbSoLuong.Size = new System.Drawing.Size(105, 17);
            this.rbSoLuong.TabIndex = 3;
            this.rbSoLuong.TabStop = true;
            this.rbSoLuong.Text = "Sắp hết số lượng";
            this.rbSoLuong.UseVisualStyleBackColor = true;
            // 
            // rbTatCa
            // 
            this.rbTatCa.AutoSize = true;
            this.rbTatCa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbTatCa.Location = new System.Drawing.Point(18, 19);
            this.rbTatCa.Name = "rbTatCa";
            this.rbTatCa.Size = new System.Drawing.Size(56, 17);
            this.rbTatCa.TabIndex = 2;
            this.rbTatCa.TabStop = true;
            this.rbTatCa.Text = "Tất cả";
            this.rbTatCa.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 45);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1019, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "QUẢN LÝ NGUYÊN LIỆU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer.Location = new System.Drawing.Point(0, 45);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnAn);
            this.splitContainer.Panel1.Controls.Add(this.btnTimKiem);
            this.splitContainer.Panel1.Controls.Add(this.label7);
            this.splitContainer.Panel1.Controls.Add(this.cmbNhaCungCap);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.label11);
            this.splitContainer.Panel1.Controls.Add(this.txtTenNguyenLieu);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtTotalPage);
            this.splitContainer.Panel2.Controls.Add(this.btnFirstPage);
            this.splitContainer.Panel2.Controls.Add(this.btnSua);
            this.splitContainer.Panel2.Controls.Add(this.btnThoat);
            this.splitContainer.Panel2.Controls.Add(this.txtPageNumber);
            this.splitContainer.Panel2.Controls.Add(this.btnThem);
            this.splitContainer.Panel2.Controls.Add(this.btnLastPage);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.dGVNguyenLieu);
            this.splitContainer.Panel2.Controls.Add(this.btnPrevPage);
            this.splitContainer.Panel2.Controls.Add(this.btnNextPage);
            this.splitContainer.Size = new System.Drawing.Size(1019, 449);
            this.splitContainer.SplitterDistance = 360;
            this.splitContainer.TabIndex = 163;
            // 
            // btnAn
            // 
            this.btnAn.BackColor = System.Drawing.Color.Transparent;
            this.btnAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAn.ForeColor = System.Drawing.Color.Transparent;
            this.btnAn.Image = global::Karaoke.Properties.Resources.rewind;
            this.btnAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAn.Location = new System.Drawing.Point(295, 5);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(41, 29);
            this.btnAn.TabIndex = 163;
            this.btnAn.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Image = global::Karaoke.Properties.Resources.lens;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(232, 214);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 29);
            this.btnTimKiem.TabIndex = 67;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.go_first;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Location = new System.Drawing.Point(201, 15);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(30, 30);
            this.btnFirstPage.TabIndex = 148;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = global::Karaoke.Properties.Resources.go_last;
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Location = new System.Drawing.Point(319, 15);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(30, 30);
            this.btnLastPage.TabIndex = 147;
            this.btnLastPage.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.BackgroundImage = global::Karaoke.Properties.Resources.left_arrow;
            this.btnPrevPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevPage.Location = new System.Drawing.Point(235, 11);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(34, 34);
            this.btnPrevPage.TabIndex = 146;
            this.btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = global::Karaoke.Properties.Resources.right_arrow;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextPage.Location = new System.Drawing.Point(278, 10);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 35);
            this.btnNextPage.TabIndex = 145;
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // frmNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(216)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 494);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNguyenLieu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dGVNguyenLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridView dGVNguyenLieu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSoLuong;
        private System.Windows.Forms.RadioButton rbTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnAn;
    }
}