﻿USE QUAN_LY_NHA_HANG

--===========================================Tạo các kiểu dữ liệu cần thiết cho các procedures===========================================
-- Tạo table type cho món ăn
CREATE TYPE dbo.CTPDType AS TABLE
(
    DishName NVARCHAR(50),
    Amount INT,
    Price INT,
    TotalAmount INT,
    Note NVARCHAR(200)
);
GO

--Tạo kiểu dữ liệu để cập nhật thực đơn
CREATE TYPE dbo.ThucDonThayDoi AS TABLE
(
	MaMA VARCHAR(10),
	TinhTrangPhucVu VARCHAR(10),
	TinhTrangGiaoHang VARCHAR(10)
)


--Tạo kiểu dữ liệu để cập nhật Loại thẻ
CREATE TYPE dbo.LoaiTheThayDoi AS TABLE
(
	TenLoaiThe VARCHAR(10),
	ChietKhau INT,
	GiamGia INT,
	SpTang NVARCHAR(200)
)


--Tạo kiểu dữ liệu để cập nhật lương
CREATE TYPE dbo.LuongThayDoi AS TABLE
(
	MaBP VARCHAR(10),
	TenBP NVARCHAR(50),
	Luong INT
)


--Tạo kiểu dữ liệu để cập nhật thực đơn

CREATE TYPE dbo.ThucDonThayDoi AS TABLE
(
	MaMA VARCHAR(10),
	TinhTrangPhucVu VARCHAR(10),
	TinhTrangGiaoHang VARCHAR(10)
)
GO

--===========================================Đăng Nhập===========================================
GO
CREATE OR ALTER PROCEDURE USP_DangNhap
    @TenTK VARCHAR(50),
    @MatKhau VARCHAR(20),
    @MaTK VARCHAR(10) OUTPUT,    -- Thêm MaTK làm tham số đầu ra
    @LoaiTK NVARCHAR(10) OUTPUT,
    @TenBP NVARCHAR(50) OUTPUT
AS
BEGIN
    -- Kiểm tra thông tin đăng nhập
    IF EXISTS (
        SELECT 1
        FROM TaiKhoan
        WHERE TenTK = @TenTK AND MatKhau = @MatKhau
    )
    BEGIN
        IF N'Khách Hàng' = (SELECT LoaiTK FROM TaiKhoan WHERE TenTK = @TenTK AND MatKhau = @MatKhau)
		BEGIN
			SELECT @MaTK = MaTK, @LoaiTK = LoaiTK
			FROM TaiKhoan
			WHERE TenTK = @TenTK AND MatKhau = @MatKhau;
		END
		
		ELSE
		BEGIN
			SELECT @MaTK = TK.MaTK, @TenBP = BP.TenBP, @LoaiTK = LoaiTK
			FROM TaiKhoan TK
			JOIN NhanVien NV ON TK.MaTK = NV.MaTK
			JOIN BoPhan BP ON BP.MaBP = NV.MaBP
			WHERE TenTK = @TenTK AND MatKhau = @MatKhau
			AND NV.NgayNghiViec IS NULL;
		END
    END
    ELSE
    BEGIN
        -- Nếu không tồn tại, trả giá trị NULL để ứng dụng hiển thị lỗi
        SET @MaTK = NULL;
        SET @LoaiTK = NULL;
        SET @TenBP = NULL;
    END
END;
GO

--===========================================Đăng Ký===========================================
GO
CREATE OR ALTER PROCEDURE USP_DangKy
    @TenTK VARCHAR(50),
    @MatKhau VARCHAR(20),
    @HoTen NVARCHAR(50),
    @SDT VARCHAR(10),
    @GioiTinh NVARCHAR(3),
    @CCCD VARCHAR(12),
    @Email VARCHAR(50),
    @MaTK VARCHAR(10) OUTPUT -- Biến trả về MaTK
AS
BEGIN
    -- Kiểm tra sự tồn tại của các trường
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTK)
    BEGIN
        ;THROW 50000, 'Tên tài khoản đã tồn tại. Vui lòng nhập tên khác.', 1;
    END

    IF EXISTS (SELECT 1 FROM KhachHang WHERE SDT = @SDT)
    BEGIN
        ;THROW 50000, 'Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.', 1;
    END

    IF EXISTS (SELECT 1 FROM KhachHang WHERE CCCD = @CCCD)
    BEGIN
        ;THROW 50000, 'CCCD đã tồn tại. Vui lòng nhập CCCD khác.', 1;
    END

    IF EXISTS (SELECT 1 FROM KhachHang WHERE Email = @Email)
    BEGIN
        ;THROW 50000, 'Email đã tồn tại. Vui lòng nhập email khác.', 1;
    END

    -- Nếu không có trường nào bị trùng lặp, tiếp tục đăng ký
    DECLARE @MaxMaTK INT, @NewMaTK VARCHAR(10);
    SELECT @MaxMaTK = ISNULL(MAX(CAST(SUBSTRING(MaTK, 3, LEN(MaTK) - 2) AS INT)), -1)
    FROM TaiKhoan;

    SET @NewMaTK = 'KH' + FORMAT(@MaxMaTK + 1, '000000');

    -- Thêm vào bảng TaiKhoan
    INSERT INTO TaiKhoan (MaTK, TenTK, MatKhau, LoaiTK)
    VALUES (@NewMaTK, @TenTK, @MatKhau, N'Khách Hàng');

    -- Thêm vào bảng KhachHang
    INSERT INTO KhachHang (MaTK, HoTen, SDT, GioiTinh, CCCD, Email)
    VALUES (@NewMaTK, @HoTen, @SDT, @GioiTinh, @CCCD, @Email);

    -- Trả về MaTK
    SET @MaTK = @NewMaTK;
END
GO

--===========================================Xem thông tin khách hàng===========================================
GO
CREATE OR ALTER PROCEDURE USP_XemThongTinKhachHang
    @MaTK VARCHAR(10) -- Nhận vào userID (MaTK)
AS
BEGIN
    SELECT TK.TenTK,TK.MatKhau,
           KH.HoTen, KH.SDT, KH.Email, KH.CCCD, KH.GioiTinh, 
		   TH.MaThe, TH.NgayLap, TH.NgayBDChuKy, TH.TongDiem, TH.TongDiemDuyTri, TH.TenLoaiThe
    FROM TaiKhoan TK
	JOIN KhachHang KH ON TK.MaTK = KH.MaTK
    LEFT JOIN The TH ON KH.MaTK = TH.TkSoHuu
    WHERE TK.MaTK = @MaTK
    AND (TH.TinhTrang = N'Mở' OR TH.TinhTrang IS NULL); -- Chỉ lấy thẻ có trạng thái 'Mở'
END;
GO

--===========================================Cập Nhật thông tin khách hàng===========================================
GO
CREATE OR ALTER PROCEDURE USP_CapNhatThongTinKhachHang
    @MaTK VARCHAR(10),    
    @TenTK VARCHAR(50),   
    @MatKhau VARCHAR(20), 
    @HoTen NVARCHAR(50),   
    @SDT VARCHAR(10),     
    @Email VARCHAR(50),   
    @CCCD VARCHAR(12),    
    @GioiTinh NVARCHAR(3) 
AS
BEGIN
    -- Kiểm tra tính duy nhất cho các trường
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTK AND MaTK != @MaTK)
    BEGIN
        ;THROW 51000, 'Tên tài khoản đã tồn tại.', 1;
    END

    IF EXISTS (SELECT 1 FROM KhachHang WHERE SDT = @SDT AND MaTK != @MaTK)
    BEGIN
        ;THROW 51000, 'Số điện thoại đã tồn tại.', 1;
    END

    IF EXISTS (SELECT 1 FROM KhachHang WHERE Email = @Email AND MaTK != @MaTK)
    BEGIN
        ;THROW 51000, 'Email đã tồn tại.', 1;
    END

    IF EXISTS (SELECT 1 FROM KhachHang WHERE CCCD = @CCCD AND MaTK != @MaTK)
    BEGIN
        ;THROW 51000, 'CCCD đã tồn tại.', 1;
    END

    -- Cập nhật thông tin trong bảng TaiKhoan
    UPDATE TaiKhoan
    SET TenTK = @TenTK,
        MatKhau = @MatKhau
    WHERE MaTK = @MaTK;

    -- Cập nhật thông tin trong bảng KhachHang
    UPDATE KhachHang
    SET HoTen = @HoTen,
        SDT = @SDT,
        Email = @Email,
        CCCD = @CCCD,
        GioiTinh = @GioiTinh
    WHERE MaTK = @MaTK;
END
GO

--===========================================Lấy thông tin chi nhánh===========================================
GO
CREATE OR ALTER PROCEDURE USP_ThongTinChiNhanh 
    @DiaChiChiNhanh NVARCHAR(200)
AS
BEGIN
    -- Lấy thông tin chi nhánh theo địa chỉ chi nhánh
    SELECT TenCN, SDT, BaiDoXeHoi, BaiDoXeMay, 
        -- Trả về thời gian mở cửa và đóng cửa với định dạng HH:mm
        RIGHT('00' + CAST(DATEPART(HOUR, TgMoCua) AS VARCHAR(2)), 2) + ':' + 
        RIGHT('00' + CAST(DATEPART(MINUTE, TgMoCua) AS VARCHAR(2)), 2) AS ThoiGianMoCua,
        
        RIGHT('00' + CAST(DATEPART(HOUR, TgDongCua) AS VARCHAR(2)), 2) + ':' + 
        RIGHT('00' + CAST(DATEPART(MINUTE, TgDongCua) AS VARCHAR(2)), 2) AS ThoiGianDongCua
    FROM ChiNhanh
    WHERE DiaChi = @DiaChiChiNhanh;
END;
GO

--===========================================Lấy thực đơn của chi nhánh===========================================
GO
CREATE OR ALTER PROCEDURE USP_ThucDonChiNhanh
    @LoaiPhieuDat NVARCHAR(50),
    @DiaChiChiNhanh NVARCHAR(200)
AS
BEGIN
    IF @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến'
    BEGIN
        SELECT MA.TenMA AS DishName, Muc.TenMuc AS DishType, MA.GiaHienTai AS Price
		FROM dbo.ThucDon TD
		JOIN dbo.ChiNhanh CN ON CN.MaCN = TD.MaCN
		JOIN dbo.MonAn MA ON MA.MaMA = TD.MaMA
		JOIN dbo.Muc ON Muc.MaMuc = MA.MaMuc
		WHERE CN.DiaChi = @DiaChiChiNhanh AND TD.TinhTrangPhucVu = N'Có'
    END

    ELSE IF @LoaiPhieuDat = N'Giao Hàng Tận Nơi'
    BEGIN
        SELECT MA.TenMA AS DishName, Muc.TenMuc AS DishType, MA.GiaHienTai AS Price
		FROM dbo.ThucDon TD
		JOIN dbo.ChiNhanh CN ON CN.MaCN = TD.MaCN
		JOIN dbo.MonAn MA ON MA.MaMA = TD.MaMA
		JOIN dbo.Muc ON Muc.MaMuc = MA.MaMuc
		WHERE CN.DiaChi = @DiaChiChiNhanh AND TD.TinhTrangGiaoHang = N'Có'
    END
