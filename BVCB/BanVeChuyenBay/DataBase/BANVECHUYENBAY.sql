
CREATE DATABASE BANVECHUYENBAY
GO
USE BANVECHUYENBAY
GO

---- NOI DUNG BM1
SET DATEFORMAT dmy;

CREATE TABLE DIADIEM
(
	MaDiaDiem varchar(10) primary key not null,
	QuocGia nvarchar(50) not null,
	ThanhPho nvarchar(50) not null,
)

CREATE TABLE HANGHANGKHONG
(
	MaHang varchar(10) primary key not null,
	TenHang nvarchar(50) not null,
)

CREATE TABLE SANBAY
(
	MaSanBay VARCHAR(10) PRIMARY KEY NOT NULL,
	TenSanBay NVARCHAR(100),
	MaDiaDiem varchar(10) FOREIGN KEY REFERENCES DIADIEM(MaDiaDiem)
)

CREATE TABLE TUYENBAY
(
	MaTuyenBay varchar(10) PRIMARY KEY NOT NULL,
	MaSanBayDi varchar(10) FOREIGN KEY REFERENCES SANBAY(MaSanBay),
	MaSanBayDen varchar(10) FOREIGN KEY REFERENCES SANBAY(MaSanBay)
)

CREATE TABLE LICHCHUYENBAY
(
	MaChuyenBay varchar(10) PRIMARY KEY NOT NULL,
	MaTuyenBay varchar(10) FOREIGN KEY REFERENCES TUYENBAY(MaTuyenBay),
	KhoiHanh DATETIME,
	ThoiGianBay int,
	GiaVe money,
	MaHang varchar(10) FOREIGN KEY REFERENCES HANGHANGKHONG(MaHang),
)

CREATE TABLE CT_LICHCHUYENBAY
(
	MaChuyenBay VARCHAR(10) FOREIGN KEY REFERENCES LICHCHUYENBAY(MaChuyenBay),
	MaSanBayTrungGian VARCHAR(10) foreign key references SANBAY(MaSanBay),
	ThoiGianDung INT,
	GhiChu NVARCHAR(100),
	CONSTRAINT PK_CT_LICHCHUYENBAY PRIMARY KEY (MaChuyenBay, MaSanBayTrungGian)
)

-------------------------------
--- BM2 va Qui Dinh 2

CREATE TABLE HANGVE
(
	MaHangVe varchar(10) primary key not null,
	TenHangVe nvarchar(50),
	TiLeDonGia float
)



CREATE TABLE CT_GHE
(
	MaChuyenBay VARCHAR(10) FOREIGN KEY REFERENCES LICHCHUYENBAY(MaChuyenBay),
	MaHangVe varchar(10) FOREIGN KEY REFERENCES HANGVE(MaHangVe),
	SoGhe int,
	SoGheDat int,
	SoGheTrong int
	
	CONSTRAINT PK_CT_GHE PRIMARY KEY (MaChuyenBay, MaHangVe)
)

CREATE TABLE PHIEUDATCHO
(
	MaPhieuDatCho varchar(10) PRIMARY KEY NOT NULL,
	NguoiDat nvarchar(50),
	CMND varchar(20),
	DienThoai varchar(20),
	NgayDat datetime
)



CREATE TABLE CT_PHIEUDATCHO
(
	MaPhieuDatCho varchar(10)FOREIGN KEY REFERENCES PHIEUDATCHO(MaPhieuDatCho),
	MaChuyenBay	varchar(10) FOREIGN KEY REFERENCES LICHCHUYENBAY(MaChuyenBay),
	HanhKhachBay	nvarchar(50),
	CMND varchar(20),
	DienThoai varchar(20),
	MaHangVe	varchar(10) FOREIGN KEY REFERENCES HANGVE(MaHangVe),
	LayVe Bit,
	
	CONSTRAINT PK_CT_PHIEUDATCHO PRIMARY KEY (MaChuyenBay, MaPhieuDatCho)
)



CREATE TABLE THAMSO
(
	ThoiGianBayToiThieu	int,
	SoSanBayTrungGianToiDa	int,
	ThoiGianDungToiThieu	int,
	ThoiGianDungToiDa	int,
	TGChamNhatHuyDatVe	bit	,
	TGChamNhatDatVe	int,
)

-- BM5.1

CREATE TABLE BAOCAODOANHTHUNAM
(
	Nam INT primary key,
	TongDoanhThu MONEY,
)

CREATE TABLE BAOCAODOANHTHUTHANG
(
	Thang int,
	Nam int,
	SoChuyenBay	int,
	DoanhThu	money,
	TiLe FLOAT,
	
	CONSTRAINT PK_BAOCAODOANHTHUTHANG PRIMARY KEY (Thang, Nam)
)



CREATE TABLE BAOCAODOANHTHUCHUYENBAY
(
	MaChuyenBay	varchar(10) FOREIGN KEY REFERENCES LICHCHUYENBAY(MaChuyenBay),
	SoVe int,
	Thang int,
	Nam int,
	DoanhThu money, 
	TiLe float,
	
	CONSTRAINT PK_CT_DOANHTHUTHANG PRIMARY KEY (Nam, Thang, MaChuyenBay)
)


