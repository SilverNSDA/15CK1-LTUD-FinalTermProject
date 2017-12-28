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

Alter table PHONG
add constraint PK_PHONG_LOAIPHONG
foreign key(LoaiPhong) references LOAIPHONG(ID)
