﻿// <auto-generated />
using System;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppData.Migrations
{
    [DbContext(typeof(DBLaptopContext))]
    partial class DBLaptopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppData.Models.BaoHanh", b =>
                {
                    b.Property<Guid>("MaBaoHanh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ThoiHan")
                        .HasColumnType("int");

                    b.HasKey("MaBaoHanh");

                    b.ToTable("BaoHanh", (string)null);
                });

            modelBuilder.Entity("AppData.Models.GioHang", b =>
                {
                    b.Property<Guid>("MaGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.HasKey("MaGioHang");

                    b.HasIndex("MaUser")
                        .IsUnique();

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("AppData.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("MaGHCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("MaGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaGHCT");

                    b.HasIndex("MaGioHang");

                    b.HasIndex("MaSanPham");

                    b.ToTable("GioHangChiTiet", (string)null);
                });

            modelBuilder.Entity("AppData.Models.HoaDon", b =>
                {
                    b.Property<Guid>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayMua")
                        .HasColumnType("datetime");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaUser");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("AppData.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("MaHDCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("MaHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaHDCT");

                    b.HasIndex("MaHoaDon");

                    b.HasIndex("MaSanPham");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("AppData.Models.NhaSanXuat", b =>
                {
                    b.Property<Guid>("MaNSX")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenNSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaNSX");

                    b.ToTable("NhaSanXuat", (string)null);
                });

            modelBuilder.Entity("AppData.Models.SanPham", b =>
                {
                    b.Property<Guid>("MaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("MaBaoHanh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaNSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaSanPham");

                    b.HasIndex("MaBaoHanh");

                    b.HasIndex("MaNSX");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("AppData.Models.User", b =>
                {
                    b.Property<Guid>("MaUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenUser");

                    b.HasKey("MaUser");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AppData.Models.Voucher", b =>
                {
                    b.Property<Guid>("MaVoucher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTri")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("MaHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime");

                    b.Property<string>("TenVoucher")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaVoucher");

                    b.HasIndex("MaHoaDon");

                    b.ToTable("Voucher", (string)null);
                });

            modelBuilder.Entity("AppData.Models.GioHang", b =>
                {
                    b.HasOne("AppData.Models.User", "Users")
                        .WithOne("GioHang")
                        .HasForeignKey("AppData.Models.GioHang", "MaUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MaUser_GioHang");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AppData.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("AppData.Models.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("MaGioHang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_MaGioHang_GioHangChiTiet");

                    b.HasOne("AppData.Models.SanPham", "SanPham")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("MaSanPham")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_MaSanPham_GioHangChiTiet");

                    b.Navigation("GioHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("AppData.Models.HoaDon", b =>
                {
                    b.HasOne("AppData.Models.User", "Users")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MaUser_1");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AppData.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("AppData.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_MaHoaDon_1");

                    b.HasOne("AppData.Models.SanPham", "SanPham")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("MaSanPham")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_MaSanPham_HoaDonChiTiet");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("AppData.Models.SanPham", b =>
                {
                    b.HasOne("AppData.Models.BaoHanh", "BaoHanh")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaBaoHanh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MaBaoHanh");

                    b.HasOne("AppData.Models.NhaSanXuat", "NhaSanXuat")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaNSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MaNSX");

                    b.Navigation("BaoHanh");

                    b.Navigation("NhaSanXuat");
                });

            modelBuilder.Entity("AppData.Models.Voucher", b =>
                {
                    b.HasOne("AppData.Models.HoaDon", "HoaDon")
                        .WithMany("Vouchers")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MaHoaDon_Voucher");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("AppData.Models.BaoHanh", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("AppData.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("AppData.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");

                    b.Navigation("Vouchers");
                });

            modelBuilder.Entity("AppData.Models.NhaSanXuat", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("AppData.Models.SanPham", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("AppData.Models.User", b =>
                {
                    b.Navigation("GioHang")
                        .IsRequired();

                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
