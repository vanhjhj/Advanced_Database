-- Đăng Nhập
GO
CREATE PROCEDURE USP_DangNhap
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
CREATE PROCEDURE USP_DangKy
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
    -- Tạo MaTK mới
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
END;
GO

-- Xem thông tin khách hàng
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE USP_XemThongTinKhachHang
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
    AND TH.TinhTrang = N'Mở' OR TH.TinhTrang IS NULL; -- Chỉ lấy thẻ có trạng thái 'Mở'
END;
GO

-- Cập Nhật thông tin khách hàng
GO
CREATE PROCEDURE USP_CapNhatThongTinKhachHang
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





