create database Max_QueryQLMICAYCAY
go
use Max_QueryQLMICAYCAY
go

CREATE TABLE [dbo].[nhanvien](
	[manv] [varchar](10) primary key,
	[tennv] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[gioitinh] [nvarchar](5) NOT NULL,
	[diachi] [nvarchar](150) NOT NULL,
	[sdt] [int] NOT NULL,
	[chucvu] [nvarchar](30) NOT NULL,
	[matkhau] [varchar](100) NOT NULL
)
go

CREATE TABLE [dbo].[nhommon](
	[manhom] [varchar](10) primary key,
	[tennhom] [nvarchar](50) NOT NULL
)
go

CREATE TABLE [dbo].[monan](
	[mamon] [varchar](10) primary key,
	[tenmon] [nvarchar](50) NOT NULL,
	[giatien] [decimal](18, 0) NOT NULL,
	[dvt] [nvarchar](10) NOT NULL,
	[manhom] [varchar](10) NULL

	FOREIGN KEY (manhom) REFERENCES  [dbo].[nhommon](manhom)
)
go

CREATE TABLE [dbo].[taikhoan](
	[name] [varchar](100) ,
	[IDNhanVien] varchar(10) not null,
	[pass] [varchar](50) NOT NULL DEFAULT 0,
	[Type] nvarchar(20) 

	foreign key (IDNhanVien) references [dbo].[nhanvien](manv)
)
go


CREATE TABLE [dbo].[ban](
	[id] [int] identity primary key,
	[tenban] [nvarchar] (20) NOT NULL,
	[trangthai] [nvarchar](20) 
)
go

CREATE TABLE [dbo].[hoadon](
	[sohd] [varchar](10) PRIMARY KEY,
	[giovao] [datetime] NOT NULL DEFAULT GETDATE(),
	[giora] [datetime] ,
	[manv] [varchar](10) NULL,
	[soban] [int] NOT NULL,
	[tongtien] [decimal](18,0) NOT NULL ,
	[trangthai] [int] NOT NULL DEFAULT 0 -- 1: đã thanh toán , 0: chưa thanh toán 

	FOREIGN KEY (manv) REFERENCES  [dbo].[nhanvien](manv),
	FOREIGN KEY (soban) REFERENCES  [dbo].[ban](id)
)
GO


CREATE TABLE [dbo].[chitiethoadon](
	[id] int IDENTITY PRIMARY KEY,
	[sohd] [varchar](10) NOT NULL,
	[mamon] [varchar](10) NOT NULL,
	[soluong] [int] NOT NULL DEFAULT 0,
	[gia] [decimal](18,0) NOT NULL,
	[thanhtien] [decimal] (18,0) NOT NULL

	FOREIGN KEY (sohd) REFERENCES  [dbo].[hoadon](sohd),
	FOREIGN KEY (mamon) REFERENCES  [dbo].[monan](mamon)
) 
GO

Insert into nhanvien (manv, tennv, ngaysinh, gioitinh, diachi, sdt, chucvu, matkhau)
values ('NV001', N'lĩnh', '12/30/2001', N'Nam', N'Hòa Vinh', '8789', N'Giám Đốc', '113')
go

CREATE PROC USP_LAYDANHSACHNVBANGMANV
@MaNV varchar(20)
AS
BEGIN
	SELECT * FROM nhanvien WHERE manv = @MaNV
END
GO

EXEC USP_LAYDANHSACHNVBANGMANV @MaNV = 'NV001'

go

DECLARE @i INT = 0 

WHILE @i <= 20
BEGIN
	INSERT ban (tenban) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i +1
END
GO

CREATE PROC USP_DANHSACHBAN
AS SELECT * FROM ban
go

UPDATE ban SET trangthai = N'Có Người' WHERE id = '8'

EXEC USP_DANHSACHBAN
go

-- thêm nhóm món
INSERT nhommon (manhom, tennhom) values ('NHOM1', N'Mì Cay')
GO
INSERT nhommon (manhom, tennhom) values ('NHOM2', N'Nước')
GO

--thêm món ăn 
INSERT monan(mamon, tenmon, giatien, dvt, manhom) values ('MON1', N'Mì Cay Hải Sản', 45000, N'Phần', 'NHOM1')
GO

INSERT monan(mamon, tenmon, giatien, dvt, manhom) values ('MON3', N'Mì Cay Bò', 50000, N'Phần', 'NHOM1')
GO

INSERT monan(mamon, tenmon, giatien, dvt, manhom) values ('MON2', N'Coca Cola', 15000, N'Lon', 'NHOM2')
GO

INSERT monan(mamon, tenmon, giatien, dvt, manhom) values ('MON4', N'7 Up', 15000, N'Lon', 'NHOM2')
GO

--Thêm hóa đơn
INSERT hoadon(sohd, giovao, giora, manv, soban, trangthai)
VALUES ('HD001', GETDATE(), NULL, 'NV001', 2, 0)

--INSERT hoadon(sohd, giovao, giora, manv, soban, trangthai)
--VALUES ('HD002', GETDATE(), NULL, 'ada', 3, 0)

