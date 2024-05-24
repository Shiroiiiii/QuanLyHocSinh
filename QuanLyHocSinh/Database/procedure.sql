use qlhs1
GO
create procedure themhocsinh
	@MaHocSinh varchar(10),
	@MaLop varchar(10),
	@HoTen varchar(50),
    	@GioiTinh bit,
	@NgaySinh date,
	@DiaChi varchar(255),
	@Email varchar(100)
AS 
BEGIN 
	INSERT INTO HOCSINH(MaHocSinh,MaLop,HoTen,GioiTinh,NgaySinh,DiaChi,Email)
	VALUES (@MaHocSinh,@MaLop,@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@Email)
END
GO
CREATE PROCEDURE themNamHoc
    @MaNamHoc VARCHAR(4),
    @TenNamHoc VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NAMHOC WHERE MaNamHoc = @MaNamHoc)
    BEGIN
        PRINT 'Mã năm học đã tồn tại.';
        RETURN;
    END

    INSERT INTO NAMHOC (MaNamHoc, TenNamHoc)
    VALUES (@MaNamHoc, @TenNamHoc);

    PRINT 'Thêm dữ liệu vào bảng NAMHOC thành công.';
END
GO
CREATE PROCEDURE xoaNamHoc
    @MaNamHoc VARCHAR(4)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM NAMHOC WHERE MaNamHoc = @MaNamHoc)
    BEGIN
        PRINT 'Mã năm học không tồn tại.';
        RETURN;
    END

    DELETE FROM NAMHOC WHERE MaNamHoc = @MaNamHoc;

    PRINT 'Xóa dữ liệu từ bảng NAMHOC thành công.';

END
GO
CREATE PROCEDURE capnhatNamHoc
    @MaNamHoc VARCHAR(4),
    @TenNamHoc VARCHAR(50)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM NAMHOC WHERE MaNamHoc = @MaNamHoc)
    BEGIN
        PRINT 'Mã năm học không tồn tại.';
        RETURN;
    END

    UPDATE NAMHOC
    SET TenNamHoc = @TenNamHoc
    WHERE MaNamHoc = @MaNamHoc;

    PRINT 'Cập nhật dữ liệu trong bảng NAMHOC thành công.';

END
GO
CREATE PROCEDURE themlop
    @MaLop VARCHAR(10),
    @TenLop VARCHAR(50),
    @SiSo INT,
    @MaKhoiLop VARCHAR(10),
    @MaNamHoc VARCHAR(4)
AS
BEGIN
    INSERT INTO LOP (MaLop, TenLop, SiSo, MaKhoiLop, MaNamHoc)
    VALUES (@MaLop, @TenLop, @SiSo, @MaKhoiLop, @MaNamHoc);
