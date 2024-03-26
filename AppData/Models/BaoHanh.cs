using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class BaoHanh
    {
        public Guid MaBaoHanh { get; set; }
        public int ThoiHan { get; set; }
        public string MoTa { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
