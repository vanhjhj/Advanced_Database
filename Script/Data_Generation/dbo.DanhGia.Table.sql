USE [QUAN_LY_NHA_HANG]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 17/12/2024 10:37:46 CH ******/
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
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_HoaDon]
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
