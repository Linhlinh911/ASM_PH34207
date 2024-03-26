using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    public partial class Liems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaoHanh",
                columns: table => new
                {
                    MaBaoHanh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiHan = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHanh", x => x.MaBaoHanh);
                });

            migrationBuilder.CreateTable(
                name: "NhaSanXuat",
                columns: table => new
                {
                    MaNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNSX = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaSanXuat", x => x.MaNSX);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenUser = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.MaUser);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    MaNSX = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaBaoHanh = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_MaBaoHanh",
                        column: x => x.MaBaoHanh,
                        principalTable: "BaoHanh",
                        principalColumn: "MaBaoHanh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaNSX",
                        column: x => x.MaNSX,
                        principalTable: "NhaSanXuat",
                        principalColumn: "MaNSX",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    MaGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.MaGioHang);
                    table.ForeignKey(
                        name: "FK_MaUser_GioHang",
                        column: x => x.MaUser,
                        principalTable: "Users",
                        principalColumn: "MaUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "datetime", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_MaUser_1",
                        column: x => x.MaUser,
                        principalTable: "Users",
                        principalColumn: "MaUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    MaGHCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.MaGHCT);
                    table.ForeignKey(
                        name: "FK_MaGioHang_GioHangChiTiet",
                        column: x => x.MaGioHang,
                        principalTable: "GioHang",
                        principalColumn: "MaGioHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaSanPham_GioHangChiTiet",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.MaHDCT);
                    table.ForeignKey(
                        name: "FK_MaHoaDon_1",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaSanPham_HoaDonChiTiet",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    MaVoucher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVoucher = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaTri = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.MaVoucher);
                    table.ForeignKey(
                        name: "FK_MaHoaDon_Voucher",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_MaUser",
                table: "GioHang",
                column: "MaUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_MaGioHang",
                table: "GioHangChiTiet",
                column: "MaGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_MaSanPham",
                table: "GioHangChiTiet",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaUser",
                table: "HoaDon",
                column: "MaUser");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaHoaDon",
                table: "HoaDonChiTiet",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaSanPham",
                table: "HoaDonChiTiet",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaBaoHanh",
                table: "SanPham",
                column: "MaBaoHanh");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaNSX",
                table: "SanPham",
                column: "MaNSX");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_MaHoaDon",
                table: "Voucher",
                column: "MaHoaDon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "BaoHanh");

            migrationBuilder.DropTable(
                name: "NhaSanXuat");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
