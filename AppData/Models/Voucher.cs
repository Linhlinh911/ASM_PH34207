using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Voucher
    {
        public Guid MaVoucher { get; set; }
        public string TenVoucher { get; set; }
        public decimal GiaTri { get; set; }
        public DateTime NgayHetHan { get; set; }
        public Guid MaHoaDon { get; set; }
        public virtual HoaDon HoaDon { get; set; }

    }
}
