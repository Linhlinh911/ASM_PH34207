using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class HoaDon
    {
        public Guid MaHoaDon { get; set; }
        public Guid MaUser { get; set; }
        public DateTime NgayMua { get; set; }
        public decimal TongTien { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
