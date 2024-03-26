using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class GioHangChiTiet
    {
        public Guid MaGHCT {  get; set; }
        public Guid MaGioHang {  get; set; }
        public Guid MaSanPham { get; set;}
        public int SoLuong { get; set; }
        public decimal GiaTien { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
