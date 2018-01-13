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

ALTER TABLE HOADON ADD CONSTRAINT FK_HOADON
FOREIGN KEY (MaPhieuThue) REFERENCES PHIEUTHUE (ID),
FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG (ID)

--ALTER TABLE HOADON DROP CONSTRAINT FK_HOADON

ALTER TABLE MD_SUDUNGPHONG ADD CONSTRAINT FK_MD_SUDUNGPHONG
FOREIGN KEY (MaPhong) REFERENCES PHONG (ID)

ALTER TABLE DT_THEOLOAIPHONG ADD CONSTRAINT FK_DT_THEOLOAIPHONG
FOREIGN KEY (MaLoaiPhong) REFERENCES LOAIPHONG (ID)