--INSERT hoadon(sohd, giovao, giora, manv, soban, trangthai)
--VALUES ('HD003', GETDATE(), GETDATE(), 'ada', 1, 1)

-- thêm chi tiết hóa đơn
INSERT chitiethoadon( sohd, mamon, soluong) values ('HD001', 'MON1', 2)
GO

INSERT chitiethoadon( sohd, mamon, soluong) values ('HD001', 'MON2', 2)
GO

INSERT chitiethoadon( sohd, mamon, soluong) values ('HD002', 'MON1', 3)
GO
INSERT chitiethoadon( sohd, mamon, soluong) values ('HD002', 'MON2', 3)
GO

INSERT chitiethoadon( sohd, mamon, soluong) values ('HD003', 'MON1', 5)
GO
INSERT chitiethoadon( sohd, mamon, soluong) values ('HD003', 'MON2', 3)
GO

SELECT sohd FROM hoadon WHERE soban = 3 and trangthai = 0

SELECT * FROM chitiethoadon WHERE sohd = 'HD001'

SELECT ma.tenmon, ma.dvt, cthd.soluong, ma.giatien, ma.giatien * cthd.soluong as tongtien FROM chitiethoadon as cthd, hoadon as hd, monan as ma 
WHERE cthd.sohd = hd.sohd AND cthd.mamon = ma.mamon AND hd.trangthai = 0 AND hd.soban = 2

ALTER PROC USP_ThemHoaDon 
@soban int ,
@sohd varchar(10),
@manv varchar(10),
@tongtien decimal(18,0)
AS
BEGIN
	
	INSERT hoadon(sohd, giovao, giora, manv, soban, trangthai, tongtien)
	VALUES (@sohd, GETDATE(), NULL, @manv, @soban, 0, @tongtien )
END
GO

ALTER PROC USP_ThemChiTietHoaDon 
@sohd varchar(10),
@mamon varchar(10),
@soluong int,
@giatien decimal (18,0),
@thanhtien decimal (18,0)
AS
BEGIN
	DECLARE @CheckSuTonTaiCuaCTHD int
	DECLARE @SoLuongCuaMonAn int = 1 

	SELECT @CheckSuTonTaiCuaCTHD = id , @SoLuongCuaMonAn = soluong 
	FROM chitiethoadon 
	WHERE sohd = @sohd AND mamon = @mamon

	IF(@CheckSuTonTaiCuaCTHD > 0)
	BEGIN
		DECLARE @newSoluong int = @SoLuongCuaMonAn + @soluong
		IF(@newSoluong > 0)
		BEGIN
			UPDATE chitiethoadon 
			SET soluong = @SoLuongCuaMonAn + @soluong , thanhtien = (@SoLuongCuaMonAn + @soluong) * gia
			WHERE mamon = @mamon
		END
		ELSE 
		BEGIN
			DELETE chitiethoadon 
			WHERE sohd = @sohd 
			AND mamon = @mamon
		END
	END
	ELSE 
	BEGIN 
		INSERT chitiethoadon(sohd, mamon, soluong, gia , thanhtien)
		VALUES (@sohd, @mamon, @soluong , @giatien , @thanhtien)
	END
END
GO




Delete chitiethoadon
Delete hoadon
Delete nhommon
delete monan

CREATE TRIGGER UTG_CapNhatCTHD
ON chitiethoadon FOR INSERT, UPDATE 
AS 
BEGIN
	DECLARE @sohd varchar(10)

	SELECT @sohd = sohd from Inserted

	DECLARE @soban int

	SELECT @soban = soban from hoadon where sohd = @sohd and trangthai = 0

	UPDATE ban SET trangthai =	N'Có người' where id = @soban
END
GO

Create TRIGGER UTG_CapNhatHoaDon
ON hoadon FOR  UPDATE 
AS 
BEGIN
	DECLARE @sohd varchar(10)

	SELECT @sohd = sohd from Inserted

	DECLARE @soban int

	SELECT @soban = soban from hoadon where sohd = @sohd

	DECLARE @soluong int = 0

	SELECT @soluong = COUNT(*) from hoadon where soban = @soban and trangthai = 0

	IF(@soluong = 0)
	BEGIN
			UPDATE ban SET trangthai = N'' where id = @soban 
	END

END
GO


ALTER view     View_Bill_MiCay
as
select hd.sohd, hd.soban, hd.giovao, hd.giora, hd.tongtien, cthd.mamon , cthd.soluong , cthd.gia, cthd.thanhtien, ma.tenmon, nv.tennv
from dbo.HOADON hd, dbo.chitiethoadon cthd, dbo.monan ma, dbo.nhanvien nv
where hd.sohd = cthd.sohd and cthd.mamon = ma.mamon and hd.manv = nv.manv

select * from View_Bill_MiCay where sohd = 'HD005'

--INSERT hoadon(sohd, giovao, giora, manv, soban, tongtien, trangthai)
--VALUES ('HD010', GETDATE(), '5/21/2020', 'NV001', 1, 45000, 1)