Create database QLKhachSan
go

Create table PHONG(
	ID nchar(10),
	LoaiPhong nchar(10) not null,
	GhiChu nvarchar(50),
	Primary key (ID)
);

Create table LOAIPHONG(
	ID nchar(10),
	DonGia int,
	Primary key (ID)
);

Create table PHIEUTHUE(
	ID nchar(10),
	MaPhong nchar(10) not null,
	NgayBatDau datetime not null,
	Primary key (ID)
);

Create table KHACHHANG(
	ID nchar(10),
	HoTen nvarchar(255),
	LoaiKhachHang nchar(10),
	CMND nchar(20),
	DiaChi nvarchar(4000),
	Primary key (ID)
);

Create table LOAIKHACHHANG(
	ID nchar(10),
	TenLoai nvarchar(4000),
	Primary key (ID)
);

Create table CT_PHIEUTHUE(
	ID nchar(10),
	MaPhieuThue nchar(10) not null,
	MaKhachHang nchar(10) not null,
	Primary key (ID)
);

Create table HOADON(
	MaPhieuThue nchar(10),
	MaKhachHang nchar(10),
	NgayThanhToan datetime,
	GiaTri int,
	Primary key (MaPhieuThue)
);

Create table QUYDINH(
	ID nchar(10),
	MoTa text,
	GiaTri float,
	Primary key (ID)
);

Create table MD_SUDUNGPHONG(
	ID nchar(10),
	MaPhong nchar(10) not null,
	NgayBatDau datetime,
	NgayKetThuc datetime,
	MatDo int,
	Primary key (ID)
);

Create table DT_THEOLOAIPHONG(
	ID nchar(10),
	MaLoaiPhong nchar(10) not null,
	NgayBatDau datetime,
	NgayKetThuc datetime,
	DoanhTHu int,
	Primary key (ID)
);

ALTER TABLE PHONG ADD CONSTRAINT FK_PHONG
FOREIGN KEY (LoaiPhong) REFERENCES LOAIPHONG (ID)

ALTER TABLE PHIEUTHUE ADD CONSTRAINT FK_PHIEUTHUE
FOREIGN KEY (MaPhong) REFERENCES PHONG (ID)

ALTER TABLE KHACHHANG ADD CONSTRAINT FK_KHACHHANG
FOREIGN KEY (LoaiKhachHang) REFERENCES LOAIKHACHHANG (ID)

ALTER TABLE CT_PHIEUTHUE ADD CONSTRAINT FK_CT_PHIEUTHUE
FOREIGN KEY (MaPhieuThue) REFERENCES PHIEUTHUE (ID),
FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG (ID)

ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON
FOREIGN KEY (MaPhieuThue) REFERENCES PHIEUTHUE (ID),
FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG (ID)

--ALTER TABLE HOADON DROP CONSTRAINT FK_HOADON

ALTER TABLE MD_SUDUNGPHONG ADD CONSTRAINT FK_MD_SUDUNGPHONG
FOREIGN KEY (MaPhong) REFERENCES PHONG (ID)

ALTER TABLE DT_THEOLOAIPHONG ADD CONSTRAINT FK_DT_THEOLOAIPHONG
FOREIGN KEY (MaLoaiPhong) REFERENCES LOAIPHONG (ID)