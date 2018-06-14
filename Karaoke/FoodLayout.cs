using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Karaoke
{
    public partial class FoodLayout : UserControl
    {
        public int IndexDict { get; set; }
        public int IndexList { get; set; }


        public bool IsClick { get; set; }

        private HangHoa hangHoa;
        public HangHoa HangHoa
        {
            get
            {
                return hangHoa;
            }
            set
            {
                hangHoa = value;
                if (value != null)
                {
                    txtName.Text = hangHoa.Ten;
                    txtPrice.Text = hangHoa.Gia.ToString();
                }
               
            }
        }
        public FoodLayout(Image image)
        {
            InitializeComponent();
            if (image != null)
            {
                imgFood.BackgroundImage = image;
                
            }
            imgFood.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public FoodLayout()
        {
            InitializeComponent();
        }
        private void setImage(Image image)
        {
            imgFood.BackgroundImage = image;
            imgFood.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void setClick(EventHandler handler)
        {
            imgFood.Click += handler;
            txtName.Click += handler;
            this.Click+= handler;
        }
    }
}
