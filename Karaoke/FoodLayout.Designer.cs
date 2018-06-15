namespace Karaoke
{
    partial class FoodLayout
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
            this.txtPrice = new System.Windows.Forms.Label();
            this.imgFood = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(123, 19);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(45, 19);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Text = "100$";
            // 
            // imgFood
            // 
            this.imgFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFood.Location = new System.Drawing.Point(27, 47);
            this.imgFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgFood.Name = "imgFood";
            this.imgFood.Size = new System.Drawing.Size(141, 103);
            this.imgFood.TabIndex = 1;
            this.imgFood.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(23, 163);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(45, 19);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "100$";
            // 
            // FoodLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.imgFood);
            this.Controls.Add(this.txtPrice);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FoodLayout";
            this.Size = new System.Drawing.Size(194, 219);
            ((System.ComponentModel.ISupportInitialize)(this.imgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtPrice;
        public System.Windows.Forms.PictureBox imgFood;
        public System.Windows.Forms.Label txtName;
    }
}
