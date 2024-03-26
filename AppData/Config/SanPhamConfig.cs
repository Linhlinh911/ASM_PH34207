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
    internal class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.MaSanPham);
            builder.HasOne(p => p.NhaSanXuat).WithMany(p => p.SanPhams).HasForeignKey(p => p.MaNSX)
                .HasConstraintName("FK_MaNSX");
            builder.HasOne(p => p.BaoHanh).WithMany(p => p.SanPhams).HasForeignKey(p => p.MaBaoHanh)
                .HasConstraintName("FK_MaBaoHanh");
            builder.Property(p => p.TenSanPham).IsRequired().HasColumnType("nvarchar(255)");
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(max)");
            builder.Property(p => p.Gia).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.SoLuongTon).IsRequired().HasColumnType("int");
        }
    }
}