END;
GO

--===========================================Lập Phiếu Đặt Bàn Trực Tuyến===========================================
GO
CREATE OR ALTER PROCEDURE USP_DatBanTrucTuyen
    @TkLap VARCHAR(10),                    
    @DiaChiChiNhanh NVARCHAR(200),        
    @TdTruyCap DATETIME,                  
    @TgTruyCap INT,                       
    @SLKhach INT,                         
    @ThoiGianDen DATETIME,                
    @GhiChu NVARCHAR(200),                
    @CTPD dbo.CTPDType READONLY 
AS
BEGIN
    -- Biến để lưu MaPhieu mới
    DECLARE @MaPhieu VARCHAR(10);

    -- Tạo mã phiếu mới tự động
    DECLARE @MaxMaPhieu INT;
    SELECT @MaxMaPhieu = ISNULL(MAX(CAST(SUBSTRING(MaPhieu, 5, LEN(MaPhieu) - 4) AS INT)), 0)
    FROM PhieuDatBanTrucTuyen;

    SET @MaPhieu = 'PDOL' + FORMAT(@MaxMaPhieu + 1, '000000');

	DECLARE @MaCN VARCHAR(10);
	
	SELECT @MaCN = MaCN
	FROM ChiNhanh
	WHERE DiaChi = @DiaChiChiNhanh

    -- Bước 1: Nhập dữ liệu vào bảng PhieuDat
    INSERT INTO PhieuDat (MaPhieu, TinhTrangThanhToan, LoaiPD, MaCN, TkLap)
    VALUES (@MaPhieu, N'Chưa Thanh Toán', N'Trực Tuyến', @MaCN, @TkLap);

    -- Bước 2: Nhập dữ liệu vào bảng PhieuDatBanTrucTuyen
    INSERT INTO PhieuDatBanTrucTuyen (MaPhieu, TdTruyCap, TgTruyCap, SLKhach, ThoiGianDen, GhiChu)
    VALUES (@MaPhieu, @TdTruyCap, @TgTruyCap, @SLKhach, @ThoiGianDen, @GhiChu);

    -- Bước 3: Nhập dữ liệu vào bảng CTPD
    DECLARE @DishName NVARCHAR(50), @SoLuong INT, @DonGia INT, @ThanhTien INT, @GhiChuCTPD NVARCHAR(200);
    DECLARE @MaMA VARCHAR(10); -- Mã món ăn

    -- Lặp qua tất cả các món ăn được chọn trong TVP
    DECLARE cur CURSOR FOR
    SELECT DishName, Amount, Price, TotalAmount, Note
    FROM @CTPD;

    OPEN cur;
    FETCH NEXT FROM cur INTO @DishName, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD;

    -- Lặp qua từng món ăn trong danh sách
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Lấy MaMA từ bảng MonAn dựa trên TenMA
        SELECT @MaMA = MaMA FROM MonAn WHERE TenMA = @DishName;

        INSERT INTO CTPD (MaPhieu, MaMA, SoLuong, DonGia, ThanhTien, GhiChu)
        VALUES (@MaPhieu, @MaMA, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD);

        FETCH NEXT FROM cur INTO @DishName, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD;
    END

    CLOSE cur;
    DEALLOCATE cur;
END;
GO

--===========================================Lập Phiếu Giao Hàng Tận Nơi===========================================
GO
CREATE OR ALTER PROCEDURE USP_GiaoHangTanNoi 
	@TkLap VARCHAR(10),                    
    @DiaChiChiNhanh NVARCHAR(200),        
    @TdTruyCap DATETIME,                  
    @TgTruyCap INT,                       
    @DiaChiNhan NVARCHAR(200),                          
    @SDTNhan VARCHAR(10),                 
    @GhiChu NVARCHAR(200),                
    @CTPD dbo.CTPDType READONLY
AS
BEGIN
    -- Biến để lưu MaPhieu mới
    DECLARE @MaPhieu VARCHAR(10);

    -- Tạo mã phiếu mới tự động
    DECLARE @MaxMaPhieu INT;
    SELECT @MaxMaPhieu = ISNULL(MAX(CAST(SUBSTRING(MaPhieu, 5, LEN(MaPhieu) - 4) AS INT)), 0)
    FROM PhieuDatGiaoHang;

    SET @MaPhieu = 'PDGH' + FORMAT(@MaxMaPhieu + 1, '000000');

	DECLARE @MaCN VARCHAR(10);
	
	SELECT @MaCN = MaCN
	FROM ChiNhanh
	WHERE DiaChi = @DiaChiChiNhanh

    -- Bước 1: Nhập dữ liệu vào bảng PhieuDat
    INSERT INTO PhieuDat (MaPhieu, TinhTrangThanhToan, LoaiPD, MaCN, TkLap)
    VALUES (@MaPhieu, N'Chưa Thanh Toán', N'Giao Hàng', @MaCN, @TkLap);

    -- Bước 2: Nhập dữ liệu vào bảng PhieuDatBanTrucTuyen
    INSERT INTO PhieuDatGiaoHang(MaPhieu, TdTruyCap, TgTruyCap, DiaChi, SDTNguoiNhan, GhiChuGH)
    VALUES (@MaPhieu, @TdTruyCap, @TgTruyCap, @DiaChiNhan, @SDTNhan, @GhiChu);

    -- Bước 3: Nhập dữ liệu vào bảng CTPD
    DECLARE @DishName NVARCHAR(50), @SoLuong INT, @DonGia INT, @ThanhTien INT, @GhiChuCTPD NVARCHAR(200);
    DECLARE @MaMA VARCHAR(10); -- Mã món ăn

    -- Lặp qua tất cả các món ăn được chọn trong TVP
    DECLARE cur CURSOR FOR
    SELECT DishName, Amount, Price, TotalAmount, Note
    FROM @CTPD;

    OPEN cur;
    FETCH NEXT FROM cur INTO @DishName, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD;

    -- Lặp qua từng món ăn trong danh sách
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Lấy MaMA từ bảng MonAn dựa trên TenMA
        SELECT @MaMA = MaMA FROM MonAn WHERE TenMA = @DishName;

        INSERT INTO CTPD (MaPhieu, MaMA, SoLuong, DonGia, ThanhTien, GhiChu)
        VALUES (@MaPhieu, @MaMA, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD);

        -- Tiến đến món ăn tiếp theo
        FETCH NEXT FROM cur INTO @DishName, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD;
    END

    CLOSE cur;
    DEALLOCATE cur;
END;
GO


--===========================================Đăng ký thẻ thành viên cho khách hàng===========================================
GO
CREATE OR ALTER PROCEDURE USP_DangKyTheThanhVien
	@TkLap VARCHAR(10),
	@TenTKKH VARCHAR(50),
	@MaThe VARCHAR(10) OUTPUT
AS
BEGIN
	-- Kiểm tra tên tài khoản khách hàng có tồn tại
	IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTKKH)
		THROW 50000, N'Tên tài khoản khách hàng không tồn tại!', 1;

	-- Lấy mã tài khoản khách hàng
	DECLARE @MaTKKH VARCHAR(10)

	SELECT @MaTKKH = MaTK
	FROM TaiKhoan
	WHERE TenTK = @TenTKKH

	--Kiểm tra tên tài khoản có thuộc loại khách hàng hay không
	IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaTK = @MaTKKH)
		THROW 50000, N'Tài khoản không phải là tài khoản khách hàng', 1

	-- Kiểm tra tài khoản lập có tồn tại và có là nhân viên không
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @TkLap)
		THROW 50000, N'Tài khoản lập không tồn tại hoặc không phải là nhân viên', 1

	-- Kiểm tra nếu tài khoản khách hàng đã có thẻ rồi thì không được đăng ký mới nữa
	IF EXISTS (SELECT 1 FROM The WHERE TkSoHuu = @MaTKKH)
		THROW 50000, N'Khách hàng đã có thẻ thành viên', 1

	-- Kiểm tra hợp lệ, tạo mã thẻ mới
	DECLARE @MaxMaThe INT, @NewMaThe VARCHAR(10)
	SELECT @MaxMaThe = ISNULL(MAX(CAST(SUBSTRING(MaThe, 4, LEN(MaThe) - 3) as INT)), -1)
	FROM The

	SET @NewMaThe = 'THE' + FORMAT(@MaxMaThe + 1, '000000')

	-- Insert vào bảng The
	INSERT INTO The (MaThe, NgayLap, NgayBDChuKy, TongDiem, TongDiemDuyTri, TinhTrang, TenLoaiThe, TkSoHuu, TkLap)
	VALUES (@NewMaThe, GETDATE(), GETDATE(), 0, 0, N'Mở', 'Membership', @MaTKKH, @TkLap)

	-- Trả về mã thẻ
	SET @MaThe = @NewMaThe
END
GO

--===========================================Cấp lại thẻ thành viên cho khách hàng===========================================
GO
CREATE OR ALTER PROCEDURE USP_CapLaiTheThanhVien
	@TkLap VARCHAR(10),
	@TenTKKH VARCHAR(50),
	@MaThe VARCHAR(10) OUTPUT
AS
BEGIN
	--Kiểm tra tên tài khoản có tồn tại
	IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTKKH)
		THROW 50000, N'Tên tài khoản không tồn tại', 1

	--Lấy mã tài khoản
	DECLARE @MaTKKH VARCHAR(10)
	SELECT @MaTKKH = MaTK
	FROM TaiKhoan
	WHERE @TenTKKH = TenTK

	--Kiểm tra tài khoản có phải là tài khoản khách hàng không
	IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaTK = @MaTKKH)
		THROW 50000, N'Tài khoản không phải là tài khoản khách hàng', 1

	--Kiểm tra tài khoản đã có thẻ chưa
	IF NOT EXISTS (SELECT 1 FROM The WHERE TkSoHuu = @MaTKKH)
		THROW 50000, N'Tài khoản chưa có thẻ thành viên, vui lòng đăng ký thẻ thành viên', 1

	-- Kiểm tra tài khoản lập có tồn tại và có là nhân viên không
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @TkLap)
		THROW 50000, N'Tài khoản lập không tồn tại hoặc không phải là nhân viên', 1

	-- Kiểm tra hợp lệ, tạo mã thẻ mới
	DECLARE @MaxMaThe INT, @NewMaThe VARCHAR(10)
	SELECT @MaxMaThe = ISNULL(MAX(CAST(SUBSTRING(MaThe, 4, LEN(MaThe) - 3) as INT)), -1)
	FROM The

	SET @NewMaThe = 'THE' + FORMAT(@MaxMaThe + 1, '000000')

	--Lấy lại các thông tin của thẻ thành viên có tình trạng đang mở
	DECLARE @NgayBDChuKy DATETIME, @TongDiem INT, @TongDiemDuyTri INT, @TenLoaiThe VARCHAR(10)
	
	SELECT TOP 1 @NgayBDChuKy = NgayBDChuKy, @TongDiem = TongDiem, @TongDiemDuyTri = TongDiemDuyTri, @TenLoaiThe = TenLoaiThe
	FROM The
	WHERE TkSoHuu = @MaTKKH and TinhTrang = N'Mở'
	ORDER BY NgayLap DESC

	--Update tất cả thẻ cũ thành tình trạng đóng
	UPDATE The
	SET TinhTrang = N'Đóng'
	WHERE TkSoHuu = @MaTKKH AND TinhTrang = N'Mở'

	--Insert thẻ mới vào bảng The
	INSERT INTO The (MaThe, NgayLap, NgayBDChuKy, TongDiem, TongDiemDuyTri, TinhTrang, TenLoaiThe, TkSoHuu, TkLap)
	VALUES (@NewMaThe, GETDATE(), @NgayBDChuKy, @TongDiem, @TongDiemDuyTri, N'Mở', @TenLoaiThe, @MaTKKH, @TkLap)

	-- Trả về mã thẻ
	SET @MaThe = @NewMaThe
END
GO


--===========================================Cập nhật lại hạng thẻ cho khách hàng===========================================
GO
CREATE OR ALTER PROCEDURE USP_CapNhatHangTheThanhVien
	@MaTK VARCHAR(10)
AS
BEGIN

	-- Kiểm tra tài khoản thực hiện có tồn tại và có là nhân viên không
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @MaTK)
		THROW 50000, N'Tài khoản thực hiện không tồn tại hoặc không phải là nhân viên', 1
	
	--Khai báo cursor, lấy ra các thẻ cần cập nhật
	DECLARE cur CURSOR FOR
	SELECT MaThe, TongDiemDuyTri, TenLoaiThe
	FROM The
	WHERE DATEDIFF(DAY, NgayBDChuKy, GETDATE()) >= 365 AND TinhTrang = N'Mở'

	--Khai báo các biến để duyệt
	DECLARE @MaThe VARCHAR(10), @TongDiemDuyTri INT, @TenLoaiThe VARCHAR(10) 

	OPEN cur
	FETCH NEXT FROM cur INTO @Mathe, @TongDiemDuyTri, @TenLoaiThe

	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @TenLoaiTheMoi VARCHAR(10)

		--Xác định loại thẻ mới dựa trên tổng điểm duy trì trong năm
		IF @TenLoaiThe = 'Membership'
		BEGIN
			IF @TongDiemDuyTri >= 100
				SET @TenLoaiTheMoi = 'Silver'
			ELSE
				SET @TenLoaiTheMoi = @TenLoaiThe
		END

		ELSE IF @TenLoaiThe = 'Silver'
		BEGIN
			IF @TongDiemDuyTri < 50
				SET @TenLoaiTheMoi = 'Membership'
			ELSE IF @TongDiemDuyTri < 100
				SET @TenLoaiTheMoi = @TenLoaiThe
			ELSE
				SET @TenLoaiTheMoi = 'Gold'
		END

		ELSE
		BEGIN
			IF @TongDiemDuyTri < 100
				SET @TenLoaiTheMoi = 'Silver'
			ELSE
				SET @TenLoaiTheMoi = @TenLoaiThe
		END

		--Cập nhật lại loại thẻ, reset tổng điểm duy trì về 0, ngày bắt đầu chu kỳ là ngày chạy thủ tục
		UPDATE The
		SET TenLoaiThe = @TenLoaiTheMoi, TongDiemDuyTri = 0, NgayBDChuKy = GETDATE()
		WHERE MaThe = @MaThe

		--Duyệt qua thẻ tiếp theo
		FETCH NEXT FROM cur INTO @Mathe, @TongDiemDuyTri, @TenLoaiThe
	END

	CLOSE cur
	DEALLOCATe cur
END
GO

--===========================================Chủ chi nhánh lấy danh sách thực đơn và tình trạng thực đơn của chi nhánh===========================================
GO
CREATE OR ALTER PROCEDURE USP_QuanLiXemThucDonChiNhanh
	@MaTK VARCHAR(10)
AS
BEGIN
	--Kiểm tra mã tài khoản có tồn tại
	IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE MaTK = @MaTK)
		THROW 50000, N'Tài khoản không tồn tại', 1

	--Kiểm tra tài khoản có phải là quản lý
	IF NOT EXISTS (SELECT 1 FROM ChiNhanh WHERE QuanLy = @MaTK)
		THROW 50000, N'Tài khoản không phải là quản lý của chi nhánh', 1

	--Nếu là quản lí, lấy mã chi nhánh mà người đó quản lý
	DECLARE @MaCN VARCHAR(10)
	SELECT @MaCN = MaCN
	FROM ChiNhanh 
	WHERE QuanLy = @MaTK

	--Lấy ra mã món, tên món, tình trạng phục vụ, tình trạng giao hàng
	SELECT ma.MaMA, ma.TenMA, td.TinhTrangPhucVu, td.TinhTrangGiaoHang
	FROM ThucDon td 
	JOIN MonAn ma ON td.MaMA = ma.MaMA
	WHERE td.MaCN = @MaCN
END
GO


--===========================================Quản lí chi nhánh cập nhật thực đơn (trạng thái phục vụ và trạng thái giao hàng)===========================================
GO
CREATE OR ALTER PROCEDURE USP_CapNhatThucDon
	@MaTK VARCHAR(10),
	@ThucDonThayDoi dbo.ThucDonThayDoi READONLY
AS
BEGIN
	--Kiểm tra mã tài khoản có tồn tại
	IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE MaTK = @MaTK)
		THROW 50000, N'Tài khoản không tồn tại', 1
	
	--Kiểm tra tài khoản có phải là quản lý
	IF NOT EXISTS (SELECT 1 FROM ChiNhanh WHERE QuanLy = @MaTK)
		THROW 50000, N'Tài khoản không phải là quản lý của chi nhánh', 1

	--Nếu là quản lí, lấy mã chi nhánh mà người đó quản lý
	DECLARE @MaCN VARCHAR(10)
	SELECT @MaCN = MaCN
	FROM ChiNhanh 
	WHERE QuanLy = @MaTK

	--Khai báo cursor
	DECLARE cur CURSOR FOR
	SELECT MaMA, TinhTrangPhucVu, TinhTrangGiaoHang
	FROM @ThucDonThayDoi

	--Khai báo các biến dùng để duyệt
	DECLARE @MaMA VARCHAR(10), @TinhTrangPhucVu VARCHAR(10), @TinhTrangGiaoHang VARCHAR(10)

	--Duyệt qua cursor
	OPEN cur
	FETCH NEXT FROM cur INTO @MaMA, @TinhTrangPhucVu, @TinhTrangGiaoHang

	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE ThucDon
		SET TinhTrangPhucVu = @TinhTrangPhucVu, TinhTrangGiaoHang = @TinhTrangGiaoHang
		WHERE MaCN = @MaCN and MaMA = @MaMA

		--Nếu tình trạng phục vụ là 'Không', thì tình trạng giao hàng phải là 'Không'
		IF @TinhTrangPhucVu = N'Không'
			UPDATE ThucDon
			SET TinhTrangGiaoHang = N'Không'
			WHERE MaCN = @MaCN and MaMA = @MaMA

		FETCH NEXT FROM cur INTO @MaMA, @TinhTrangPhucVu, @TinhTrangGiaoHang
	END

	CLOSE cur
	DEALLOCATe cur
END
GO


--===========================================Quản Lý Thống Kê===========================================
GO
CREATE OR ALTER PROCEDURE USP_QuanLyThongKe
    @MaTK VARCHAR(10),
    @NgayBD DATETIME,
    @NgayKT DATETIME,
	@TenMA  NVARCHAR(100) = NULL,
    @TongSoLuongBan INT OUT, 
    @TongDoanhThu BIGINT OUT
AS
BEGIN
    BEGIN TRY
        -- Kiểm tra userID hợp lệ
        IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @MaTK)
        BEGIN
            ;THROW 60000, N'UserID không hợp lệ hoặc không tồn tại.', 1;
        END

        -- Lấy thông tin chi nhánh từ userID
        DECLARE @MaCN NVARCHAR(10);
        SELECT @MaCN = NV.MaCN
        FROM NhanVien NV
        JOIN ChiNhanh CN ON CN.MaCN = NV.MaCN
        WHERE MaTK = @MaTK;

        -- Kiểm tra chi nhánh hợp lệ
        IF NOT EXISTS (
			SELECT *
			FROM ChiNhanh
			WHERE MaCN = @MaCN
		)
        BEGIN
            ;THROW 60001, N'Nhân viên không thuộc chi nhánh nào.', 1;
        END

        -- Kiểm tra điều kiện ngày
        IF @NgayKT < @NgayBD
        BEGIN
            ;THROW 60002, N'Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.', 1;
        END

		;WITH CTE_PhieuDat AS (
			SELECT 
				CTPD.MaMA, 
				CTPD.SoLuong, 
				CTPD.ThanhTien
			FROM PhieuDat PD
			JOIN HoaDon HD ON HD.MaPhieu = PD.MaPhieu
			JOIN CTPD ON CTPD.MaPhieu = PD.MaPhieu
			WHERE HD.NgayLapHD BETWEEN @NgayBD AND @NgayKT 
			  AND PD.MaCN = @MaCN
		),
		CTE_ThucDon AS (
			SELECT MaMA
			FROM ThucDon
			WHERE MaCN = @MaCN
		)
		-- Truy vấn chính
		SELECT 
			MA.TenMA AS 'DishName',
			SUM(ISNULL(PD.SoLuong, 0)) AS Amount,
			SUM(ISNULL(CAST(PD.ThanhTien AS BIGINT), 0)) AS Revenue
		FROM MonAn MA
		LEFT JOIN CTE_PhieuDat PD ON MA.MaMA = PD.MaMA
		WHERE 
			(@TenMA IS NULL OR @TenMA = MA.TenMA)
			AND MA.MaMA IN (SELECT MaMA FROM CTE_ThucDon)
		GROUP BY MA.MaMA, MA.TenMA
		ORDER BY Revenue DESC;

		IF @TenMA IS NULL
		BEGIN
			-- Thống kê tổng
			SELECT @TongSoLuongBan = SUM(CTPD.SoLuong),
				   @TongDoanhThu = SUM(CAST(CTPD.ThanhTien AS BIGINT))
			FROM CTPD
			JOIN PhieuDat PD ON PD.MaPhieu = CTPD.MaPhieu
			JOIN HoaDon HD ON HD.MaPhieu = CTPD.MaPhieu
			WHERE PD.MaCN = @MaCN
			AND HD.NgayLapHD BETWEEN @NgayBD AND @NgayKT
			AND ctpd.MaMA IN (
				SELECT td.MaMA
				FROM ThucDon td
				WHERE td.MaCN = @MaCN
			)
		END
    END TRY
    BEGIN CATCH
        THROW 50001, 'Lỗi thống kê', 1;
    END CATCH
END
GO


--===========================================Admin quan ly thong ke===========================================
GO
CREATE OR ALTER PROCEDURE USP_QuanLyThongKeBoiAdmin
    @MaTK VARCHAR(10),
    @NgayBD DATETIME,
    @NgayKT DATETIME,
	@TenKV  NVARCHAR(100) = NULL,
	@TenCN NVARCHAR(100) = NUll,
    @TongSoLuongBan INT OUT, 
    @TongDoanhThu BIGINT OUT
AS
BEGIN
    BEGIN TRY

        -- Kiểm tra điều kiện ngày
        IF @NgayKT < @NgayBD
        BEGIN
            ;THROW 60002, N'Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.', 1;
        END

        -- Thống kê theo món ăn
        SELECT KV1.TenKV AS 'KhuVuc',
               CN1.TenCN AS 'ChiNhanh',
               MA1.TenMA AS 'DishName', 
               0 AS Amount, 
               0 AS Revenue
        FROM KhuVuc KV1
        JOIN ChiNhanh CN1 ON CN1.MaKV = KV1.MaKV
        JOIN ThucDon TD1 ON TD1.MaCN = CN1.MaCN
        JOIN MonAn MA1 ON MA1.MaMA = TD1.MaMA
        WHERE (@TenCN IS NULL OR CN1.TenCN = @TenCN)
          AND (@TenKV IS NULL OR KV1.TenKV = @TenKV)
          AND MA1.MaMA NOT IN (
              SELECT MA2.MaMA
              FROM MonAn MA2
              LEFT JOIN CTPD ON MA2.MaMA = CTPD.MaMA
              LEFT JOIN PhieuDat PD2 ON PD2.MaPhieu = CTPD.MaPhieu
              LEFT JOIN HoaDon HD2 ON HD2.MaPhieu = CTPD.MaPhieu
              LEFT JOIN ChiNhanh CN2 ON CN2.MaCN = PD2.MaCN
              LEFT JOIN KhuVuc KV2 ON KV2.MaKV = CN2.MaKV
              INNER JOIN ThucDon TD ON TD.MaCN = CN2.MaCN AND TD.MaMA = MA2.MaMA
              WHERE (@TenCN IS NULL OR CN2.TenCN = @TenCN)
                AND (@TenKV IS NULL OR KV2.TenKV = @TenKV)
                AND HD2.NgayLapHD BETWEEN @NgayBD AND @NgayKT
          )
        UNION ALL
        -- Món ăn có doanh thu trong khoảng thời gian @NgayBD - @NgayKT
        SELECT KV.TenKV AS 'KhuVuc',
               CN.TenCN AS 'ChiNhanh',
               MA.TenMA AS 'DishName',
               SUM(ISNULL(CTPD.SoLuong, 0)) AS Amount,
               SUM(ISNULL(CAST(CTPD.ThanhTien AS BIGINT), 0)) AS Revenue
        FROM MonAn MA
        LEFT JOIN CTPD ON MA.MaMA = CTPD.MaMA
        LEFT JOIN PhieuDat PD ON PD.MaPhieu = CTPD.MaPhieu
        LEFT JOIN HoaDon HD ON HD.MaPhieu = CTPD.MaPhieu
        LEFT JOIN ChiNhanh CN ON CN.MaCN = PD.MaCN
        LEFT JOIN KhuVuc KV ON KV.MaKV = CN.MaKV
        INNER JOIN ThucDon TD ON TD.MaCN = CN.MaCN AND TD.MaMA = MA.MaMA
        WHERE (@TenCN IS NULL OR CN.TenCN = @TenCN)
          AND (@TenKV IS NULL OR KV.TenKV = @TenKV)
          AND HD.NgayLapHD BETWEEN @NgayBD AND @NgayKT
        GROUP BY KV.TenKV, CN.TenCN, MA.MaMA, MA.TenMA
        ORDER BY 1 ASC, 2 ASC, 4 DESC, 5 DESC;

		--IF @TenCN IS NULL OR @TenKV IS NULL
		BEGIN
			-- Thống kê tổng
			SELECT 
					 @TongSoLuongBan = COALESCE(SUM(CTPD.SoLuong), 0),
					 @TongDoanhThu = COALESCE(SUM(CAST(CTPD.ThanhTien AS BIGINT)), 0)
			FROM CTPD
			LEFT JOIN PhieuDat PD ON PD.MaPhieu = CTPD.MaPhieu
			LEFT JOIN HoaDon HD ON HD.MaPhieu = CTPD.MaPhieu
			LEFT JOIN ChiNhanh CN ON CN.MaCN= PD.MaCN
			LEFT JOIN KhuVuc KV ON KV.MaKV =CN.MaKV
			INNER JOIN ThucDon TD ON TD.MaCN = CN.MaCN AND CTPD.MaMA = TD.MaMA 
			WHERE (@TenCN IS NULL OR CN.TenCN = @TenCN)
			AND (@TenKV IS NULL OR KV.TenKV = @TenKV)
			AND HD.NgayLapHD BETWEEN @NgayBD AND @NgayKT
		END
    END TRY
    BEGIN CATCH
        THROW 50001, 'Lỗi thống kê', 1;
    END CATCH
END
GO


--===========================================Xem thông tin tất cả nhân viên thuộc 1 bộ phận cụ thể===========================================
GO
CREATE OR ALTER PROCEDURE USP_XemThongTinNhanVienCuaMotBoPhan
	@MaTK VARCHAR(10),
	@TenBP NVARCHAR(50)
AS
BEGIN
	SELECT NV.MaTK, NV.Hoten, NV.NgaySinh, NV.GioiTinh, NV.NgayVaoLam, NV.NgayNghiViec, NV.SDT, NV.DiaChi
	FROM NhanVien NV JOIN ChiNhanh CN ON NV.MaCN=CN.MaCN
	JOIN BoPhan BP ON NV.MaBP=BP.MaBP
	WHERE BP.TenBP=@TenBP AND CN.QuanLy=@MaTK 
END;
GO 


--===========================================Xem thông tin tất cả nhân viên thuộc tất cả bộ phận===========================================
GO
CREATE OR ALTER PROCEDURE USP_XemThongTinNhanVienCuaTatCaBoPhan
	@MaTK VARCHAR(10)
AS
BEGIN
	SELECT NV.MaTK, NV.Hoten, NV.NgaySinh, NV.GioiTinh, NV.NgayVaoLam, NV.NgayNghiViec, NV.SDT, NV.DiaChi
	FROM NhanVien NV JOIN ChiNhanh CN ON NV.MaCN=CN.MaCN
	WHERE CN.QuanLy=@MaTK 
END;
GO 


--===========================================Xem thông tin nhân viên(từ người quản lý)===========================================
GO
CREATE OR ALTER PROCEDURE USP_XemThongTinNhanVienTuQuanLy
    @MaTK VARCHAR(10) -- Nhận vào userID (MaTK)
AS
BEGIN
    SELECT NV.Hoten, NV.NgaySinh, NV.GioiTinh, NV.NgayVaoLam, NV.NgayNghiViec, NV.SDT, NV.DiaChi, NV.MaBP, NV.MaCN
    FROM NhanVien NV
    WHERE NV.MaTK = @MaTK
END;
GO


--===========================================Cập nhật thông tin nhân viên(từ người quản lý)===========================================
GO 
CREATE OR ALTER PROCEDURE USP_CapNhatThongTinNhanVienTuQuanLy
	@MaTK VARCHAR(10),    
	@Hoten NVARCHAR(50),
	@NgaySinh DATETIME,
    @GioiTinh NVARCHAR(3),
	@NgayNghiViec DATETIME,
	@SDT VARCHAR(10),
	@DiaChi NVARCHAR(200)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM NhanVien WHERE SDT = @SDT AND MaTK!=@MaTK)
    BEGIN
        ;THROW 50000, 'Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.', 1;
    END

	IF @NgayNghiViec<(SELECT NgayVaoLam FROM NhanVien WHERE MaTK=@MaTK)
	BEGIN
        ;THROW 50000, 'Ngày nghỉ việc phải sau ngày vào làm. Vui lòng điền ngày khác.', 1;
    END

	UPDATE NhanVien
	SET Hoten=@Hoten, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, SDT=@SDT, DiaChi=@DiaChi, NgayNghiViec=@NgayNghiViec 
	WHERE MaTK=@MaTK;
END;
GO


--===========================================Điều động nhân viên sang chi nhánh khác===========================================
GO
CREATE OR ALTER PROCEDURE USP_DieuDongNhanVien
	@MaTK VARCHAR(10),
	@MaTKNV VARCHAR(10),
	@TenCNMoi NVARCHAR(50),
	@NgayBD DATETIME,
	@NgayKT DATETIME
AS
BEGIN
	IF @TenCNMoi =(SELECT TenCN FROM ChiNhanh WHERE QuanLy=@MaTK)
	BEGIN
        ;THROW 50000, 'Tên chi nhánh mới phải khác chi nhánh cũ. Vui lòng điền chi nhánh khác.', 1;
    END

	IF @NgayBD<(SELECT NgayVaoLam FROM NhanVien WHERE MaTK=@MaTKNV)
	BEGIN
        ;THROW 50000, 'Ngày bắt đầu phải sau ngày vào làm. Vui lòng điền ngày khác.', 1;
    END

	IF (@NgayKT<>NULL)
	BEGIN
		IF (@NgayBD>@NgayKT)
		BEGIN
			;THROW 50000, 'Ngày kết thúc phải sau ngày bắt đầu. Vui lòng điền ngày khác', 1;
		END
	END

	DECLARE @MaCN VARCHAR(10)
	SET @MaCN=(SELECT MaCN FROM ChiNhanh WHERE QuanLy=@MaTK)

	INSERT INTO LichSuDieuDong(MaCN,MaTkNV,NgayBD,NgayKT) VALUES (@MaCN,@MaTKNV,@NgayBD,@NgayKT)
END;
GO


--===========================================Thêm nhân viên mới===========================================
GO
CREATE OR ALTER PROCEDURE USP_ThemNhanVien
	@MaTK VARCHAR(10),
    @TenTK VARCHAR(50),
    @MatKhau VARCHAR(20),
    @HoTen NVARCHAR(50),
	@NgaySinh DATETIME,
    @GioiTinh NVARCHAR(3),
	@NgayVaoLam DATETIME,
	@NgayNghiViec DATETIME,
    @SDT VARCHAR(10),
    @DiaChi NVARCHAR(200),
	@TenBP NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra sự tồn tại của các trường
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTK)
    BEGIN
        ;THROW 50000, 'Tên tài khoản đã tồn tại. Vui lòng nhập tên khác.', 1;
    END

	IF DATEDIFF(YEAR,@NgaySinh, GETDATE()) < 18
	BEGIN
        ;THROW 50000, 'Nhân viên phải có độ tuổi từ 18 trở lên. Vui lòng nhập ngày sinh khác.', 1;
    END

	IF @NgayVaoLam < GETDATE()
	BEGIN
        ;THROW 50000, 'Ngày vào làm phải bắt đầu từ sau ngày hiện tại. Vui lòng nhập ngày khác.', 1;
    END

	IF @NgayNghiViec <> NULL
	BEGIN
		IF @NgayNghiViec<@NgayVaoLam
		BEGIN
			;THROW 50000, 'Ngày nghỉ việc phải sau ngày vào làm. Vui lòng nhập ngày khác.', 1;
		END
	END

	DECLARE @MaBP VARCHAR(10)
	SET @MaBP=(SELECT MaBP FROM BoPhan WHERE TenBP=@TenBP)

	DECLARE @MaCN VARCHAR(10)
	SET @MaCN=(SELECT MaCN FROM ChiNhanh WHERE QuanLy=@MaTK)

    DECLARE @MaxMaTK INT, @NewMaTK VARCHAR(10);
    SELECT @MaxMaTK = ISNULL(MAX(CAST(SUBSTRING(MaTK, 3, LEN(MaTK) - 2) AS INT)), -1)
    FROM TaiKhoan;

    SET @NewMaTK = 'NV' + FORMAT(@MaxMaTK + 1, '000000');

    -- Thêm vào bảng TaiKhoan
    INSERT INTO TaiKhoan (MaTK, TenTK, MatKhau, LoaiTK)
    VALUES (@NewMaTK, @TenTK, @MatKhau, N'Nhân Viên');

    -- Thêm vào bảng NhanVien
    INSERT INTO NhanVien(MaTK, HoTen, NgaySinh, GioiTinh, NgayVaoLam, NgayNghiViec, SDT, DiaChi, MaBP, MaCN)
    VALUES (@NewMaTK, @HoTen, @NgaySinh, @GioiTinh, @NgayVaoLam, @NgayNghiViec, @SDT, @DiaChi, @MaBP, @MaCN);
END
GO


--===========================================Xem thông tin chủ chi nhánh/nhân viên===========================================
GO
CREATE OR ALTER PROCEDURE USP_XemThongTinNhanVien
    @MaTK VARCHAR(10) -- Nhận vào userID (MaTK)
AS
BEGIN
    SELECT TK.TenTK,TK.MatKhau,
           NV.Hoten, NV.NgaySinh, NV.GioiTinh, NV.NgayVaoLam, NV.NgayNghiViec, NV.SDT, NV.DiaChi, NV.MaBP, NV.MaCN
    FROM TaiKhoan TK
	JOIN NhanVien NV ON TK.MaTK = NV.MaTK
    WHERE TK.MaTK = @MaTK
END;
GO


--===========================================Chỉnh sửa thông tin chủ chi nhánh/nhân viên===========================================
GO 
CREATE OR ALTER PROCEDURE USP_CapNhatThongTinNhanVien
	@MaTK VARCHAR(10),    
    @TenTK VARCHAR(50),   
    @MatKhau VARCHAR(20), 
	@Hoten NVARCHAR(50),
	@NgaySinh DATETIME,
    @GioiTinh NVARCHAR(3),
	@SDT VARCHAR(10),
	@DiaChi NVARCHAR(200)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTK AND MaTK != @MaTK)
    BEGIN
        ;THROW 50000, 'Tên tài khoản đã tồn tại.', 1;
    END
	IF EXISTS (SELECT 1 FROM NhanVien WHERE SDT = @SDT AND MaTK!=@MaTK)
    BEGIN
        ;THROW 50000, 'Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.', 1;
    END

	UPDATE TaiKhoan
	SET TenTK=@TenTK, MatKhau=@MatKhau
	WHERE MaTK=@MaTK;

	UPDATE NhanVien
	SET Hoten=@Hoten, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, SDT=@SDT, DiaChi=@DiaChi
	WHERE MaTK=@MaTK;
END;
GO


--===========================================Thực đơn cho nhân viên xem khi lập phiếu===========================================
GO
CREATE OR ALTER PROCEDURE USP_ThucDonChoDatBanTrucTiep
	@TkLap VARCHAR(10), 
	@TenCN NVARCHAR(50) OUTPUT
AS
BEGIN
	-- Kiểm tra tài khoản lập có tồn tại và có là nhân viên không
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @TkLap)
	BEGIN
		;THROW 50000, N'Tài khoản lập không tồn tại hoặc không phải là nhân viên', 1
	END

	-- Lấy ra mã, tên chi nhánh của nhân viên đang làm việc
	DECLARE @MaCN VARCHAR(10);

	SELECT @MaCN = CN.MaCN, @TenCN = CN.TenCN
	FROM ChiNhanh CN
	JOIN NhanVien NV ON NV.MaCN = CN.MaCN
	WHERE NV.MaTK = @TkLap;

	-- Lấy ra thực đơn của chi nhánh nhân viên làm việc
	SELECT MA.TenMA AS DishName, Muc.TenMuc AS DishType, MA.GiaHienTai AS Price
	FROM Muc 
	JOIN MonAn MA ON Muc.MaMuc = MA.MaMuc
	JOIN ThucDon TD ON TD.MaMA = MA.MaMA
	JOIN ChiNhanh CN ON CN.MaCN = TD.MaCN
	WHERE CN.MaCN = @MaCN AND TD.TinhTrangPhucVu = N'Có';
END
GO


--===========================================Lập Phiếu Đặt Bàn Trực Tiếp===========================================
GO
CREATE OR ALTER PROCEDURE USP_DatBanTrucTiep
	@TkLap VARCHAR(10),
	@CTPD dbo.CTPDType READONLY 
AS
BEGIN
	DECLARE @MaCN VARCHAR(10);

	-- Lấy ra mã chi nhánh của nhân viên
	SELECT @MaCN = NV.MaCN
	FROM NhanVien NV
	WHERE NV.MaTK = @TkLap;

	-- Biến để lưu MaPhieu mới
    DECLARE @MaPhieu VARCHAR(10);

    -- Tạo mã phiếu mới tự động
    DECLARE @MaxMaPhieu INT;
    SELECT @MaxMaPhieu = ISNULL(MAX(CAST(SUBSTRING(MaPhieu, 5, LEN(MaPhieu) - 4) AS INT)), 0)
    FROM PhieuDat
	WHERE MaPhieu LIKE 'PDTT%';

    SET @MaPhieu = 'PDTT' + FORMAT(@MaxMaPhieu + 1, '000000');

	-- Bước 1: Nhập dữ liệu vào bảng PhieuDat
    INSERT INTO PhieuDat (MaPhieu, TinhTrangThanhToan, LoaiPD, MaCN, TkLap)
    VALUES (@MaPhieu, N'Chưa Thanh Toán', N'Trực Tiếp', @MaCN, @TkLap);

    -- Bước 2: Nhập dữ liệu vào bảng CTPD
    DECLARE @DishName NVARCHAR(50), @SoLuong INT, @DonGia INT, @ThanhTien INT, @GhiChuCTPD NVARCHAR(200);
    DECLARE @MaMA VARCHAR(10); -- Mã món ăn

	-- Lặp qua tất cả các món ăn được chọn trong TVP
    DECLARE cur CURSOR FOR
    SELECT DishName, Amount, Price, TotalAmount, Note
    FROM @CTPD;

    OPEN cur;
    FETCH NEXT FROM cur INTO @DishName, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD;

    -- Lặp qua từng món ăn trong danh sách
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Lấy MaMA từ bảng MonAn dựa trên TenMA
        SELECT @MaMA = MaMA FROM MonAn WHERE TenMA = @DishName;

        INSERT INTO CTPD (MaPhieu, MaMA, SoLuong, DonGia, ThanhTien, GhiChu)
        VALUES (@MaPhieu, @MaMA, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD);

        FETCH NEXT FROM cur INTO @DishName, @SoLuong, @DonGia, @ThanhTien, @GhiChuCTPD;
    END

    CLOSE cur;
    DEALLOCATE cur;
END
GO


--===========================================Lấy danh sách phiếu đặt của loại phiếu đặt để cập nhật phiếu đặt===========================================
GO
CREATE OR ALTER PROCEDURE USP_DanhSachDat
    @LoaiPhieuDat NVARCHAR(20),
    @MaTKNhanVien VARCHAR(10)
AS
BEGIN
    DECLARE @MaPhieuResult TABLE (MaPhieu VARCHAR(50));

    IF @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến'
    BEGIN
        INSERT INTO @MaPhieuResult (MaPhieu)
        SELECT PD.MaPhieu
        FROM PhieuDat PD
        JOIN NhanVien NV ON NV.MaCN = PD.MaCN
        WHERE NV.MaTK = @MaTKNhanVien
        AND PD.LoaiPD = N'Trực Tuyến' AND PD.TinhTrangThanhToan = N'Chưa Thanh Toán';
    END
    ELSE IF @LoaiPhieuDat = N'Giao Hàng Tận Nơi'
    BEGIN
        INSERT INTO @MaPhieuResult (MaPhieu)
        SELECT PD.MaPhieu
        FROM PhieuDat PD
        JOIN NhanVien NV ON NV.MaCN = PD.MaCN
        WHERE NV.MaTK = @MaTKNhanVien
        AND PD.LoaiPD = N'Giao Hàng' AND PD.TinhTrangThanhToan = N'Chưa Thanh Toán';
    END
	ELSE IF @LoaiPhieuDat = N'Đặt Bàn Trực Tiếp'
	BEGIN
		INSERT INTO @MaPhieuResult (MaPhieu)
        SELECT PD.MaPhieu
        FROM PhieuDat PD
        JOIN NhanVien NV ON NV.MaCN = PD.MaCN
        WHERE NV.MaTK = @MaTKNhanVien
        AND PD.LoaiPD = N'Trực Tiếp' AND PD.TinhTrangThanhToan = N'Chưa Thanh Toán';
	END

    -- Kiểm tra kết quả và ném lỗi nếu không tìm thấy bản ghi nào
    IF NOT EXISTS (SELECT 1 FROM @MaPhieuResult)
    BEGIN
        ;THROW 50000, N'Không tìm thấy phiếu đặt nào với thông tin đã cung cấp hoặc nhân viên không thuộc chi nhánh mà khách hàng đặt.', 1;
    END

    -- Trả kết quả nếu có
    SELECT MaPhieu FROM @MaPhieuResult ORDER BY LEN(MaPhieu), MaPhieu DESC;
END
GO


--===========================================Lấy danh sách phiếu đặt của loại phiếu đặt===========================================
GO
CREATE OR ALTER PROCEDURE USP_DanhSachDatHoaDon
    @LoaiPhieuDat NVARCHAR(20),
    @MaTKNhanVien VARCHAR(10),
	@SDTKhachHang VARCHAR(10)
AS
BEGIN
    DECLARE @MaPhieuResult TABLE (MaPhieu VARCHAR(50));

    IF @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến'
    BEGIN
		IF NOT EXISTS (SELECT 1 FROM dbo.KhachHang KH WHERE @SDTKhachHang = KH.SDT)
		BEGIN
		;THROW 51000, 'Khách hàng chưa có tài khoản', 1;
		END
		
		ELSE
        BEGIN
			INSERT INTO @MaPhieuResult (MaPhieu)
			SELECT PD.MaPhieu
			FROM PhieuDat PD
			JOIN NhanVien NV ON NV.MaCN = PD.MaCN
			JOIN dbo.KhachHang KH ON KH.MaTK = PD.TkLap
			WHERE NV.MaTK = @MaTKNhanVien AND KH.SDT = @SDTKhachHang
			AND PD.LoaiPD = N'Trực Tuyến' AND PD.TinhTrangThanhToan = N'Chưa Thanh Toán';
		END
    END
    ELSE IF @LoaiPhieuDat = N'Giao Hàng Tận Nơi'
    BEGIN
		IF NOT EXISTS (SELECT 1 FROM dbo.KhachHang KH WHERE @SDTKhachHang = KH.SDT)
		BEGIN
			;THROW 51000, 'Khách hàng chưa có tài khoản', 1;
		END
		
		ELSE
		BEGIN
			INSERT INTO @MaPhieuResult (MaPhieu)
			SELECT PD.MaPhieu
			FROM PhieuDat PD
			JOIN NhanVien NV ON NV.MaCN = PD.MaCN
			JOIN dbo.KhachHang KH ON KH.MaTK = PD.TkLap
			WHERE NV.MaTK = @MaTKNhanVien AND KH.SDT = @SDTKhachHang
			AND PD.LoaiPD = N'Giao Hàng' AND PD.TinhTrangThanhToan = N'Chưa Thanh Toán';
		END
    END
	ELSE IF @LoaiPhieuDat = N'Đặt Bàn Trực Tiếp'
	BEGIN
		INSERT INTO @MaPhieuResult (MaPhieu)
        SELECT PD.MaPhieu
        FROM PhieuDat PD
        JOIN NhanVien NV ON NV.MaCN = PD.MaCN
        WHERE NV.MaTK = @MaTKNhanVien
        AND PD.LoaiPD = N'Trực Tiếp' AND PD.TinhTrangThanhToan = N'Chưa Thanh Toán';
	END

    -- Kiểm tra kết quả và ném lỗi nếu không tìm thấy bản ghi nào
    IF NOT EXISTS (SELECT 1 FROM @MaPhieuResult)
    BEGIN
        ;THROW 50000, N'Không tìm thấy phiếu đặt nào với thông tin đã cung cấp hoặc nhân viên không thuộc chi nhánh mà khách hàng đặt.', 1;
    END

    -- Trả kết quả nếu có
    SELECT MaPhieu FROM @MaPhieuResult ORDER BY LEN(MaPhieu), MaPhieu DESC;
END
GO


--===========================================Lấy ra chi tiết phiếu đặt và thực đơn===========================================
CREATE OR ALTER PROCEDURE USP_CTPD_ThucDon
	@MaPhieu VARCHAR(10),
	@MaTKNhanVien VARCHAR(10),
	@GhiChu NVARCHAR(200) OUTPUT,
	@SLKhach INT OUTPUT,
	@ThoiGianDen DateTime OUTPUT,
	@DiaChi NVARCHAR(200) OUTPUT,
	@SDTKhachHang VARCHAR(10) OUTPUT,
	@SDTNguoiNhan VARCHAR(10) OUTPUT
AS
BEGIN
	DECLARE @LoaiPhieuDat NVARCHAR(20);
	SELECT @LoaiPhieuDat = LoaiPD
	FROM PhieuDat 
	WHERE MaPhieu = @MaPhieu;

	IF @LoaiPhieuDat = N'Trực Tuyến'
    BEGIN
		-- Lấy ra số lượng khách, thời gian đến
        SELECT @SDTKhachHang = KH.SDT,
			   @SLKhach = SLKhach, @ThoiGianDen = ThoiGianDen, 
			   @DiaChi = NULL, @SDTNguoiNhan = NULL,
			   @GhiChu = GhiChu
		FROM PhieuDatBanTrucTuyen PDTT
		JOIN dbo.PhieuDat PD ON PD.MaPhieu = PDTT.MaPhieu
		JOIN dbo.KhachHang KH ON KH.MaTK = PD.TkLap
		WHERE PDTT.MaPhieu = @MaPhieu;

		-- Lấy ra mã, tên chi nhánh của nhân viên đang làm việc
		DECLARE @MaCNOL VARCHAR(10);

		SELECT @MaCNOL = CN.MaCN
		FROM ChiNhanh CN
		JOIN NhanVien NV ON NV.MaCN = CN.MaCN
		WHERE NV.MaTK = @MaTKNhanVien;

		-- Những món đã đặt
		SELECT MA.TenMA AS DishName, Muc.TenMuc AS DishType, CTPD.SoLuong AS Amount,
			   CTPD.DonGia AS Price, CTPD.ThanhTien AS TotalAmount, CTPD.GhiChu AS Note
		FROM PhieuDatBanTrucTuyen PDTT
		JOIN CTPD ON PDTT.MaPhieu = CTPD.MaPhieu
		JOIN MonAn MA ON MA.MaMA = CTPD.MaMA
		JOIN Muc ON MA.MaMuc = Muc.MaMuc
		WHERE PDTT.MaPhieu = @MaPhieu

		UNION

		-- Lấy ra thực đơn của chi nhánh nhân viên làm việc
		SELECT DISTINCT MA.TenMA AS DishName, Muc.TenMuc AS DishType, NULL AS Amount, 
						MA.GiaHienTai AS Price, NULL AS TotalAmount, NULL AS Note
		FROM Muc 
		JOIN MonAn MA ON Muc.MaMuc = MA.MaMuc
		JOIN ThucDon TD ON TD.MaMA = MA.MaMA
		JOIN PhieuDat PD ON PD.MaCN = TD.MaCN
		WHERE PD.MaCN = @MaCNOL AND TD.TinhTrangPhucVu = N'Có'
    END
    ELSE IF @LoaiPhieuDat = N'Giao Hàng'
    BEGIN
		-- Lấy ra Địa chỉ, số điện thoại người nhận
        SELECT @SDTKhachHang = KH.SDT,
			   @DiaChi = DiaChi, @SDTNguoiNhan = SDTNguoiNhan,
			   @SLKhach = NULL, @ThoiGianDen = NULL,
			   @GhiChu = GhiChuGH
		FROM PhieuDatGiaoHang PDGH
		JOIN dbo.PhieuDat PD ON PD.MaPhieu = PDGH.MaPhieu
		JOIN dbo.KhachHang KH ON KH.MaTK = PD.TkLap
		WHERE PDGH.MaPhieu = @MaPhieu;


		-- Lấy ra mã, tên chi nhánh của nhân viên đang làm việc
		DECLARE @MaCNGH VARCHAR(10);

		SELECT @MaCNGH = CN.MaCN
		FROM ChiNhanh CN
		JOIN NhanVien NV ON NV.MaCN = CN.MaCN
		WHERE NV.MaTK = @MaTKNhanVien;

		SELECT MA.TenMA AS DishName, Muc.TenMuc AS DishType, CTPD.SoLuong AS Amount,
			   CTPD.DonGia AS Price, CTPD.ThanhTien AS TotalAmount, CTPD.GhiChu AS Note
		FROM PhieuDatGiaoHang PDGH
		JOIN CTPD ON PDGH.MaPhieu = CTPD.MaPhieu
		JOIN MonAn MA ON MA.MaMA = CTPD.MaMA
		JOIN Muc ON MA.MaMuc = Muc.MaMuc
		WHERE PDGH.MaPhieu = @MaPhieu

		UNION

		-- Lấy ra thực đơn của chi nhánh nhân viên làm việc
		SELECT DISTINCT MA.TenMA AS DishName, Muc.TenMuc AS DishType, NULL AS Amount, 
						MA.GiaHienTai AS Price, NULL AS TotalAmount, NULL AS Note
		FROM Muc 
		JOIN MonAn MA ON Muc.MaMuc = MA.MaMuc
		JOIN ThucDon TD ON TD.MaMA = MA.MaMA
		JOIN PhieuDat PD ON PD.MaCN = TD.MaCN
		WHERE PD.MaCN = @MaCNGH AND TD.TinhTrangGiaoHang = N'Có';
    END

	ELSE IF @LoaiPhieuDat = N'Trực Tiếp'
    BEGIN
		-- Lấy ra Địa chỉ, số điện thoại người nhận
        SELECT @SDTKhachHang = NULL,
			   @DiaChi = NULL, @SDTNguoiNhan = NULL,
			   @SLKhach = NULL, @ThoiGianDen = NULL,
			   @GhiChu = NULL
		FROM PhieuDat
		WHERE MaPhieu = @MaPhieu;

		-- Lấy ra mã, tên chi nhánh của nhân viên đang làm việc
		DECLARE @MaCNTT VARCHAR(10);

		SELECT @MaCNTT = CN.MaCN
		FROM ChiNhanh CN
		JOIN NhanVien NV ON NV.MaCN = CN.MaCN
		WHERE NV.MaTK = @MaTKNhanVien;

		SELECT MA.TenMA AS DishName, Muc.TenMuc AS DishType, CTPD.SoLuong AS Amount,
			   CTPD.DonGia AS Price, CTPD.ThanhTien AS TotalAmount, CTPD.GhiChu AS Note
		FROM PhieuDat PD
		JOIN CTPD ON PD.MaPhieu = CTPD.MaPhieu
		JOIN MonAn MA ON MA.MaMA = CTPD.MaMA
		JOIN Muc ON MA.MaMuc = Muc.MaMuc
		WHERE PD.MaPhieu = @MaPhieu

		UNION

		-- Lấy ra thực đơn của chi nhánh nhân viên làm việc
		SELECT DISTINCT MA.TenMA AS DishName, Muc.TenMuc AS DishType, NULL AS Amount, 
						MA.GiaHienTai AS Price, NULL AS TotalAmount, NULL AS Note
		FROM Muc 
		JOIN MonAn MA ON Muc.MaMuc = MA.MaMuc
		JOIN ThucDon TD ON TD.MaMA = MA.MaMA
		JOIN PhieuDat PD ON PD.MaCN = TD.MaCN
		WHERE PD.MaCN = @MaCNTT AND TD.TinhTrangPhucVu = N'Có'
		AND MA.TenMA NOT IN (SELECT MA.TenMA
							 FROM PhieuDat PD
							 JOIN CTPD ON PD.MaPhieu = CTPD.MaPhieu
							 JOIN MonAn MA ON MA.MaMA = CTPD.MaMA
							 JOIN Muc ON MA.MaMuc = Muc.MaMuc
							 WHERE PD.MaPhieu = @MaPhieu)
    END
END
GO


--===========================================Cập nhật phiếu đặt online===========================================
CREATE OR ALTER PROCEDURE USP_CapNhatPhieuDat
    @Maphieu VARCHAR(10),
    @LoaiPhieuDat NVARCHAR(20),
    @GhiChu NVARCHAR(200),
    @SLKhach INT,
    @ThoiGianDen DATETIME,
    @DiaChi NVARCHAR(200),
    @SDTNguoiNhan VARCHAR(10),
    @CTPD dbo.CTPDType READONLY
AS
BEGIN
    -- Kiểm tra loại phiếu đặt để xử lý logic khác nhau
    IF @LoaiPhieuDat = N'Giao Hàng Tận Nơi'
    BEGIN
        -- Cập nhật bảng Phiếu Đặt Giao Hàng
        UPDATE PhieuDatGiaoHang
        SET DiaChi = @DiaChi, SDTNguoiNhan = @SDTNguoiNhan, GhiChuGH = @GhiChu
        WHERE MaPhieu = @Maphieu;
    END
    
    ELSE IF @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến'
    BEGIN
        -- Cập nhật bảng Phiếu Đặt Bàn Trực Tuyến
        UPDATE PhieuDatBanTrucTuyen
        SET SLKhach = @SLKhach, ThoiGianDen = @ThoiGianDen, GhiChu = @GhiChu
        WHERE MaPhieu = @Maphieu;
    END

    -- Cập nhật chi tiết phiếu đặt (CTPD)
	-- Xóa hết các món cũ để nhập lại từ đầu
	DELETE FROM CTPD WHERE MaPhieu = @Maphieu;
    
	-- Lặp qua từng món ăn trong @CTPD
    DECLARE @MaMA NVARCHAR(50), @Amount INT, @Price INT, @TotalAmount INT, @Note NVARCHAR(200);

    DECLARE c CURSOR FOR
        SELECT DishName, Amount, Price, TotalAmount, Note FROM @CTPD
        WHERE Amount IS NOT NULL AND Amount > 0;
    
    OPEN c;
    FETCH NEXT FROM c INTO @MaMA, @Amount, @Price, @TotalAmount, @Note;
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Lấy MaMA từ TenMA
        SELECT @MaMA = MaMA FROM MonAn WHERE TenMA = @MaMA;
		-- Nếu không có, thêm mới vào CTPD
        INSERT INTO CTPD (MaPhieu, MaMA, SoLuong, DonGia, ThanhTien, GhiChu)
        VALUES (@Maphieu, @MaMA, @Amount, @Price, @TotalAmount, @Note);
        
        FETCH NEXT FROM c INTO @MaMA, @Amount, @Price, @TotalAmount, @Note;
    END

    CLOSE c;
    DEALLOCATE c;

    -- Xóa các món ăn mà khách hàng không đặt nữa
    DELETE FROM CTPD
    WHERE MaPhieu = @Maphieu
    AND MaMA NOT IN (SELECT MaMA FROM @CTPD WHERE Amount IS NOT NULL AND Amount > 0);

    -- Kiểm tra xem có còn món ăn nào trong CTPD cho phiếu đặt này không
    IF NOT EXISTS (SELECT 1 FROM CTPD WHERE MaPhieu = @Maphieu)
    BEGIN
        -- Nếu không còn món nào, xóa phiếu đặt ở các bảng liên quan
        IF @LoaiPhieuDat = N'Đặt Bàn Trực Tuyến'
        BEGIN
            DELETE FROM PhieuDatBanTrucTuyen WHERE MaPhieu = @Maphieu;
        END
        ELSE IF @LoaiPhieuDat = N'Giao Hàng Tận Nơi'
        BEGIN
            DELETE FROM PhieuDatGiaoHang WHERE MaPhieu = @Maphieu;
        END

        -- Xóa phiếu đặt tổng ở bảng PhieuDat
        DELETE FROM PhieuDat WHERE MaPhieu = @Maphieu;
    END
END;
GO


--===========================================Admin cập nhật Loại thẻ===========================================
GO
CREATE OR ALTER PROCEDURE USP_CapNhatLoaiThe
	@MaTK VARCHAR(10),
	@LoaiTheThayDoi dbo.LoaiTheThayDoi READONLY
AS
BEGIN
	--Kiểm tra mã tài khoản có tồn tại
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @MaTK)
		THROW 50000, N'Tài khoản không tồn tại', 1

	--Khai báo cursor
	DECLARE cur CURSOR FOR
	SELECT TenLoaiThe, ChietKhau, GiamGia, SpTang
	FROM @LoaiTheThayDoi

	--Khai báo các biến dùng để duyệt
	DECLARE @TenLoaiThe VARCHAR(10), @ChietKhau INT, @GiamGia INT, @SpTang NVARCHAR(200)

	--Duyệt qua cursor
	OPEN cur
	FETCH NEXT FROM cur INTO @TenLoaiThe, @ChietKhau, @GiamGia, @SpTang

	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE LoaiThe
		SET ChietKhau = @ChietKhau, GiamGia = @GiamGia, SpTang = @SpTang
		WHERE TenLoaiThe = @TenLoaiThe
		FETCH NEXT FROM cur INTO @TenLoaiThe, @ChietKhau, @GiamGia, @SpTang
	END

	CLOSE cur
	DEALLOCATe cur
END
GO


--===========================================Lấy ra thẻ cho khách hàng===========================================
GO
CREATE OR ALTER PROCEDURE USP_LayRaTheCuaKhachHang
	@SDTKhachHang VARCHAR(10),
	@MaThe VARCHAR(10) OUTPUT,
	@GiamGia INT OUTPUT
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM dbo.KhachHang KH WHERE @SDTKhachHang = KH.SDT)
	BEGIN
		SET @MaThe = NULL
		;THROW 51000, 'Khách hàng chưa có tài khoản', 1;
	END

	ELSE IF NOT EXISTS(SELECT 1 FROM THE JOIN dbo.KhachHang ON MaTK = TkSoHuu WHERE SDT = @SDTKhachHang AND TinhTrang = N'Mở')
	BEGIN
		SET @MaThe = NULL
	END

	ELSE
	BEGIN
		SELECT @MaThe = MaThe, @GiamGia = GiamGia
		FROM dbo.LoaiThe 
		JOIN dbo.The ON The.TenLoaiThe = LoaiThe.TenLoaiThe
		JOIN dbo.KhachHang ON MaTK = TkSoHuu
		WHERE SDT = @SDTKhachHang AND TinhTrang = N'Mở'
	END
END
GO


--===========================================Lấy ra chi tiết hóa đơn===========================================
GO
CREATE OR ALTER PROCEDURE USP_CTHD
	@MaPhieu VARCHAR(10)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM dbo.PhieuDat WHERE MaPhieu = @MaPhieu)
	BEGIN
		;THROW 51000, 'Phiếu Đặt Không Tồn Tại', 1
	END

	ELSE
	BEGIN
		SELECT MA.TenMA AS DishName, CTPD.SoLuong AS Amount, CTPD.DonGia AS Price, CTPD.ThanhTien AS TotalAmount
		FROM dbo.MonAn MA
		JOIN dbo.CTPD ON CTPD.MaMA = MA.MaMA
		JOIN dbo.PhieuDat PD ON PD.MaPhieu = CTPD.MaPhieu
		WHERE PD.MaPhieu = @MaPhieu
	END
END
GO


--===========================================Tạo hóa đơn===========================================
GO
CREATE OR ALTER PROCEDURE USP_Xuat_Hoa_Don
	@MaHD VARCHAR(10) OUTPUT,
	@TongTien INT,
	@TongTienDuocGiam INT,
	@ThanhTien INT,
	@DiemCong INT,
	@MaPhieu VARCHAR(10),
	@MaThe VARCHAR(10)
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM dbo.PhieuDat WHERE MaPhieu = @MaPhieu AND TinhTrangThanhToan = N'Chưa Thanh Toán')
	BEGIN
		;THROW 50000,'Phiếu Đặt không tồn tại hoặc đã được thanh toán', 1
	END

	IF @TongTien <= 0 OR @TongTienDuocGiam < 0 OR @ThanhTien < 0 OR @DiemCong < 0
	BEGIN
		;THROW 51000,'Thông số không hợp lệ', 1
	END

	-- Nếu không có trường nào bị trùng lặp, tiếp tục đăng ký
    DECLARE @MaxMaHD INT, @NewMaHD VARCHAR(10);
    SELECT @MaxMaHD = ISNULL(MAX(CAST(SUBSTRING(MaHD, 3, LEN(MaHD) - 2) AS INT)), -1)
    FROM dbo.HoaDon;

    SET @MaHD = 'HD' + FORMAT(@MaxMaHD + 1, '000000');

	INSERT INTO dbo.HoaDon (MaHD, NgayLapHD, TongTien, TongTienDuocGiam, ThanhTien, DiemCong, MaPhieu, MaThe)
	VALUES (@MaHD, GETDATE(), @TongTien, @TongTienDuocGiam, @ThanhTien, @DiemCong, @MaPhieu, @MaThe);

	UPDATE dbo.PhieuDat 
	SET TinhTrangThanhToan = N'Đã Thanh Toán'
	WHERE MaPhieu = @MaPhieu;

	-- Cộng điểm cho thẻ
	IF @MaThe IS NOT NULL
	BEGIN
		UPDATE dbo.The
		SET TongDiem = TongDiem + @DiemCong, TongDiemDuyTri = TongDiemDuyTri + @DiemCong
		WHERE MaThe = @MaThe
	END
END
GO


