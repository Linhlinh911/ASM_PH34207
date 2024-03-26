CREATE DATABASE LAPTOP
GO

USE LAPTOP
GO

CREATE TABLE Laptops (
    LaptopID INT PRIMARY KEY,
    Ten VARCHAR(255) NOT NULL,
    MaThuongHieu INT,
    Gia DECIMAL(10, 2) NOT NULL,
    SoLuong INT NOT NULL,
    MoTa TEXT,
    NgaySanXuat DATE,
    CONSTRAINT FK_Brand FOREIGN KEY (MaThuongHieu) REFERENCES Brands(MaThuongHieu)
);

CREATE TABLE Brands (
    MaThuongHieu INT PRIMARY KEY,
    TenThuongHieu VARCHAR(50) NOT NULL
);

CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    MaKhachHang INT,
    NGayTao DATETIME NOT NULL,
    TongTien DECIMAL(10, 2) NOT NULL,
    TrangThai VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Customer FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    HoTen VARCHAR(50) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Phone VARCHAR(15),
    DiaChi VARCHAR(255),
);

CREATE TABLE HoaDonChiTiet (
    MaHDCT INT PRIMARY KEY,
    MaHoaDon INT,
    LaptopID INT,
    SoLuong INT NOT NULL,
    ThanhTien DECIMAL(10, 2) NOT NULL,
    CONSTRAINT FK_Order FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    CONSTRAINT FK_Laptop FOREIGN KEY (LaptopID) REFERENCES Laptops(LaptopID)
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    TenTaiKhoan VARCHAR(50) NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    VaiTro VARCHAR(20) NOT NULL
);
