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
    internal class BaoHanhConfig : IEntityTypeConfiguration<BaoHanh>
    {
        public void Configure(EntityTypeBuilder<BaoHanh> builder)
        {
            builder.ToTable("BaoHanh");
            builder.HasKey(x => x.MaBaoHanh);

            builder.Property(p => p.ThoiHan).IsRequired().HasColumnType("int");
            builder.Property(p => p.MoTa).IsRequired().HasColumnType("nvarchar(255)");
        }
    }
}
