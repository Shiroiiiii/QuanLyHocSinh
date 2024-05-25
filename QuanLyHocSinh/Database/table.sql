use master
drop database if exists qlhs1
create database qlhs1
use qlhs1

create table THAMSO
(
    TuoiToiThieu int,
    TuoiToiDa int,
    SiSoToiDa int,
    DiemDatMon Decimal(4,2),
    DiemDat Decimal(4,2),
    DiemToiThieu Decimal(4,2),
    DiemToiDa Decimal(4,2)
)
INSERT INTO THAMSO VALUES(15, 20, 40, 5.0, 5.0, 0.0, 10.0)

create table MONHOC
(
	MaMonHoc varchar(10) primary key,
	TenMonHoc varchar(50),
	HeSo int
)
INSERT INTO MONHOC VALUES('MH0001', N'Toán', 1)
INSERT INTO MONHOC VALUES('MH0002', N'Vật Lý', 1)
INSERT INTO MONHOC VALUES('MH0003', N'Hóa Học', 1)
INSERT INTO MONHOC VALUES('MH0004', N'Sinh Học', 1)
INSERT INTO MONHOC VALUES('MH0005', N'Lịch Sử', 1)
INSERT INTO MONHOC VALUES('MH0006', N'Địa Lý', 1)
INSERT INTO MONHOC VALUES('MH0007', N'Ngữ Văn', 1)
INSERT INTO MONHOC VALUES('MH0008', N'Đạo Đức', 1)
INSERT INTO MONHOC VALUES('MH0009', N'Thể Dục', 1)

create table KHOILOP
(
	MaKhoiLop varchar(10) primary key,
	TenKhoiLop varchar(50)
)
INSERT INTO KHOILOP VALUES('KHOI10', N'Khối 10') 
INSERT INTO KHOILOP VALUES('KHOI11', N'Khối 11') 
INSERT INTO KHOILOP VALUES('KHOI12', N'Khối 12') 

create table HOCKI
(
	MaHocKi varchar(10) primary key,
	TenHocKi varchar(50)
)
INSERT INTO HOCKI VALUES('HK1', N'Học Kỳ 1')
INSERT INTO HOCKI VALUES('HK2', N'Học Kỳ 2')

create table NAMHOC
(
	MaNamHoc VARCHAR(4) PRIMARY KEY CHECK (MaNamHoc LIKE '[0-9][0-9][0-9][0-9]'),
	TenNamHoc varchar(50)
)

