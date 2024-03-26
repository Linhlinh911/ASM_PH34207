using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class SanPham
    {
        public Guid MaSanPham { get; set; }
        public string TenSanPham {  set; get; }
        public string MoTa {  set; get; }
        public decimal Gia { set; get; }
        public int SoLuongTon { set; get; }
        public Guid MaNSX { set; get; }
        public Guid MaBaoHanh { set; get; }
        public virtual NhaSanXuat NhaSanXuat { set; get; }
        public virtual BaoHanh BaoHanh { set; get; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