CREATE TABLE NHANVIEN
(
	MaNhanVien varchar(10) primary key not null,
	TenNhanVien nvarchar(50) null,
	TenDangNhap varchar(50) null,
	MatKhau varchar(50) null,
	QuyenHan int null,
	DiaChi nvarchar(100) null,
	DienThoai varchar(20) null,	
)

CREATE TABLE KHACHHANG
(
	MaKhachHang varchar(10) primary key not null,
	TenKhachHang nvarchar(50) null,
	TenDangNhap varchar(50) null,
	MatKhau varchar(50) null,
	DiaChi nvarchar(100) null,
	DienThoai varchar(20) null,
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	CMND varchar(9),
)

go

--------------------STORE PROCEDURE--------------
CREATE PROCEDURE NHANVIEN_SELECT_DANGNHAP
(
	@TenDangNhap nvarchar(50),
	@MatKhau varchar(50)
)
as
begin
	SELECT NHANVIEN.MaNhanVien, NHANVIEN.TenNhanVien,  NHANVIEN.TenDangNhap, NHANVIEN.MatKhau, NHANVIEN.QuyenHan, NHANVIEN.DiaChi, NHANVIEN.DienThoai FROM NHANVIEN WHERE TenDangNhap=@TenDangNhap AND MatKhau = @MatKhau
end
go

CREATE PROCEDURE NHANVIEN_SELECT_ALL
AS
BEGIN
	SELECT NHANVIEN.MaNhanVien, NHANVIEN.TenNhanVien, NHANVIEN.DiaChi, NHANVIEN.DienThoai, NHANVIEN.TenDangNhap, NHANVIEN.MatKhau, NHANVIEN.QuyenHan FROM NHANVIEN
END
GO


CREATE PROCEDURE NHANVIEN_SELECT_MANHANVIEN
(
	@MaNhanVien varchar(10)
)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien
END
GO


CREATE PROCEDURE NHANVIEN_INSERT
(
	@MaNhanVien varchar(10),
	@TenNhanVien nvarchar(50),
	@TenDangNhap varchar(50),
	@MatKhau varchar(50),
	@QuyenHan int,
	@DiaChi nvarchar(100),
	@DienThoai varchar(20)	
)
AS
BEGIN
	INSERT INTO NHANVIEN
	VALUES(@MaNhanVien, @TenNhanVien, @TenDangNhap, @MatKhau, @QuyenHan, @DiaChi, @DienThoai)
END
GO


CREATE PROCEDURE NHANVIEN_DELETE
(
@MaNhanVien varchar(10)
)
as
begin
	if( EXISTS (SELECT * FROM NHANVIEN WHERE NHANVIEN.MaNhanVien = @MaNhanVien))
	BEGIN
		DELETE FROM NHANVIEN
		WHERE MaNhanVien = @MaNhanVien
	END
end
go

CREATE PROCEDURE UPDATE_NHANVIEN_MATKHAU
(
@MaNhanVien varchar(10),
@MatKhau varchar(50)
)
as
begin
		UPDATE NHANVIEN
		SET MatKhau = @MatKhau
		WHERE MaNhanVien = @MaNhanVien
end
go


CREATE PROCEDURE UPDATE_NHANVIEN
(
	@MaNhanVien varchar(10),
	@TenNhanVien nvarchar(50),
	@TenDangNhap varchar(50),
	@MatKhau varchar(50),
	@QuyenHan int,
	@DiaChi nvarchar(100),
	@DienThoai varchar(20)	
)
AS
BEGIN
		UPDATE NHANVIEN
		SET TenNhanVien = @TenNhanVien, TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, QuyenHan = @QuyenHan,
			DiaChi = @DiaChi, DienThoai = @DienThoai
		WHERE MaNhanVien = @MaNhanVien
END
GO

CREATE PROCEDURE INSERT_SANBAY
(
@MaSanBay varchar(10),
@TenSanBay nvarchar(100),
@MaDiaDiem varchar(10)
)
as
begin
	INSERT INTO SANBAY VALUES(@MaSanBay, @TenSanBay, @MaDiaDiem)
end
go

CREATE PROCEDURE UPDATE_SANBAY
(
@MaSanBay varchar(10),
@TenSanBay nvarchar(100),
@MaDiaDiem varchar(10)
)
as
begin
		UPDATE SANBAY
		SET TenSanBay = @TenSanBay, MaDiaDiem = @MaDiaDiem
		WHERE MaSanBay = @MaSanBay
end
go




CREATE PROCEDURE DELETE_SANBAY
(
@MaSanBay varchar(10)
)
as
begin
	if( EXISTS (SELECT * FROM SANBAY WHERE SANBAY.MaSanBay = @MaSanBay))
	BEGIN
		DELETE FROM SANBAY
		WHERE MaSanBay = @MaSanBay
	END
end
go



CREATE PROCEDURE SELECT_ALL_SANBAY
AS
BEGIN
	SELECT SANBAY.MaSanBay, SANBAY.TenSanBay FROM SANBAY
END
GO

CREATE PROCEDURE SELECT_AT_SANBAY
@MaSanBay varchar(10)
AS
BEGIN
	SELECT SANBAY.MaSanBay, SANBAY.TenSanBay FROM SANBAY WHERE MaSanBay = @MaSanBay 