--===========================================Tạo đánh giá===========================================
GO
CREATE OR ALTER PROCEDURE USP_Them_Danh_Gia
	@MaHD VARCHAR(10),
	@DiemViTriCN INT,
	@DiemChatLuongMonAn INT,
	@DiemGiaCa INT,
	@DiemKhongGianNhaHang INT,
	@DiemPhucVu INT,
	@BinhLuan NVARCHAR(200)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM dbo.HoaDon WHERE MaHD = @MaHD)
	BEGIN
		;THROW 55000, 'Không tồn tại hóa đơn', 1;
	END

	IF @DiemViTriCN < 1 OR @DiemChatLuongMonAn < 1 OR @DiemGiaCa < 1 OR @DiemKhongGianNhaHang < 1 OR @DiemPhucVu < 1
	BEGIN
		;THROW 56000, 'Điểm số không hợp lệ', 2;
	END

	INSERT INTO dbo.DanhGia (MaHD, DiemViTriCN, DiemChatLuongMonAN, DiemGiaCa, DiemKhongGianNhaHang, DiemPhucVu, BinhLuan)
	VALUES (@MaHD, @DiemViTriCN, @DiemChatLuongMonAn, @DiemGiaCa, @DiemKhongGianNhaHang, @DiemPhucVu, @BinhLuan);
END
GO


--===========================================Admin cập nhật lương===========================================
GO
CREATE OR ALTER PROCEDURE USP_CapNhatLuong
	@MaTK VARCHAR(10),
	@LuongThayDoi dbo.LuongThayDoi READONLY
AS
BEGIN
	--Kiểm tra mã tài khoản có tồn tại
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaTK = @MaTK)
		THROW 50000, N'Tài khoản không tồn tại', 1

	--Khai báo cursor
	DECLARE cur CURSOR FOR
	SELECT MaBP, TenBP, Luong
	FROM @LuongThayDoi

	--Khai báo các biến dùng để duyệt
	DECLARE @MaBP VARCHAR(10), @TenBP NVARCHAR(50), @Luong INT

	--Duyệt qua cursor
	OPEN cur
	FETCH NEXT FROM cur INTO @MaBP, @TenBP, @Luong

	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE BoPhan
		SET Luong = @Luong, TenBP = @TenBP
		WHERE MaBP = @MaBP
		FETCH NEXT FROM cur INTO @MaBP, @TenBP, @Luong
	END

	CLOSE cur
	DEALLOCATe cur
END
GO


--===========================================Thêm món mới===========================================
CREATE OR ALTER PROCEDURE USP_ThemMonAnMoi
    @TenMA NVARCHAR(50),
    @GiaHienTai INT,
    @MaMuc VARCHAR(10),
    @NewMaMA VARCHAR(10) OUTPUT -- Tham số OUTPUT
AS
BEGIN
    -- Kiểm tra tên món ăn đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM dbo.MonAn WHERE TenMA = @TenMA)
    BEGIN
        ;THROW 50000, N'Tên món ăn đã tồn tại!', 1;
    END

    -- Tạo mã món ăn tự động
    DECLARE @MaxMA INT;
    SELECT @MaxMA = ISNULL(MAX(CAST(SUBSTRING(MaMA, 3, LEN(MaMA) - 2) AS INT)), 0)
    FROM dbo.MonAn;

    SET @NewMaMA = 'MA' + FORMAT(@MaxMA + 1, '000');

    -- Thêm dữ liệu vào bảng MonAn
    INSERT INTO dbo.MonAn (MaMA, TenMA, GiaHienTai, TinhTrangMonAn, MaMuc)
    VALUES (@NewMaMA, @TenMA, @GiaHienTai, N'Có', @MaMuc);

END
GO


--===========================================Update Menu===========================================
CREATE OR ALTER PROCEDURE USP_UpdateMenu
    @AreaName NVARCHAR(100) -- Khu vực (hoặc 'Tất cả')
AS
BEGIN
    -- Biến tạm để lưu giá trị từ con trỏ
    DECLARE @OriginalTenMA NVARCHAR(100),
            @NewTenMA NVARCHAR(100),
            @GiaHienTai DECIMAL(18, 2),
            @TinhTrang NVARCHAR(50),
            @TenMuc NVARCHAR(100),
            @MaMA VARCHAR(10); -- Mã món ăn

    -- Kiểm tra bảng tạm tồn tại
    IF OBJECT_ID('tempdb..#TempMenu') IS NULL
    BEGIN
        THROW 51000, 'Bảng tạm #TempMenu không tồn tại!', 1;
    END;

    -- Khai báo con trỏ
    DECLARE menu_cursor CURSOR FOR
    SELECT OriginalTenMA, NewTenMA, GiaHienTai, TinhTrangMonAn, TenMuc
    FROM #TempMenu;

    -- Mở con trỏ
    OPEN menu_cursor;

    -- Lấy dòng đầu tiên từ con trỏ
    FETCH NEXT FROM menu_cursor INTO @OriginalTenMA, @NewTenMA, @GiaHienTai, @TinhTrang, @TenMuc;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Kiểm tra giá trị NULL trong các biến
        IF @OriginalTenMA IS NULL OR @NewTenMA IS NULL OR @GiaHienTai IS NULL OR @TinhTrang IS NULL OR @TenMuc IS NULL
        BEGIN
            FETCH NEXT FROM menu_cursor INTO @OriginalTenMA, @NewTenMA, @GiaHienTai, @TinhTrang, @TenMuc;
            CONTINUE; -- Bỏ qua dòng này nếu có giá trị NULL
        END;

        -- Lấy MaMA của món bị sửa từ MonAn
        SELECT @MaMA = MaMA FROM MonAn WHERE TenMA = @OriginalTenMA;

        -- Nếu không tìm thấy MaMA, bỏ qua dòng này
        IF @MaMA IS NOT NULL
        BEGIN
            -- Kiểm tra nếu tên món ăn mới đã tồn tại
            IF (@OriginalTenMA <> @NewTenMA)
            BEGIN
                IF EXISTS (SELECT 1 FROM MonAn WHERE TenMA = @NewTenMA)
                BEGIN
                    FETCH NEXT FROM menu_cursor INTO @OriginalTenMA, @NewTenMA, @GiaHienTai, @TinhTrang, @TenMuc;
                    CONTINUE; -- Bỏ qua dòng này nếu tên mới đã tồn tại
                END;
            END;

            -- Nếu khu vực là "Tất cả", cập nhật toàn bộ
            IF @AreaName = N'Tất cả'
            BEGIN
                DECLARE @MaMuc VARCHAR(10), @TinhTrangMonAn NVARCHAR(5);
				--Lấy Mã mục từ tên mục
                SELECT @MaMuc = MaMuc FROM Muc WHERE TenMuc = @TenMuc;
				--Lấy tình trạng món ăn lúc đầu
				SELECT @TinhTrangMonAn =TinhTrangMonAn
				FROM MonAn
				WHERE TenMA=@OriginalTenMA
                -- Cập nhật bảng MonAn
                UPDATE MonAn
                SET TenMA = @NewTenMA,
                    GiaHienTai = @GiaHienTai,
                    TinhTrangMonAn = @TinhTrang,
                    MaMuc = @MaMuc
                WHERE MaMA = @MaMA;

                -- Cập nhật bảng ThucDon
				
                --Nếu tình trạng là Không và trước khi sửa là có thì xóa món đó ra khỏi tất cả chi nhánh có bán món đó
					IF (@TinhTrang=N'Không' AND @TinhTrangMonAn=N'Có' )
					BEGIN
						DELETE FROM ThucDon
						WHERE MaMA = @MaMA
					END;
            END
			ELSE 
				BEGIN
					DECLARE @TinhTrangTruocKhiSua NVARCHAR(5);
					--Nếu tồn tại 1 món trong thực đơn của khu vực thì set tình trạng trước khi sửa là có
					IF EXISTS (SELECT 1
								FROM ThucDon TD
								JOIN ChiNhanh CN ON TD.MaCN = CN.MaCN
								JOIN KhuVuc KV ON CN.MaKV = KV.MaKV
								WHERE TD.MaMA = @MaMA AND KV.TenKV = @AreaName)
					BEGIN
						SET @TinhTrangTruocKhiSua = N'Có';
					END
					ELSE
					BEGIN
						SET @TinhTrangTruocKhiSua = N'Không';
					END;

					--Nếu tình trạng là Không và trước khi sửa là có thì xóa món đó ra khỏi tất cả chi nhánh trong khu vực
					IF (@TinhTrang=N'Không' AND @TinhTrangTruocKhiSua=N'Có')
					BEGIN
						DELETE FROM ThucDon
						WHERE MaMA = @MaMA AND MaCN IN (
							SELECT CN.MaCN
							FROM ChiNhanh CN
							JOIN KhuVuc KV ON CN.MaKV = KV.MaKV
							WHERE KV.TenKV = @AreaName
						);
					END;
					--Nếu tình trạng là có và trước khi sửa là không thì thêm món đó vào tất cả chi nhánh trong khu vực
					IF (@TinhTrang=N'Có' AND @TinhTrangTruocKhiSua=N'Không')
					BEGIN
						INSERT INTO ThucDon(MaCN,MaMA,TinhTrangPhucVu,TinhTrangGiaoHang)
						SELECT CN.MaCN,@MaMA,N'Có',N'Có'
						FROM ChiNhanh CN
						JOIN KhuVuc KV ON CN.MaKV = KV.MaKV
						WHERE KV.TenKV = @AreaName
					END;

				END
        END;

        -- Lấy dòng tiếp theo từ con trỏ
        FETCH NEXT FROM menu_cursor INTO @OriginalTenMA, @NewTenMA, @GiaHienTai, @TinhTrang, @TenMuc;
    END;

    -- Đóng con trỏ
    CLOSE menu_cursor;
    DEALLOCATE menu_cursor;
END;
GO


--===========================================Lấy ra mức giảm của khách hàng từ MaTK của khách hàng===========================================
CREATE OR ALTER PROCEDURE USP_LayMucGiamCuaThe
	@MaTK VARCHAR(10),
	@MucGiam INT OUTPUT
AS
BEGIN
	--Kiểm tra mã tài khoản có tồn tại
	IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaTK = @MaTK)
		THROW 50000, N'Tài khoản không tồn tại hoặc không phải là khách hàng', 1

	SET @MucGiam = 0

	SELECT @MucGiam = ISNULL(LT.GiamGia, @MucGiam)
	FROM KhachHang KH
	LEFT JOIN The T ON KH.MaTK = T.TkSoHuu
	LEFT JOIN LoaiThe LT ON T.TenLoaiThe = LT.TenLoaiThe
	WHERE t.TinhTrang = N'Mở' AND kh.MaTK = @MaTK
END
GO