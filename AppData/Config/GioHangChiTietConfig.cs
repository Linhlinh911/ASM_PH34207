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
    internal class GioHangChiTietConfig : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet");
            builder.HasKey(x => x.MaGHCT);
            builder.HasOne(p => p.GioHang).WithMany(p => p.GioHangChiTiets).HasForeignKey(p => p.MaGioHang)
                    .HasConstraintName("FK_MaGioHang_GioHangChiTiet").OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.SanPham)
                   .WithMany(p => p.GioHangChiTiets)
                   .HasForeignKey(p => p.MaSanPham)
                   .HasConstraintName("FK_MaSanPham_GioHangChiTiet")
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