END
GO
--------------------
CREATE PROCEDURE INSERT_LICHCHUYENBAY 
(
	-- Add the parameters for the stored procedure here
	@MaChuyenBay varchar(10),
	@MaTuyenBay varchar(10),
	@KhoiHanh datetime,
	@ThoiGianBay int,
	@GiaVe money,
	@MaHang varchar(10)
)
AS
BEGIN
	INSERT INTO LICHCHUYENBAY VALUES (@MaChuyenBay, @MaTuyenBay, @KhoiHanh, @ThoiGianBay, @GiaVe, @MaHang)
END
GO

CREATE PROCEDURE UPDATE_LICHCHUYENBAY 
(
	-- Add the parameters for the stored procedure here
	@MaChuyenBay varchar(100),
	@MaTuyenBay varchar(10),
	@KhoiHanh datetime,
	@ThoiGianBay int,
	@GiaVe money,
	@MaHang varchar(10)
)
AS
BEGIN
	UPDATE LICHCHUYENBAY
	SET MaTuyenBay = @MaTuyenBay, ThoiGianBay = @ThoiGianBay, KhoiHanh = @KhoiHanh, GiaVe = @GiaVe, MaHang = @MaHang
	WHERE MaChuyenBay = @MaChuyenBay
END
GO

CREATE PROCEDURE DELETE_LICHCHUYENBAY
@MaChuyenBay varchar(10)
AS
BEGIN
	IF(EXISTS (SELECT * FROM LICHCHUYENBAY WHERE LICHCHUYENBAY.MaChuyenBay = @MaChuyenBay))
	BEGIN
		DELETE FROM LICHCHUYENBAY WHERE LICHCHUYENBAY.MaChuyenBay = @MaChuyenBay
	END
END
GO

CREATE PROCEDURE SELECT_ALL_LICHCHUYENBAY_NOTPLANE
AS
BEGIN
	SELECT  A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM
	(SELECT F.MaChuyenBay, F.MaTuyenBay, F.KhoiHanh, F.ThoiGianBay, F.GiaVe, DATEDIFF(day, GETDATE(), F.KhoiHanh) AS SUBDATE , DATEDIFF(MINUTE, GETDATE(), F.KhoiHanh) AS SUBTIME FROM LICHCHUYENBAY F) A	
	WHERE A.SUBDATE >= 0 AND A.SUBTIME > 0
END
GO

CREATE PROCEDURE SELECT_ALL_LICHCHUYENBAY_PLANED
AS
BEGIN
	SELECT  A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM
	(SELECT F.MaChuyenBay, F.MaTuyenBay, F.KhoiHanh, F.ThoiGianBay, F.GiaVe, DATEDIFF(day, GETDATE(), F.KhoiHanh) AS SUBDATE , DATEDIFF(MINUTE, GETDATE(), F.KhoiHanh) AS SUBTIME FROM LICHCHUYENBAY F) A	
	WHERE A.SUBDATE <= 0 AND A.SUBTIME < 0
END
GO


CREATE PROCEDURE SELECT_ALL_LICHCHUYENBAY
AS
BEGIN
	SELECT  A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM LICHCHUYENBAY A
END
GO

CREATE PROCEDURE SELECT_AT_LICHCHUYENBAY
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT LICHCHUYENBAY.MaChuyenBay, LICHCHUYENBAY.MaTuyenBay, LICHCHUYENBAY.KhoiHanh, LICHCHUYENBAY.ThoiGianBay, LICHCHUYENBAY.GiaVe FROM LICHCHUYENBAY WHERE LICHCHUYENBAY.MaChuyenBay = @MaChuyenBay
END
GO

CREATE PROCEDURE SELECT_ALL_LICHCHUYENBAY_BY_QD3
AS
BEGIN
	DECLARE @MinDatVe int
	SET @MinDatVe = (SELECT THAMSO.TGChamNhatDatVe FROM THAMSO) 

	SELECT A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM
	(SELECT F.MaChuyenBay, F.MaTuyenBay, F.KhoiHanh, F.ThoiGianBay, F.GiaVe, DATEDIFF(day, GETDATE(), F.KhoiHanh) AS SUBDATE FROM LICHCHUYENBAY F) A
	WHERE A.SUBDATE >= @MinDatVe
END
GO



------------------------------
CREATE PROCEDURE INSERT_CT_LICHCHUYENBAY
(
	@MaChuyenBay varchar(10),
	@MaSanBayTrungGian varchar(10),
	@ThoiGianDung int,
	@GhiChu varchar(100)
)
as
begin
	INSERT INTO CT_LICHCHUYENBAY VALUES(@MaChuyenBay, @MaSanBayTrungGian, @ThoiGianDung, @GhiChu)
end
go

CREATE PROCEDURE UPDATE_CT_LICHCHUYENBAY
(
	@MaChuyenBay varchar(10),
	@MaSanBayTrungGian varchar(10),
	@ThoiGianDung int,
	@GhiChu varchar(100)
)
as
begin
	UPDATE CT_LICHCHUYENBAY
	SET MaSanBayTrungGian = @MaSanBayTrungGian, ThoiGianDung = @ThoiGianDung, GhiChu = @GhiChu
	WHERE MaChuyenBay = @MaChuyenBay
end
go



