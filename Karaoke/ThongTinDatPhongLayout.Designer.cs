namespace Karaoke
{
    partial class ThongTinDatPhongLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDatPhongLayout));
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.txtTenPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPicture
            // 
            this.imgPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgPicture.BackgroundImage")));
            this.imgPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPicture.Location = new System.Drawing.Point(17, 24);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(64, 54);
            this.imgPicture.TabIndex = 0;
            this.imgPicture.TabStop = false;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenPhong.AutoSize = true;
            this.txtTenPhong.Location = new System.Drawing.Point(31, 84);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(35, 13);
            this.txtTenPhong.TabIndex = 2;
            this.txtTenPhong.Text = "label1";
            // 
            // ThongTinDatPhongLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.imgPicture);
            this.Name = "ThongTinDatPhongLayout";
            this.Size = new System.Drawing.Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.Label txtTenPhong;
    }
}
