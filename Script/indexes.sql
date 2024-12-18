--Tạo Non-clustered Index cho PhieuDat (MaCN, LoaiPD, TinhTrangThanhToan)
CREATE NONCLUSTERED INDEX Idx_PhieuDat_MaCN_LoaiPD_TinhTrangThanhToan ON dbo.PhieuDat (MaCN, LoaiPD, TinhTrangThanhToan);
	
	--Thực thi procedures để kiểm tra Execution Plan
EXEC dbo.USP_DanhSachDat @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến', -- nvarchar(20)
                         @MaTKNhanVien = 'NV000040'   -- varchar(10)
	
	--Drop Index
--DROP INDEX Idx_PhieuDat_MaCN_LoaiPD_TinhTrangThanhToan ON dbo.PhieuDat;


--=======================================================================================================================

--Tạo Non-clustered Index cho The (TkSoHuu)
CREATE NONCLUSTERED INDEX Idx_The_TkSoHuu ON dbo.The (TkSoHuu);

	--Thực thi procedures để kiểm tra Execution Plan
EXEC dbo.USP_XemThongTinKhachHang @MaTK = 'KH044999' -- varchar(10)

	--Drop Index
--DROP INDEX Idx_The_TkSoHuu ON dbo.The;

--=======================================================================================================================

--Tạo Non-clustered Index cho CTPD (MaMA) INCLUDE (SoLuong, ThanhTien)
CREATE NONCLUSTERED INDEX Idx_CTPD_MaMA ON dbo.CTPD (MaMA) INCLUDE (SoLuong, ThanhTien);
--CREATE NONCLUSTERED INDEX Idx_PhieuDat_MaCN_LoaiPD_TinhTrangThanhToan ON dbo.PhieuDat (MaCN, LoaiPD, TinhTrangThanhToan);
	--Thực thi procedures để kiểm tra Execution Plan
DECLARE @TongSoLuongBan INT,
        @TongDoanhThu BIGINT;
EXEC dbo.USP_QuanLyThongKe @MaTK = 'NV000012',                         -- varchar(10)
                           @NgayBD = '2010-01-01 00:00:00',          -- datetime
                           @NgayKT = '2016-12-31 00:00:00',          -- datetime
                           @TenMA = N'HOKKIGAI SASHIMI',			 -- nvarchar(100)
                           @TongSoLuongBan = @TongSoLuongBan OUTPUT, -- int
                           @TongDoanhThu = @TongDoanhThu OUTPUT      -- bigint
	--Drop Index
--DROP INDEX Idx_CTPD_MaMA ON dbo.CTPD;