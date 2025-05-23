USE [QUAN_LY_NHA_HANG]
GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoPhan](
	[MaBP] [varchar](10) NOT NULL,
	[TenBP] [nvarchar](50) NULL,
	[Luong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MaCN] [varchar](10) NOT NULL,
	[TenCN] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[TgMoCua] [time](7) NULL,
	[TgDongCua] [time](7) NULL,
	[SDT] [varchar](10) NULL,
	[BaiDoXeMay] [nvarchar](5) NULL,
	[BaiDoXeHoi] [nvarchar](5) NULL,
	[MaKV] [varchar](10) NULL,
	[QuanLy] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DiaChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[QuanLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPD]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPD](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaMA] [varchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaHD] [varchar](10) NOT NULL,
	[DiemViTriCN] [int] NOT NULL,
	[DiemChatLuongMonAN] [int] NOT NULL,
	[DiemGiaCa] [int] NOT NULL,
	[DiemKhongGianNhaHang] [int] NOT NULL,
	[DiemPhucVu] [int] NOT NULL,
	[BinhLuan] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLapHD] [datetime] NOT NULL,
	[TongTien] [int] NOT NULL,
	[TongTienDuocGiam] [int] NULL,
	[ThanhTien] [int] NOT NULL,
	[DiemCong] [int] NULL,
	[MaPhieu] [varchar](10) NULL,
	[MaThe] [varchar](10) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PS_HoaDon_NgayLapHD]([NgayLapHD])
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaTK] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[CCCD] [varchar](12) NULL,
	[GioiTinh] [nvarchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKV] [varchar](10) NOT NULL,
	[TenKV] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuDieuDong]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuDieuDong](
	[MaCN] [varchar](10) NOT NULL,
	[MaTkNV] [varchar](10) NOT NULL,
	[NgayBD] [datetime] NOT NULL,
	[NgayKT] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC,
	[MaTkNV] ASC,
	[NgayBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThe]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThe](
	[TenLoaiThe] [varchar](10) NOT NULL,
	[ChietKhau] [int] NULL,
	[GiamGia] [int] NULL,
	[SpTang] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenLoaiThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMA] [varchar](10) NOT NULL,
	[TenMA] [nvarchar](50) NULL,
	[GiaHienTai] [int] NULL,
	[TinhTrangMonAn] [nvarchar](5) NULL,
	[MaMuc] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Muc]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muc](
	[MaMuc] [varchar](10) NOT NULL,
	[TenMuc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaTK] [varchar](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgayVaoLam] [datetime] NULL,
	[NgayNghiViec] [datetime] NULL,
	[SDT] [varchar](10) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaBP] [varchar](10) NULL,
	[MaCN] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDat]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDat](
	[MaPhieu] [varchar](10) NOT NULL,
	[TinhTrangThanhToan] [nvarchar](15) NOT NULL,
	[LoaiPD] [nvarchar](20) NOT NULL,
	[MaCN] [varchar](10) NULL,
	[TkLap] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatBanTrucTuyen]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatBanTrucTuyen](
	[MaPhieu] [varchar](10) NOT NULL,
	[TdTruyCap] [datetime] NOT NULL,
	[TgTruyCap] [int] NOT NULL,
	[SLKhach] [int] NOT NULL,
	[ThoiGianDen] [datetime] NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatGiaoHang]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatGiaoHang](
	[MaPhieu] [varchar](10) NOT NULL,
	[TdTruyCap] [datetime] NOT NULL,
	[TgTruyCap] [int] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDTNguoiNhan] [varchar](10) NOT NULL,
	[GhiChuGH] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [varchar](10) NOT NULL,
	[TenTK] [varchar](50) NULL,
	[MatKhau] [varchar](20) NOT NULL,
	[LoaiTK] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempMenu]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempMenu](
	[OriginalTenMA] [nvarchar](50) NULL,
	[NewTenMA] [nvarchar](50) NULL,
	[GiaHienTai] [int] NULL,
	[TinhTrangMonAn] [nvarchar](5) NULL,
	[TenMuc] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[The]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[The](
	[MaThe] [varchar](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[NgayBDChuKy] [datetime] NULL,
	[TongDiem] [int] NULL,
	[TongDiemDuyTri] [int] NULL,
	[TinhTrang] [nvarchar](4) NOT NULL,
	[TenLoaiThe] [varchar](10) NOT NULL,
	[TkSoHuu] [varchar](10) NOT NULL,
	[TkLap] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 17/12/2024 10:36:35 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[MaCN] [varchar](10) NOT NULL,
	[MaMA] [varchar](10) NOT NULL,
	[TinhTrangPhucVu] [nvarchar](5) NULL,
	[TinhTrangGiaoHang] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC,
	[MaMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiNhanh_KhuVuc] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KhuVuc] ([MaKV])
GO
ALTER TABLE [dbo].[ChiNhanh] CHECK CONSTRAINT [FK_ChiNhanh_KhuVuc]
GO
ALTER TABLE [dbo].[ChiNhanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiNhanh_NhanVien] FOREIGN KEY([QuanLy])
REFERENCES [dbo].[NhanVien] ([MaTK])
GO
ALTER TABLE [dbo].[ChiNhanh] CHECK CONSTRAINT [FK_ChiNhanh_NhanVien]
GO
ALTER TABLE [dbo].[CTPD]  WITH CHECK ADD  CONSTRAINT [FK_CTPD_MonAn] FOREIGN KEY([MaMA])
REFERENCES [dbo].[MonAn] ([MaMA])
GO
ALTER TABLE [dbo].[CTPD] CHECK CONSTRAINT [FK_CTPD_MonAn]
GO
ALTER TABLE [dbo].[CTPD]  WITH CHECK ADD  CONSTRAINT [FK_CTPD_PhieuDat] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDat] ([MaPhieu])
GO
ALTER TABLE [dbo].[CTPD] CHECK CONSTRAINT [FK_CTPD_PhieuDat]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_PhieuDat] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDat] ([MaPhieu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_PhieuDat]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_The] FOREIGN KEY([MaThe])
REFERENCES [dbo].[The] ([MaThe])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_The]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[LichSuDieuDong]  WITH CHECK ADD  CONSTRAINT [FK_LichSuDieuDong_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[LichSuDieuDong] CHECK CONSTRAINT [FK_LichSuDieuDong_ChiNhanh]
GO
ALTER TABLE [dbo].[LichSuDieuDong]  WITH CHECK ADD  CONSTRAINT [FK_LichSuDieuDong_NhanVien] FOREIGN KEY([MaTkNV])
REFERENCES [dbo].[NhanVien] ([MaTK])
GO
ALTER TABLE [dbo].[LichSuDieuDong] CHECK CONSTRAINT [FK_LichSuDieuDong_NhanVien]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_Muc] FOREIGN KEY([MaMuc])
REFERENCES [dbo].[Muc] ([MaMuc])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_Muc]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BoPhan] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BoPhan] ([MaBP])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BoPhan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDat_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[PhieuDat] CHECK CONSTRAINT [FK_PhieuDat_ChiNhanh]
GO
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDat_TaiKhoan] FOREIGN KEY([TkLap])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[PhieuDat] CHECK CONSTRAINT [FK_PhieuDat_TaiKhoan]
GO
ALTER TABLE [dbo].[PhieuDatBanTrucTuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBanTrucTuyen_PhieuDat] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDat] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuDatBanTrucTuyen] CHECK CONSTRAINT [FK_PhieuDatBanTrucTuyen_PhieuDat]
GO
ALTER TABLE [dbo].[PhieuDatGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatGiaoHang_PhieuDat] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDat] ([MaPhieu])
GO
ALTER TABLE [dbo].[PhieuDatGiaoHang] CHECK CONSTRAINT [FK_PhieuDatGiaoHang_PhieuDat]
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD  CONSTRAINT [FK_The_KhachHang] FOREIGN KEY([TkSoHuu])
REFERENCES [dbo].[KhachHang] ([MaTK])
GO
ALTER TABLE [dbo].[The] CHECK CONSTRAINT [FK_The_KhachHang]
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD  CONSTRAINT [FK_The_LoaiThe] FOREIGN KEY([TenLoaiThe])
REFERENCES [dbo].[LoaiThe] ([TenLoaiThe])
GO
ALTER TABLE [dbo].[The] CHECK CONSTRAINT [FK_The_LoaiThe]
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD  CONSTRAINT [FK_The_NhanVien] FOREIGN KEY([TkLap])
REFERENCES [dbo].[NhanVien] ([MaTK])
GO
ALTER TABLE [dbo].[The] CHECK CONSTRAINT [FK_The_NhanVien]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_ChiNhanh] FOREIGN KEY([MaCN])
REFERENCES [dbo].[ChiNhanh] ([MaCN])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_ChiNhanh]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_MonAn] FOREIGN KEY([MaMA])
REFERENCES [dbo].[MonAn] ([MaMA])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_MonAn]
GO
ALTER TABLE [dbo].[BoPhan]  WITH CHECK ADD CHECK  (([LUONG]>(0)))
GO
ALTER TABLE [dbo].[ChiNhanh]  WITH CHECK ADD CHECK  (([BaiDoXeMay]=N'Không' OR [BaiDoXeMay]=N'Có'))
GO
ALTER TABLE [dbo].[ChiNhanh]  WITH CHECK ADD CHECK  (([BaiDoXeHoi]=N'Không' OR [BaiDoXeHoi]=N'Có'))
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD CHECK  (([DiemChatLuongMonAn]>=(1) AND [DiemChatLuongMonAn]<=(5)))
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD CHECK  (([DiemGiaCa]>=(1) AND [DiemGiaCa]<=(5)))
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD CHECK  (([DiemKhongGianNhaHang]>=(1) AND [DiemKhongGianNhaHang]<=(5)))
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD CHECK  (([DiemPhucVu]>=(1) AND [DiemPhucVu]<=(5)))
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD CHECK  (([DiemViTriCN]>=(1) AND [DiemViTriCN]<=(5)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([DiemCong]>=(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([ThanhTien]>=(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([TongTien]>(0)))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([TongTienDuocGiam]>=(0)))
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[LoaiThe]  WITH CHECK ADD CHECK  (([ChietKhau]>=(0)))
GO
ALTER TABLE [dbo].[LoaiThe]  WITH CHECK ADD CHECK  (([GiamGia]>=(0)))
GO
ALTER TABLE [dbo].[LoaiThe]  WITH CHECK ADD CHECK  (([TenLoaiThe]='Gold' OR [TenLoaiThe]='Silver' OR [TenLoaiThe]='Membership'))
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD CHECK  (([GiaHienTai]>(0)))
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD CHECK  (([TinhTrangMonAn]=N'Không' OR [TinhTrangMonAn]=N'Có'))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD CHECK  (([LoaiPD]=N'Giao Hàng' OR [LoaiPD]=N'Trực Tuyến' OR [LoaiPD]=N'Trực Tiếp'))
GO
ALTER TABLE [dbo].[PhieuDat]  WITH CHECK ADD CHECK  (([TinhTrangThanhToan]=N'Chưa Thanh Toán' OR [TinhTrangThanhToan]=N'Đã Thanh Toán'))
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD CHECK  (([LoaiTK]=N'Nhân Viên' OR [LoaiTK]=N'Khách Hàng'))
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD CHECK  (([TinhTrang]=N'Đóng' OR [TinhTrang]=N'Mở'))
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD CHECK  (([TongDiem]>=(0)))
GO
ALTER TABLE [dbo].[The]  WITH CHECK ADD CHECK  (([TongDiemDuyTri]>=(0)))
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD CHECK  (([TinhTrangPhucVu]=N'Không' OR [TinhTrangPhucVu]=N'Có'))
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD CHECK  (([TinhTrangGiaoHang]=N'Không' OR [TinhTrangGiaoHang]=N'Có'))
GO
