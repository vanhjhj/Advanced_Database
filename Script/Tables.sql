CREATE DATABASE QUAN_LY_NHA_HANG;
GO

USE QUAN_LY_NHA_HANG;
GO

-- Tạo bảng Khu Vực
CREATE TABLE KhuVuc(
	MaKV VARCHAR(10) PRIMARY KEY,
	TenKV NVARCHAR(50) UNIQUE
);

-- Tạo bảng Chi Nhánh
CREATE TABLE ChiNhanh(
	MaCN VARCHAR(10) PRIMARY KEY,
	TenCN NVARCHAR(50),
	DiaChi NVARCHAR(200) UNIQUE,
	TgMoCua TIME,
	TgDongCua TIME,
	SDT VARCHAR(10) UNIQUE,
	BaiDoXeMay NVARCHAR(5) CHECK (BaiDoXeMay IN (N'Có', N'Không')),
	BaiDoXeHoi NVARCHAR(5) CHECK (BaiDoXeHoi IN (N'Có', N'Không')),
	MaKV VARCHAR(10), -- FK
	QuanLy VARCHAR(10) UNIQUE -- FK
);

-- Tạo bảng Mục
CREATE TABLE Muc(
	MaMuc VARCHAR(10) PRIMARY KEY,
	TenMuc NVARCHAR(50) UNIQUE
);

-- Tạo bảng Món Ăn
CREATE TABLE MonAn(
	MaMA VARCHAR(10) PRIMARY KEY,
	TenMA NVARCHAR(50) UNIQUE,
	GiaHienTai INT CHECK (GiaHienTai > 0),
	TinhTrangMonAn NVARCHAR(5) CHECK (TinhTrangMonAn IN (N'Có', N'Không')),
	MaMuc VARCHAR(10) -- FK
);

-- Tạo bảng Thực Đơn
CREATE TABLE ThucDon(
	MaCN VARCHAR(10), -- FK
	MaMA VARCHAR(10), -- FK
	TinhTrangPhucVu NVARCHAR(5) CHECK (TinhTrangPhucVu IN (N'Có', N'Không')),
	TinhTrangGiaoHang NVARCHAR(5) CHECK (TinhTrangGiaoHang IN (N'Có', N'Không')),
	PRIMARY KEY (MaCN, MaMA)
);

-- Tạo bảng Tài Khoản
CREATE TABLE TaiKhoan(
	MaTK VARCHAR(10) PRIMARY KEY,
	TenTK VARCHAR(50) UNIQUE,
	MatKhau VARCHAR(20) NOT NULL,
	LoaiTK NVARCHAR(10) CHECK (LoaiTK IN (N'Khách Hàng', N'Nhân Viên'))
);

-- Tạo bảng Bộ Phận
CREATE TABLE BoPhan(
	MaBP VARCHAR(10) PRIMARY KEY,
	TenBP NVARCHAR(50) UNIQUE,
	Luong INT CHECK (LUONG > 0)
);

-- Tạo bảng Nhân Viên
CREATE TABLE NhanVien(
	MaTK VARCHAR(10) PRIMARY KEY, -- FK
	Hoten NVARCHAR(50),
	NgaySinh DATETIME,
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
	NgayVaoLam DATETIME,
	NgayNghiViec DATETIME,
	SDT VARCHAR(10) UNIQUE,
	DiaChi NVARCHAR(200),
	MaBP VARCHAR(10), -- FK
	MaCN VARCHAR(10) -- FK
);

-- Tạo bảng Lịch Sử Điều Động
CREATE TABLE LichSuDieuDong(
	MaCN VARCHAR(10), -- FK
	MaTkNV VARCHAR(10), -- FK
	NgayBD DATETIME,
	NgayKT DATETIME,
	PRIMARY KEY (MaCN, MaTkNV, NgayBD)
);

-- Tạo bảng Khách Hàng
CREATE TABLE KhachHang(
	MaTK VARCHAR(10) PRIMARY KEY, -- FK
	HoTen NVARCHAR(50),
	SDT VARCHAR(10) UNIQUE,
	Email VARCHAR(50) UNIQUE,
	CCCD VARCHAR(12) UNIQUE,
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN (N'Nam', N'Nữ'))
);

