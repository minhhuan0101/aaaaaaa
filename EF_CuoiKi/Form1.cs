using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CuoiKi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cbb_Search.Items.Add(new Cbb_Items
            {
                Text = "All",
                Value = 0
            });
            BLL.BLL.Instance.Add_CbbItem_BLL(Cbb_Search);
            Cbb_Sort.Items.Add(
                Text = "TenSanPham"
                );
            Cbb_Sort.Items.Add(
                Text = "LoaiSanPham"
                );
            Cbb_Search.SelectedIndex = 0;
        }

        private void Bt_Search_Click(object sender, EventArgs e)
        {
            int ID = ((Cbb_Items)Cbb_Search.SelectedItem).Value;
            string String_Search = Tb_Search.Text;
            dataGridView1.DataSource = BLL.BLL.Instance.Search_BLL(ID, String_Search);
        }
        private void ShowDG()
        {
            dataGridView1.DataSource = BLL.BLL.Instance.ShowDG();
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(0);
            f.D += new Form2.DLG(ShowDG);
            f.ShowDialog();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select 1 row");
            }
            else
            {
                int ID;
                DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
                ID = Convert.ToInt32(r[0].Cells["ID_SanPham"].Value.ToString());
                Form2 f = new Form2(ID);
                f.D += new Form2.DLG(ShowDG);
                f.ShowDialog();
            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select 1 row or more");
            }
            else
            {
                int ID;
                DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
                ID = Convert.ToInt32(r[0].Cells["ID_SanPham"].Value.ToString());
                BLL.BLL.Instance.Del_SanPham_BLL(ID);
                ShowDG();
            }
        }

        private void Bt_Sort_Click(object sender, EventArgs e)
        {
            object r = Cbb_Sort.SelectedItem;
            if (r != null)
            {
                DataTable dt = new DataTable();
                dt = (DataTable)dataGridView1.DataSource;
                dt.DefaultView.Sort = Cbb_Sort.SelectedItem.ToString() + " ASC";
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("Chọn kiểu Sort");
            return;
        }
    }
 }

