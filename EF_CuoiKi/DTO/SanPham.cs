using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CuoiKi
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int ID_SanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public int ID_LoaiSanPham { get; set; }
        [ForeignKey("ID_LoaiSanPham")]

        public virtual ICollection<LoaiSanPham> LoaiSanPhams { get; set; }
    }
}
