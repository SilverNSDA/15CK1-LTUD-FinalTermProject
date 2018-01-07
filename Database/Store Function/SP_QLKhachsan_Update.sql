USE QLKhachSan

------------- TABLE LOẠI PHÒNG ------------------------
-- INSERT
CREATE PROCEDURE add_row_LOAIPHONG
@ID nchar(10),
@DG int
AS
BEGIN
	INSERT INTO LOAIPHONG(ID,DonGia) 
	VALUES ( @ID,@DG) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_LOAIPHONG
@ID nchar(10),
@DG int
AS
BEGIN
	UPDATE LOAIPHONG 
	SET ID = @ID , DonGia = @DG
	WHERE id = @id 
END
GO
-- DELETE
CREATE PROCEDURE delete_row_LOAIPHONG
@id NCHAR(10)
AS
BEGIN
	DELETE FROM LOAIPHONG
	WHERE ID = @id 
END
GO

--------------------------TABLE PHÒNG ------------------------------------
--INSERT
CREATE PROCEDURE add_row_PHONG
@ID nchar(10),
@LP nchar(10),
@GC nvarchar(50)
AS
BEGIN
	INSERT INTO PHONG(ID,LoaiPhong,GhiChu) 
	VALUES ( @ID,@LP,@GC) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_PHONG
@ID nchar(10),
@LP nchar(10),
@GC nvarchar(50)
AS
BEGIN
	UPDATE PHONG 
	SET ID = @ID , LoaiPhong = @LP, GhiChu = @GC
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_PHONG
@id NCHAR(10)
AS
BEGIN
	DELETE FROM PHONG
	WHERE ID = @id 
END
GO
--------------------------TABLE PHIẾU THUÊ-------------------------
--INSERT
CREATE PROCEDURE add_row_PHIEUTHUE
@ID nchar(10),
@MP nchar(10),
@NBD datetime
AS
BEGIN
	INSERT INTO PHIEUTHUE(ID,MaPhong,NgayBatDau) 
	VALUES ( @ID,@MP,@NBD) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_PHIEUTHUE
@ID nchar(10),
@MP nchar(10),
@NBD datetime
AS
BEGIN
	UPDATE PHIEUTHUE
	SET ID = @ID , MaPhong = @MP , NgayBatDau = @NBD
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_PHIEUTHUE
@id NCHAR(10)
AS
BEGIN
	DELETE FROM PHIEUTHUE
	WHERE ID = @id 
END
GO
---------------------------TABLE KHÁCH HÀNG-------------------------
--INSERT
CREATE PROCEDURE add_row_KHACHHANG
@ID nchar(10),
@HT nvarchar(255),
@LKH nchar(10),
@CMND nchar(20),
@DC nvarchar(4000)
AS
BEGIN
	INSERT INTO KHACHHANG(ID,HoTen,LoaiKhachHang,CMND,DiaChi)
	VALUES ( @ID,@HT,@LKH,@CMND,@DC) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_KHACHHANG
@ID nchar(10),
@HT nvarchar(255),
@LKH nchar(10),
@CMND nchar(20),
@DC nvarchar(4000)
AS
BEGIN
	UPDATE KHACHHANG
	SET ID = @ID , HoTen = @HT, LoaiKhachHang = @LKH, CMND = @CMND
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_KHACHHANG
@id NCHAR(10)
AS
BEGIN
	DELETE FROM KHACHHANG
	WHERE ID = @id 
END
GO
-------------------------TABLE LOẠI KHÁCH HÀNG----------------------------
--INSERT
CREATE PROCEDURE add_row_LOAIKHACHHANG
@ID nchar(10),
@TL nvarchar(4000)
AS
BEGIN
	INSERT INTO LOAIKHACHHANG(ID,TenLoai)
	VALUES ( @ID,@TL) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_LOAIKHACHHANG
@ID nchar(10),
@TL nvarchar(4000)
AS
BEGIN
	UPDATE LOAIKHACHHANG
	SET ID = @ID , TenLoai = @TL
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_LOAIKHACHHANG
@id NCHAR(10)
AS
BEGIN
	DELETE FROM LOAIKHACHHANG
	WHERE ID = @id 
END
GO
----------------------------------TABLE CHI TIẾT PHIẾU THUÊ ---------------------
--INSERT
CREATE PROCEDURE add_row_CT_PHIEUTHUE
@ID nchar(10),
@MPT nchar(10),
@MKH nchar(10)
AS
BEGIN
	INSERT INTO CT_PHIEUTHUE(ID,MaPhieuThue,MaKhachHang)
	VALUES ( @ID,@MPT,@MKH) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_CT_PHIEUTHUE
