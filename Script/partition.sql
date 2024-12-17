-- Tạo filegroup cho các phân vùng
ALTER DATABASE QUAN_LY_NHA_HANG ADD FILEGROUP FG_2010_2015;
ALTER DATABASE QUAN_LY_NHA_HANG ADD FILEGROUP FG_2015_2020;
ALTER DATABASE QUAN_LY_NHA_HANG ADD FILEGROUP FG_2020_2024;
GO

-- Tạo tệp dữ liệu cho từng filegroup
ALTER DATABASE QUAN_LY_NHA_HANG
ADD FILE (
    NAME = 'HD_FG_2010_2015',
    FILENAME = 'D:\HD_FG_2010_2015.ndf',
    SIZE = 10MB
) TO FILEGROUP FG_2010_2015;

ALTER DATABASE QUAN_LY_NHA_HANG
ADD FILE (
    NAME = 'HD_FG_2015_2020',
    FILENAME = 'D:\HD_FG_2015_2020.ndf',
    SIZE = 10MB
) TO FILEGROUP FG_2015_2020;

ALTER DATABASE QUAN_LY_NHA_HANG
ADD FILE (
    NAME = 'HD_FG_2020_2024',
    FILENAME = 'D:\HD_FG_2020_2024.ndf',
    SIZE = 10MB
) TO FILEGROUP FG_2020_2024;

-- Tạo hàm partition
GO
CREATE PARTITION FUNCTION PF_HoaDon_NgayLapHD(DATETIME)
AS RANGE RIGHT FOR VALUES ('2015-01-01','2020-01-01','2024-01-01');

-- Đổ dữ liệu vào cái partition scheme
CREATE PARTITION SCHEME PS_HoaDon_NgayLapHD 
AS PARTITION PF_HoaDon_NgayLapHD 
TO ([FG_2010_2015], [FG_2015_2020], [FG_2020_2024], [PRIMARY]);
GO

-- Bỏ khóa ngoại tham chiếu tới HoaDon trước khi partition
ALTER TABLE dbo.DanhGia
DROP CONSTRAINT FK_DanhGia_HoaDon;

-- Bỏ clustered index trên MaHD
ALTER TABLE dbo.HoaDon
DROP CONSTRAINT PK__HoaDon --[Thay tên PK ở đây]

-- Thêm lại non-clustered index cho MaHD
ALTER TABLE dbo.HoaDon
ADD PRIMARY KEY 
NONCLUSTERED (MaHD)
ON [PRIMARY];

-- Thêm lại khóa ngoại cho DanhGia
ALTER TABLE dbo.DanhGia
ADD CONSTRAINT FK_DanhGia_HoaDon
FOREIGN KEY (MaHD) REFERENCES dbo.HoaDon (MaHD);

-- Tạo clustered index trên thuộc tính được dùng để partition NgayLapHD
CREATE CLUSTERED INDEX Idx_HoaDon_NgayLapHD 
ON dbo.HoaDon (NgayLapHD) ON PS_HoaDon_NgayLapHD (NgayLapHD);




