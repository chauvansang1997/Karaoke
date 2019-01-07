using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace Karaoke
{
    public partial class frmPhanQuyen : Form
    {
        private List<Quyen> listQuyen;
        public frmPhanQuyen()
        {
            InitializeComponent();
            
        }

        private void khoiTao()
        {
            listQuyen = BUS.PhanQuyenBUS.XemQuyen();
            //tableLayout.ColumnCount = 3;
            tableLayout.RowCount = listQuyen.Count;
        }
    }
}