CREATE PROCEDURE DELETE_CT_LICHCHUYENBAY
(
@MaChuyenBay varchar(10)
)
as
begin
	IF( EXISTS (SELECT * FROM CT_LICHCHUYENBAY A WHERE A.MaChuyenBay = @MaChuyenBay))
	BEGIN
		DELETE FROM CT_LICHCHUYENBAY
		WHERE MaChuyenBay = @MaChuyenBay
	END
end
go

CREATE PROCEDURE SELECT_AT_CT_LICHCHUYENBAY
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT CT.MaChuyenBay, CT.MaSanBayTrungGian, SB.TenSanBay AS SanBayTrungGian, CT.ThoiGianDung, CT.GhiChu FROM CT_LICHCHUYENBAY CT, SANBAY SB
	WHERE CT.MaChuyenBay = @MaChuyenBay AND CT.MaSanBayTrungGian = SB.MaSanBay
END
GO



-----------------------------------
CREATE PROCEDURE INSERT_HANGVE
(
	@MaHangVe varchar(10),
	@TenHangVe nvarchar(50),
	@GiaVe FLOAT
)
as
begin
	INSERT INTO HANGVE VALUES(@MaHangVe, @TenHangVe, @GiaVe)
end
go

CREATE PROCEDURE UPDATE_HANGVE
(
	@MaHangVe varchar(10),
	@TenHangVe nvarchar(50),
	@GiaVe FLOAT
)
as
begin
	UPDATE HANGVE
	SET TenHangVe = @TenHangVe, TiLeDonGia = @GiaVe
	WHERE MaHangVe = @MaHangVe
end
go

CREATE PROCEDURE DELETE_HANGVE
(
	@MaHangVe varchar(10)
)
as
begin
	DELETE FROM HANGVE
	WHERE MaHangVe = @MaHangVe
end
go


CREATE PROCEDURE SELECT_ALL_HANGVE
AS
BEGIN
	SELECT HANGVE.MaHangVe, HANGVE.TenHangVe, HANGVE.TiLeDonGia FROM HANGVE
END
GO

CREATE PROCEDURE SELECT_AT_HANGVE
@MaHangVe varchar(10)
AS
BEGIN
	SELECT HANGVE.MaHangVe, HANGVE.TenHangVe, HANGVE.TiLeDonGia FROM HANGVE WHERE HANGVE.MaHangVe = @MaHangVe
END
GO

------------------------------
CREATE PROCEDURE INSERT_TUYENBAY
@MaTuyenBay varchar(10),
@MaSanBayDi varchar(10),
@MaSanBayDen varchar(10)
as
begin
	INSERT INTO TUYENBAY VALUES(@MaTuyenBay, @MaSanBayDi, @MaSanBayDen)
end
go

CREATE PROCEDURE UPDATE_TUYENBAY
@MaTuyenBay varchar(10),
@MaSanBayDi varchar(10),
@MaSanBayDen varchar(10)
as
begin
	UPDATE TUYENBAY
	SET MaSanBayDi = @MaSanBayDi, MaSanBayDen = @MaSanBayDen
	WHERE MaTuyenBay = @MaTuyenBay
end
go


CREATE PROCEDURE DELETE_TUYENBAY
@MaTuyenBay varchar(10)
as
begin
	IF(EXISTS (SELECT * FROM TUYENBAY WHERE TUYENBAY.MaTuyenBay = @MaTuyenBay))
	BEGIN
	DELETE FROM TUYENBAY
	WHERE MaTuyenBay = @MaTuyenBay
	END
end
go


CREATE PROCEDURE SELECT_ALL_TUYENBAY
AS
BEGIN
	SELECT TUYENBAY.MaTuyenBay, TUYENBAY.MaSanBayDi, TUYENBAY.MaSanBayDen FROM TUYENBAY
END
GO


CREATE PROCEDURE SELECT_AT_TUYENBAY
@MaTuyenBay varchar(10)
AS
BEGIN
	SELECT TUYENBAY.MaTuyenBay, TUYENBAY.MaSanBayDi, TUYENBAY.MaSanBayDen FROM TUYENBAY WHERE TUYENBAY.MaTuyenBay = @MaTuyenBay
END
GO



CREATE PROCEDURE SELECT_AT_COLUMNS_TUYENBAY
@TenColumn varchar(100)
AS
BEGIN
	
	IF(@TenColumn = 'MaSanBayDi')
	BEGIN
		SELECT DISTINCT SANBAY.MaSanBay, SANBAY.TenSanBay FROM TUYENBAY, SANBAY WHERE TUYENBAY.MaSanBayDi = SANBAY.MaSanBay
	END
	ELSE
		IF(@TenColumn = 'MaSanBayDen')
		BEGIN
			SELECT DISTINCT SANBAY.MaSanBay, SANBAY.TenSanBay FROM TUYENBAY, SANBAY WHERE TUYENBAY.MaSanBayDen = SANBAY.MaSanBay
		END
END
GO
-------------------------


CREATE PROCEDURE INSERT_CT_GHE
	-- Add the parameters for the stored procedure here
	@MaChuyenBay VARCHAR(10),
	@MaHangVe VARCHAR(10),
	@SoGhe int,
	@SoGheDat int,
	@SoGheTrong int
AS
BEGIN
	INSERT INTO CT_GHE VALUES(@MaChuyenBay, @MaHangVe, @SoGhe, @SoGheDat, @SoGheTrong)
