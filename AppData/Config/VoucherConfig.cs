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
    internal class VoucherConfig : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.ToTable("Voucher");
            builder.HasKey(x => x.MaVoucher);

            builder.Property(p => p.TenVoucher).IsRequired().HasMaxLength(50);
            builder.Property(p => p.NgayHetHan).IsRequired().HasColumnType("datetime");
            builder.Property(p => p.GiaTri).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(p => p.HoaDon).WithMany(p => p.Vouchers).HasForeignKey(p => p.MaHoaDon)
                .HasConstraintName("FK_MaHoaDon_Voucher");
        }
    }
}
