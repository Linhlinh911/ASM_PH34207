using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class NhaSanXuat
    {
        public Guid MaNSX { get; set; }
        public string TenNSX { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
