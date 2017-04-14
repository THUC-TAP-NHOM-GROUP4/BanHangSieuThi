USE [BanHangSieuThi]
GO

-- TAO BANG BO MON

CREATE TABLE NhanVien
(
Ma VARCHAR(20) PRIMARY KEY,
Ten NVARCHAR(50) NOT NULL,
Gioitinh BIT,
Ngaysinh DATE,
SDT int,
Luong FLOAT,
PhongBan NVARCHAR(30),
DiaChi TEXT,
MatKhau varchar(20)
)

create table KhachHang
(
Ma varchar(20) primary key,
Ten nvarchar(50),
gioitinh bit,
diachi nvarchar(50),
SDT int,
socmnd int,
Email varchar(50)

)



create table HoaDon
(
Ma varchar(20) primary key,
KHma varchar(20),
TongTienTT FLOAT,
nvma varchar(20),
NgayTT date,
FOREIGN KEY(nvma) REFERENCES NhanVien(Ma),
FOREIGN KEY(KHma) REFERENCES KhachHang(Ma)

)

create table HangHoa
(
Ma varchar(20) primary key,
hoadonma varchar(20),
TenHang nvarchar(50),
SoLuong int,
NgaySX date,
HanSD date,
NoiSX nvarchar(50),
FOREIGN KEY(hoadonma) REFERENCES HoaDon(Ma)

)

INSERT INTO  NhanVien VALUES ('NV001', N'LÊ VĂN AN' ,'0' , '03/04/1990','0123456789' ,'20.000000'  , N'phòng kinh doanh', 'HN' , '1111'),
                             ('NV002', N'NGUYỄN VĂN AN' ,'0' , '03/04/1999','0123456789' ,'20.000000'  , N'phòng khách hàng', 'HN' , '1111'),
							 ('NV003', N'NGUYỄN VĂN BÌNH' ,'0' , '03/04/1890','0123456789' ,'20.000000'  , N'phòng kế toán', 'HN' , '1111'),
							 ('NV004', N'LÊ VĂN HẢI' ,'0' , '03/04/1970','0123456789' ,'5.000000'  , N'phòng bảo vệ', 'HN' , '1111'),
							 ('NV005', N'LÊ VĂN ANH' ,'0' , '03/04/1990','0123456789' ,'20.000000'  , N'phòng giám đốc', 'HN' , '1111')



INSERT INTO  KhachHang VALUES ('KH001' , N'hoàng văn tùng', '0', N'hà nội' , '01234234564' ,'173876534','hoangtung@gmail.com'),
                              ('KH002' , N'hoàng văn nam', '0', N'hà nội' , '01234234564' ,'173876534','hoangnam@gmail.com'),
							  ('KH003' , N'hoàng văn hải', '0', N'hà nội' , '01234234564' ,'173876534','hoanghai@gmail.com'),
							  ('KH004' , N'hoàng văn bình',  '0', N'hà nội' , '01234234564' ,'173876534','hoangbinh@gmail.com'),
							  ('KH005' , N'hoàng văn tiến',  '0', N'hà nội' , '01234234564' ,'173876534','hoangtien@gmail.com')

						


INSERT INTO  HoaDon VALUES ('HD001' , 'KH001' , '23.000000' , 'NV001' , '3/04/2015'),
                           ('HD002' , 'KH002' , '23.000000' , 'NV002' , '03/07/2015'),
						   ('HD003' , 'KH003' , '23.000000' , 'NV003' , '2/09/2015'),
						   ('HD004' , 'KH004' , '23.000000' , 'NV004' , '02/03/2015'),
						   ('HD005' , 'KH005' , '23.000000' , 'NV005' , '2/04/2015')





INSERT INTO  HangHoa VALUES ('H001', 'HD001' , N'Quần Áo' , '1000' , '2/4/2014', '' ,N'Hà Nội'),
                            ('H002', 'HD002' , N'Chăn Đệm' , '1000' , '3/4/2014', '' ,N'Hà Nội'),
							('H003', 'HD003' , N'Thực Phẩm' , '1000' , '5/4/2014', '04/05/2016' ,N'Hà Nội'),
							('H004', 'HD004' , N'Đồ gia dụng' , '1000' , '8/4/2014', '05/03/2016' ,N'Hà Nội'),
							('H005', 'HD005' , N'Mỹ Phẩm' , '1000' , '9/4/2014', '07/05/2015' ,N'Hà Nội')