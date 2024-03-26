using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppData.Models
{
    public partial class DBLaptopContext : DbContext
    {
        public DBLaptopContext()
        {
        }

        public DBLaptopContext(DbContextOptions<DBLaptopContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public DbSet<BaoHanh> BaoHanhs { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DATLEE;Initial Catalog=DBLaptop;Integrated Security=True;Trust Server Certificate=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
