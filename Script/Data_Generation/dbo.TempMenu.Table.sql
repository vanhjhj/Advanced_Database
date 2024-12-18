USE [QUAN_LY_NHA_HANG]
GO
/****** Object:  Table [dbo].[TempMenu]    Script Date: 17/12/2024 10:37:46 CH ******/
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
