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
    internal class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(x => x.MaGioHang);
            builder.HasOne<User>(g => g.Users).WithOne(p => p.GioHang).HasForeignKey<GioHang>(p => p.MaUser)
                    .HasConstraintName("FK_MaUser_GioHang");
            builder.Property(p => p.NgayTao).IsRequired().HasColumnType("datetime");
        }
    }
}
