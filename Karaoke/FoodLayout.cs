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
    public partial class FoodLayout : UserControl
    {
        public int IndexDict { get; set; }
        public int IndexList { get; set; }
        public string Name { get; set; }

        public uint Price { get; set; }
        public bool IsClick { get; set; }

        public FoodLayout(Image image, string name, uint price)
        {
            InitializeComponent();
            if (image != null)
            {
                imgFood.Image = image;
            }

            txtPrice.Text = price.ToString();
            txtName.Text = name;
            Price = price;
            Name = name;
        }
        public FoodLayout()
        {
            InitializeComponent();
        }
        private void setImage(Image image)
        {
            imgFood.Image = image;
        }
        private void setPrice(uint price)
        {
            txtPrice.Text = price.ToString();
        }
        private void setName(string name)
        {
            txtName.Text = name;
        }
        public void setClick(EventHandler handler)
        {
            imgFood.Click += handler;
            txtName.Click += handler;
            this.Click+= handler;
        }
    }
}
