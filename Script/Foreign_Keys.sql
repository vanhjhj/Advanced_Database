USE QUAN_LY_NHA_HANG;
GO

-- Thêm khóa ngoại cho bảng Khu Vực

-- Thêm khóa ngoại cho bảng Chi Nhánh
-- Chi Nhánh -> Khu Vực
ALTER TABLE ChiNhanh
ADD CONSTRAINT FK_ChiNhanh_KhuVuc
FOREIGN KEY (MaKV) REFERENCES KhuVuc (MaKV)

-- Chi Nhánh -> Nhân Viên
ALTER TABLE ChiNhanh
ADD CONSTRAINT FK_ChiNhanh_NhanVien
FOREIGN KEY (QuanLy) REFERENCES NhanVien (MaTK)

-- Thêm khóa ngoại cho bảng Mục

-- Thêm khóa ngoại cho bảng Món Ăn
-- Món Ăn -> Mục
ALTER TABLE MonAn
ADD CONSTRAINT FK_MonAn_Muc
FOREIGN KEY (MaMuc) REFERENCES Muc (MaMuc)

-- Thêm khóa ngoại cho bảng Thực Đơn
-- Thực Đơn -> Chi Nhánh
ALTER TABLE ThucDon
ADD CONSTRAINT FK_ThucDon_ChiNhanh
FOREIGN KEY (MaCN) REFERENCES ChiNhanh (MaCN)

-- Thực Đơn -> Món Ăn
ALTER TABLE ThucDon
ADD CONSTRAINT FK_ThucDon_MonAn
FOREIGN KEY (MaMA) REFERENCES MonAn (MaMA) 

-- Thêm khóa ngoại cho bảng Tài Khoản

-- Thêm khóa ngoại cho bảng Bộ Phận

-- Thêm khóa ngoại cho bảng Nhân Viên
-- Nhân Viên -> Tài Khoản
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_TaiKhoan
FOREIGN KEY (MaTK) REFERENCES TaiKhoan (MaTK)

-- Nhân Viên -> Bộ Phận
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_BoPhan
FOREIGN KEY (MaBP) REFERENCES BoPhan (MaBP)

-- Nhân Viên -> Chi Nhánh
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_ChiNhanh
FOREIGN KEY (MaCN) REFERENCES ChiNhanh (MaCN)

-- Thêm khóa ngoại cho bảng Lịch Sử Điều Động
-- Lịch Sử Điều Động -> Chi Nhánh
ALTER TABLE LichSuDieuDong
ADD CONSTRAINT FK_LichSuDieuDong_ChiNhanh
FOREIGN KEY (MaCN) REFERENCES ChiNhanh (MaCN)

-- Lịch Sử Điều Động -> Nhân Viên
ALTER TABLE LichSuDieuDong
ADD CONSTRAINT FK_LichSuDieuDong_NhanVien
FOREIGN KEY (MaTkNV) REFERENCES NhanVien (MaTK)

-- Thêm khóa ngoại cho bảng Khách Hàng
-- Khách Hàng -> Tài Khoản
ALTER TABLE KhachHang
ADD CONSTRAINT FK_KhachHang_TaiKhoan
FOREIGN KEY (MaTK) REFERENCES TaiKhoan (MaTK)

-- Thêm khóa ngoại cho bảng Loại Thẻ

-- Thêm khóa ngoại cho bảng Thẻ
-- Thẻ -> Loại Thẻ
ALTER TABLE The
ADD CONSTRAINT FK_The_LoaiThe
FOREIGN KEY (TenLoaiThe) REFERENCES LoaiThe (TenLoaiThe)

-- Thẻ -> Khách Hàng
ALTER TABLE The
ADD CONSTRAINT FK_The_KhachHang
FOREIGN KEY (TkSoHuu) REFERENCES KhachHang (MaTK)

-- Thẻ -> Nhân Viên
ALTER TABLE The
ADD CONSTRAINT FK_The_NhanVien
FOREIGN KEY (TkLap) REFERENCES NhanVien (MaTK)

-- Thêm khóa ngoại cho bảng Phiếu Đặt
-- Phiếu Đặt -> Chi Nhánh
ALTER TABLE PhieuDat
ADD CONSTRAINT FK_PhieuDat_ChiNhanh
FOREIGN KEY (MaCN) REFERENCES ChiNhanh (MaCN)

-- Phiếu Đặt -> Tài Khoản
ALTER TABLE PhieuDat
ADD CONSTRAINT FK_PhieuDat_TaiKhoan
FOREIGN KEY (TkLap) REFERENCES TaiKhoan (MaTK)

-- Thêm khóa ngoại cho bảng Chi Tiết Phiếu Đặt
-- Chi Tiết Phiếu Đặt -> Phiếu Đặt
ALTER TABLE CTPD
ADD CONSTRAINT FK_CTPD_PhieuDat
FOREIGN KEY (MaPhieu) REFERENCES PhieuDat (MaPhieu)

-- Chi Tiết Phiếu Đặt -> Món Ăn
ALTER TABLE CTPD
ADD CONSTRAINT FK_CTPD_MonAn
FOREIGN KEY (MaMA) REFERENCES MonAn (MaMA)

-- Thêm khóa ngoại cho bảng Phiếu Đặt Bàn Trực Tuyến
-- Phiếu Đặt Trực Tuyến -> Phiếu Đặt
ALTER TABLE PhieuDatBanTrucTuyen
ADD CONSTRAINT FK_PhieuDatBanTrucTuyen_PhieuDat
FOREIGN KEY (MaPhieu) REFERENCES PhieuDat (MaPhieu)

-- Thêm khóa ngoại cho bảng Phiếu Đặt Giao Hàng
-- Phiếu Đặt Giao Hàng -> Phiếu Đặt
ALTER TABLE PhieuDatGiaoHang
ADD CONSTRAINT FK_PhieuDatGiaoHang_PhieuDat
FOREIGN KEY (MaPhieu) REFERENCES PhieuDat (MaPhieu)

-- Thêm khóa ngoại cho bảng Hóa Đơn
-- Hóa Đơn -> Phiếu Đặt
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_PhieuDat
FOREIGN KEY (MaPhieu) REFERENCES PhieuDat (MaPhieu)

-- Hóa Đơn -> Thẻ
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_The
FOREIGN KEY (MaThe) REFERENCES The (MaThe)

-- Thêm khóa ngoại cho bảng Đánh Giá
-- Đánh Giá -> Hóa Đơn
ALTER TABLE DanhGia
ADD CONSTRAINT FK_DanhGia_HoaDon
FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD)