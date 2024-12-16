-- Non-clustered cho PhieuDat
CREATE NONCLUSTERED INDEX Idx_PhieuDat_TinhTrangThanhToan_LoaiPD_MaCN ON dbo.PhieuDat (TinhTrangThanhToan, LoaiPD, MaCN);

EXEC dbo.USP_DanhSachDat @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến', -- nvarchar(20)
                         @MaTKNhanVien = 'NV0040'   -- varchar(10)

DROP INDEX Idx_PhieuDat_TinhTrangThanhToan_LoaiPD_MaCN ON dbo.PhieuDat;
-- Non-clustered cho The
CREATE NONCLUSTERED INDEX Idx_The_TkSoHuu ON dbo.The (TkSoHuu);

EXEC dbo.USP_XemThongTinKhachHang @MaTK = 'KH44999' -- varchar(10)


DROP INDEX Idx_The_TkSoHuu ON dbo.The;
-- Non-clustered cho HoaDon và CTPD và Partition cho HoaDon
DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;

CREATE NONCLUSTERED INDEX Idx_HoaDon_MaPhieu ON dbo.HoaDon (MaPhieu);
DROP INDEX Idx_HoaDon_MaPhieu ON dbo.HoaDon;

CREATE NONCLUSTERED INDEX Idx_CTPD_MaMA ON dbo.CTPD (MaMA) INCLUDE (SoLuong, ThanhTien);
DROP INDEX Idx_CTPD_MaMA ON dbo.CTPD;

DECLARE @TongSoLuongBan INT,
        @TongDoanhThu BIGINT;
EXEC dbo.USP_QuanLyThongKe @MaTK = 'NV0012',                         -- varchar(10)
                           @NgayBD = '2019-12-14 20:15:10',          -- datetime
                           @NgayKT = '2024-12-14 20:15:10',          -- datetime
                           @TenMA = N'SAKE POTETO CHIIZU'			 -- nvarchar(100)
                           @TongSoLuongBan = @TongSoLuongBan OUTPUT, -- int
                           @TongDoanhThu = @TongDoanhThu OUTPUT      -- bigint
