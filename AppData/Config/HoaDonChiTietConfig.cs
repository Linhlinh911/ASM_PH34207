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
    internal class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.MaHDCT);
            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonChiTiets).HasForeignKey(p => p.MaHoaDon)
                                .HasConstraintName("FK_MaHoaDon_1").OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.SanPham).WithMany(p => p.HoaDonChiTiets).HasForeignKey(p => p.MaSanPham)
                   .HasConstraintName("FK_MaSanPham_HoaDonChiTiet").OnDelete(DeleteBehavior.Restrict);
            builder.Property(p => p.SoLuong).IsRequired();
            builder.Property(p => p.GiaTien).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}

