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
    WHERE MaBangDiem = @MaBangDiem;
end
go
CREATE PROCEDURE themCTDiemLoaiHinhKT
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10),
    @MaLoaiHinhKT VARCHAR(10),
    @Lan INT,
    @Diem DECIMAL(4,2)
AS
BEGIN
    -- Kiểm tra xem các khóa ngoại tồn tại trong bảng tương ứng
    IF NOT EXISTS (SELECT 1 FROM BANGDIEMMON WHERE MaBangDiem = @MaBangDiem)
    BEGIN
        PRINT 'Mã bảng điểm không tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HOCSINH WHERE MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Mã học sinh không tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM LOAIHINHKIEMTRA WHERE MaLoaiHinhKT = @MaLoaiHinhKT)
    BEGIN
        PRINT 'Mã loại hình kiểm tra không tồn tại.';
        RETURN;
    END

    -- Thêm dữ liệu vào bảng CT_DIEMLOAIHINHKT
    INSERT INTO CT_DIEMLOAIHINHKT (MaBangDiem, MaHocSinh, MaLoaiHinhKT, Lan, Diem)
    VALUES (@MaBangDiem, @MaHocSinh, @MaLoaiHinhKT, @Lan, @Diem);

    PRINT 'Thêm dữ liệu vào bảng CT_DIEMLOAIHINHKT thành công.';

    DECLARE @TongDiem DECIMAL(4,2);
    DECLARE @TongHeSo INT;

    -- Tính tổng điểm và tổng hệ số từ bảng CT_DIEMLOAIHINHKT
    SELECT @TongDiem = SUM(Diem * HeSo), @TongHeSo = SUM(HeSo)
    FROM CT_DIEMLOAIHINHKT ctk
    JOIN LOAIHINHKIEMTRA lhkt ON ctk.MaLoaiHinhKT = lhkt.MaLoaiHinhKT
    WHERE ctk.MaBangDiem = @MaBangDiem AND ctk.MaHocSinh = @MaHocSinh;

    -- Kiểm tra nếu không có dữ liệu trong bảng CT_DIEMLOAIHINHKT
    IF @TongDiem IS NULL OR @TongHeSo IS NULL OR @TongHeSo = 0
    BEGIN
        PRINT 'Không có dữ liệu điểm loại hình kiểm tra cho bảng điểm này hoặc tổng hệ số bằng 0.';
        RETURN;
    END

    -- Tính điểm trung bình
    DECLARE @DTBMon DECIMAL(4,2);
    SET @DTBMon = @TongDiem / @TongHeSo;

    -- Cập nhật dữ liệu trong bảng CT_BANGDIEMMON
    EXEC capnhatCTBangDiemMon @MaBangDiem, @MaHocSinh, @DTBMon;

    PRINT 'Cập nhật dữ liệu trong bảng CT_BANGDIEMMON thành công.';
    EXEC tinhLaiDTBMon @MaBangDiem, @MaHocSinh;
END
GO
CREATE PROCEDURE tinhLaiDTBMon
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    DECLARE @TongDiem DECIMAL(4,2);
    DECLARE @TongHeSo INT;

    -- Tính tổng điểm và tổng hệ số từ bảng CT_DIEMLOAIHINHKT
    SELECT @TongDiem = SUM(Diem * HeSo), @TongHeSo = SUM(HeSo)
    FROM CT_DIEMLOAIHINHKT ctk
    JOIN LOAIHINHKIEMTRA lhkt ON ctk.MaLoaiHinhKT = lhkt.MaLoaiHinhKT
    WHERE ctk.MaBangDiem = @MaBangDiem AND ctk.MaHocSinh = @MaHocSinh;

    -- Kiểm tra nếu không có dữ liệu trong bảng CT_DIEMLOAIHINHKT
    IF @TongDiem IS NULL OR @TongHeSo IS NULL OR @TongHeSo = 0
    BEGIN
        PRINT 'Không có dữ liệu điểm loại hình kiểm tra cho bảng điểm này hoặc tổng hệ số bằng 0.';
        RETURN;
    END

    -- Tính điểm trung bình
    DECLARE @DTBMon DECIMAL(4,2);
    SET @DTBMon = @TongDiem / @TongHeSo;

    -- Cập nhật dữ liệu trong bảng CT_BANGDIEMMON
    EXEC capnhatCTBangDiemMon @MaBangDiem, @MaHocSinh, @DTBMon;

    PRINT 'Tính lại và cập nhật dữ liệu DTBMon trong bảng CT_BANGDIEMMON thành công.';