END
GO



CREATE PROCEDURE UPDATE_CT_GHE
	-- Add the parameters for the stored procedure here
	@MaChuyenBay VARCHAR(10),
	@MaHangVe VARCHAR(10),
	@SoGhe int,
	@SoGheDat int,
	@SoGheTrong int
AS
BEGIN
	UPDATE CT_GHE
	SET SoGhe = @SoGhe, SoGheDat = @SoGheDat, SoGheTrong = @SoGheTrong
	WHERE MaChuyenBay = @MaChuyenBay AND MaHangVe = @MaHangVe 
END
GO

CREATE PROCEDURE DELETE_CT_GHE
	-- Add the parameters for the stored procedure here
	@MaChuyenBay VARCHAR(10)
AS
BEGIN
	IF( EXISTS (SELECT * FROM CT_GHE WHERE CT_GHE.MaChuyenBay = @MaChuyenBay))
	BEGIN
	DELETE FROM CT_GHE
	WHERE MaChuyenBay = @MaChuyenBay
	END
END
GO


CREATE PROCEDURE SELECT_AT_CT_GHE
@MaChuyenBay varchar(10),
@MaHangVe varchar(10)
AS
BEGIN
	SELECT CT_GHE.MaChuyenBay, CT_GHE.MaHangVe, CT_GHE.SoGhe ,CT_GHE.SoGheDat, CT_GHE.SoGheTrong FROM CT_GHE WHERE CT_GHE.MaChuyenBay = @MaChuyenBay AND CT_GHE.MaHangVe = @MaHangVe
END
GO


CREATE PROCEDURE SELECT_AT_CT_GHE_BY_MACHUYENBAY
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT CT_GHE.MaChuyenBay, CT_GHE.MaHangVe, CT_GHE.SoGhe ,CT_GHE.SoGheDat, CT_GHE.SoGheTrong FROM CT_GHE WHERE CT_GHE.MaChuyenBay = @MaChuyenBay
END
GO

----------------------
CREATE PROCEDURE INSERT_PHIEUDATCHO
@MaPhieuDatCho varchar(10),
@NguoiDat nvarchar(50),
@CMND varchar(20),
@DienThoai varchar(20),
@NgayDat datetime
as
begin
	INSERT INTO PHIEUDATCHO VALUES(@MaPhieuDatCho, @NguoiDat, @CMND, @DienThoai, @NgayDat)
end
go


CREATE PROCEDURE UPDATE_PHIEUDATCHO
@MaPhieuDatCho varchar(10),
@NguoiDat nvarchar(50),
@CMND varchar(20),
@DienThoai varchar(20)
as
begin
	UPDATE PHIEUDATCHO
	SET NguoiDat = @NguoiDat, CMND = @CMND, DienThoai = @DienThoai
	WHERE MaPhieuDatCho = @MaPhieuDatCho
end
go


CREATE PROCEDURE DELETE_PHIEUDATCHO
@MaPhieuDatCho varchar(10)
as
begin
	IF(EXISTS (SELECT * FROM PHIEUDATCHO WHERE PHIEUDATCHO.MaPhieuDatCho = @MaPhieuDatCho))
	BEGIN
	DELETE FROM PHIEUDATCHO
	WHERE MaPhieuDatCho = @MaPhieuDatCho
	END
end
go


CREATE PROCEDURE SELECT_AT_PHIEUDATCHO
@MaPhieuDatCho varchar(10)
AS
BEGIN
	SELECT PHIEUDATCHO.MaPhieuDatCho, PHIEUDATCHO.NguoiDat, PHIEUDATCHO.CMND, PHIEUDATCHO.DienThoai, PHIEUDATCHO.NgayDat FROM PHIEUDATCHO WHERE MaPhieuDatCho = @MaPhieuDatCho
END
GO

CREATE PROCEDURE SELECT_ALL_PHIEUDATCHO
AS
BEGIN
	SELECT PHIEUDATCHO.MaPhieuDatCho, PHIEUDATCHO.NguoiDat, PHIEUDATCHO.CMND, PHIEUDATCHO.DienThoai, PHIEUDATCHO.NgayDat FROM PHIEUDATCHO
END
GO

----------------
CREATE PROCEDURE INSERT_CT_PHIEUDATCHO
(
@MaPhieuDatCho varchar(10),
@MaChuyenBay varchar(10),
@HanhKhachBay nvarchar(50),
@CMND varchar(20),
@DienThoai varchar(20),
@MaHangVe varchar(10),
@LayVe bit
)
AS
BEGIN
	INSERT INTO CT_PHIEUDATCHO VALUES(@MaPhieuDatCho, @MaChuyenBay, @HanhKhachBay, @CMND, @DienThoai, @MaHangVe, @LayVe) 
END
GO


CREATE PROCEDURE UPDATE_CT_PHIEUDATCHO
(
@MaPhieuDatCho varchar(10),
@MaChuyenBay varchar(10),
@HanhKhachBay nvarchar(50),
@CMND varchar(20),
@DienThoai varchar(20),
@MaHangVe varchar(10),
@LayVe bit
)
AS
BEGIN
	UPDATE CT_PHIEUDATCHO
	SET  HanhKhachBay = @HanhKhachBay, CMND = @CMND
	, DienThoai = @DienThoai, MaHangVe = @MaHangVe, LayVe = @LayVe
	WHERE MaPhieuDatCho = @MaPhieuDatCho AND MaChuyenBay = @MaChuyenBay
