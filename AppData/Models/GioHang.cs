using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class GioHang
    {
        public Guid MaGioHang {  get; set; }
        public Guid MaUser { get; set; }
        public DateTime NgayTao { get; set; }
        public Guid MaVoucher { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; }

    }
}
