use QLKhachSan
go

insert into LOAIPHONG values('A',150)
insert into LOAIPHONG values('B',170)
insert into LOAIPHONG values('C',200)

insert into PHONG values('A1','A','')
insert into PHONG values('A2','A','')
insert into PHONG values('A3','A','')
insert into PHONG values('B1','B','')
insert into PHONG values('B2','B','')
insert into PHONG values('B3','B','')
insert into PHONG values('C1','C','')
insert into PHONG values('C2','C','')
insert into PHONG values('C3','C','')
insert into PHONG values('C4','C','')

insert into LOAIKHACHHANG values('L00001',N'Nội địa')
insert into LOAIKHACHHANG values('L00002',N'Nước ngoài')

insert into KHACHHANG values('KH00001',N'Nguyễn Sanh Đình Anh','L00001','2335461234',N'15 Cống Quỳnh')
insert into KHACHHANG values('KH00002',N'Đinh Thị Chang','L00002','2763647567',N'60 Chương Dương')
insert into KHACHHANG values('KH00003',N'Nguyễn Gia Bảo','L00001','2436485647',N'26 Đặng Trần Côn')
insert into KHACHHANG values('KH00004',N'Vũ Phương Hoài Đan','L00002','2876394657',N'110 Huỳnh Thúc Kháng')
insert into KHACHHANG values('KH00005',N'Đinh Trần Thị Kim Cương','L00002','2635478563',N'11 Lê Lợi')
insert into KHACHHANG values('KH00006',N'Nguyễn Thị Chúc','L00002','2265749875',N'227 Nguyễn Văn Cừ')
insert into KHACHHANG values('KH00007',N'Hồ Quốc Bình','L00002','2647356427',N'35 Nam Kỳ Khởi Nghĩa')
insert into KHACHHANG values('KH00008',N'Hoàng Đình Sơn Dương','L00001','2176253447',N'143 Nguyễn Thái Bình')
insert into KHACHHANG values('KH00009',N'Nguyễn Nguyên Anh','L00001','2736984915',N'10 Hồ Xuân Hương')
insert into KHACHHANG values('KH00010',N'Nguyễn Hoàng Duy','L00001','2534173418',N'44 Nguyễn Đình Chiểu')

insert into QUYDINH values('QD00001',N'Phụ thu khách thứ 3(%)',25,'%')
insert into QUYDINH values('QD00002',N'Khách nước ngoài (hệ số nhân)',1.5,'*')
insert into QUYDINH values('QD00003',N'Số lượng khách tối đa trong phòng',3,'unit')