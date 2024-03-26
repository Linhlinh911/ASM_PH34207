using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Config
{
    internal class NhaSanXuatConfig : IEntityTypeConfiguration<NhaSanXuat>
    {
        public void Configure(EntityTypeBuilder<NhaSanXuat> builder)
        {
            builder.ToTable("NhaSanXuat");
            builder.HasKey(x => x.MaNSX);
            builder.Property(p => p.TenNSX).IsRequired().HasColumnType("nvarchar(255)");
        }
    }
}
