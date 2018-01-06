Create database QLKhachSan
go
use QLKhachSan

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

ALTER TABLE PHONG ADD CONSTRAINT FK_PHONG
FOREIGN KEY (LoaiPhong) REFERENCES LOAIPHONG (ID)

