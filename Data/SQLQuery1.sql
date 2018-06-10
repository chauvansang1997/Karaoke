-- Thêm khách hàng
GO
ALTER PROCEDURE usp_ThemKhachHang
	@MAKH CHAR(7),
	@MALOAIKH INT,
	@TENKH NVARCHAR(50),
	@SDT NVARCHAR(11)
AS
BEGIN
	INSERT INTO dbo.KHACHHANG
	        ( MAKH, MALOAIKH, TENKH, SDT )
	VALUES  ( @MAKH, -- MAKH - char(7)
	          @MALOAIKH, -- MALOAIKH - int
	          @TENKH, -- TENKH - nvarchar(50)
	          @SDT  -- SDT - nvarchar(11)
	          )
END

EXECUTE	dbo.usp_ThemKhachHang @MAKH = 'KH0001', -- char(7)
    @MALOAIKH = 4, -- int
    @TENKH = N'Lê Minh', -- nvarchar(50)
    @SDT = '0123456789' -- nvarchar(11)

SELECT * FROM dbo.KHACHHANG


-- Cập nhật khách hàng
GO
ALTER PROCEDURE usp_CapNhatKhachHang
	@MAKH CHAR(7),
	@MALOAIKH INT,
	@TENKH NVARCHAR(50),
	@SDT NVARCHAR(11)
AS
BEGIN
	UPDATE dbo.KHACHHANG
	SET MALOAIKH = @MALOAIKH,
		TENKH = @TENKH,
		SDT = @SDT
	WHERE MAKH = @MAKH
END

EXECUTE dbo.usp_CapNhatKhachHang @MAKH = 'KH00010', -- char(7)
    @MALOAIKH = 2, -- int
    @TENKH = N'Phan Ngọc Thịnh', -- nvarchar(50)
    @SDT = N'0988690345' -- nvarchar(11)

SELECT * FROM dbo.KHACHHANG





-- Thêm loại khách hàng
ALTER PROCEDURE usp_ThemLoaiKhachHang
	@MALOAIKH INT,
	@TENLOAIKH NVARCHAR(50),
	@MUCKM FLOAT
AS
BEGIN
	INSERT INTO dbo.LOAIKHACHHANG
	        ( MALOAIKH, TENLOAIKH, MUCKM )
	VALUES  ( @MALOAIKH, -- MALOAIKH - int
	          @TENLOAIKH, -- TENLOAIKH - nvarchar(50)
	          @MUCKM  -- MUCKM - float
	          )
END

EXECUTE dbo.usp_ThemLoaiKhachHang @MALOAIKH = 5,
	@TENLOAIKH = N'xxxxxx',
	@MUCKM = 0.11111

SELECT * FROM dbo.LOAIKHACHHANG


-- Cập nhật loại khách hàng
ALTER PROCEDURE usp_CapNhatLoaiKhachHang
	@MALOAIKH INT,
	@TENLOAIKH NVARCHAR(50),
	@MUCKM FLOAT
AS
BEGIN
	UPDATE dbo.LOAIKHACHHANG
	SET TENLOAIKH = @TENLOAIKH,
		MUCKM = @MUCKM
	WHERE MALOAIKH = @MALOAIKH
END

EXECUTE dbo.usp_CapNhatLoaiKhachHang @MALOAIKH = 1,
		@TENLOAIKH = N'Thành viên',
		@MUCKM = 0.035

SELECT * FROM dbo.LOAIKHACHHANG


-- Xóa loại khách hàng
ALTER PROCEDURE usp_XoaLoaiKhachHang
	@MALOAIKH INT
AS
BEGIN
	DELETE FROM dbo.LOAIKHACHHANG
	WHERE MALOAIKH = @MALOAIKH
END

EXECUTE usp_XoaLoaiKhachHang @MALOAIKH = 5

SELECT * FROM dbo.LOAIKHACHHANG



-- Thêm khuyến mãi
GO
ALTER PROCEDURE usp_ThemKhuyenMai
	@MAKM INT,
	@TENKM NVARCHAR(50),
	@NGAYBD DATETIME,
	@NGAYKT DATETIME,
	@MUCKM FLOAT
AS
BEGIN
	INSERT INTO dbo.KHUYENMAI
	        ( MAKM, TENKM, NGAYBD, NGAYKT, MUCKM )
	VALUES  ( @MAKM, -- MAKM - int
	          @TENKM, -- TENKM - nvarchar(50)
	          @NGAYBD, -- NGAYBD - datetime
	          @NGAYKT, -- NGAYKT - datetime
	          @MUCKM  -- MUCKM - float
	          )
END

EXECUTE dbo.usp_ThemKhuyenMai @MAKM = 10, -- int
    @TENKM = N'Quốc tế thiếu nhi', -- nvarchar(50)
    @NGAYBD = '2018-05-31 00:00:00', -- datetime
    @NGAYKT = '2018-06-02 23:59:00', -- datetime
    @MUCKM = 0.1 -- float

SELECT * FROM dbo.KHUYENMAI


-- Cập nhật khuyến mãi
GO
ALTER PROCEDURE usp_CapNhatKhuyenMai
	@MAKM INT,
	@TENKM NVARCHAR(50),
	@NGAYBD DATETIME,
	@NGAYKT DATETIME,
	@MUCKM FLOAT
AS 
BEGIN
	UPDATE dbo.KHUYENMAI
	SET TENKM = @TENKM,
		NGAYBD = @NGAYBD,
		NGAYKT = @NGAYKT,
		MUCKM = @MUCKM
	WHERE MAKM = @MAKM 
END