END
GO


CREATE PROCEDURE DELETE_CT_PHIEUDATCHO
(
@MaPhieuDatCho varchar(10)
)
AS
BEGIN
	IF(EXISTS (SELECT * FROM CT_PHIEUDATCHO WHERE CT_PHIEUDATCHO.MaPhieuDatCho = @MaPhieuDatCho))
	BEGIN
	DELETE FROM CT_PHIEUDATCHO
	WHERE MaPhieuDatCho = @MaPhieuDatCho
	END
END
GO


CREATE PROCEDURE DELETE_CT_PHIEUDATCHO_BY_MACHUYENBAY
@MaChuyenBay varchar(10)
as
begin
	IF(EXISTS (SELECT * FROM CT_PHIEUDATCHO WHERE CT_PHIEUDATCHO.MaChuyenBay = @MaChuyenBay))
	BEGIN
	DELETE FROM CT_PHIEUDATCHO
	WHERE MaChuyenBay = @MaChuyenBay
	END
end
go


CREATE PROCEDURE SELECT_AT_CT_PHIEUDATCHO
@MaPhieuDatCho varchar(10),
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F WHERE F.MaPhieuDatCho = @MaPhieuDatCho AND F.MaChuyenBay = @MaChuyenBay
END
GO


CREATE PROCEDURE SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY_LAYVE
@MaChuyenBay varchar(10),
@LayVe bit
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F WHERE F.MaChuyenBay = @MaChuyenBay AND LayVe = @LayVe
END
GO

CREATE PROCEDURE SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F WHERE F.MaChuyenBay = @MaChuyenBay
END
GO

CREATE PROCEDURE SELECT_ALL_CT_PHIEUDATCHO
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F
END
GO
---------------

CREATE PROCEDURE SELECT_ALL_THAMSO
AS
BEGIN
	SELECT THAMSO.SoSanBayTrungGianToiDa, THAMSO.ThoiGianDungToiDa, THAMSO.ThoiGianDungToiThieu, THAMSO.ThoiGianBayToiThieu, THAMSO.TGChamNhatDatVe, THAMSO.TGChamNhatHuyDatVe
	FROM THAMSO
END
GO


CREATE PROCEDURE UPDATE_THAMSO
@ThoiGianBayToiThieu int,
@SoSanBayTrungGian int,
@TGDungToiThieu int,
@TGDungToiDa int,
@TGChamNhatHuyDatVe BIT,
@TGChamNhatDatVe int
AS
BEGIN
	UPDATE THAMSO
	SET ThoiGianBayToiThieu = @ThoiGianBayToiThieu, SoSanBayTrungGianToiDa = @SoSanBayTrungGian,
	ThoiGianDungToiThieu = @TGDungToiThieu, ThoiGianDungToiDa = @TGDungToiDa,
	TGChamNhatHuyDatVe = @TGChamNhatHuyDatVe, TGChamNhatDatVe = @TGChamNhatDatVe
END
GO

---- BM 5.1---

CREATE PROCEDURE INSERT_BAOCAODOANHTHUNAM
(
@Nam int,
@TongDoanhThu money
)
AS
BEGIN
	INSERT INTO BAOCAODOANHTHUNAM VALUES (@Nam, @TongDoanhThu)
END
GO


CREATE PROCEDURE UPDATE_BAOCAODOANHTHUNAM
(
@Nam int,
@TongDoanhThu money
)
AS
BEGIN
	UPDATE BAOCAODOANHTHUNAM
	SET TongDoanhThu = @TongDoanhThu
	WHERE Nam = @Nam
END
GO

CREATE PROCEDURE DELETE_BAOCAODOANHTHUNAM
(
@Nam int
)
AS
BEGIN
	DELETE FROM BAOCAODOANHTHUNAM
	WHERE Nam = @Nam
END
GO

-----------
CREATE PROCEDURE INSERT_BAOCAODOANHTHUTHANG
(
@Thang int,
@Nam int,
@SoChuyenBay int,
@DoanhThu money,
@TiLe float
)
AS
BEGIN
	INSERT INTO BAOCAODOANHTHUTHANG VALUES (@Thang, @Nam, @SoChuyenBay, @DoanhThu, @TiLe)
END
GO


CREATE PROCEDURE DELETE_BAOCAODOANHTHUTHANG
(
@Thang int,
@Nam int
)
AS
BEGIN
	DELETE FROM BAOCAODOANHTHUTHANG
	WHERE Thang = @Thang AND Nam = @Nam
END
GO


CREATE PROCEDURE SELECT_BAOCAODOANHTHUTHANG_BY_NAM
@Nam int
AS
BEGIN
	SELECT A.Thang, A.Nam, A.DoanhThu, A.SoChuyenBay, A.TiLe  FROM BAOCAODOANHTHUTHANG A WHERE A.Nam = @Nam
END
GO

