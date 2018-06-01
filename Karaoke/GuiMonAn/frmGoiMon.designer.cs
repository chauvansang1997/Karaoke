namespace Karaoke.GuiMonAn
{
    partial class frmGoiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoiMon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiamGia = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTongCong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVHoaDon = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTraiCay = new System.Windows.Forms.Button();
            this.btnNuocUong = new System.Windows.Forms.Button();
            this.btnThucAn = new System.Windows.Forms.Button();
            this.flowFoodLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiamGia);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTongCong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dGVHoaDon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 483);
            this.panel1.TabIndex = 0;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.AutoSize = true;
            this.txtGiamGia.Location = new System.Drawing.Point(400, 418);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(43, 13);
            this.txtGiamGia.TabIndex = 7;
            this.txtGiamGia.Text = "100000";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoSize = true;
            this.txtThanhTien.Location = new System.Drawing.Point(400, 455);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(43, 13);
            this.txtThanhTien.TabIndex = 6;
            this.txtThanhTien.Text = "200000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thành tiền:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 3);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtTongCong
            // 
            this.txtTongCong.AutoSize = true;
            this.txtTongCong.Location = new System.Drawing.Point(400, 387);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(43, 13);
            this.txtTongCong.TabIndex = 3;
            this.txtTongCong.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giảm giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng cộng:";
            // 
            // dGVHoaDon
            // 
            this.dGVHoaDon.AllowDrop = true;
            this.dGVHoaDon.AllowUserToAddRows = false;
            this.dGVHoaDon.AllowUserToDeleteRows = false;
            this.dGVHoaDon.AllowUserToResizeColumns = false;
            this.dGVHoaDon.AllowUserToResizeRows = false;
            this.dGVHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa});
            this.dGVHoaDon.Location = new System.Drawing.Point(3, 3);
            this.dGVHoaDon.MultiSelect = false;
            this.dGVHoaDon.Name = "dGVHoaDon";
            this.dGVHoaDon.RowHeadersVisible = false;
            this.dGVHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVHoaDon.Size = new System.Drawing.Size(496, 368);
            this.dGVHoaDon.TabIndex = 0;
            this.dGVHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHoaDon_CellClick);
            this.dGVHoaDon.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dGVHoaDon_CellValidating);
            this.dGVHoaDon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVHoaDon_CellValueChanged);
            this.dGVHoaDon.DragDrop += new System.Windows.Forms.DragEventHandler(this.dGVHoaDon_DragDrop);
            this.dGVHoaDon.DragOver += new System.Windows.Forms.DragEventHandler(this.dGVHoaDon_DragOver);
            this.dGVHoaDon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dGVHoaDon_MouseDown);
            this.dGVHoaDon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dGVHoaDon_MouseMove);
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.Width = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnTraiCay);
            this.panel2.Controls.Add(this.btnNuocUong);
            this.panel2.Controls.Add(this.btnThucAn);
            this.panel2.Location = new System.Drawing.Point(520, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 480);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 62);
            this.button5.TabIndex = 8;
            this.button5.Text = "Sinh tố";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnTraiCay
            // 
            this.btnTraiCay.Location = new System.Drawing.Point(12, 225);
            this.btnTraiCay.Name = "btnTraiCay";
            this.btnTraiCay.Size = new System.Drawing.Size(90, 59);
            this.btnTraiCay.TabIndex = 6;
            this.btnTraiCay.Text = "Trái cây";
            this.btnTraiCay.UseVisualStyleBackColor = true;
            this.btnTraiCay.Click += new System.EventHandler(this.btnTraiCay_Click);
            // 
            // btnNuocUong
            // 
            this.btnNuocUong.Location = new System.Drawing.Point(12, 128);
            this.btnNuocUong.Name = "btnNuocUong";
            this.btnNuocUong.Size = new System.Drawing.Size(90, 65);
            this.btnNuocUong.TabIndex = 5;
            this.btnNuocUong.Text = "Nước uống";
            this.btnNuocUong.UseVisualStyleBackColor = true;
            this.btnNuocUong.Click += new System.EventHandler(this.btnNuocUong_Click);
            // 
            // btnThucAn
            // 
            this.btnThucAn.Location = new System.Drawing.Point(12, 22);
            this.btnThucAn.Name = "btnThucAn";
            this.btnThucAn.Size = new System.Drawing.Size(90, 68);
            this.btnThucAn.TabIndex = 0;
            this.btnThucAn.Text = "Thức ăn";
            this.btnThucAn.UseVisualStyleBackColor = true;
            this.btnThucAn.Click += new System.EventHandler(this.btnThucAn_Click);
            // 
            // flowFoodLayout
            // 
            this.flowFoodLayout.AutoScroll = true;
            this.flowFoodLayout.Location = new System.Drawing.Point(636, 47);
            this.flowFoodLayout.Name = "flowFoodLayout";
            this.flowFoodLayout.Size = new System.Drawing.Size(440, 448);
            this.flowFoodLayout.TabIndex = 2;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(882, 21);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 151;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(827, 21);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 150;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNumber.TextChanged += new System.EventHandler(this.txtPageNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(866, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 149;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.Image = global::Karaoke.Properties.Resources.diskette;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(249, 501);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.TabIndex = 172;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = global::Karaoke.Properties.Resources.first_pape;
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Location = new System.Drawing.Point(774, 19);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
            this.btnFirstPage.TabIndex = 155;
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
            this.btnLastPage.Location = new System.Drawing.Point(948, 19);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(24, 24);
            this.btnLastPage.TabIndex = 154;
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
            this.btnPrevPage.Location = new System.Drawing.Point(797, 19);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(24, 24);
            this.btnPrevPage.TabIndex = 153;
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
            this.btnNextPage.Location = new System.Drawing.Point(925, 19);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 24);
            this.btnNextPage.TabIndex = 152;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightBlue;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.Location = new System.Drawing.Point(383, 501);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 36);
            this.btnThanhToan.TabIndex = 173;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 547);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.flowFoodLayout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGoiMon";
            this.Text = "frmGoiMon";
            this.Load += new System.EventHandler(this.frmGoiMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtGiamGia;
        private System.Windows.Forms.Label txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTongCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTraiCay;
        private System.Windows.Forms.Button btnNuocUong;
        private System.Windows.Forms.Button btnThucAn;
        private System.Windows.Forms.FlowLayoutPanel flowFoodLayout;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThanhToan;
    }
}