END
GO
CREATE PROCEDURE capnhatCTDiemLoaiHinhKT
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10),
    @MaLoaiHinhKT VARCHAR(10),
    @Lan INT,
    @Diem DECIMAL(4,2)
AS
BEGIN
    -- Kiểm tra xem bản ghi có tồn tại hay không
    IF NOT EXISTS (SELECT 1 FROM CT_DIEMLOAIHINHKT WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh AND MaLoaiHinhKT = @MaLoaiHinhKT AND Lan = @Lan)
    BEGIN
        PRINT 'Bản ghi không tồn tại.';
        RETURN;
    END

    -- Cập nhật dữ liệu trong bảng CT_DIEMLOAIHINHKT
    UPDATE CT_DIEMLOAIHINHKT
    SET Diem = @Diem
    WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh AND MaLoaiHinhKT = @MaLoaiHinhKT AND Lan = @Lan;

    PRINT 'Cập nhật dữ liệu trong bảng CT_DIEMLOAIHINHKT thành công.';

    -- Tính lại điểm trung bình môn từ bảng CT_DIEMLOAIHINHKT và cập nhật vào CT_BANGDIEMMON
    EXEC tinhLaiDTBMon @MaBangDiem, @MaHocSinh;
END
go
CREATE PROCEDURE xoaCTDiemLoaiHinhKT
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10),
    @MaLoaiHinhKT VARCHAR(10),
    @Lan INT
AS
BEGIN
    -- Xóa dữ liệu từ bảng CT_DIEMLOAIHINHKT dựa trên khóa chính
    DELETE FROM CT_DIEMLOAIHINHKT 
    WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh AND MaLoaiHinhKT = @MaLoaiHinhKT AND Lan = @Lan;

    PRINT 'Xóa dữ liệu từ bảng CT_DIEMLOAIHINHKT thành công.';

    -- Tính lại DTBMon sau khi xóa dữ liệu
    EXEC tinhLaiDTBMon @MaBangDiem, @MaHocSinh;
END
go
CREATE PROCEDURE themCTBangDiemMon
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem mã bảng điểm tồn tại trong bảng BANGDIEMMON
    IF NOT EXISTS (SELECT 1 FROM BANGDIEMMON WHERE MaBangDiem = @MaBangDiem)
    BEGIN
        PRINT 'Mã bảng điểm không tồn tại.';
        RETURN;
    END

    -- Kiểm tra xem mã học sinh tồn tại trong bảng HOCSINH
    IF NOT EXISTS (SELECT 1 FROM HOCSINH WHERE MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Mã học sinh không tồn tại.';
        RETURN;
    END

    DECLARE @TongDiem DECIMAL(4,2);
    DECLARE @TongHeSo INT;

    -- Tính tổng điểm và tổng hệ số từ bảng CT_DIEMLOAIHINHKT
    SELECT @TongDiem = SUM(Diem * HeSo), @TongHeSo = SUM(HeSo)
    FROM CT_DIEMLOAIHINHKT ctk
    JOIN LOAIHINHKIEMTRA lhkt ON ctk.MaLoaiHinhKT = lhkt.MaLoaiHinhKT
    WHERE ctk.MaBangDiem = @MaBangDiem AND ctk.MaHocSinh = @MaHocSinh;

    -- Kiểm tra nếu không có dữ liệu trong bảng CT_DIEMLOAIHINHKT
    IF @TongDiem IS NULL OR @TongHeSo IS NULL
    BEGIN
        PRINT 'Không có dữ liệu điểm loại hình kiểm tra cho bảng điểm này.';
        RETURN;
    END

    -- Tính điểm trung bình
    DECLARE @DTBMon DECIMAL(4,2);
    SET @DTBMon = @TongDiem / @TongHeSo;

    -- Thêm dữ liệu vào bảng CT_BANGDIEMMON
    INSERT INTO CT_BANGDIEMMON (MaBangDiem, MaHocSinh, DTBMon)
    VALUES (@MaBangDiem, @MaHocSinh, @DTBMon);

    PRINT 'Thêm dữ liệu vào bảng CT_BANGDIEMMON thành công.';
END
go
CREATE PROCEDURE capnhatCTBangDiemMon
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10),
    @DTBMon DECIMAL(4,2)
