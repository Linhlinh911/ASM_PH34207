using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class HoaDonChiTiet
    {
        public Guid MaHDCT { get; set; }
        public Guid MaHoaDon { get; set; }
        public Guid MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTien { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
