using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.NguyenLieu
{
    public partial class frmNguyenLieu : Form
    {
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {

        }
        private void AddGridTableStyle()
        {
            DataGridTableStyle table = new DataGridTableStyle
            {
                // MappingName = this.dtct.TableName,
                AlternatingBackColor = Color.Beige,
                BackColor = Color.GhostWhite,
                ForeColor = Color.MidnightBlue,
                GridLineColor = Color.RoyalBlue,
                HeaderBackColor = Color.MidnightBlue,
                HeaderForeColor = Color.Lavender,
                SelectionBackColor = Color.Teal,
                SelectionForeColor = Color.PaleGreen,
                ReadOnly = false,
                RowHeaderWidth = 10
            };
            DataGridTextBoxColumn column = new DataGridTextBoxColumn
            {
                MappingName = "stt",
                HeaderText = "Stt",
                Width = 30
            };
            table.GridColumnStyles.Add(column);

            column = new DataGridTextBoxColumn
            {
                MappingName = "ma",
                HeaderText = "Mã số",
                Width = 50
            };



            table.GridColumnStyles.Add(column);
            //this.dataGrid1.TableStyles.Add(table);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void frmNguyenLieu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
