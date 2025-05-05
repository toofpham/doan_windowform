CREATE DATABASE QuanLyQuanCafe
ON PRIMARY (
    NAME = QuanLyQuanCafe,
    FILENAME = 'D:\ckc\nam 2 hk2\c#\doan\quanlyquancafe.mdf'
)
LOG ON (
    NAME = QuanLyQuanCafe_log,
    FILENAME = 'D:\ckc\nam 2 hk2\c#\doan\quanlyquancafe_log.ldf'
);
GO

USE QuanLyQuanCafe;
GO

CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    Email NVARCHAR(100),
    SDT NVARCHAR(20),
    Luong DECIMAL(18, 2),
    ViTri NVARCHAR(50),
    TrangThai NVARCHAR(10),
	TenDangNhap NVARCHAR(50),
    MatKhau NVARCHAR(50)
);


CREATE TABLE Mon (
    MaMon INT PRIMARY KEY,
    TenMon NVARCHAR(100),
    Gia DECIMAL(18, 2),
    MoTa NVARCHAR(255),
    TrangThai NVARCHAR(20)
);

CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY  IDENTITY(1,1),
    MaNV INT,
    Ngay DATETIME,
    TongTien DECIMAL(18, 2),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ChiTietHoaDon (
    MaHD INT,
    MaMon INT,
    SoLuong INT,
    DonGia DECIMAL(18, 2),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon)
);

CREATE TABLE NguyenLieu (
    MaNL INT PRIMARY KEY,
    TenNL NVARCHAR(100),
    SoLuong DECIMAL(18,2),
    MaMon INT,
    DonViTinh NVARCHAR(50),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon)
);

CREATE TABLE LichLamViec (
    MaLich INT PRIMARY KEY,
    MaNV INT,
    Ngay DATE,
    CaLam NVARCHAR(20),
    ViTri NVARCHAR(50),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE BaoCaoDoanhThu (
    MaBC INT PRIMARY KEY IDENTITY(1,1),
	MaNV INT,
    NgayBaoCao DATE,
    TongDoanhThu DECIMAL(18, 2),
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, Email, SDT, Luong, ViTri, TrangThai,TenDangNhap,MatKhau)
VALUES 
    (101, N'Nhật Lâm', '2005-01-08', N'Nam', 'nhatlam@example.com', '0987654321', 15000000.00, N'Quản Lý', N'Hoạt động','nhatlam','123'),
    (102, N'Khôi Nguyên', '1995-10-20', N'Nam', 'khoinguyen@example.com', '0976543210', 12000000.00, N'Phục Vụ', N'Hoạt động','khoinguyen','123'),
    (103, N'Huy Khang', '1995-10-20', N'Nam', 'huykhang@example.com', '0976543210', 12000000.00, N'Pha Chế', N'Hoạt động','huykhang','123'),
    (104, N'Quốc Khánh', '2005-09-02', N'Nam', 'quockhanh@example.com', '0976543210', 12000000.00, N'Thu Ngân', N'Hoạt động','quockhanh','123');
   

INSERT INTO Mon (MaMon, TenMon, Gia, MoTa, TrangThai) VALUES
(1, N'Cafe Đen', 20000, N'Cà phê nguyên chất', N'Còn hàng'),
(2, N'Cafe Sữa', 25000, N'Cà phê pha sữa', N'Còn hàng'),
(3, N'Bạc Xỉu', 30000, N'Sữa nhiều, cà phê ít', N'Còn hàng'),
(4, N'Macha Đá Xay', 35000, N'Trá xanh mát lạnh', N'Còn hàng'),
(5, N'Matcha Latte', 40000, N'Sữa tươi kết hợp matcha', N'Còn hàng'),
(6, N'Cacao Latte', 40000, N'Cacao thơm ngon', N'Còn hàng'),
(7, N'Trà Đào Cam Xả', 30000, N'Trà đào tươi mát', N'Còn hàng'),
(8, N'Trà Ô Long Sen Vàng', 30000, N'Trà thảo mộc', N'Còn hàng'),
(9, N'Cookie Cream', 45000, N'Sinh tố cookie kem', N'Còn hàng'),
(10, N'Matha Đá Xay', 35000, N'Matcha đá xay đậm vị', N'Còn hàng'),
(11, N'Trà Sữa Trân Châu Đường đen (M)', 35000, N'Trà sữa size M', N'Còn hàng'),
(12, N'Trà Sữa Trân Châu Đường đen (L)', 40000, N'Trà sữa size L', N'Còn hàng'),
(13, N'Sữa Tươi Trân Châu Đường đen (M)', 35000, N'Sữa tươi size M', N'Còn hàng'),
(14, N'Sữa Tươi Trân Châu Đường đen (L)', 40000, N'Sữa tươi size L', N'Còn hàng');

INSERT INTO NguyenLieu (MaNL, TenNL, SoLuong, MaMon, DonViTinh)
VALUES 
(1,  N'Cà phê nguyên chất',2.0,  1, N'Kg'),
(2,  N'Sữa đặc',1.5,  2, N'Lít'),
(3,  N'Sữa tươi',2.0,  3, N'Lít'),
(4,  N'Bột matcha',1.2,  4, N'Kg'),
(5,  N'Sữa tươi',2.5,  5, N'Lít'),
(6,  N'Bột cacao',1.0,  6, N'Kg'),
(7,  N'Trà đào',1.8,  7, N'Lít'),
(8,  N'Trà ô long',1.6,  8, N'Lít'),
(9,  N'Bánh quy nghiền',1.0,  9, N'Kg'),
(10, N'Bột matcha',1.2, 10, N'Kg'),
(11, N'Trà sữa',2.0, 11, N'Lít'),
(12, N'Trà sữa',2.5, 12, N'Lít'),
(13, N'Sữa tươi',2.2, 13, N'Lít'),
(14, N'Sữa tươi',2.8, 14, N'Lít');

INSERT INTO LichLamViec (MaLich , MaNV , Ngay , CaLam , ViTri)
VALUES 
(1,102,'2025-05-02','Part-Time(8h-12h)',N'Phục Vụ'),
(2,103,'2025-05-02','Part-Time(8h-12h)',N'Pha Chế'),
(3,104,'2025-05-02','Part-Time(8h-12h)',N'Thu Ngân');

INSERT INTO HoaDon (MaNV, Ngay, TongTien)
VALUES 
(102, '2025-04-30', 150000),
(103, '2025-04-30', 200000),
(104, '2025-04-30', 250000),
(102, '2025-04-30', 180000),
(103, '2025-04-30', 220000),
(104, '2025-04-30', 170000),
(102, '2025-04-30', 210000),
(103, '2025-04-30', 230000),
(104, '2025-04-30', 240000),
(102, '2025-04-30', 190000);

INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong, DonGia)
VALUES
(1, 1, 2, 20000),
(1, 2, 1, 25000),
(2, 3, 3, 30000),
(2, 4, 2, 35000),
(3, 5, 1, 40000),
(3, 6, 2, 40000),
(4, 1, 3, 20000),
(4, 5, 1, 40000),
(5, 2, 2, 25000),
(5, 6, 3, 35000),
(6, 3, 2, 30000),
(6, 4, 1, 35000),
(7, 5, 4, 40000),
(7, 6, 1, 40000),
(8, 2, 2, 25000),
(8, 3, 1, 30000),
(9, 4, 3, 35000),
(9, 1, 2, 20000),
(10, 6, 1, 40000),
(10, 5, 3, 40000);

