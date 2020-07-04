use MyShopDB06
create table HistoryLog
(
	Id INT IDENTITY PRIMARY KEY,
    NameTable  NVARCHAR(200) NOT NULL,
    TypeOperation NVARCHAR(200) NOT NULL,
    CreateAt DATETIME NOT NULL DEFAULT GETDATE()
);
Create procedure CreateRecHistoryLog
	@tableName nvarchar(50),
	@openInfo nvarchar(50)
AS
INSERT INTO Historylog(NameTable, Typeoperation)
VALUES (@tableName, @openInfo)

create trigger Customers_INSERT
ON Customers
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'Insert, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Customers_UPDATE
ON Customers
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'Updated, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Customers_DELETE
ON Customers
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Manufacturers_INSERT
ON Manufacturers
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'Insert, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Manufacturers_UPDATE
ON Manufacturers
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'UPDATED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Manufacturers_DELETE
ON Manufacturers
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger OrderDetails_INSERT
ON OrderDetails
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;
go
create trigger OrderDetails_UPDATE
ON OrderDetails
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger OrderDetails_DELETE
ON OrderDetails
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Orders_INSERT
ON Orders
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Orders_Update
ON Orders
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Orders_DELETE
ON Orders
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted; 
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Products_INSERT
ON Products
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Products_UPDATE
ON Products
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Products_DELETE
ON Products
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Shippers_INSERT
ON Shippers
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Shippers_UPDATE
ON Shippers
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger Shippers_DELETE
ON Shippers
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger TrafficProducts_INSERT
ON Shippers
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger TrafficProducts_UPDATE
ON Shippers
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger TrafficProducts_DELETE
ON Shippers
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger TypesProduct_INSERT
ON TypesProduct
AFTER INSERT
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger TypesProduct_UPDATE
ON TypesProduct
AFTER UPDATE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from inserted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

create trigger TypesProduct_DELETE
ON TypesProduct
AFTER DELETE
AS
BEGIN
declare @x int,@y nvarchar(200);
select @x=Id from deleted;
set @y = 'DELETED, Id= '+convert(char(10),@x);
	EXEC CreateRecHistoryLog 'Customers', @y;
END;

select * from
use MyShopDB06;
go


create trigger TrafficProduct_To_Product
ON TrafficProducts
AFTER UPDATE
AS
BEGIN
declare @x int,@y int;
select @y=ProductCount from inserted; 
select @x=Id from inserted;
UPDATE Products SET ProductCount=ProductCount+@y Where Id=@x;
END;

create function CalcOrderPrice (@x int)
RETURNS MONEY
AS
BEGIN
	DECLARE 
		@calc money;
		SET @calc=(SELECT Price FROM OrderDetails od where od.Id=@x)*(SELECT CountProduct FROM OrderDetails where OrderDetails.Id=@x);
		return @calc;
END;

create trigger Order_Details_UP
ON OrderDetails
AFTER INSERT
AS
BEGIN
declare @x int, @pc int;
select @x=Id from inserted;
select @pc=CountProduct from inserted;
	INSERT INTO TrafficProducts VALUES
	(
		Getdate(), 0, 0, @pc, dbo.CalcOrderPrice(@x), @x
	)
END;

insert into Customers VALUES
('Федотов','Артем','Борисович','fedot35@gmail.com',35),
('Стрельцова','Анна','Сергеевна','annuta@gmail.com',25),
('Комаров','Антон','Николаевич','kumarik@gmail.com',44)

insert into Manufacturers VALUES
('Samsung'),
('LG'),
('Apple')

insert into Shippers values
('Child','asdsaf@gmail.com'),
('Chrome','rtuhgj@gmail.com'),
('Bubble','cvbg@gmail.com')

insert into TypesProduct values
('Смартфон'),
('Планшет'),
('Ноутбук')

insert into Products values
('34GP18',19560,23,2,1,1),
('457TH47',12365,11,3,2,2),
('X10',29560,23,1,3,3)

insert into Orders (NumberOrder,DateOrder,IdCustomer)values
('154852365',GETDATE(),2),
('1548521',GETDATE(),3),
('15485234',GETDATE(),1)

insert into OrderDetails values
(2,29560,1,3),
(2,12365,2,2),
(2,19560,3,1)

insert into TrafficProducts values
(GETDATE(),3,1,2,23658,2),
(GETDATE(),2,1,2,56781,2),
(GETDATE(),1,1,2,36541,2)

SELECT *FROM	ProductView
SELECT *FROM	CustomersView
SELECT *FROM	Agent
SELECT *FROM	TrafficProductsView
