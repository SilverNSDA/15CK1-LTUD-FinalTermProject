Create table PHIEUTHUE(
	ID nchar(10),
	MaPhong nchar(10) not null,
	NgayBatDau datetime not null,
	Primary key (ID)
);

Alter table PHIEUTHUE
add constraint PK_PHIEUTHUE_PHONG
foreign key(MaPhong) references PHONG(ID)

Create table KHACHHANG(
	ID nchar(10),
	HoTen nvarchar(255),
	LoaiKhachHang nchar(10),
	CMND nchar(20),
	DiaChi nvarchar(255),
	Primary key (ID)
);

Create table LOAIKHACHHANG(
	ID nchar(10),
	TenLoai nvarchar(255),
	Primary key (ID)
);

Create table CT_PHIEUTHUE(
	ID nchar(10),
	MaPhieuThue nchar(10) not null,
	MaKhachHang nchar(10) not null,
	Primary key (ID)
);

Alter table KHACHHANG
add constraint PK_KHACHHANG_LOAIKHACHHANG
foreign key(LoaiKhachHang) references LOAIKHACHHANG(ID)

Alter table CT_PHIEUTHUE
add constraint PK_CT_PHIEUTHUE_PHIEUTHUE
foreign key(MaPhieuThue) references LOAIKHACHHANG(ID)

Alter table CT_PHIEUTHUE
add constraint PK_CT_PHIEUTHUE_KHACHHANG
foreign key(MaKhachHang) references KHACHHANG(ID)