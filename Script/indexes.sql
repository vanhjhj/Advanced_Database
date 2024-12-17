--Tạo Non-clustered Index cho PhieuDat (TinhTrangThanhToan, LoaiPD, MaCN)
CREATE NONCLUSTERED INDEX Idx_PhieuDat_TinhTrangThanhToan_LoaiPD_MaCN ON dbo.PhieuDat (TinhTrangThanhToan, LoaiPD, MaCN);
	
	--Thực thi procedures để kiểm tra Execution Plan
EXEC dbo.USP_DanhSachDat @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến', -- nvarchar(20)
                         @MaTKNhanVien = 'NV0040'   -- varchar(10)
	
	--Drop Index
--DROP INDEX Idx_PhieuDat_TinhTrangThanhToan_LoaiPD_MaCN ON dbo.PhieuDat;


--=======================================================================================================================

--Tạo Non-clustered Index cho The (TkSoHuu)
CREATE NONCLUSTERED INDEX Idx_The_TkSoHuu ON dbo.The (TkSoHuu);

	--Thực thi procedures để kiểm tra Execution Plan
EXEC dbo.USP_XemThongTinKhachHang @MaTK = 'KH44999' -- varchar(10)

	--Drop Index
--DROP INDEX Idx_The_TkSoHuu ON dbo.The;

--=======================================================================================================================

--Tạo Non-clustered Index cho CTPD (MaMA) INCLUDE (SoLuong, ThanhTien)
CREATE NONCLUSTERED INDEX Idx_CTPD_MaMA ON dbo.CTPD (MaMA) INCLUDE (SoLuong, ThanhTien);

	--Thực thi procedures để kiểm tra Execution Plan
DECLARE @TongSoLuongBan INT,
        @TongDoanhThu BIGINT;
EXEC dbo.USP_QuanLyThongKe @MaTK = 'NV0012',                         -- varchar(10)
                           @NgayBD = '2019-12-14 20:15:10',          -- datetime
                           @NgayKT = '2024-12-14 20:15:10',          -- datetime
                           @TenMA = N'SAKE POTETO CHIIZU'			 -- nvarchar(100)
                           @TongSoLuongBan = @TongSoLuongBan OUTPUT, -- int
                           @TongDoanhThu = @TongDoanhThu OUTPUT      -- bigint

	--Drop Index
--DROP INDEX Idx_CTPD_MaMA ON dbo.CTPD;