EXECUTE dbo.usp_CapNhatKhuyenMai @MAKM = 10, -- int
    @TENKM = N'Quốc tế thiếu nhi', -- nvarchar(50)
    @NGAYBD = '2018-05-31 00:00:00', -- datetime
    @NGAYKT = '2018-06-02 23:59:00', -- datetime
    @MUCKM = 0.15 -- float

SELECT * FROM dbo.KHUYENMAI


-- Xóa khuyến mãi
GO 
ALTER PROCEDURE usp_XoaKhuyenMai
	@MAKM INT
AS
BEGIN
	DELETE FROM dbo.KHUYENMAI
	WHERE MAKM = @MAKM

END

EXECUTE dbo.usp_XoaKhuyenMai @MAKM = 10 -- int

SELECT * FROM dbo.KHUYENMAI



-- Tính doanh thu ngày
GO
CREATE PROCEDURE usp_TinhDoanhThuNgay
	@NGAY DATE
AS
BEGIN
	SELECT NGAYTHANHTOAN AS NGAY, SUM (THANHTIEN) AS DOANHTHU
	FROM dbo.HOADON
	WHERE TRANGTHAI = N'Đã thanh toán' AND NGAYTHANHTOAN = @NGAY
	GROUP BY NGAYTHANHTOAN
END



-- Tạo tài khoản mới
GO
ALTER PROCEDURE usp_TaoTaiKhoan 
	@TENTK VARCHAR(20),
	@MATKHAU VARCHAR(20)
AS
BEGIN
	INSERT INTO dbo.TAIKHOAN
	        ( TENTK, MATKHAU )
	VALUES  ( @TENTK, -- TENTK - varchar(20)
	          @MATKHAU  -- MATKHAU - varchar(20)
	          )
END


-- Xóa tài khoản
GO
ALTER PROCEDURE usp_XoaTaiKhoan
	@TENTK VARCHAR(20)
AS
BEGIN
	DELETE FROM dbo.TAIKHOAN
	WHERE TENTK = @TENTK
END 

-- Thêm nhân viên
GO
ALTER PROCEDURE usp_ThemNhanVien
	@MANV CHAR(5),
	@TENTK VARCHAR(20),
	@MACV CHAR(4),
	@TENNV NVARCHAR(50),
	@SDT NVARCHAR(11),
	@DIACHI NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.NHANVIEN
	        ( MANV, TENTK, MACV, TENNV, SDT, DIACHI )
	VALUES  ( @MANV, -- MANV - char(5)
	          @TENTK, -- TENTK - varchar(20)
	          @MACV, -- MACV - int
	          @TENNV, -- TENNV - nvarchar(50)
	          @SDT, -- SDT - nvarchar(11)
	          @DIACHI  -- DIACHI - nvarchar(100)
	          )
END


-- Cập nhật nhân viên
GO
ALTER PROCEDURE usp_CapNhatNhanVien
	@MANV CHAR(5),
	@MACV CHAR(4),
	@TENNV NVARCHAR(50),
	@SDT NVARCHAR(11),
	@DIACHI NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.NHANVIEN
	SET MACV = @MACV,
		TENNV = @TENNV,
		SDT = @SDT,
		DIACHI = @DIACHI
	WHERE MANV = @MANV
END

-- Xóa nhân viên
GO
ALTER PROCEDURE usp_XoaNhanVien
	@MANV CHAR(5),
	@TENTK VARCHAR(20)
AS
BEGIN		
	UPDATE dbo.NHANVIEN 
	SET TENTK = NULL
	WHERE MANV = @MANV

	DELETE FROM dbo.TAIKHOAN
	WHERE TENTK = @TENTK
END



SELECT * FROM dbo.NHANVIEN


-- Tra cứu nhân viên
GO
ALTER PROCEDURE usp_TraCuuNhanVien
	@MANV CHAR(5),
	@TENTK VARCHAR(20),
	@MACV CHAR(4),
	@TENNV NVARCHAR(50),
	@SDT NVARCHAR(11),
	@DIACHI NVARCHAR(100)
AS
BEGIN
	IF (@MANV !='' AND @TENTK !='' AND @MACV !='' AND @TENNV !='' AND @SDT !='' AND @DIACHI !='')
	BEGIN
		SELECT * FROM dbo.NHANVIEN WHERE MANV=@MANV AND TENTK=@TENTK AND MACV=@MACV AND TENNV=@TENNV AND SDT=@SDT AND DIACHI=@DIACHI
		AND TENTK IS NOT NULL
	END 

	IF (@MANV !='' AND @TENTK ='' AND @MACV ='' AND @TENNV ='' AND @SDT ='' AND @DIACHI ='')
	BEGIN
		SELECT * FROM dbo.NHANVIEN WHERE MANV=@MANV
		AND TENTK IS NOT NULL
	END

	IF (@MANV ='' AND @TENTK ='' AND @MACV !='' AND @TENNV ='' AND @SDT ='' AND @DIACHI ='')
	BEGIN
		SELECT * FROM dbo.NHANVIEN WHERE MACV=@MACV
		AND TENTK IS NOT NULL
	END

	IF (@MANV ='' AND @TENTK ='' AND @MACV ='' AND @TENNV !='' AND @SDT ='' AND @DIACHI ='')
	BEGIN
		SELECT * FROM dbo.NHANVIEN WHERE TENNV LIKE '%' + @TENNV + '%'
		AND TENTK IS NOT NULL
	END
END


EXEC usp_TraCuuNhanVien @MANV='', @TENTK='', @MACV='', @TENNV=N'Châu', @SDT='', @DIACHI=''

SELECT * FROM dbo.NHANVIEN