USE QLKhachSan

------------- TABLE LOẠI PHÒNG ------------------------
-- INSERT
CREATE PROCEDURE add_row_LOAIPHONG
@ID nchar(10),
@DG int
AS
BEGIN
	if exists(select * from LOAIPHONG lp where lp.ID = @ID)
	begin
		Raiserror(N'lọai phòng đã tồn tại',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from LOAIPHONG lp where lp.ID = @ID)
	begin
		Raiserror(N'lọai phòng chưa có, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE LOAIPHONG 
	SET DonGia = @DG
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_LOAIPHONG
@id NCHAR(10)
AS
BEGIN
	if exists(select * from PHONG p where p.LoaiPhong = @id)
	begin
		declare @dem int
		select @dem = COUNT(p.LoaiPhong) from PHONG p where p.LoaiPhong = @id
		Raiserror(N'không thể xóa.Hien có %d phong thuộc loại phòng này',15,1,@dem)
		Rollback Transaction
	end
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
	if exists(select * from PHONG p where p.ID = @ID)
	begin
		Raiserror(N'không thể insert phòng do phòng đã tồn tại',15,1,@dem)
		Rollback Transaction
	end
	if not exists(select * from LOAIPHONG lp where lp.ID = @LP)
	begin
		Raiserror(N'không thể insert phòng do loại phòng chưa tồn tại',15,1,@dem)
		Rollback Transaction
	end
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
	if exists(select * from PHONG p where p.ID = @ID)
	begin
		Raiserror(N'không thể insert phòng do phòng đã tồn tại',15,1,@dem)
		Rollback Transaction
	end
	if not exists(select * from LOAIPHONG lp where lp.ID = @LP)
	begin
		Raiserror(N'không thể insert phòng do loại phòng chưa tồn tại',15,1,@dem)
		Rollback Transaction
	end
	UPDATE PHONG 
	SET LoaiPhong = @LP, GhiChu = @GC
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_PHONG
@id NCHAR(10)
AS
BEGIN
	--to do
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
	if exists(select * from PHIEUTHUE pt where pt.ID = @ID)
	begin
		Raiserror(N'Phiếu thuê đã tồn tại',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from PHIEUTHUE pt where pt.ID = @ID)
	begin
		Raiserror(N'Phiếu thuê chưa có, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE PHIEUTHUE
	SET MaPhong = @MP , NgayBatDau = @NBD
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_PHIEUTHUE
@id NCHAR(10)
AS
BEGIN
	if exists(select * from HOADON hd where hd.MaPhieuThue = @id)
	begin
		Raiserror(N'Phiếu thuê đã thanh toán, không thể xóa',15,1)
		Rollback Transaction
	end
	if exists(select * from CT_PHIEUTHUE ct where ct.MaPhieuThue = @id)
	begin
		DELETE FROM CT_PHIEUTHUE
		WHERE MaPhieuThue = @id 
	end
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
	if exists(select * from KHACHHANG kh where kh.ID = @ID)
	begin
		Raiserror(N'ID đã tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
	if exists(select * from KHACHHANG kh where kh.CMND = @CMND)
	begin
		Raiserror(N'CMND đã được sử dụng, không thể insert',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from KHACHHANG kh where kh.ID = @ID)
	begin
		Raiserror(N'ID chưa tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	if exists(select * from KHACHHANG kh where kh.CMND = @CMND)
	begin
		Raiserror(N'CMND đã được sử dụng, không thể insert',15,1)
		Rollback Transaction
	end
	UPDATE KHACHHANG
	SET HoTen = @HT, LoaiKhachHang = @LKH, CMND = @CMND
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_KHACHHANG
@id NCHAR(10)
AS
BEGIN
	Raiserror(N'Bạn không thể delete',15,1)
	Rollback Transaction
	--DELETE FROM KHACHHANG
	--WHERE ID = @id 
END
GO
-------------------------TABLE LOẠI KHÁCH HÀNG----------------------------
--INSERT
CREATE PROCEDURE add_row_LOAIKHACHHANG
@ID nchar(10),
@TL nvarchar(4000)
AS
BEGIN
	if exists(select * from LOAIKHACHHANG lkh where lkh.ID = @ID)
	begin
		Raiserror(N'ID loại đã tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from LOAIKHACHHANG lkh where lkh.ID = @ID)
	begin
		Raiserror(N'ID loại không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE LOAIKHACHHANG
	SET TenLoai = @TL
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_LOAIKHACHHANG
@id NCHAR(10)
AS
BEGIN
	if exists(select * from KHACHHANG kh where kh.LoaiKhachHang = @id)
	begin
		declare @dem int
		select @dem = COUNT(kh.LoaiKhachHang) from KHACHHANG kh where kh.LoaiKhachHang = @id
		Raiserror(N'không thể xóa.Hien có %d khách hàng thuộc loại khách hàng này',15,1,@dem)
		Rollback Transaction
	end
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
	if exists(select * from CT_OHIEUTHUE ct where ct.ID = @ID)
	begin
		Raiserror(N'ID chi tiết đã tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from CT_PHIEUTHUE ct where ct.ID = @ID)
	begin
		Raiserror(N'ID chi tiết không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	if not exists(select * from PHIEUTHUE pt where pt.MaPhieuThue = @MPT)
	begin
		Raiserror(N'MPT không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE CT_PHIEUTHUE
	SET MaPhieuThue = @MPT , MaKhachHang = @MKH
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
	if not exists(select * from PHIEUTHUE pt where pt.ID = @MPT)
	begin
		Raiserror(N'MPT không tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
	if not exists(select * from KHACHHANG kh where kh.ID = @MKH)
	begin
		Raiserror(N'MKH không tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
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
	Raiserror(N'không thể update',15,1)
	Rollback Transaction
	--UPDATE HOADON
	--SET  MaPhieuThue = @MPT , MaKhachHang = @MKH , NgayThanhToan = @NTT, GiaTri = @GT
	--WHERE MaPhieuThue = @MPT 
END
GO
-- DELETE
CREATE PROCEDURE delete_row_HOADON
@MPT nchar(10)
AS
BEGIN
	Raiserror(N'không thể delete',15,1)
	Rollback Transaction
	--DELETE FROM HOADON
	--WHERE MaPhieuThue = @MPT 
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
	Raiserror(N'ID đã tồn tại, không thể insert',15,1)
	Rollback Transaction
	--INSERT INTO QUYDINH(ID,MoTa,GiaTri)
	--VALUES ( @ID,@MT,@GT) 
END
GO
-- UPDATE
CREATE PROCEDURE update_row_QUYDINH
@ID nchar(10),
@GT float
AS
BEGIN
	if not exists(select * from QUYDINH qd where qd.ID = @ID)
	begin
		Raiserror(N'ID không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE QUYDINH
	SET  GiaTri = @GT
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_QUYDINH
@ID nchar(10)
AS
BEGIN
	Raiserror(N'ID không tồn tại, không thể update',15,1)
	Rollback Transaction
	--DELETE FROM QUYDINH
	--WHERE ID = @ID
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
	if exists(select * from MD_SUDUNGPHONG md where md.ID = @ID)
	begin
		Raiserror(N'ID đã tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
	if not exists(select * from PHONG p where p.ID = @MP)
	begin
		Raiserror(N'MP không tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from MD_SUDUNGPHONG md where md.ID = @ID)
	begin
		Raiserror(N'ID không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	if not exists(select * from PHONG p where p.ID = @MP)
	begin
		Raiserror(N'MP không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE MD_SUDUNGPHONG
	SET  MaPhong = @MP, NgayBatDau = @NBD, NgayKetThuc = @NKT,MatDo = @MD
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_MD_SUDUNGPHONG
@ID nchar(10)
AS
BEGIN
	if not exists(select * from MD_SUDUNGPHONG md where md.ID = @ID)
	begin
		Raiserror(N'ID không tồn tại, không thể delete',15,1)
		Rollback Transaction
	end
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
	if exists(select * from DT_THEOLOAIPHONG dt where dt.ID = @ID)
	begin
		Raiserror(N'ID đã tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
	if not exists(select * from LOAIPHONG lp where lp.ID = @MLP)
	begin
		Raiserror(N'MLP không tồn tại, không thể insert',15,1)
		Rollback Transaction
	end
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
	if not exists(select * from DT_THEOLOAIPHONG dt where dt.ID = @ID)
	begin
		Raiserror(N'ID không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	if not exists(select * from LOAIPHONG lp where lp.ID = @MLP)
	begin
		Raiserror(N'MLP không tồn tại, không thể update',15,1)
		Rollback Transaction
	end
	UPDATE DT_THEOLOAIPHONG
	SET MaLoaiPhong = @MLP, NgayBatDau = @NBD, NgayKetThuc = @NKT,DoanhTHu = @DT
	WHERE ID = @ID
END
GO
-- DELETE
CREATE PROCEDURE delete_row_DT_THEOLOAIPHONG
@ID nchar(10)
AS
BEGIN
	if not exists(select * from DT_THEOLOAIPHONG dt where dt.ID = @ID)
	begin
		Raiserror(N'ID đã tồn tại, không thể delete',15,1)
		Rollback Transaction
	end
	DELETE FROM DT_THEOLOAIPHONG
	WHERE ID = @ID
END
GO



