USE QUAN_LY_NHA_HANG
-- Đăng Nhập
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
        -- Lấy MaTK, LoaiTK và TenBP nếu tài khoản tồn tại
        SELECT 
            @MaTK = TK.MaTK,
            @LoaiTK = TK.LoaiTK,
            @TenBP = BP.TenBP
        FROM TaiKhoan TK
        LEFT JOIN NhanVien NV ON TK.MaTK = NV.MaTK
        LEFT JOIN BoPhan BP ON NV.MaBP = BP.MaBP
        WHERE TK.TenTK = @TenTK AND TK.MatKhau = @MatKhau;
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

-- Đăng Ký
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

    SET @NewMaTK = 'KH' + FORMAT(@MaxMaTK + 1, '00000');

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

-- Xem thông tin khách hàng
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

-- Cập Nhật thông tin khách hàng
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



-- Lấy thông tin chi nhánh
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

-- Lấy thực đơn của chi nhánh
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

-- Lập Phiếu Đặt Bàn Trực Tuyến
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

    SET @MaPhieu = 'PDOL' + FORMAT(@MaxMaPhieu + 1, '0000');

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

-- Lập Phiếu Giao Hàng Tận Nơi
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

    SET @MaPhieu = 'PDGH' + FORMAT(@MaxMaPhieu + 1, '0000');

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


--Đăng ký thẻ thành viên cho khách hàng
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

	SET @NewMaThe = 'THE' + FORMAT(@MaxMaThe + 1, '00000')

	-- Insert vào bảng The
	INSERT INTO The (MaThe, NgayLap, NgayBDChuKy, TongDiem, TongDiemDuyTri, TinhTrang, TenLoaiThe, TkSoHuu, TkLap)
	VALUES (@NewMaThe, GETDATE(), GETDATE(), 0, 0, N'Mở', 'Membership', @MaTKKH, @TkLap)

	-- Trả về mã thẻ
	SET @MaThe = @NewMaThe
END


--Cấp lại thẻ thành viên cho khách hàng
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

	SET @NewMaThe = 'THE' + FORMAT(@MaxMaThe + 1, '00000')

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


--Cập nhật lại hạng thẻ cho khách hàng
CREATE OR ALTER PROCEDURE USP_CapNhatHangTheThanhVien
AS
BEGIN
	
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


CREATE TYPE dbo.ThucDonThayDoi AS TABLE
(
	MaMA VARCHAR(10),
	TinhTrangPhucVu VARCHAR(10),
	TinhTrangGiaoHang VARCHAR(10)
)

--Quản lí chi nhánh cập nhật thực đơn (trạng thái phục vụ và trạng thái giao hàng)

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

		FETCH NEXT FROM cur INTO @MaMA, @TinhTrangPhucVu, @TinhTrangGiaoHang
	END

	CLOSE cur
	DEALLOCATe cur
END
GO

-- Quản Lý Thống Kê
GO
CREATE OR ALTER PROCEDURE USP_QuanLyThongKe
    @MaTK VARCHAR(10),
    @NgayBD DATETIME,
    @NgayKT DATETIME,
    @TongSoLuongBan INT OUTPUT, 
    @TongDoanhThu BIGINT OUTPUT
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
        IF @MaCN IS NULL
        BEGIN
            ;THROW 60001, N'Nhân viên không thuộc chi nhánh nào.', 1;
        END

        -- Kiểm tra điều kiện ngày
        IF @NgayKT < @NgayBD
        BEGIN
            ;THROW 60002, N'Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.', 1;
        END

        -- Thống kê theo món ăn
        SELECT MA.TenMA AS DishName, 
               SUM(ISNULL(CTPD.SoLuong, 0)) AS Amount,
               SUM(ISNULL(CAST(CTPD.ThanhTien AS BIGINT), 0)) AS Revenue
        FROM MonAn MA
        JOIN CTPD ON MA.MaMA = CTPD.MaMA
        JOIN PhieuDat PD ON PD.MaPhieu = CTPD.MaPhieu
        JOIN HoaDon HD ON HD.MaPhieu = CTPD.MaPhieu
        WHERE PD.MaCN = @MaCN 
        AND HD.NgayLapHD BETWEEN @NgayBD AND @NgayKT 
        GROUP BY MA.MaMA, MA.TenMA
        ORDER BY Revenue DESC;

        -- Thống kê tổng
        SELECT @TongSoLuongBan = SUM(ISNULL(CTPD.SoLuong, 0)),
               @TongDoanhThu = CAST(SUM(ISNULL(CAST(CTPD.ThanhTien AS BIGINT), 0)) AS BIGINT)
        FROM CTPD
        JOIN PhieuDat PD ON PD.MaPhieu = CTPD.MaPhieu
        JOIN HoaDon HD ON HD.MaPhieu = CTPD.MaPhieu
        WHERE PD.MaCN = @MaCN 
          AND HD.NgayLapHD BETWEEN @NgayBD AND @NgayKT;

    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO