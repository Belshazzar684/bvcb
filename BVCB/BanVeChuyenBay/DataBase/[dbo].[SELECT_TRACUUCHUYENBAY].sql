
ALTER PROCEDURE [dbo].[SELECT_TRACUUCHUYENBAY]
@MaChuyenBay varchar(10) = NULL,
@MaSanBayDi varchar(10) = NULL,
@MaSanBayDen varchar(10) = NULL,
@NgayKhoiHanhMin datetime = NULL,
@NgayKhoiHanhMax datetime = NULL,
@GiaVeMin money = NULL,
@GiaVeMax money = NULL,
@TinhTrangGheTrong bit = NULL
AS
BEGIN
	SELECT	lcb.MaChuyenBay,
			sbdi.TenSanBay AS SanBayDi,
			sbden.TenSanBay As SanBayDen,
			lcb.KhoiHanh,
			lcb.ThoiGianBay,
			CB_SOGHE.SoGheTrong,
			lcb.GiaVe

	FROM	LICHCHUYENBAY lcb,
			TUYENBAY tb,
			SANBAY sbdi,
			SANBAY sbden,
			(SELECT CT_GHE.MaChuyenBay, SUM(CT_GHE.SoGheTrong) AS SoGheTrong 
			FROM CT_GHE
			GROUP BY CT_GHE.MaChuyenBay) CB_SOGHE

	WHERE (lcb.MaTuyenBay = tb.MaTuyenBay
			AND tb.MaSanBayDi = sbdi.MaSanBay
			AND tb.MaSanBayDen = sbden.MaSanBay
			AND lcb.MaChuyenBay = CB_SOGHE.MaChuyenBay)

			AND (@MaChuyenBay is NULL or @MaChuyenBay = '' or lcb.MaChuyenBay like '%' + @MaChuyenBay + '%')
			AND (@MaSanBayDi is NULL or @MaSanBayDi = '' or @MaSanBayDi = sbdi.MaSanBay)
			AND (@MaSanBayDen is NULL or @MaSanBayDen ='' or @MaSanBayDen = sbden.MaSanBay)
			AND ((@NgayKhoiHanhMin is NULL and @NgayKhoiHanhMax is NULL)
					OR (@NgayKhoiHanhMax is NULL and lcb.KhoiHanh >= @NgayKhoiHanhMin)
					OR (@NgayKhoiHanhMin is NULL and lcb.KhoiHanh <= @NgayKhoiHanhMax)
					OR (lcb.KhoiHanh between @NgayKhoiHanhMin and @NgayKhoiHanhMax))
			AND ((@GiaVeMin is NULL and @GiaVeMax is NULL)
					OR (@GiaVeMax is NULL and lcb.GiaVe >= @GiaVeMin)
					OR (@GiaVeMin is NULL and lcb.GiaVe <= @GiaVeMax)
					OR (lcb.GiaVe between @GiaVeMin and @GiaVeMax))
			AND ((@TinhTrangGheTrong is NULL)
					OR (@TinhTrangGheTrong = 1 and CB_SOGHE.SoGheTrong > 0)
					OR (@TinhTrangGheTrong = 0 and CB_SOGHE.SoGheTrong = 0))
END