END
GO
DROP PROCEDURE IF EXISTS xoahocsinh
GO
CREATE PROCEDURE xoahocsinh
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    -- Bắt đầu một giao dịch
    BEGIN TRANSACTION;

    -- Biến lưu mã lớp của học sinh để cập nhật sĩ số sau khi xóa
    DECLARE @MaLop VARCHAR(10);

    -- Kiểm tra xem học sinh tồn tại trong bảng HOCSINH
    IF NOT EXISTS (SELECT 1 FROM HOCSINH WHERE MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Học sinh không tồn tại.';
        RETURN;
    END

    -- Lấy mã lớp của học sinh
    SELECT @MaLop = MaLop FROM HOCSINH WHERE MaHocSinh = @MaHocSinh;

    -- Xóa học sinh khỏi bảng HOCSINH
    DELETE FROM HOCSINH WHERE MaHocSinh = @MaHocSinh;

    -- Cập nhật sĩ số của lớp
    UPDATE LOP
    SET SiSo = SiSo - 1
    WHERE MaLop = @MaLop;

    -- Kiểm tra lỗi và hoàn thành giao dịch
    IF @@ERROR = 0
    BEGIN
        COMMIT TRANSACTION;
        PRINT 'Xóa học sinh thành công.';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Lỗi xảy ra khi xóa học sinh.';
    END
END
GO
CREATE PROCEDURE capnhathocsinh
    @MaHocSinh VARCHAR(10),
    @MaLop VARCHAR(10),
    @HoTen VARCHAR(50),
    @GioiTinh BIT,
    @NgaySinh DATE,
    @DiaChi VARCHAR(255),
    @Email VARCHAR(100)
AS
BEGIN
    -- Bắt đầu một giao dịch
    BEGIN TRANSACTION;

    -- Kiểm tra xem học sinh tồn tại trong bảng HOCSINH
    IF NOT EXISTS (SELECT 1 FROM HOCSINH WHERE MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Học sinh không tồn tại.';
        RETURN;
    END

    -- Cập nhật thông tin học sinh
    UPDATE HOCSINH
    SET 
        MaLop = @MaLop,
        HoTen = @HoTen,
        GioiTinh = @GioiTinh,
        NgaySinh = @NgaySinh,
        DiaChi = @DiaChi,
        Email = @Email
    WHERE 
        MaHocSinh = @MaHocSinh;

    -- Kiểm tra lỗi và hoàn thành giao dịch
    IF @@ERROR = 0
    BEGIN
        COMMIT TRANSACTION;
        PRINT 'Cập nhật thông tin học sinh thành công.';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Lỗi xảy ra khi cập nhật thông tin học sinh.';
    END
END
	GO
CREATE PROCEDURE capnhatlop
    @MaLop VARCHAR(10),
    @TenLop VARCHAR(50),
    @SiSo INT,
    @MaKhoiLop VARCHAR(10),
    @MaNamHoc VARCHAR(4)
AS
BEGIN
    BEGIN TRANSACTION;

    -- Cập nhật thông tin lớp trong bảng LOP
    UPDATE LOP
    SET 
        TenLop = @TenLop,
        SiSo = @SiSo,
        MaKhoiLop = @MaKhoiLop,
        MaNamHoc = @MaNamHoc
    WHERE 
        MaLop = @MaLop;

    IF @@ERROR = 0
    BEGIN
        COMMIT TRANSACTION;
        PRINT 'Cập nhật thông tin lớp thành công.';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Lỗi xảy ra khi cập nhật thông tin lớp.';
    END
END
GO
CREATE PROCEDURE xoalop
    @MaLop VARCHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    -- Xóa lớp từ bảng LOP
    DELETE FROM LOP WHERE MaLop = @MaLop;

    IF @@ERROR = 0
    BEGIN
        COMMIT TRANSACTION;
        PRINT 'Xóa lớp thành công.';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Lỗi xảy ra khi xóa lớp.';
    END
END
GO
CREATE PROCEDURE themBangDiemMon
    @MaBangDiem VARCHAR(10),
    @MaLop VARCHAR(10),
    @MaHocKi VARCHAR(10),
    @MaMonHoc VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem mã lớp tồn tại trong bảng LOP
    IF NOT EXISTS (SELECT 1 FROM LOP WHERE MaLop = @MaLop)
    BEGIN
        PRINT 'Mã lớp không tồn tại.';
        RETURN;
    END

    -- Kiểm tra xem mã học kỳ tồn tại trong bảng HOCKI
    IF NOT EXISTS (SELECT 1 FROM HOCKI WHERE MaHocKi = @MaHocKi)
    BEGIN
        PRINT 'Mã học kỳ không tồn tại.';
        RETURN;
    END

    -- Kiểm tra xem mã môn học tồn tại trong bảng MONHOC
    IF NOT EXISTS (SELECT 1 FROM MONHOC WHERE MaMonHoc = @MaMonHoc)
    BEGIN
        PRINT 'Mã môn học không tồn tại.';
        RETURN;
    END

    -- Thêm dữ liệu vào bảng BANGDIEMMON
    INSERT INTO BANGDIEMMON (MaBangDiem, MaLop, MaHocKi, MaMonHoc)
    VALUES (@MaBangDiem, @MaLop, @MaHocKi, @MaMonHoc);

    PRINT 'Thêm dữ liệu vào bảng BANGDIEMMON thành công.';
END
go
CREATE PROCEDURE xoaBangDiemMon
    @MaBangDiem VARCHAR(10)
AS
BEGIN
    -- Xóa dữ liệu từ bảng BANGDIEMMON dựa trên MaBangDiem
    DELETE FROM BANGDIEMMON WHERE MaBangDiem = @MaBangDiem;

    PRINT 'Xóa dữ liệu từ bảng BANGDIEMMON thành công.';
END
GO
CREATE PROCEDURE capnhatBangDiemMon
    @MaBangDiem VARCHAR(10),
    @MaLop VARCHAR(10),
    @MaHocKi VARCHAR(10),
    @MaMonHoc VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem các khóa ngoại tồn tại trong bảng tương ứng
    IF NOT EXISTS (SELECT 1 FROM LOP WHERE MaLop = @MaLop)
    BEGIN
        PRINT 'Mã lớp không tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HOCKI WHERE MaHocKi = @MaHocKi)
    BEGIN
        PRINT 'Mã học kỳ không tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM MONHOC WHERE MaMonHoc = @MaMonHoc)
    BEGIN
        PRINT 'Mã môn học không tồn tại.';
        RETURN;
    END

    -- Cập nhật dữ liệu trong bảng BANGDIEMMON
    UPDATE BANGDIEMMON
    SET 
        MaLop = @MaLop,
        MaHocKi = @MaHocKi,
        MaMonHoc = @MaMonHoc
    WHERE 
        MaBangDiem = @MaBangDiem;

    PRINT 'Cập nhật dữ liệu trong bảng BANGDIEMMON thành công.';
END
