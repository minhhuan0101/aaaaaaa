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
    public partial class Form2 : Form
    {
        private int _iD;

        public int ID { get => _iD; set => _iD = value; }

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int ID)
        {
            this.ID = ID;
            InitializeComponent();
            BLL.BLL.Instance.Add_CbbItem_BLL(Cbb_LoaiSanPham);
            if (ID != 0)
            {
                Fill(ID);
            }
        }
        public delegate void DLG();
        public DLG D { get; set; }

        public void Fill(int ID)
        {
            SanPham Sp = new SanPham();
            Sp = BLL.BLL.Instance.GetSanPham_ByID_BLL(ID);
            Tb_TenSanPham.Text = Sp.TenSanPham;
            Tb_SoLuong.Text = Sp.SoLuong.ToString();
            dateTimePicker1.Value = Sp.NgayNhap;
            Cbb_LoaiSanPham.SelectedIndex = Sp.ID_LoaiSanPham - 1;
        }
        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SanPham Add_Value()
        {
            SanPham sp = new SanPham();
            sp.TenSanPham = Tb_TenSanPham.Text;
            sp.SoLuong = Convert.ToInt32(Tb_SoLuong.Text);
            sp.NgayNhap = dateTimePicker1.Value;
            sp.ID_LoaiSanPham = Cbb_LoaiSanPham.SelectedIndex + 1;
            return sp;
        }
        public SanPham Update_Value(int ID)
        {
            SanPham sp = new SanPham();
            sp.ID_SanPham = ID;
            sp.TenSanPham = Tb_TenSanPham.Text;
            sp.SoLuong = Convert.ToInt32(Tb_SoLuong.Text);
            sp.NgayNhap = dateTimePicker1.Value;
            sp.ID_LoaiSanPham = Cbb_LoaiSanPham.SelectedIndex + 1;
            return sp;
        }
        private void Bt_OK_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                if (BLL.BLL.Instance.Add_SanPham_BLL(Add_Value()))
                    MessageBox.Show("Thành Công!");
                else
                    MessageBox.Show("Thất Bại!");
            }
            else
            {
                
                if (BLL.BLL.Instance.Update_SanPham_BLL(Update_Value(ID)))
                    MessageBox.Show("Thành Công!");
                else
                    MessageBox.Show("Thất Bại!");
            }
            D();
        }
    }
}
