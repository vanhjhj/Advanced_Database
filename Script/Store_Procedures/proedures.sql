-- Đăng Nhập
GO
CREATE PROCEDURE USP_DangNhap
    @TenTK NVARCHAR(50),
    @MatKhau NVARCHAR(50),
    @MaTK NVARCHAR(10) OUTPUT,    -- Thêm MaTK làm tham số đầu ra
    @LoaiTK NVARCHAR(50) OUTPUT,
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
CREATE PROCEDURE USP_DangKy
    @TenTK NVARCHAR(50),
    @MatKhau NVARCHAR(50),
    @HoTen NVARCHAR(50),
    @SDT NVARCHAR(10),
    @GioiTinh NVARCHAR(3),
    @CCCD NVARCHAR(12),
    @Email NVARCHAR(50),
    @MaTK NVARCHAR(10) OUTPUT -- Biến trả về MaTK
AS
BEGIN
    -- Tạo MaTK mới
    DECLARE @MaxMaTK INT, @NewMaTK NVARCHAR(10);
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
