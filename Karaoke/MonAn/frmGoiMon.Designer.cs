namespace Karaoke.MonAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.foodLayout1 = new Karaoke.FoodLayout();
            this.foodLayout2 = new Karaoke.FoodLayout();
            this.foodLayout3 = new Karaoke.FoodLayout();
            this.foodLayout4 = new Karaoke.FoodLayout();
            this.foodLayout5 = new Karaoke.FoodLayout();
            this.foodLayout6 = new Karaoke.FoodLayout();
            this.foodLayout7 = new Karaoke.FoodLayout();
            this.foodLayout8 = new Karaoke.FoodLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 494);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "200000";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "100000";
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa,
            this.TenMonAn,
            this.Gia,
            this.SoLuong,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(496, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            this.Xoa.Width = 32;
            // 
            // TenMonAn
            // 
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.Name = "TenMonAn";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(520, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 491);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "Trái cây";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 65);
            this.button7.TabIndex = 5;
            this.button7.Text = "Nước uống";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 68);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thức ăn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.foodLayout1);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout2);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout3);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout4);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout5);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout6);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout7);
            this.flowLayoutPanel1.Controls.Add(this.foodLayout8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(636, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 491);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // foodLayout1
            // 
            this.foodLayout1.Location = new System.Drawing.Point(3, 3);
            this.foodLayout1.Name = "foodLayout1";
            this.foodLayout1.Size = new System.Drawing.Size(100, 100);
            this.foodLayout1.TabIndex = 0;
            // 
            // foodLayout2
            // 
            this.foodLayout2.Location = new System.Drawing.Point(109, 3);
            this.foodLayout2.Name = "foodLayout2";
            this.foodLayout2.Size = new System.Drawing.Size(100, 100);
            this.foodLayout2.TabIndex = 1;
            // 
            // foodLayout3
            // 
            this.foodLayout3.Location = new System.Drawing.Point(215, 3);
            this.foodLayout3.Name = "foodLayout3";
            this.foodLayout3.Size = new System.Drawing.Size(100, 100);
            this.foodLayout3.TabIndex = 2;
            // 
            // foodLayout4
            // 
            this.foodLayout4.Location = new System.Drawing.Point(321, 3);
            this.foodLayout4.Name = "foodLayout4";
            this.foodLayout4.Size = new System.Drawing.Size(100, 100);
            this.foodLayout4.TabIndex = 3;
            // 
            // foodLayout5
            // 
            this.foodLayout5.Location = new System.Drawing.Point(3, 109);
            this.foodLayout5.Name = "foodLayout5";
            this.foodLayout5.Size = new System.Drawing.Size(100, 100);
            this.foodLayout5.TabIndex = 4;
            // 
            // foodLayout6
            // 
            this.foodLayout6.Location = new System.Drawing.Point(109, 109);
            this.foodLayout6.Name = "foodLayout6";
            this.foodLayout6.Size = new System.Drawing.Size(100, 100);
            this.foodLayout6.TabIndex = 5;
            // 
            // foodLayout7
            // 
            this.foodLayout7.Location = new System.Drawing.Point(215, 109);
            this.foodLayout7.Name = "foodLayout7";
            this.foodLayout7.Size = new System.Drawing.Size(100, 100);
            this.foodLayout7.TabIndex = 6;
            // 
            // foodLayout8
            // 
            this.foodLayout8.Location = new System.Drawing.Point(321, 109);
            this.foodLayout8.Name = "foodLayout8";
            this.foodLayout8.Size = new System.Drawing.Size(100, 100);
            this.foodLayout8.TabIndex = 7;
            // 
            // frmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 515);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGoiMon";
            this.Text = "frmGoiMon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FoodLayout foodLayout1;
        private FoodLayout foodLayout2;
        private FoodLayout foodLayout3;
        private FoodLayout foodLayout4;
        private FoodLayout foodLayout5;
        private FoodLayout foodLayout6;
        private FoodLayout foodLayout7;
        private FoodLayout foodLayout8;
    }
}