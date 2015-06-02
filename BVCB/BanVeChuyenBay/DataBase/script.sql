CREATE PROCEDURE [dbo].[DELETE_BAOCAODOANHTHUCHUYENBAY]
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
/****** Object:  StoredProcedure [dbo].[DELETE_BAOCAODOANHTHUNAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DELETE_BAOCAODOANHTHUNAM]
(
@Nam int
)
AS
BEGIN
	DELETE FROM BAOCAODOANHTHUNAM
	WHERE Nam = @Nam
END

GO
/****** Object:  StoredProcedure [dbo].[DELETE_BAOCAODOANHTHUTHANG]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DELETE_BAOCAODOANHTHUTHANG]
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
/****** Object:  StoredProcedure [dbo].[DELETE_CT_GHE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DELETE_CT_GHE]
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
/****** Object:  StoredProcedure [dbo].[DELETE_CT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DELETE_CT_LICHCHUYENBAY]
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

GO
/****** Object:  StoredProcedure [dbo].[DELETE_CT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DELETE_CT_PHIEUDATCHO]
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
/****** Object:  StoredProcedure [dbo].[DELETE_CT_PHIEUDATCHO_BY_MACHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DELETE_CT_PHIEUDATCHO_BY_MACHUYENBAY]
@MaChuyenBay varchar(10)
as
begin
	IF(EXISTS (SELECT * FROM CT_PHIEUDATCHO WHERE CT_PHIEUDATCHO.MaChuyenBay = @MaChuyenBay))
	BEGIN
	DELETE FROM CT_PHIEUDATCHO
	WHERE MaChuyenBay = @MaChuyenBay
	END
end

GO
/****** Object:  StoredProcedure [dbo].[DELETE_HANGVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DELETE_HANGVE]
(
	@MaHangVe varchar(10)
)
as
begin
	DELETE FROM HANGVE
	WHERE MaHangVe = @MaHangVe
end

GO
/****** Object:  StoredProcedure [dbo].[DELETE_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DELETE_LICHCHUYENBAY]
@MaChuyenBay varchar(10)
AS
BEGIN
	IF(EXISTS (SELECT * FROM LICHCHUYENBAY WHERE LICHCHUYENBAY.MaChuyenBay = @MaChuyenBay))
	BEGIN
		DELETE FROM LICHCHUYENBAY WHERE LICHCHUYENBAY.MaChuyenBay = @MaChuyenBay
	END
END

GO
/****** Object:  StoredProcedure [dbo].[DELETE_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DELETE_PHIEUDATCHO]
@MaPhieuDatCho varchar(10)
as
begin
	IF(EXISTS (SELECT * FROM PHIEUDATCHO WHERE PHIEUDATCHO.MaPhieuDatCho = @MaPhieuDatCho))
	BEGIN
	DELETE FROM PHIEUDATCHO
	WHERE MaPhieuDatCho = @MaPhieuDatCho
	END
end

GO
/****** Object:  StoredProcedure [dbo].[DELETE_SANBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[DELETE_SANBAY]
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

GO
/****** Object:  StoredProcedure [dbo].[DELETE_TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DELETE_TUYENBAY]
@MaTuyenBay varchar(10)
as
begin
	IF(EXISTS (SELECT * FROM TUYENBAY WHERE TUYENBAY.MaTuyenBay = @MaTuyenBay))
	BEGIN
	DELETE FROM TUYENBAY
	WHERE MaTuyenBay = @MaTuyenBay
	END
end

GO
/****** Object:  StoredProcedure [dbo].[INSERT_BAOCAODOANHTHUCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------

CREATE PROCEDURE [dbo].[INSERT_BAOCAODOANHTHUCHUYENBAY]
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
/****** Object:  StoredProcedure [dbo].[INSERT_BAOCAODOANHTHUNAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---- BM 5.1---

CREATE PROCEDURE [dbo].[INSERT_BAOCAODOANHTHUNAM]
(
@Nam int,
@TongDoanhThu money
)
AS
BEGIN
	INSERT INTO BAOCAODOANHTHUNAM VALUES (@Nam, @TongDoanhThu)
END

GO
/****** Object:  StoredProcedure [dbo].[INSERT_BAOCAODOANHTHUTHANG]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------
CREATE PROCEDURE [dbo].[INSERT_BAOCAODOANHTHUTHANG]
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
/****** Object:  StoredProcedure [dbo].[INSERT_CT_GHE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------


CREATE PROCEDURE [dbo].[INSERT_CT_GHE]
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
/****** Object:  StoredProcedure [dbo].[INSERT_CT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



------------------------------
CREATE PROCEDURE [dbo].[INSERT_CT_LICHCHUYENBAY]
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

GO
/****** Object:  StoredProcedure [dbo].[INSERT_CT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------
CREATE PROCEDURE [dbo].[INSERT_CT_PHIEUDATCHO]
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
/****** Object:  StoredProcedure [dbo].[INSERT_HANGVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-----------------------------------
CREATE PROCEDURE [dbo].[INSERT_HANGVE]
(
	@MaHangVe varchar(10),
	@TenHangVe varchar(50),
	@GiaVe FLOAT
)
as
begin
	INSERT INTO HANGVE VALUES(@MaHangVe, @TenHangVe, @GiaVe)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------
CREATE PROCEDURE [dbo].[INSERT_LICHCHUYENBAY] 
(
	-- Add the parameters for the stored procedure here
	@MaChuyenBay varchar(10),
	@MaTuyenBay varchar(10),
	@KhoiHanh datetime,
	@ThoiGianBay int,
	@GiaVe money
)
AS
BEGIN
	INSERT INTO LICHCHUYENBAY VALUES (@MaChuyenBay, @MaTuyenBay, @KhoiHanh, @ThoiGianBay, @GiaVe)
END

GO
/****** Object:  StoredProcedure [dbo].[INSERT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------------
CREATE PROCEDURE [dbo].[INSERT_PHIEUDATCHO]
@MaPhieuDatCho varchar(10),
@NguoiDat nvarchar(50),
@CMND varchar(20),
@DienThoai varchar(20),
@NgayDat datetime
as
begin
	INSERT INTO PHIEUDATCHO VALUES(@MaPhieuDatCho, @NguoiDat, @CMND, @DienThoai, @NgayDat)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERT_SANBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERT_SANBAY]
(
@MaSanBay varchar(10),
@TenSanBay varchar(100)
)
as
begin
	INSERT INTO SANBAY VALUES(@MaSanBay, @TenSanBay)
end

GO
/****** Object:  StoredProcedure [dbo].[INSERT_TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------
CREATE PROCEDURE [dbo].[INSERT_TUYENBAY]
@MaTuyenBay varchar(10),
@MaSanBayDi varchar(10),
@MaSanBayDen varchar(10)
as
begin
	INSERT INTO TUYENBAY VALUES(@MaTuyenBay, @MaSanBayDi, @MaSanBayDen)
end

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_DELETE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[NHANVIEN_DELETE]
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

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_INSERT]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[NHANVIEN_INSERT]
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
/****** Object:  StoredProcedure [dbo].[NHANVIEN_SELECT_ALL]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NHANVIEN_SELECT_ALL]
AS
BEGIN
	SELECT NHANVIEN.MaNhanVien, NHANVIEN.TenNhanVien, NHANVIEN.DiaChi, NHANVIEN.DienThoai, NHANVIEN.TenDangNhap, NHANVIEN.MatKhau, NHANVIEN.QuyenHan FROM NHANVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_SELECT_DANGNHAP]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_SELECT_DANGNHAP]
(
	@TenDangNhap nvarchar(50),
	@MatKhau varchar(50)
)
as
begin
	SELECT NHANVIEN.MaNhanVien, NHANVIEN.TenNhanVien,  NHANVIEN.TenDangNhap, NHANVIEN.MatKhau, NHANVIEN.QuyenHan, NHANVIEN.DiaChi, NHANVIEN.DienThoai FROM NHANVIEN WHERE TenDangNhap=@TenDangNhap AND MatKhau = @MatKhau
end

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_SELECT_MANHANVIEN]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[NHANVIEN_SELECT_MANHANVIEN]
(
	@MaNhanVien varchar(10)
)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_CT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_ALL_CT_PHIEUDATCHO]
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_HANGVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_ALL_HANGVE]
AS
BEGIN
	SELECT HANGVE.MaHangVe, HANGVE.TenHangVe, HANGVE.TiLeDonGia FROM HANGVE
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_ALL_LICHCHUYENBAY]
AS
BEGIN
	SELECT  A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM LICHCHUYENBAY A
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_LICHCHUYENBAY_BY_QD3]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_ALL_LICHCHUYENBAY_BY_QD3]
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
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_LICHCHUYENBAY_NOTPLANE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_ALL_LICHCHUYENBAY_NOTPLANE]
AS
BEGIN
	SELECT  A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM
	(SELECT F.MaChuyenBay, F.MaTuyenBay, F.KhoiHanh, F.ThoiGianBay, F.GiaVe, DATEDIFF(day, GETDATE(), F.KhoiHanh) AS SUBDATE , DATEDIFF(MINUTE, GETDATE(), F.KhoiHanh) AS SUBTIME FROM LICHCHUYENBAY F) A	
	WHERE A.SUBDATE >= 0 AND A.SUBTIME > 0
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_LICHCHUYENBAY_PLANED]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_ALL_LICHCHUYENBAY_PLANED]
AS
BEGIN
	SELECT  A.MaChuyenBay, A.MaTuyenBay, A.KhoiHanh, A.ThoiGianBay, A.GiaVe
	FROM
	(SELECT F.MaChuyenBay, F.MaTuyenBay, F.KhoiHanh, F.ThoiGianBay, F.GiaVe, DATEDIFF(day, GETDATE(), F.KhoiHanh) AS SUBDATE , DATEDIFF(MINUTE, GETDATE(), F.KhoiHanh) AS SUBTIME FROM LICHCHUYENBAY F) A	
	WHERE A.SUBDATE <= 0 AND A.SUBTIME < 0
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_ALL_PHIEUDATCHO]
AS
BEGIN
	SELECT PHIEUDATCHO.MaPhieuDatCho, PHIEUDATCHO.NguoiDat, PHIEUDATCHO.CMND, PHIEUDATCHO.DienThoai, PHIEUDATCHO.NgayDat FROM PHIEUDATCHO
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_SANBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SELECT_ALL_SANBAY]
AS
BEGIN
	SELECT SANBAY.MaSanBay, SANBAY.TenSanBay FROM SANBAY
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_THAMSO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------

CREATE PROCEDURE [dbo].[SELECT_ALL_THAMSO]
AS
BEGIN
	SELECT THAMSO.SoSanBayTrungGianToiDa, THAMSO.ThoiGianDungToiDa, THAMSO.ThoiGianDungToiThieu, THAMSO.ThoiGianBayToiThieu, THAMSO.TGChamNhatDatVe, THAMSO.TGChamNhatHuyDatVe
	FROM THAMSO
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_ALL_TUYENBAY]
AS
BEGIN
	SELECT TUYENBAY.MaTuyenBay, TUYENBAY.MaSanBayDi, TUYENBAY.MaSanBayDen FROM TUYENBAY
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_COLUMNS_TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SELECT_AT_COLUMNS_TUYENBAY]
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
/****** Object:  StoredProcedure [dbo].[SELECT_AT_CT_GHE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_AT_CT_GHE]
@MaChuyenBay varchar(10),
@MaHangVe varchar(10)
AS
BEGIN
	SELECT CT_GHE.MaChuyenBay, CT_GHE.MaHangVe, CT_GHE.SoGhe ,CT_GHE.SoGheDat, CT_GHE.SoGheTrong FROM CT_GHE WHERE CT_GHE.MaChuyenBay = @MaChuyenBay AND CT_GHE.MaHangVe = @MaHangVe
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_CT_GHE_BY_MACHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_AT_CT_GHE_BY_MACHUYENBAY]
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT CT_GHE.MaChuyenBay, CT_GHE.MaHangVe, CT_GHE.SoGhe ,CT_GHE.SoGheDat, CT_GHE.SoGheTrong FROM CT_GHE WHERE CT_GHE.MaChuyenBay = @MaChuyenBay
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_CT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_AT_CT_LICHCHUYENBAY]
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT CT.MaChuyenBay, CT.MaSanBayTrungGian, SB.TenSanBay AS SanBayTrungGian, CT.ThoiGianDung, CT.GhiChu FROM CT_LICHCHUYENBAY CT, SANBAY SB
	WHERE CT.MaChuyenBay = @MaChuyenBay AND CT.MaSanBayTrungGian = SB.MaSanBay
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_CT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_AT_CT_PHIEUDATCHO]
@MaPhieuDatCho varchar(10),
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F WHERE F.MaPhieuDatCho = @MaPhieuDatCho AND F.MaChuyenBay = @MaChuyenBay
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY]
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F WHERE F.MaChuyenBay = @MaChuyenBay
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY_LAYVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_AT_CT_PHIEUDATCHO_BY_MACHUYENBAY_LAYVE]
@MaChuyenBay varchar(10),
@LayVe bit
AS
BEGIN
	SELECT F.MaPhieuDatCho, F.MaChuyenBay, F.HanhKhachBay, F.CMND, F.DienThoai, F.MaHangVe, F.LayVe FROM CT_PHIEUDATCHO F WHERE F.MaChuyenBay = @MaChuyenBay AND LayVe = @LayVe
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_HANGVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_AT_HANGVE]
@MaHangVe varchar(10)
AS
BEGIN
	SELECT HANGVE.MaHangVe, HANGVE.TenHangVe, HANGVE.TiLeDonGia FROM HANGVE WHERE HANGVE.MaHangVe = @MaHangVe
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_AT_LICHCHUYENBAY]
@MaChuyenBay varchar(10)
AS
BEGIN
	SELECT LICHCHUYENBAY.MaChuyenBay, LICHCHUYENBAY.MaTuyenBay, LICHCHUYENBAY.KhoiHanh, LICHCHUYENBAY.ThoiGianBay, LICHCHUYENBAY.GiaVe FROM LICHCHUYENBAY WHERE LICHCHUYENBAY.MaChuyenBay = @MaChuyenBay
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_AT_PHIEUDATCHO]
@MaPhieuDatCho varchar(10)
AS
BEGIN
	SELECT PHIEUDATCHO.MaPhieuDatCho, PHIEUDATCHO.NguoiDat, PHIEUDATCHO.CMND, PHIEUDATCHO.DienThoai, PHIEUDATCHO.NgayDat FROM PHIEUDATCHO WHERE MaPhieuDatCho = @MaPhieuDatCho
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_SANBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_AT_SANBAY]
@MaSanBay varchar(10)
AS
BEGIN
	SELECT SANBAY.MaSanBay, SANBAY.TenSanBay FROM SANBAY WHERE MaSanBay = @MaSanBay 
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_AT_TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_AT_TUYENBAY]
@MaTuyenBay varchar(10)
AS
BEGIN
	SELECT TUYENBAY.MaTuyenBay, TUYENBAY.MaSanBayDi, TUYENBAY.MaSanBayDen FROM TUYENBAY WHERE TUYENBAY.MaTuyenBay = @MaTuyenBay
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_BAOCAODOANHTHUCHUYENBAY_BY_NAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SELECT_BAOCAODOANHTHUCHUYENBAY_BY_NAM]
@Nam int
AS
BEGIN
	SELECT A.MaChuyenBay, A.SoVe, A.DoanhThu, A.Thang, A.Nam, A.TiLe
	FROM  BAOCAODOANHTHUCHUYENBAY A,
	(SELECT LCB.MaChuyenBay, DATEDIFF(MINUTE, GETDATE(), LCB.KhoiHanh) as SUBDATE  FROM LICHCHUYENBAY LCB WHERE YEAR(LCB.KhoiHanh) = @Nam) B
	WHERE A.Nam = @Nam AND A.MaChuyenBay = B.MaChuyenBay AND B.SUBDATE <= 0
	
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_BAOCAODOANHTHUCHUYENBAY_BY_THANGNAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SELECT_BAOCAODOANHTHUCHUYENBAY_BY_THANGNAM]
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
/****** Object:  StoredProcedure [dbo].[SELECT_BAOCAODOANHTHUTHANG_BY_NAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_BAOCAODOANHTHUTHANG_BY_NAM]
@Nam int
AS
BEGIN
	SELECT A.Thang, A.Nam, A.DoanhThu, A.SoChuyenBay, A.TiLe  FROM BAOCAODOANHTHUTHANG A WHERE A.Nam = @Nam
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_BAOCAODOANHTHUTHANG_BY_THANGNAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_BAOCAODOANHTHUTHANG_BY_THANGNAM]
@Thang int,
@Nam int
AS
BEGIN
	SELECT A.Thang, A.Nam, A.DoanhThu, A.SoChuyenBay, A.TiLe  FROM BAOCAODOANHTHUTHANG A WHERE A.Nam = @Nam AND A.Thang = @Thang
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_MAX_MAPHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SELECT_MAX_MAPHIEUDATCHO]
AS
BEGIN
	SELECT MAX(A.CONSO) AS MAXNUMBER
	FROM
	(SELECT STUFF(MaPhieuDatCho, 1, 2,'') AS CONSO FROM CT_PHIEUDATCHO) A 
END

GO
/****** Object:  StoredProcedure [dbo].[SELECT_TONGDOANHTHU_BY_MACHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_TONGDOANHTHU_BY_MACHUYENBAY]
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
/****** Object:  StoredProcedure [dbo].[SELECT_TRACUUCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SELECT_TRACUUCHUYENBAY]
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
	WHERE CHUYENBAY.MaChuyenBay = TEMP.MaChuyenBay AND TEMP.KhoiHanh <= @DenNgay AND TEMP.KhoiHanh >= @TuNgay
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_BAOCAODOANHTHUCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_BAOCAODOANHTHUCHUYENBAY]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_BAOCAODOANHTHUNAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UPDATE_BAOCAODOANHTHUNAM]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_BAOCAODOANHTHUTHANG]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_BAOCAODOANHTHUTHANG]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_CT_GHE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[UPDATE_CT_GHE]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_CT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_CT_LICHCHUYENBAY]
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

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UPDATE_CT_PHIEUDATCHO]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_HANGVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_HANGVE]
(
	@MaHangVe varchar(10),
	@TenHangVe varchar(50),
	@GiaVe FLOAT
)
as
begin
	UPDATE HANGVE
	SET TenHangVe = @TenHangVe, TiLeDonGia = @GiaVe
	WHERE MaHangVe = @MaHangVe
end

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_LICHCHUYENBAY] 
(
	-- Add the parameters for the stored procedure here
	@MaChuyenBay varchar(100),
	@MaTuyenBay varchar(10),
	@KhoiHanh datetime,
	@ThoiGianBay int,
	@GiaVe money
)
AS
BEGIN
	UPDATE LICHCHUYENBAY
	SET MaTuyenBay = @MaTuyenBay, ThoiGianBay = @ThoiGianBay, KhoiHanh = @KhoiHanh, GiaVe = @GiaVe
	WHERE MaChuyenBay = @MaChuyenBay
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_NHANVIEN]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UPDATE_NHANVIEN]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_NHANVIEN_MATKHAU]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_NHANVIEN_MATKHAU]
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

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UPDATE_PHIEUDATCHO]
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

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_SANBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_SANBAY]
(
@MaSanBay varchar(10),
@TenSanBay varchar(100)
)
as
begin
		UPDATE SANBAY
		SET TenSanBay = @TenSanBay
		WHERE MaSanBay = @MaSanBay
end

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_THAMSO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UPDATE_THAMSO]
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
/****** Object:  StoredProcedure [dbo].[UPDATE_TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_TUYENBAY]
@MaTuyenBay varchar(10),
@MaSanBayDi varchar(10),
@MaSanBayDen varchar(10)
as
begin
	UPDATE TUYENBAY
	SET MaSanBayDi = @MaSanBayDi, MaSanBayDen = @MaSanBayDen
	WHERE MaTuyenBay = @MaTuyenBay
end

GO
/****** Object:  Table [dbo].[BAOCAODOANHTHUCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAOCAODOANHTHUCHUYENBAY](
	[MaChuyenBay] [varchar](10) NOT NULL,
	[SoVe] [int] NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[DoanhThu] [money] NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_CT_DOANHTHUTHANG] PRIMARY KEY CLUSTERED 
(
	[Nam] ASC,
	[Thang] ASC,
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BAOCAODOANHTHUNAM]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAODOANHTHUNAM](
	[Nam] [int] NOT NULL,
	[TongDoanhThu] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BAOCAODOANHTHUTHANG]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAODOANHTHUTHANG](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[SoChuyenBay] [int] NULL,
	[DoanhThu] [money] NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_BAOCAODOANHTHUTHANG] PRIMARY KEY CLUSTERED 
(
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_GHE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_GHE](
	[MaChuyenBay] [varchar](10) NOT NULL,
	[MaHangVe] [varchar](10) NOT NULL,
	[SoGhe] [int] NULL,
	[SoGheDat] [int] NULL,
	[SoGheTrong] [int] NULL,
 CONSTRAINT [PK_CT_GHE] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC,
	[MaHangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_LICHCHUYENBAY](
	[MaChuyenBay] [varchar](10) NOT NULL,
	[MaSanBayTrungGian] [varchar](10) NOT NULL,
	[ThoiGianDung] [int] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_CT_LICHCHUYENBAY] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC,
	[MaSanBayTrungGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUDATCHO](
	[MaPhieuDatCho] [varchar](10) NOT NULL,
	[MaChuyenBay] [varchar](10) NOT NULL,
	[HanhKhachBay] [nvarchar](50) NULL,
	[CMND] [varchar](20) NULL,
	[DienThoai] [varchar](20) NULL,
	[MaHangVe] [varchar](10) NULL,
	[LayVe] [bit] NULL,
 CONSTRAINT [PK_CT_PHIEUDATCHO] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC,
	[MaPhieuDatCho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGVE]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGVE](
	[MaHangVe] [varchar](10) NOT NULL,
	[TenHangVe] [nvarchar](50) NULL,
	[TiLeDonGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LICHCHUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LICHCHUYENBAY](
	[MaChuyenBay] [varchar](10) NOT NULL,
	[MaTuyenBay] [varchar](10) NULL,
	[KhoiHanh] [datetime] NULL,
	[ThoiGianBay] [int] NULL,
	[GiaVe] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[QuyenHan] [int] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUDATCHO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUDATCHO](
	[MaPhieuDatCho] [varchar](10) NOT NULL,
	[NguoiDat] [nvarchar](50) NULL,
	[CMND] [varchar](20) NULL,
	[DienThoai] [varchar](20) NULL,
	[NgayDat] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatCho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANBAY](
	[MaSanBay] [varchar](10) NOT NULL,
	[TenSanBay] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[ThoiGianBayToiThieu] [int] NULL,
	[SoSanBayTrungGianToiDa] [int] NULL,
	[ThoiGianDungToiThieu] [int] NULL,
	[ThoiGianDungToiDa] [int] NULL,
	[TGChamNhatHuyDatVe] [bit] NULL,
	[TGChamNhatDatVe] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TUYENBAY]    Script Date: 22/05/2015 15:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TUYENBAY](
	[MaTuyenBay] [varchar](10) NOT NULL,
	[MaSanBayDi] [varchar](10) NULL,
	[MaSanBayDen] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BAOCAODOANHTHUCHUYENBAY] ([MaChuyenBay], [SoVe], [Thang], [Nam], [DoanhThu], [TiLe]) VALUES (N'1', 0, 2, 2015, 0.0000, 0)
INSERT [dbo].[BAOCAODOANHTHUCHUYENBAY] ([MaChuyenBay], [SoVe], [Thang], [Nam], [DoanhThu], [TiLe]) VALUES (N'12', 0, 2, 2015, 0.0000, 0)
INSERT [dbo].[BAOCAODOANHTHUCHUYENBAY] ([MaChuyenBay], [SoVe], [Thang], [Nam], [DoanhThu], [TiLe]) VALUES (N'123', 0, 2, 2015, 0.0000, 0)
INSERT [dbo].[BAOCAODOANHTHUTHANG] ([Thang], [Nam], [SoChuyenBay], [DoanhThu], [TiLe]) VALUES (10, 2014, 0, 0.0000, 0)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'1', N'A1', 12, 0, 12)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'1', N'HV01', 12, 0, 12)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'1', N'HV02', 12, 0, 12)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'12', N'A1', 123, 0, 123)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'12', N'HV01', 123, 0, 123)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'12', N'HV02', 123, 0, 123)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'123', N'A1', 1, 0, 1)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'123', N'HV01', 1, 0, 1)
INSERT [dbo].[CT_GHE] ([MaChuyenBay], [MaHangVe], [SoGhe], [SoGheDat], [SoGheTrong]) VALUES (N'123', N'HV02', 1, 0, 1)
INSERT [dbo].[CT_LICHCHUYENBAY] ([MaChuyenBay], [MaSanBayTrungGian], [ThoiGianDung], [GhiChu]) VALUES (N'1', N'VVBM', 10, N'123')
INSERT [dbo].[CT_LICHCHUYENBAY] ([MaChuyenBay], [MaSanBayTrungGian], [ThoiGianDung], [GhiChu]) VALUES (N'12', N'VVCS', 12, N'')
INSERT [dbo].[CT_LICHCHUYENBAY] ([MaChuyenBay], [MaSanBayTrungGian], [ThoiGianDung], [GhiChu]) VALUES (N'12', N'VVDB', 12, N'')
INSERT [dbo].[CT_LICHCHUYENBAY] ([MaChuyenBay], [MaSanBayTrungGian], [ThoiGianDung], [GhiChu]) VALUES (N'123', N'VVCS', 12, N'')
INSERT [dbo].[CT_LICHCHUYENBAY] ([MaChuyenBay], [MaSanBayTrungGian], [ThoiGianDung], [GhiChu]) VALUES (N'123', N'VVDN', 11, N'')
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'A1', N'abc', 12)
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'HV01', N'Vé loại 1', 1.05)
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe], [TiLeDonGia]) VALUES (N'HV02', N'Vé loại 2', 1)
INSERT [dbo].[LICHCHUYENBAY] ([MaChuyenBay], [MaTuyenBay], [KhoiHanh], [ThoiGianBay], [GiaVe]) VALUES (N'1', N'VVCS_VVPC', CAST(0x0000A43901749B61 AS DateTime), 31, 1.0000)
INSERT [dbo].[LICHCHUYENBAY] ([MaChuyenBay], [MaTuyenBay], [KhoiHanh], [ThoiGianBay], [GiaVe]) VALUES (N'12', N'VVNB_VVTS', CAST(0x0000A439017FAB82 AS DateTime), 123, 123.0000)
INSERT [dbo].[LICHCHUYENBAY] ([MaChuyenBay], [MaTuyenBay], [KhoiHanh], [ThoiGianBay], [GiaVe]) VALUES (N'123', N'VVCS_VVPC', CAST(0x0000A439017B63E1 AS DateTime), 123, 123.0000)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [QuyenHan], [DiaChi], [DienThoai]) VALUES (N'1', N'Dư Phát Tài', N'duphattai', N'duphattai', 0, N'Ktx', N'')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [QuyenHan], [DiaChi], [DienThoai]) VALUES (N'2', N'Lê Tuấn Anh', N'letuananh', N'letuananh', 2, N'Ktx', N'')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [QuyenHan], [DiaChi], [DienThoai]) VALUES (N'3', N'Admin', N'admin', N'admin', 1, N'Ktx', N'')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVBM', N'Sân bay Buôn Ma Thuột')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVCM', N'Sân bay Cà Mau')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVCS', N'Sân bay Côn Đảo')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVCT', N'Sân bay quốc tế Cần Thơ')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVDB', N'Sân bay Điện Biên Phủ')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVDN', N'Sân bay quốc tế Đà Nẵng')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVNB', N'Sân bay quốc tế Nội Bài')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVPC', N'Sân bay Phù Cát')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVPQ', N'Sân bay qu?c t? 69')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'VVTS', N'Sân bay quốc tế Tân Sơn Nhất')
INSERT [dbo].[THAMSO] ([ThoiGianBayToiThieu], [SoSanBayTrungGianToiDa], [ThoiGianDungToiThieu], [ThoiGianDungToiDa], [TGChamNhatHuyDatVe], [TGChamNhatDatVe]) VALUES (30, 2, 10, 20, 1, 1)
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VVCM_VVCT', N'VVCM', N'VVCT')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VVCS_VVCT', N'VVCS', N'VVCT')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VVCS_VVPC', N'VVCS', N'VVPC')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VVCT_VVDB', N'VVCT', N'VVDB')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VVNB_VVTS', N'VVNB', N'VVTS')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VVTS_VVPQ', N'VVTS', N'VVPQ')
ALTER TABLE [dbo].[BAOCAODOANHTHUCHUYENBAY]  WITH CHECK ADD FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LICHCHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[CT_GHE]  WITH CHECK ADD FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LICHCHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[CT_GHE]  WITH CHECK ADD FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[CT_LICHCHUYENBAY]  WITH CHECK ADD FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LICHCHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[CT_LICHCHUYENBAY]  WITH CHECK ADD FOREIGN KEY([MaSanBayTrungGian])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[CT_PHIEUDATCHO]  WITH CHECK ADD FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[LICHCHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[CT_PHIEUDATCHO]  WITH CHECK ADD FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[CT_PHIEUDATCHO]  WITH CHECK ADD FOREIGN KEY([MaPhieuDatCho])
REFERENCES [dbo].[PHIEUDATCHO] ([MaPhieuDatCho])
GO
ALTER TABLE [dbo].[LICHCHUYENBAY]  WITH CHECK ADD FOREIGN KEY([MaTuyenBay])
REFERENCES [dbo].[TUYENBAY] ([MaTuyenBay])
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD FOREIGN KEY([MaSanBayDi])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD FOREIGN KEY([MaSanBayDen])
REFERENCES [dbo].[SANBAY] ([MaSanBay])