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

ALTER TABLE PHIEUTHUE ADD CONSTRAINT FK_PHIEUTHUE
FOREIGN KEY (MaPhong) REFERENCES PHONG (ID)

ALTER TABLE KHACHHANG ADD CONSTRAINT FK_KHACHHANG
FOREIGN KEY (LoaiKhachHang) REFERENCES LOAIKHACHHANG (ID)

ALTER TABLE CT_PHIEUTHUE ADD CONSTRAINT FK_CT_PHIEUTHUE
FOREIGN KEY (MaPhieuThue) REFERENCES PHIEUTHUE (ID),
FOREIGN KEY (MaKhachHang) REFERENCES KHACHHANG (ID)