CREATE PROCEDURE SELECT_BAOCAODOANHTHUTHANG_BY_THANGNAM
@Thang int,
@Nam int
AS
BEGIN
	SELECT A.Thang, A.Nam, A.DoanhThu, A.SoChuyenBay, A.TiLe  FROM BAOCAODOANHTHUTHANG A WHERE A.Nam = @Nam AND A.Thang = @Thang
END
GO

CREATE PROCEDURE UPDATE_BAOCAODOANHTHUTHANG
(
@Thang int,
@Nam int,
@SoChuyenBay int,
@DoanhThu money,
@TiLe float
)
AS
BEGIN
	UPDATE BAOCAODOANHTHUTHANG
	SET SoChuyenBay = @SoChuyenBay, DoanhThu = @DoanhThu, TiLe = @TiLe
	WHERE Thang = @Thang AND Nam = @Nam
END
GO
----------------

CREATE PROCEDURE INSERT_BAOCAODOANHTHUCHUYENBAY
(
@Thang int,
@Nam int,
@MaChuyenBay varchar(10),
@SoVe int,
@DoanhThu money,
@TiLe float
)
AS
BEGIN
	INSERT INTO BAOCAODOANHTHUCHUYENBAY VALUES( @MaChuyenBay, @SoVe, @Thang, @Nam, @DoanhThu, @TiLe)
END
GO


CREATE PROCEDURE UPDATE_BAOCAODOANHTHUCHUYENBAY
(
@Thang int,
@Nam int,
@MaChuyenBay varchar(10),
@SoVe int,
@DoanhThu money,
@TiLe float
)
AS
BEGIN
	UPDATE BAOCAODOANHTHUCHUYENBAY
	SET SoVe = @SoVe, DoanhThu = @DoanhThu, TiLe = @TiLe, Thang = @Thang, Nam = @Nam
	WHERE MaChuyenBay = @MaChuyenBay
END
GO



CREATE PROCEDURE DELETE_BAOCAODOANHTHUCHUYENBAY
(
@MaChuyenBay varchar(10)
)
AS
BEGIN
	IF(EXISTS (SELECT * FROM BAOCAODOANHTHUCHUYENBAY A WHERE A.MaChuyenBay = @MaChuyenBay))
	BEGIN
	DELETE FROM BAOCAODOANHTHUCHUYENBAY
	WHERE MaChuyenBay = @MaChuyenBay
	END 
END
GO



CREATE PROCEDURE SELECT_BAOCAODOANHTHUCHUYENBAY_BY_THANGNAM
@Thang int, 
@Nam int

AS
BEGIN
	SELECT A.MaChuyenBay, A.SoVe, A.DoanhThu, A.Thang, A.Nam, A.TiLe
	FROM  BAOCAODOANHTHUCHUYENBAY A,
	(SELECT LCB.MaChuyenBay, DATEDIFF(MINUTE, GETDATE(), LCB.KhoiHanh) as SUBDATE  FROM LICHCHUYENBAY LCB WHERE MONTH(LCB.KhoiHanh) = @Thang AND YEAR(LCB.KhoiHanh) = @Nam) B
	WHERE A.Thang = @Thang AND A.Nam = @Nam AND A.MaChuyenBay = B.MaChuyenBay AND B.SUBDATE <= 0
	
END
GO

CREATE PROCEDURE SELECT_BAOCAODOANHTHUCHUYENBAY_BY_NAM
@Nam int
AS
BEGIN
	SELECT A.MaChuyenBay, A.SoVe, A.DoanhThu, A.Thang, A.Nam, A.TiLe
	FROM  BAOCAODOANHTHUCHUYENBAY A,
	(SELECT LCB.MaChuyenBay, DATEDIFF(MINUTE, GETDATE(), LCB.KhoiHanh) as SUBDATE  FROM LICHCHUYENBAY LCB WHERE YEAR(LCB.KhoiHanh) = @Nam) B
	WHERE A.Nam = @Nam AND A.MaChuyenBay = B.MaChuyenBay AND B.SUBDATE <= 0
	
END
GO


CREATE PROCEDURE SELECT_TRACUUCHUYENBAY
@TuNgay datetime,
@DenNgay	datetime
AS
BEGIN

	SELECT TEMP.MaChuyenBay, TEMP.SanBayDi, TEMP.SanBayDen, TEMP.KhoiHanh, TEMP.ThoiGianBay, CHUYENBAY.SoGhe, CHUYENBAY.SoGheDat, CHUYENBAY.SoGheTrong
	FROM
		(SELECT CT_GHE.MaChuyenBay, SUM(CT_GHE.SoGhe) AS SoGhe,SUM(CT_GHE.SoGheDat) AS SoGheDat, SUM(CT_GHE.SoGheTrong) AS SoGheTrong 
		FROM CT_GHE
		GROUP BY CT_GHE.MaChuyenBay) CHUYENBAY,
			(SELECT LCB.MaChuyenBay, TB.MaTuyenBay, LCB.KhoiHanh, LCB.ThoiGianBay, SB1.TenSanBay AS SanBayDi, SB2.TenSanBay AS SanBayDen
			FROM LICHCHUYENBAY LCB, TUYENBAY TB, SANBAY SB1, SANBAY SB2
			WHERE LCB.MaTuyenBay = TB.MaTuyenBay AND TB.MaSanBayDi = SB1.MaSanBay  AND TB.MaSanBayDen = SB2.MaSanBay) TEMP
	WHERE CHUYENBAY.MaChuyenBay = TEMP.MaChuyenBay AND DATEDIFF(day,TEMP.KhoiHanh,@DenNgay) <= 0 AND DATEDIFF(day,TEMP.KhoiHanh,@TuNgay) > = 0
