using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CuoiKi
{
    [Table("LoaiSanPham")]
    public class LoaiSanPham
    {
        [Key]
        public int ID_LoaiSanPham { get; set; }
        public string TenLoai { get; set; }
        public LoaiSanPham()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
