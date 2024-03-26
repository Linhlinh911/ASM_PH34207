using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class User
    {
        public Guid MaUser { get; set; }
        public string TenUser { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual GioHang GioHang { get; set; }
    }
}