-- Tạo bảng Loại Thẻ
CREATE TABLE LoaiThe(
	TenLoaiThe VARCHAR(10) PRIMARY KEY CHECK (TenLoaiThe IN ('Membership', 'Silver', 'Gold')),
	ChietKhau INT CHECK (ChietKhau >= 0),
	GiamGia INT CHECK (GiamGia >= 0),
	SpTang NVARCHAR(200)
);

-- Tạo bảng Thẻ
CREATE TABLE The(
	MaThe VARCHAR(10) PRIMARY KEY,
	NgayLap DATETIME,
	NgayBDChuKy DATETIME,
	TongDiem INT CHECK (TongDiem >= 0),
	TongDiemDuyTri INT CHECK (TongDiemDuyTri >= 0),
	TinhTrang NVARCHAR(4) CHECK (TinhTrang IN (N'Mở', N'Đóng')) NOT NULL,
	TenLoaiThe VARCHAR(10) NOT NULL, -- FK
	TkSoHuu VARCHAR(10) NOT NULL, -- FK
	TkLap VARCHAR(10) NOT NULL, -- FK
);

-- Tạo bảng Phiếu Đặt
CREATE TABLE PhieuDat(
	MaPhieu VARCHAR(10) PRIMARY KEY,
	TinhTrangThanhToan NVARCHAR(15) CHECK (TinhTrangThanhToan IN (N'Đã Thanh Toán', N'Chưa Thanh Toán')) NOT NULL,
	LoaiPD NVARCHAR(20) CHECK (LoaiPD IN (N'Trực Tiếp', N'Trực Tuyến', N'Giao Hàng')) NOT NULL,
	MaCN VARCHAR(10), -- FK
	TkLap VARCHAR(10), -- FK
);

-- Tạo bảng Chi Tiết Phiếu Đặt
CREATE TABLE CTPD(
	MaPhieu VARCHAR(10), --FK
	MaMA VARCHAR(10), --FK
	SoLuong INT NOT NULL,
	DonGia INT NOT NULL,
	ThanhTien INT NOT NULL,
	GhiChu NVARCHAR(200),
	PRIMARY KEY (MaPhieu, MaMa)
);

-- Tạo bảng Phiếu Đặt Bàn Trực Tuyến
CREATE TABLE PhieuDatBanTrucTuyen(
	MaPhieu VARCHAR(10) PRIMARY KEY, -- FK
	TdTruyCap DATETIME NOT NULL,
	TgTruyCap INT NOT NULL,
	SLKhach INT NOT NULL,
	ThoiGianDen DATETIME NOT NULL,
	GhiChu NVARCHAR(200)
);

-- Tạo bảng Phiếu Đặt Giao Hàng
CREATE TABLE PhieuDatGiaoHang(
	MaPhieu VARCHAR(10) PRIMARY KEY, -- FK
	TdTruyCap DATETIME NOT NULL,
	TgTruyCap INT NOT NULL,
	DiaChi NVARCHAR(200) NOT NULL,
	SDTNguoiNhan VARCHAR(10) NOT NULL,
	GhiChuGH NVARCHAR(200)
);

-- Tạo bảng Hóa Đơn
CREATE TABLE HoaDon(
	MaHD VARCHAR(10) PRIMARY KEY,
	NgayLapHD DATETIME NOT NULL,
	TongTien INT NOT NULL CHECK (TongTien > 0),
	TongTienDuocGiam INT CHECK (TongTienDuocGiam >= 0),
	ThanhTien INT NOT NULL CHECK (ThanhTien >= 0),
	DiemCong INT CHECK (DiemCong >= 0),
	MaPhieu VARCHAR(10), -- FK
	MaThe VARCHAR(10), -- FK
);

-- Tạo bảng Đánh Giá
CREATE TABLE DanhGia(
	MaHD VARCHAR(10) PRIMARY KEY, -- FK
	DiemViTriCN INT CHECK (DiemViTriCN BETWEEN 1 AND 5) NOT NULL,
	DiemChatLuongMonAN INT CHECK (DiemChatLuongMonAn BETWEEN 1 AND 5) NOT NULL,
	DiemGiaCa INT CHECK (DiemGiaCa BETWEEN 1 AND 5) NOT NULL,
	DiemKhongGianNhaHang INT CHECK (DiemKhongGianNhaHang BETWEEN 1 AND 5) NOT NULL,
	DiemPhucVu INT CHECK (DiemPhucVu BETWEEN 1 AND 5) NOT NULL,
	BinhLuan NVARCHAR(200)
);