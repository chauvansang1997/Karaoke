namespace Karaoke.QuanLySanPham
{
    partial class frmGiaoSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoSanPham));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNguoi = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 168;
            this.label3.Text = "Người giao sản phẩm:";
            // 
            // txtTenNguoi
            // 
            this.txtTenNguoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoi.Location = new System.Drawing.Point(105, 64);
            this.txtTenNguoi.Name = "txtTenNguoi";
            this.txtTenNguoi.Size = new System.Drawing.Size(175, 26);
            this.txtTenNguoi.TabIndex = 167;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(66, 116);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 36);
            this.btnIn.TabIndex = 186;
            this.btnIn.Text = " In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(140)))), ((int)(((byte)(174)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(172, 116);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.TabIndex = 185;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 77);
            this.label1.TabIndex = 188;
            this.label1.Text = "   ";
            // 
            // frmGiaoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNguoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiaoSanPham";
            this.Text = "Người giao sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNguoi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
    }
}