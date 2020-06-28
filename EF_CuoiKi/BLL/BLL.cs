using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_CuoiKi.DAL;

namespace EF_CuoiKi.BLL
{
        public class BLL
        {
            private static BLL _Instance;
            public static BLL Instance
            {
                get
                {
                    if (_Instance == null)
                        _Instance = new BLL();
                    return _Instance;
                }
                private set => _Instance = value;
            }
            public BLL()
            {
            }
            public List<SanPham> Search_BLL(int ID, string Tb_Search)
            {
                return DAL.DAL.Instance.Search_DAL(ID,Tb_Search);
            }
        public void Add_CbbItem_BLL(ComboBox cbb)
        {
            DAL.DAL.Instance.Add_CbbItem_DAL(cbb);
        }
        public SanPham GetSanPham_ByID_BLL(int ID)
        {
            SanPham sanpham = DAL.DAL.Instance.GetSanPham_ByID_DAL(ID);
            return sanpham;
        }
        public List<SanPham> ShowDG()
        {
            return DAL.DAL.Instance.ShowDG();
        }
        public bool Add_SanPham_BLL(SanPham sanpham)
        {
            return DAL.DAL.Instance.Add_SanPham_DAL(sanpham);
        }
        public void Del_SanPham_BLL(int ID)
        {
            DAL.DAL.Instance.Del_SanPham_DAL(ID);
        }
        public bool Update_SanPham_BLL(SanPham sanpham)
        {
            return DAL.DAL.Instance.Update_SanPham_DAL(sanpham);
        }
    }
}