END
GO


CREATE PROCEDURE SELECT_TONGDOANHTHU_BY_MACHUYENBAY
@MaChuyenBay varchar(10)
AS
BEGIN
		SELECT DOANHTHU.MaChuyenBay, MONTH(DOANHTHU.KhoiHanh) AS Thang, YEAR(DOANHTHU.KhoiHanh) AS Nam, COUNT(DOANHTHU.MaChuyenBay) AS SoVe, SUM(DOANHTHU.GiaVe) AS DoanhThu 
		FROM
			(SELECT CT_PHIEUDATCHO.MaChuyenBay, LICHCHUYENBAY.KhoiHanh, LICHCHUYENBAY.GiaVe * HANGVE.TiLeDonGia AS [GiaVe]
			FROM CT_PHIEUDATCHO, HANGVE, LICHCHUYENBAY
			WHERE  CT_PHIEUDATCHO.MaChuyenBay = @MaChuyenBay AND CT_PHIEUDATCHO.MaHangVe = HANGVE.MaHangVe AND CT_PHIEUDATCHO.MaChuyenBay = LICHCHUYENBAY.MaChuyenBay
			AND CT_PHIEUDATCHO.LayVe = 'true') DOANHTHU
		GROUP BY DOANHTHU.MaChuyenBay, DOANHTHU.KhoiHanh
END
GO


CREATE PROCEDURE SELECT_MAX_MAPHIEUDATCHO
AS
BEGIN
	SELECT MAX(A.CONSO) AS MAXNUMBER
	FROM
	(SELECT STUFF(MaPhieuDatCho, 1, 2,'') AS CONSO FROM CT_PHIEUDATCHO) A 
END
GO

--Nhat
CREATE PROCEDURE SELECT_LAST_MAPHIEUDATCHO
AS
BEGIN
	SELECT TOP 1 MaPhieuDatCho
	FROM
		[dbo].[CT_PHIEUDATCHO]
	ORDER BY 
		MaPhieuDatCho DESC
END
GO

insert into DIADIEM values ('DD1', N'Việt Nam', N'Côn Đảo')
insert into DIADIEM values ('DD2', N'Việt Nam', N'Bình Định')
insert into DIADIEM values ('DD3', N'Việt Nam', N'Cà Mau')
insert into DIADIEM values ('DD4', N'Việt Nam', N'Cần Thơ')
insert into DIADIEM values ('DD5', N'Việt Nam', N'Buôn Ma Thuột')
insert into DIADIEM values ('DD6', N'Việt Nam', N'Đà Nẵng')
insert into DIADIEM values ('DD7', N'Việt Nam', N'Điện Biên Phủ')
insert into DIADIEM values ('DD8', N'Việt Nam', N'Hà Nội')
insert into DIADIEM values ('DD9', N'Việt Nam', N'Hồ Chí Minh')
insert into DIADIEM values ('DD10', N'Việt Nam', N'Phú Quốc')

insert into SANBAY values ('VVCS', N'Sân bay Côn Đảo', 'DD1')
insert into SANBAY values ('VVPC', N'Sân bay Phù Cát', 'DD2')
insert into SANBAY values ('VVCM', N'Sân bay Cà Mau', 'DD3')
insert into SANBAY values ('VVCT', N'Sân bay quốc tế Cần Thơ', 'DD4')
insert into SANBAY values ('VVBM', N'Sân bay Buôn Ma Thuột', 'DD5')
insert into SANBAY values ('VVDN', N'Sân bay quốc tế Đà Nẵng', 'DD6')
insert into SANBAY values ('VVDB', N'Sân bay Điện Biên Phủ', 'DD7')
insert into SANBAY values ('VVNB', N'Sân bay quốc tế Nội Bài', 'DD8')
insert into SANBAY values ('VVTS', N'Sân bay quốc tế Tân Sơn Nhất', 'DD9')
insert into SANBAY values ('VVPQ', N'Sân bay quốc tế Phú Quốc', 'DD10')

insert into TUYENBAY values ('VVCS_VVPC','VVCS','VVPC')
insert into TUYENBAY values ('VVCS_VVCT','VVCS','VVCT')
insert into TUYENBAY values ('VVCT_VVDB','VVCT','VVDB')
insert into TUYENBAY values ('VVTS_VVPQ','VVTS','VVPQ')
insert into TUYENBAY values ('VVNB_VVTS','VVNB','VVTS')

insert into THAMSO values (30, 2, 10, 20, 1, 1)

insert into HANGVE values ('HV01', N'Vé loại 1', 1.05)
insert into HANGVE values ('HV02', N'Vé loại 2', 1.0)

	
insert into NHANVIEN values('1', N'Dư Phát Tài', 'duphattai','duphattai', 1, 'Ktx', '')
insert into NHANVIEN values('2', N'Lê Tuấn Anh', 'letuananh','letuananh', 2, 'Ktx', '')
insert into NHANVIEN values('3', N'Admin', 'admin','admin', 0, 'Ktx', '')