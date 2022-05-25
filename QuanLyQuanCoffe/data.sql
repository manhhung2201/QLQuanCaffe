create database QuanLyQuanCoffe
go

use QuanLyQuanCoffe
go
---------
create table Employee
(	idEmployee nvarchar(50) primary key NOT NULL,
	Name nvarchar(50) NOT NULL,
	Gender nvarchar(50) NOT NULL,
	Address nvarchar(100) NOT NULL,
	Phone nvarchar(50) NOT NULL,
	Email nvarchar(100) NOT NULL,
	Salary decimal(18, 0) NOT NULL,
	StartDay date NOT NULL,

)
insert into Employee values
(	'N00',N'Nguyễn Nhật Minh',N'NAM',N'Hà Nội','0983328643','MINH@gmail.com',100000,'1/2/2022'),
(	'N01',N'Trần Linh Chi',N'Nữ',N'Hà Nội','09828643','Chi@gmail.com',50000,'2/2/2022'),
(	'N02',N'Hà Mai Trang',N'Nữ',N'Hưng Yên','09834443','Trang@gmail.com',40000,'1/2/2022'),
(	'N03',N'Trần Văn Kiên',N'Nam',N'Thái Bình','0922338643','Kien@gmail.com',45000,'2/2/2022'),
(	'N04',N'Nguyễn Huy Quang',N'Nam',N'Cần Thơ','098224223','Quang@gmail.com',20000,'6/2/2022');


-------
create table Account
( 
	username nvarchar(100) primary key not null,
	password nvarchar(100) not null,
	type nvarchar(50) not null,
	idEmployee nvarchar(50),
	constraint FK_1 foreign key (idEmployee) references Employee(idEmployee)

)
go

insert into Account values 
	('Admin','@admin@','admin','N00'),
	('chichi','@chi@','staff','N01'),
	('hatrang','@trang@','staff','N02'),
	('kientran','@kien@','staff','N03'),
	('quangx2','@quang@','staff','N04');


------
create table FoodCategory
(
	id int primary key,
	name nvarchar(100) default N'Trống' 
)
go
insert into FoodCategory values
	(1,N'Trà sữa'),
	(2,N'Hồng Trà'),
	(3,N'Bánh Ngọt'),
	(4,N'Cafe VietNam'),
	(5,N'Cafe Máy');
	

----------
create table Food(
	id int primary key,
	Foodname nvarchar(100) not null default N'Chưa đặt tên',
	idCategory int not null,
	price float not null default 0,
	image nchar(100),
	constraint FK_2 foreign key (idCategory) references FoodCategory(id)
)
go
insert into Food values
	(1, N'Trà sữa matcha ', 1, 30000, N'ts_matcha.jpg '),
	(2, N'Trà sữa chân trâu đen ',1, 41000, N'ts_chantrau.jpg '),
	(3, N'Hồng Trà xanh ',2, 30000, N'ht_xanh.jpg '),
	(4, N'Hồng Trà Nhài ',2, 35000, N'ht_nhai.jpg '),
	(5, N'Bánh socola ',3, 20000, N'b_socola.jpg '),
	(6, N'Bánh crepe',3, 25000, N'b_crepe.jpg '),
	(7, N'Bánh kimchi',3, 25000, N'b_kimchi.jpg '),
	(8, N'Cafe đen',4, 25000, N'cafe_den.jpg '),
	(9, N'Cafe sữa',4, 35000, N'cafe_sua.jpg '),
	(10, N'Latte',5, 35000, N'latte.jpg '),
	(11, N'Mocha',5, 45000, N'mocha.jpg ');

--------
create table Promotion
(	idPromotion nvarchar(50) primary key NOT NULL,
	StartDate date NULL,
	EndDate date NULL,
	Description nvarchar(500) NOT NULL,
	PricePromotion decimal(18, 0) NOT NULL,
	
	
)

--------
create table Bill
(	id int primary key,
	idEmployee nvarchar(50) NOT NULL,
	DateCheckIn Date not null default getdate(),
	DateCheckOut Date,
	idPromotion nvarchar(50) ,
	
	constraint FK_9 foreign key (idEmployee) references Employee(idEmployee),
	constraint FK_8 foreign key (idPromotion) references Promotion(idPromotion)
	
)
go
--------
create table BillInfo
(	id int primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0,
	constraint FK_3 foreign key (idBill) references Bill(id),
	constraint FK_4 foreign key (idFood) references Food(id)
)
go
-------
create table DeviceNoti
	( id int primary key,
	  idBill int,
	  status int not null default 0, --1: đang chờ nhận món
	 constraint FK_5 foreign key (idBill) references Bill(id)
)
go

--insert into Promotion values


-------
create table TimeKeep
(
	id int primary key NOT NULL,
	idEmployee nvarchar(50) NOT NULL,
	Date date NOT NULL,
	CheckIn time(7) NOT NULL,
	CheckOut time(7) NOT NULL,
	Note nchar(10) NULL,
	constraint FK_6 foreign key (idEmployee) references Employee(idEmployee)

)
------
create table Shifts
(	idShift nvarchar(50) primary key NOT NULL,
	StartDate nvarchar(50) NOT NULL,
	EndDate nvarchar(50) NOT NULL,
	Note nvarchar(500) NULL,
	idEmployee nvarchar(50) ,
	constraint FK_7 foreign key (idEmployee) references Employee(idEmployee)
)
insert into Shifts values
	(N'Ca 1', N'7:00', N'11:00', NULL, 'N02'),
	(N'Ca 2', N'11:05', N'16:05', NULL, 'N01'),
	(N'Ca 3', N'16:10', N'20:00', NULL, 'N03'),
	(N'Ca 4', N'20:10', N'22:00', NULL, 'N04');
--- proc login
CREATE PROC USP_Login
	@username nvarchar(100),
	@password nvarchar(100)
AS
BEGIN
	select * from Account where username = @username and password = @password
END
GO
execute USP_Login 'Admin','@admin@';


	





