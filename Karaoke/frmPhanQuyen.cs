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
        private List<PhanQuyen> listPhanQuyen;
        private List<ChucVu> listChucVu;
        private List<CheckBox> checkBoxes;
        private List<bool> listChoPhep;
        private ChucVu chucVu;
        private bool isLoad = false;
        private Dictionary<string, List<int>> phanQuyen;
        public frmPhanQuyen()
        {
            InitializeComponent();
            khoiTao();


        }

        private void khoiTao()
        {
            checkBoxes = new List<CheckBox>()
            {
                checkBox1,
                checkBox2,
                checkBox3,
                checkBox4,
                checkBox5,
                checkBox6,
                checkBox7,
                checkBox8,
                checkBox9,
            };
            phanQuyen = new Dictionary<string, List<int>>();
            listQuyen = BUS.PhanQuyenBUS.XemQuyen();
            listPhanQuyen = BUS.PhanQuyenBUS.XemPhanQuyen();
            //for (int i = 0; i < listPhanQuyen.Count; i++)
            //{
            //    phanQuyen[listPhanQuyen[i].MaChucVu] = new List<int>();
            //}

            //for (int i = 0; i < listQuyen.Count; i++)
            //{
            //    if (!phanQuyen.ContainsKey(listPhanQuyen[i].MaChucVu))
            //    {
            //        phanQuyen.Add(listChucVu[i].MaChucVu, new List<int>());
            //        phanQuyen[listPhanQuyen[i].MaChucVu].Add(listPhanQuyen[i].MaQuyen);
            //    }
            //    else
            //    {
            //        phanQuyen[listPhanQuyen[i].MaChucVu].Add(listPhanQuyen[i].MaQuyen);
            //    }
            //}


            listChucVu = BUS.ChucVuBUS.XemChucVu();
            lbChucVu.DataSource = listChucVu;
            lbChucVu.DisplayMember = "TenChucVu";
            lbChucVu.ValueMember = "MaChucVu";
            chucVu = listChucVu[0];
            bool check = false;

            for (int i = 0; i < listChucVu.Count; i++)
            {
                phanQuyen.Add(listChucVu[i].MaChucVu, new List<int>());
            }
            if(listPhanQuyen != null)
            {
                for (int i = 0; i < listPhanQuyen.Count; i++)
                {
                    phanQuyen[listPhanQuyen[i].MaChucVu].Add(listPhanQuyen[i].MaQuyen);
                }

                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (phanQuyen[chucVu.MaChucVu].Contains(int.Parse(checkBoxes[i].Tag.ToString())))
                    {
                        checkBoxes[i].Checked = true;
                    }
                    else
                    {
                        checkBoxes[i].Checked = false;
                    }
                }

            }


            isLoad = true;
            //tableLayout.ColumnCount = 3;
            //tableLayout.RowCount = listQuyen.Count;
            //for (int i = 0; i < listQuyen.Count; i++)
            //{
            //    ColumnStyle cs = new ColumnStyle(SizeType.Percent, (float)100 / listQuyen.Count);
            //    this.tableLayout.ColumnStyles.Add(cs);
            //    QuyenLayout layout = new QuyenLayout();
            //    layout.lbTenQuyen.Text = listQuyen[i].Ten;
            //    layout.chkQuyen.Checked = false;
            //    tableLayout.Controls.Add(layout);
            //}
            //this.tableLayout.AutoSize = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset()
        {
            listPhanQuyen = BUS.PhanQuyenBUS.XemPhanQuyen();
            phanQuyen.Clear();
            for (int i = 0; i < listChucVu.Count; i++)
            {
                phanQuyen.Add(listChucVu[i].MaChucVu, new List<int>());
            }
            if (listPhanQuyen != null)
            {
                for (int i = 0; i < listPhanQuyen.Count; i++)
                {
                    phanQuyen[listPhanQuyen[i].MaChucVu].Add(listPhanQuyen[i].MaQuyen);
                }

                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (phanQuyen[chucVu.MaChucVu].Contains(int.Parse(checkBoxes[i].Tag.ToString())))
                    {
                        checkBoxes[i].Checked = true;
                    }
                    else
                    {
                        checkBoxes[i].Checked = false;
                    }
                }

            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                BUS.PhanQuyenBUS.CapNhatPhanQuyen(chucVu, listQuyen[i], checkBoxes[i].Checked ? 1 : 0);
            }
            reset();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad)
            {
                return;
            }
            if (lbChucVu.SelectedValue != null)
            {
                chucVu = listChucVu[lbChucVu.SelectedIndex];

                for (int i = 0; i < checkBoxes.Count; i++)
                {
                    if (phanQuyen[chucVu.MaChucVu].Contains(int.Parse(checkBoxes[i].Tag.ToString())))
                    {
                        checkBoxes[i].Checked = true;
                    }
                    else
                    {
                        checkBoxes[i].Checked = false;
                    }
                }

            }
        }
    }
}
