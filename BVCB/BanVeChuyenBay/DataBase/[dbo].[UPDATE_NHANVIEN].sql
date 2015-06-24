ALTER PROCEDURE [dbo].[UPDATE_NHANVIEN]
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
		IF (@MatKhau is null or @MatKhau = '')
			UPDATE NHANVIEN
			SET TenNhanVien = @TenNhanVien, TenDangNhap = @TenDangNhap, QuyenHan = @QuyenHan,
				DiaChi = @DiaChi, DienThoai = @DienThoai
			WHERE MaNhanVien = @MaNhanVien
		ELSE
			UPDATE NHANVIEN
			SET TenNhanVien = @TenNhanVien, TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, QuyenHan = @QuyenHan,
				DiaChi = @DiaChi, DienThoai = @DienThoai
			WHERE MaNhanVien = @MaNhanVien
END