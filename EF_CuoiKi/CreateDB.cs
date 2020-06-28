using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CuoiKi
{
    class CreateDB : CreateDatabaseIfNotExists<Model>
    {
        protected override void Seed(Model context)
        {
            context.SanPham.Add(new SanPham
            {
                ID_SanPham = 1,
                TenSanPham = "Trà Sữa Truyền Thống",
                SoLuong = 100,
                NgayNhap = Convert.ToDateTime("2 / 2 / 2020"),
                ID_LoaiSanPham = 1,
            }) ; ;
            context.SanPham.Add(new SanPham
            {
                ID_SanPham = 2,
                TenSanPham = "Trà Sữa Hương Nho",
                SoLuong = 50,
                NgayNhap = Convert.ToDateTime("2 / 2 / 2020"),
                ID_LoaiSanPham = 1,
            });
            context.SanPham.Add(new SanPham
            {
                ID_SanPham = 3,
                TenSanPham = "Cà Phê Đen Đá",
                SoLuong = 150,
                NgayNhap = Convert.ToDateTime("2 / 2 / 2020"),
                ID_LoaiSanPham = 2,
            });
            context.SanPham.Add(new SanPham
            {
                ID_SanPham = 4,
                TenSanPham = "Cà Phê Sữa Sài Gòn",
                SoLuong = 100,
                NgayNhap = Convert.ToDateTime("2 / 2 / 2020"),
                ID_LoaiSanPham = 2,
            });
            context.LoaiSanPham.Add(new LoaiSanPham
            {
                ID_LoaiSanPham = 1,
                TenLoai = "Trà Sữa",
            });
            context.LoaiSanPham.Add(new LoaiSanPham
            {
                ID_LoaiSanPham = 2,
                TenLoai = "Cà Phê",
            });
        }
    }
}
