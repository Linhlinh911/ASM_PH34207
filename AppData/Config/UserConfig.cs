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
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.MaUser);
            builder.Property(p => p.TenUser).IsRequired().HasColumnName("TenUser").HasColumnType("nvarchar(50)");
            builder.Property(p => p.Email).IsRequired().HasColumnType("nvarchar(100)");
            builder.Property(p => p.MatKhau).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(p => p.DiaChi).IsRequired().HasColumnType("nvarchar(255)");
            builder.Property(p => p.SoDienThoai).IsRequired().HasColumnType("nvarchar(20)");
        }
    }
}