create table LOP
(
	MaLop varchar(10) primary key,
	TenLop varchar(50),
	SiSo int,
	MaKhoiLop varchar(10) foreign key references KHOILOP(MaKhoiLop),
	MaNamHoc varchar(4) foreign key references NAMHOC(MaNamHoc)
)
go
CREATE TRIGGER SiSo_Check
ON LOP
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @SiSoToiDa int;
    SELECT @SiSoToiDa = SiSoToiDa FROM THAMSO;
    IF EXISTS (SELECT 1 FROM inserted i WHERE i.SiSo > @SiSoToiDa)
    BEGIN
        RAISERROR ('Violation of the SiSo Check constraint, SiSo should be less than SiSoToiDa', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
go

create table HOCSINH
(
	MaHocSinh varchar(10) primary key,
	MaLop varchar(10) foreign key references LOP(MaLop),
	HoTen varchar(50),
    GioiTinh bit,
	NgaySinh date,
	DiaChi varchar(255),
	Email varchar(100)
)
go
CREATE TRIGGER Tuoi_Check 
ON HOCSINH 
AFTER INSERT, UPDATE 
AS 
BEGIN 
    DECLARE @TuoiToiThieu INT, @TuoiToiDa INT;
    SELECT @TuoiToiThieu = TuoiToiThieu, @TuoiToiDa = TuoiToiDa FROM THAMSO;

    IF EXISTS (
        SELECT 1 
        FROM inserted i
        JOIN LOP l ON i.MaLop = l.MaLop
        JOIN NAMHOC nh ON l.MaNamHoc = nh.MaNamHoc
        WHERE SUBSTRING(nh.TenNamHoc, 6, 4) - YEAR(i.NgaySinh) < @TuoiToiThieu OR SUBSTRING(nh.TenNamHoc, 6, 4) - YEAR(i.NgaySinh) > @TuoiToiDa
    ) 
    BEGIN 
        RAISERROR ('Vi phạm ràng buộc Tuoi, Tuoi phải nằm trong khoảng TuoiToiThieu và TuoiToiDa trong năm học!', 16, 1); 
        ROLLBACK TRANSACTION; 
        RETURN;
    END 
END;
go

create table BANGDIEMMON
(
	MaBangDiem varchar(10) primary key,
	MaLop varchar(10) foreign key references LOP(MaLop),
	MaHocKi varchar(10) foreign key references HOCKI(MaHocKi),
	MaMonHoc varchar(10) foreign key references MONHOC(MaMonHoc)
)

create table LOAIHINHKIEMTRA
(
	MaLoaiHinhKT varchar(10) primary key,
	TenLoaiHinhKT varchar(50),
	HeSo int
)
INSERT INTO LOAIHINHKIEMTRA VALUES('15m', '15 phut', 1)
INSERT INTO LOAIHINHKIEMTRA VALUES('45m', '1 tiet', 2)
INSERT INTO LOAIHINHKIEMTRA VALUES('90m', 'cuoi ki', 3)

CREATE TABLE CT_DIEMLOAIHINHKT
(
    MaBangDiem VARCHAR(10) FOREIGN KEY REFERENCES BANGDIEMMON(MaBangDiem),
    MaHocSinh VARCHAR(10) FOREIGN KEY REFERENCES HOCSINH(MaHocSinh),
    MaLoaiHinhKT VARCHAR(10) FOREIGN KEY REFERENCES LOAIHINHKIEMTRA(MaLoaiHinhKT),
    Lan INT,
    Diem DECIMAL(4,2),
    PRIMARY KEY (MaBangDiem, MaHocSinh, MaLoaiHinhKT, Lan),
)
GO
CREATE TRIGGER Diem_Check
ON CT_DIEMLOAIHINHKT
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @DiemToiThieu FLOAT, @DiemToiDa FLOAT;
    SELECT @DiemToiThieu = DiemToiThieu, @DiemToiDa = DiemToiDa FROM THAMSO;

    IF EXISTS (SELECT 1 FROM inserted i WHERE i.Diem < @DiemToiThieu OR i.Diem > @DiemToiDa)
    BEGIN
        RAISERROR ('Violation of the Diem Check constraint, Diem should be within DiemToiThieu and DiemToiDa', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
go

create table CT_BANGDIEMMON
(
	MaBangDiem varchar(10),
	MaHocSinh varchar(10),
	DTBMon Decimal(4,2),
	primary key (MaBangDiem, MaHocSinh),
	foreign key (MaBangDiem) references BANGDIEMMON(MaBangDiem),
	foreign key (MaHocSinh) references HOCSINH(MaHocSinh)
)

create table CHITIETDSLOP
(
	MaChiTietDSLop varchar(10) primary key,
	MaLop varchar(10),
	MaHocKi varchar(10),
	MaHocSinh varchar(10),
	DTBHocKi decimal(4,2),
	foreign key (MaLop) references LOP(MaLop),
	foreign key (MaHocKi) references HOCKI(MaHocKi),
	foreign key (MaHocSinh) references HOCSINH(MaHocSinh)
)

create table BAOCAOTONGKETMON
(
	MaBaoCaoMon varchar(10) primary key,
	MaHocKi varchar(10) foreign key references HOCKI(MaHocKi),
	MaNamHoc varchar(4) foreign key references NAMHOC(MaNamHoc),
	MaMonHoc varchar(10) foreign key references MONHOC(MaMonHoc)
)

create table CT_BAOCAOTONGKETMON
(
	MaBaoCaoMon varchar(10),
	MaLop varchar(10),
	SoLuongDat int,
	TiLeDat float,
	primary key (MaBaoCaoMon, MaLop),
	foreign key (MaBaoCaoMon) references BAOCAOTONGKETMON(MaBaoCaoMon),
	foreign key (MaLop) references LOP(MaLop)
)
go
CREATE TRIGGER DTBMon_Check_FOR_CT_BAOCAOTONGKETMON2
ON CT_BANGDIEMMON
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @DiemDatMon FLOAT, @MaBangDiem VARCHAR(10), @MaLop VARCHAR(10), @SiSo INT;
    
    SELECT @DiemDatMon = DiemDatMon FROM THAMSO;
    SELECT @MaBangDiem = MaBangDiem FROM inserted;
    SELECT @MaLop = MaLop FROM BANGDIEMMON WHERE MaBangDiem = @MaBangDiem;
    SELECT @SiSo = SiSo FROM LOP WHERE MaLop = @MaLop;
    
    IF EXISTS (SELECT 1 FROM inserted i WHERE i.DTBMon >= @DiemDatMon)
    BEGIN
        UPDATE CT_BAOCAOTONGKETMON
        SET SoLuongDat = SoLuongDat + 1
        WHERE MaBaoCaoMon = @MaBangDiem; -- Sửa MaBangDiem thành MaBaoCaoMon
    END
    UPDATE CT_BAOCAOTONGKETMON
    SET TiLeDat = (SoLuongDat / @SiSo) * 100.0
    WHERE MaBaoCaoMon = @MaBangDiem; -- Sửa MaBangDiem thành MaBaoCaoMon
END;
GO


create table BAOCAOTONGKETHK
(
	MaNamHoc varchar(4),
	MaHocKi varchar(10),
	MaLop varchar(10),
	SoLuongDat int,
	TiLeDat float,
	primary key (MaNamHoc, MaHocKi, MaLop),
	foreign key (MaNamHoc) references NAMHOC(MaNamHoc),
	foreign key (MaHocKi) references HOCKI(MaHocKi),
	foreign key (MaLop) references LOP(MaLop)
)
go
CREATE TRIGGER Increase_SoLuongDat
ON CHITIETDSLOP
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @DiemDat FLOAT, @MaLop VARCHAR(10), @MaHocKi VARCHAR(10), @MaNamHoc VARCHAR(10), @SiSo INT;
    
    SELECT @DiemDat = DiemDat FROM THAMSO;
    SELECT @MaLop = MaLop, @MaHocKi = MaHocKi FROM inserted; -- Cập nhật từ bảng dữ liệu đầu vào
    SELECT @SiSo = SiSo FROM LOP WHERE MaLop = @MaLop;
    
    IF EXISTS (SELECT 1 FROM inserted i WHERE i.DTBHocKi >= @DiemDat)
    BEGIN
	UPDATE BAOCAOTONGKETHK
	SET SoLuongDat = SoLuongDat + 1
	WHERE MaLop = @MaLop AND MaHocKi = @MaHocKi;

	UPDATE BAOCAOTONGKETHK
	SET TiLeDat = (CAST(SoLuongDat AS FLOAT) / CAST(@SiSo AS FLOAT)) * 100.0
	WHERE MaLop = @MaLop AND MaHocKi = @MaHocKi;
	END;
end;
GO

CREATE TABLE LOAINGUOIDUNG
(
	MaLoai VARCHAR(6) PRIMARY KEY,
	TenLoai NVARCHAR(30) 
)

INSERT INTO LOAINGUOIDUNG VALUES('LND001', N'Ban giám hiệu')
INSERT INTO LOAINGUOIDUNG VALUES('LND002', N'Giáo viên')
INSERT INTO LOAINGUOIDUNG VALUES('LND003', N'Nhân viên giáo vụ')

CREATE TABLE NGUOIDUNG
(
	MaNguoiDung VARCHAR(6) PRIMARY KEY,
	MaLoai VARCHAR(6),
	TenNguoiDung NVARCHAR(30),
	TenDangNhap NVARCHAR(30),
	MatKhau VARCHAR(64),
	CONSTRAINT FK_NGUOIDUNG_LOAINGUOIDUNG FOREIGN KEY(MaLoai) REFERENCES LOAINGUOIDUNG(MaLoai)
)
