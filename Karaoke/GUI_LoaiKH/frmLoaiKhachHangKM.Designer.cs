namespace Karaoke.GUI_LoaiKH
{
    partial class frmLoaiKhachHangKM
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbLoaiKH = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMucKM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(109, 151);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 36);
            this.btnLuu.TabIndex = 175;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbLoaiKH
            // 
            this.cmbLoaiKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoaiKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLoaiKH.Enabled = false;
            this.cmbLoaiKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiKH.FormattingEnabled = true;
            this.cmbLoaiKH.Location = new System.Drawing.Point(12, 40);
            this.cmbLoaiKH.Name = "cmbLoaiKH";
            this.cmbLoaiKH.Size = new System.Drawing.Size(243, 27);
            this.cmbLoaiKH.TabIndex = 178;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 177;
            this.label8.Text = "Loại khách hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(143, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 19);
            this.label10.TabIndex = 201;
            this.label10.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 200;
            this.label3.Text = "Mức khuyến mãi:";
            // 
            // txtMucKM
            // 
            this.txtMucKM.Enabled = false;
            this.txtMucKM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucKM.Location = new System.Drawing.Point(12, 107);
            this.txtMucKM.Name = "txtMucKM";
            this.txtMucKM.Size = new System.Drawing.Size(125, 27);
            this.txtMucKM.TabIndex = 199;
            // 
            // frmLoaiKhachHangKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 206);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMucKM);
            this.Controls.Add(this.cmbLoaiKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmLoaiKhachHangKM";
            this.Text = "Thêm mức khuyến mãi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cmbLoaiKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMucKM;
    }
}