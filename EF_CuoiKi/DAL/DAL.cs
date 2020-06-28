using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CuoiKi.DAL
{
    public class DAL
    {
        Model db = new Model();
        private static DAL _Instance;
        public static DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        public DAL()
        {

        }
        public List<SanPham> Search_DAL(int ID, string Tb_Search)
        {
            var list = db.SanPham.Select(p => p);
            if (Tb_Search == "" && ID == 0)
            {
                list = db.SanPham.Select(p => p);
            }
            else if (Tb_Search == "" && ID != 0)
            {
                list = db.SanPham.Where(p => p.ID_LoaiSanPham == ID)
                                     .Select(p => p);
            }
            else if (Tb_Search != "" && ID == 0)
            {
                list = db.SanPham.Where(p => p.TenSanPham == Tb_Search)
                                     .Select(p => p);
            }
            else if (Tb_Search != "" && ID != 0)
            {
                list = db.SanPham.Where(p => p.ID_LoaiSanPham == ID && p.TenSanPham == Tb_Search)
                                .Select(p => p);
            }
            return list.ToList();
        }
        public List<SanPham> ShowDG()
        {
            var list = db.SanPham.Select(p => p);
            return list.ToList();
        }

        public void Add_CbbItem_DAL(ComboBox cbb)
        {
            var result = db.LoaiSanPham.Select(p => p).ToList();
            foreach (LoaiSanPham item in result)
            {
                cbb.Items.Add(new Cbb_Items
                {
                    Text = item.TenLoai,
                    Value = item.ID_LoaiSanPham,
                });
            }
        }

        public SanPham GetSanPham_ByID_DAL(int ID)
        {
            SanPham sanpham = db.SanPham.Where(p => p.ID_SanPham == ID)
                                     .Select(p => p).FirstOrDefault();
            return sanpham;

        }

        public void Del_SanPham_DAL(int ID)
        {
            SanPham sanpham = db.SanPham.Where(p => p.ID_SanPham == ID)
                         .Select(p => p).FirstOrDefault();
            db.SanPham.Remove(sanpham);
            db.SaveChanges();
        }

        public bool Add_SanPham_DAL(SanPham sanpham)
        {
            try
            {
                db.SanPham.Add(sanpham);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update_SanPham_DAL(SanPham sanpham)
        {
            try
            {
                SanPham sp = new SanPham();
                sp = GetSanPham_ByID_DAL(sanpham.ID_SanPham);
                sp.TenSanPham = sanpham.TenSanPham;
                sp.SoLuong = sanpham.SoLuong;
                sp.NgayNhap = sanpham.NgayNhap;
                sp.ID_LoaiSanPham = sanpham.ID_LoaiSanPham;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}



