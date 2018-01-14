--Báo cáo mật độ
create function ThemMatDo(@ngaybd datetime,@ngaykt datetime,@id varchar(10))
returns float
as
begin
	declare @matdo float
	select @matdo = sum(DATEDIFF(hour,h.NgayThanhToan,pt.NgayBatDau))
	from HOADON h, PHIEUTHUE pt, PHONG p
	where h.MaPhieuThue = pt.ID 
	and p.ID = pt.MaPhong 
	and p.ID = @id 
	and (h.NgayThanhToan between @ngaybd and @ngaykt)
	return @matdo
end
go

create proc BaoCaoMatDo @ngaybd datetime, @ngaykt datetime
as
begin
	declare cur CURSOR for(select p.ID from HOADON h, PHIEUTHUE pt, PHONG p
						where h.MaPhieuThue = pt.ID 
						and p.ID = pt.MaPhong  
						and (h.NgayThanhToan between @ngaybd and @ngaykt))
	DECLARE @maphong nchar(10)
	open cur
	FETCH NEXT FROM cur INTO @maphong
	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		   insert into MD_SUDUNGPHONG values(@maphong+cast(GETDATE() as varchar(50)),@maphong,@ngaybd,@ngaykt,dbo.ThemMatDo(@ngaybd,@ngaykt,@maphong))
		   FETCH NEXT FROM cur INTO @maphong
	END   
	CLOSE cur
	DEALLOCATE cur
end
go

-- Báo cáo doanh thu
create function ThemDoanhThu(@ngaybd datetime,@ngaykt datetime,@id varchar(10))
returns float
as
begin
	declare @doanhthu float
	select @doanhthu = sum(h.GiaTri)
	from HOADON h, PHIEUTHUE pt, PHONG p,LOAIPHONG lp
	where h.MaPhieuThue = pt.ID 
	and p.ID = pt.MaPhong 
	and p.LoaiPhong = lp.ID
	and lp.ID = @id
	return @doanhthu
end
go

create proc BaoCaoDoanhThu @ngaybd datetime, @ngaykt datetime
as
begin
	declare cur CURSOR for(select p.ID from HOADON h, PHIEUTHUE pt, PHONG p,LOAIPHONG lp
						where h.MaPhieuThue = pt.ID 
						and p.ID = pt.MaPhong  
						and p.LoaiPhong = lp.ID)
	DECLARE @maloaiphong nchar(10)
	open cur
	FETCH NEXT FROM cur INTO @maloaiphong
	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		   insert into DT_THEOLOAIPHONG values(@maloaiphong+cast(GETDATE() as varchar(50)),@maloaiphong,@ngaybd,@ngaykt,dbo.ThemDoanhThu(@ngaybd,@ngaykt,@maloaiphong))
		   FETCH NEXT FROM cur INTO @maloaiphong
	END   
	CLOSE cur
	DEALLOCATE cur
end
go