AS
BEGIN
    -- Kiểm tra xem bản ghi tồn tại trong bảng CT_BANGDIEMMON
    IF NOT EXISTS (SELECT 1 FROM CT_BANGDIEMMON WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Bản ghi không tồn tại.';
        RETURN;
    END

    -- Cập nhật dữ liệu trong bảng CT_BANGDIEMMON
    UPDATE CT_BANGDIEMMON
    SET DTBMon = @DTBMon
    WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh;

    DECLARE @MaChiTietDSLop VARCHAR(10);

    SELECT @MaChiTietDSLop = ct.MaChiTietDSLop
    FROM CHITIETDSLOP ct
    WHERE ct.MaHocSinh = @MaHocSinh;

    -- Gọi thủ tục cập nhật điểm trung bình học kỳ
    IF @MaChiTietDSLop IS NOT NULL
    BEGIN
        EXEC capnhatDTBHocKi @MaChiTietDSLop, @MaHocSinh;
    END

    PRINT 'Cập nhật điểm trung bình môn và điểm trung bình học kỳ thành công.';
END
GO
CREATE PROCEDURE xoaCTBangDiemMon
    @MaBangDiem VARCHAR(10),
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem bản ghi tồn tại trong bảng CT_BANGDIEMMON
    IF NOT EXISTS (SELECT 1 FROM CT_BANGDIEMMON WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Bản ghi không tồn tại.';
        RETURN;
    END

    -- Xóa dữ liệu từ bảng CT_BANGDIEMMON
    DELETE FROM CT_BANGDIEMMON
    WHERE MaBangDiem = @MaBangDiem AND MaHocSinh = @MaHocSinh;

    PRINT 'Xóa dữ liệu từ bảng CT_BANGDIEMMON thành công.';
END
go
CREATE PROCEDURE capnhatDTBHocKi
    @MaChiTietDSLop VARCHAR(10),
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    DECLARE @TongDiem DECIMAL(10,2); -- Sử dụng DECIMAL(10,2) để tăng độ chính xác
    DECLARE @TongHeSo INT;
    DECLARE @DTBHocKi DECIMAL(10,2);

    -- Tính lại điểm trung bình học kỳ từ bảng CT_DIEMLOAIHINHKT
    SELECT @TongDiem = SUM(ctk.Diem * lhkt.HeSo), 
           @TongHeSo = SUM(lhkt.HeSo)
    FROM CT_DIEMLOAIHINHKT ctk
    JOIN LOAIHINHKIEMTRA lhkt ON ctk.MaLoaiHinhKT = lhkt.MaLoaiHinhKT
    WHERE ctk.MaHocSinh = @MaHocSinh;

    -- Kiểm tra nếu không có dữ liệu trong bảng CT_DIEMLOAIHINHKT
    IF @TongDiem IS NULL OR @TongHeSo IS NULL OR @TongHeSo = 0
    BEGIN
        PRINT 'Không có dữ liệu điểm loại hình kiểm tra cho học sinh này hoặc tổng hệ số bằng 0.';
        RETURN;
    END

    -- Tính điểm trung bình học kỳ
    SET @DTBHocKi = @TongDiem / @TongHeSo;

    -- Cập nhật điểm trung bình học kỳ vào bảng ChiTietDSLop
    UPDATE CHITIETDSLOP
    SET DTBHocKi = @DTBHocKi
    WHERE MaChiTietDSLop = @MaChiTietDSLop AND MaHocSinh = @MaHocSinh;

    PRINT 'Cập nhật điểm trung bình học kỳ thành công.';
END
GO
CREATE TRIGGER tr_capnhatDTBHocKi
ON CT_DIEMLOAIHINHKT
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaHocSinh VARCHAR(10);
    DECLARE @MaBangDiem VARCHAR(10);

    -- Lấy danh sách các học sinh bị ảnh hưởng bởi sự thay đổi
    SELECT DISTINCT MaHocSinh, MaBangDiem INTO #HocSinhAffected FROM inserted;
    INSERT INTO #HocSinhAffected SELECT DISTINCT MaHocSinh, MaBangDiem FROM deleted;

    -- Duyệt qua từng học sinh và cập nhật điểm trung bình môn và học kỳ
    DECLARE @CursorHocSinh CURSOR;
    SET @CursorHocSinh = CURSOR FOR SELECT MaHocSinh, MaBangDiem FROM #HocSinhAffected;
    OPEN @CursorHocSinh;

    FETCH NEXT FROM @CursorHocSinh INTO @MaHocSinh, @MaBangDiem;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Gọi thủ tục để tính lại điểm trung bình môn và cập nhật điểm trung bình học kỳ
        EXEC tinhLaiDTBMon @MaBangDiem, @MaHocSinh;
        
        FETCH NEXT FROM @CursorHocSinh INTO @MaHocSinh, @MaBangDiem;
    END

    CLOSE @CursorHocSinh;
    DEALLOCATE @CursorHocSinh;

    DROP TABLE #HocSinhAffected;
END
GO
CREATE PROCEDURE themCHITIETDSLOP
    @MaChiTietDSLop VARCHAR(10),
    @MaLop VARCHAR(10),
    @MaHocKi VARCHAR(10),
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem các khóa ngoại có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM LOP WHERE MaLop = @MaLop)
    BEGIN
        PRINT 'Mã lớp không tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HOCKI WHERE MaHocKi = @MaHocKi)
    BEGIN
        PRINT 'Mã học kì không tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM HOCSINH WHERE MaHocSinh = @MaHocSinh)
    BEGIN
        PRINT 'Mã học sinh không tồn tại.';
        RETURN;
    END

    -- Thêm dữ liệu vào bảng CHITIETDSLOP
    INSERT INTO CHITIETDSLOP (MaChiTietDSLop, MaLop, MaHocKi, MaHocSinh, DTBHocKi)
    VALUES (@MaChiTietDSLop, @MaLop, @MaHocKi, @MaHocSinh, 0);

    -- Tính lại điểm trung bình học kỳ
    EXEC capnhatDTBHocKi @MaChiTietDSLop, @MaHocSinh;
END
GO
CREATE PROCEDURE capnhatCHITIETDSLOP
    @MaChiTietDSLop VARCHAR(10),
    @MaLop VARCHAR(10),
    @MaHocKi VARCHAR(10),
    @MaHocSinh VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem bản ghi có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM CHITIETDSLOP WHERE MaChiTietDSLop = @MaChiTietDSLop)
    BEGIN
        PRINT 'Bản ghi không tồn tại.';
        RETURN;
    END

    -- Cập nhật dữ liệu trong bảng CHITIETDSLOP
    UPDATE CHITIETDSLOP
    SET MaLop = @MaLop, MaHocKi = @MaHocKi, MaHocSinh = @MaHocSinh
    WHERE MaChiTietDSLop = @MaChiTietDSLop;

    PRINT 'Cập nhật dữ liệu trong bảng CHITIETDSLOP thành công.';

    -- Tính lại điểm trung bình học kỳ
    EXEC capnhatDTBHocKi @MaChiTietDSLop, @MaHocSinh;
END
GO
CREATE PROCEDURE xoaCHITIETDSLOP
    @MaChiTietDSLop VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem bản ghi có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM CHITIETDSLOP WHERE MaChiTietDSLop = @MaChiTietDSLop)
    BEGIN
        PRINT 'Bản ghi không tồn tại.';
        RETURN;
    END

    -- Xóa dữ liệu từ bảng CHITIETDSLOP
    DELETE FROM CHITIETDSLOP
    WHERE MaChiTietDSLop = @MaChiTietDSLop;

    PRINT 'Xóa dữ liệu từ bảng CHITIETDSLOP thành công.';
END
Go
