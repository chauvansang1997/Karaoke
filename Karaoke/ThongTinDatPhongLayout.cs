using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class ThongTinDatPhongLayout : UserControl
    {
        private string ten;
        private string loai;
        public DTO.ThongTinDatPhong ThongTinDatPhong { get; set; }
        public int IndexDict { get; set; }
        public int IndexList { get; set; }
        public string Ten
        {
            get { return ten; }
            set
            {
                ten = value;
                txtTenPhong.Text = ten;
            }
        }

        public void setClick(EventHandler handler)
        {
            txtTenPhong.Click += handler;
            imgPicture.Click += handler;
            this.Click += handler;
        }
        public ThongTinDatPhongLayout()
        {
            InitializeComponent();
        }
    }
}
