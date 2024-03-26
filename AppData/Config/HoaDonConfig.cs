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
    internal class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.MaHoaDon);
            builder.HasOne(p => p.Users).WithMany(p => p.HoaDons).HasForeignKey(p => p.MaUser)
                .HasConstraintName("FK_MaUser_1");
            builder.Property(p => p.NgayMua).IsRequired().HasColumnType("datetime");
            builder.Property(p => p.TongTien).IsRequired().HasColumnType("decimal");
        }
    }
}
