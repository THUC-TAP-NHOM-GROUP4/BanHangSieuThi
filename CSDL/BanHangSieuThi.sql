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
Luong MONEY,
PhongBan NVARCHAR(30),
DiaChi TEXT,
MatKhau varchar(20)
)

create table KhachHang
(
Ma varchar(20) primary key,
Ten nvarchar(50),
ngaysinh date,
gioitinh bit,
diachi nvarchar(50),
SDT int,
socmnd int,
Email varchar(50)

)


create table HangHoa
(
Ma varchar(20),
hoadonma varchar(20),
TenHang nvarchar(50),
SoLuong int,
NgaySX date,
HanSD date,
NoiSX nvarchar(50),
FOREIGN KEY(hoadonma) REFERENCES HoaDon(Ma)

)

create table HoaDon
(
Ma varchar(20) primary key,
KHma varchar(20),
TongTienTT money,
nvma varchar(20),
NgayTT date,
FOREIGN KEY(nvma) REFERENCES NhanVien(Ma),
FOREIGN KEY(KHma) REFERENCES KhachHang(Ma)

)