@ID nchar(10),
@MPT nchar(10),
@MKH nchar(10)
AS
BEGIN
	UPDATE CT_PHIEUTHUE
	SET ID = @ID , MaPhieuThue = @MPT , MaKhachHang = @MKH
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_CT_PHIEUTHUE
@id NCHAR(10)
AS
BEGIN
	DELETE FROM CT_PHIEUTHUE
	WHERE ID = @id 
END
GO
----------------------------------TABLE HÓA ĐƠN ---------------------------------
--INSERT
CREATE PROCEDURE add_row_HOADON
@NTT DATETIME,
@MPT nchar(10),
@MKH nchar(10),
@GT INT
AS
BEGIN
	INSERT INTO HOADON(MaPhieuThue,MaKhachHang,NgayThanhToan,GiaTri)
	VALUES ( @MPT,@MKH,@NTT,@GT) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_HOADON
@NTT DATETIME,
@MPT nchar(10),
@MKH nchar(10),
@GT INT
AS
BEGIN
	UPDATE HOADON
	SET  MaPhieuThue = @MPT , MaKhachHang = @MKH , NgayThanhToan = @NTT, GiaTri = @GT
	WHERE MaPhieuThue = @MPT 
END
GO
-- DELETE
CREATE PROCEDURE delete_row_HOADON
@MPT nchar(10)
AS
BEGIN
	DELETE FROM HOADON
	WHERE MaPhieuThue = @MPT 
END
GO
---------------------------------TABLE QUY ĐỊNH-------------------------------
--INSERT
CREATE PROCEDURE add_row_QUYDINH
@ID nchar(10),
@MT text,
@GT float
AS
BEGIN
	INSERT INTO QUYDINH(ID,MoTa,GiaTri)
	VALUES ( @ID,@MT,@GT) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_QUYDINH
@ID nchar(10),
@MT text,
@GT float
AS
BEGIN
	UPDATE QUYDINH
	SET  ID = @ID, MoTa = @MT, GiaTri = @GT
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_QUYDINH
@ID nchar(10)
AS
BEGIN
	DELETE FROM QUYDINH
	WHERE ID = @ID
END
GO
---------------------------------TABLE MẬT ĐỘ SỬ DỤNG PHÒNG--------------------------------
--INSERT
CREATE PROCEDURE add_row_MD_SUDUNGPHONG
@ID nchar(10),
@MP nchar(10),
@NBD datetime,
@NKT datetime,
@MD int
AS
BEGIN
	INSERT INTO MD_SUDUNGPHONG(ID,MaPhong,NgayBatDau,NgayKetThuc,MatDo)
	VALUES ( @ID,@MP,@NBD,@NKT,@MD) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_MD_SUDUNGPHONG
@ID nchar(10),
@MP nchar(10),
@NBD datetime,
@NKT datetime,
@MD int
AS
BEGIN
	UPDATE MD_SUDUNGPHONG
	SET  ID = @ID, MaPhong = @MP, NgayBatDau = @NBD, NgayKetThuc = @NKT,MatDo = @MD
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_MD_SUDUNGPHONG
@ID nchar(10)
AS
BEGIN
	DELETE FROM MD_SUDUNGPHONG
	WHERE ID = @ID
END
GO
------------------------------TABLE DOANH THU THEO LOẠI PHÒNG------------------
--INSERT
CREATE PROCEDURE add_row_DT_THEOLOAIPHONG
@ID nchar(10),
@MLP nchar(10),
@NBD datetime,
@NKT datetime,
@DT int
AS
BEGIN
	INSERT INTO DT_THEOLOAIPHONG(ID,MaLoaiPhong,NgayBatDau,NgayKetThuc,DoanhTHu)
	VALUES ( @ID,@MLP,@NBD,@NKT,@DT) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_DT_THEOLOAIPHONG
@ID nchar(10),
@MLP nchar(10),
@NBD datetime,
@NKT datetime,
@DT int
AS
BEGIN
	UPDATE DT_THEOLOAIPHONG
	SET  ID = @ID, MaLoaiPhong = @MLP, NgayBatDau = @NBD, NgayKetThuc = @NKT,DoanhTHu = @DT
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_DT_THEOLOAIPHONG
@ID nchar(10)
AS
BEGIN
	DELETE FROM DT_THEOLOAIPHONG
	WHERE ID = @ID
END
GO



