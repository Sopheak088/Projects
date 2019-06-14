--Version 1
Create Database SaleInventory On (Name = SaleInventory, FileName = "D:\Lesson\MyProject\SaleInventory.mdf",
Size = 5MB,MaxSize = Unlimited, FileGrowth = 2MB)
Log On (Name = SaleInventory_log, FileName = "D:\Lesson\MyProject\SaleInventory_log.ldf",
Size = 4MB, MaxSize = Unlimited, FileGrowth =10%)
GO
--MaxSize=4GB
USE SaleInventory
GO
CREATE TABLE tbEmployee(
empID char(5)NOT NULL,
empName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
empGender VARCHAR(1) NOT NULL,
dob DATE NOT NULL,
pos NVARCHAR(MAX) COLLATE Khmer_100_BIN NOT NULL,
salary MONEY NOT NULL,
address NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
empContact NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
hired date NOT NULL,
photo VARBINARY(MAX) NOT NULL,
stopwork bit
CONSTRAINT tbEmployee_pk PRIMARY KEY(empID)
)
GO
CREATE TABLE tbSupplier(
supID INT IDENTITY(1,1) PRIMARY KEY,
supName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
supContact NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL
)
GO
CREATE TABLE tbCategory(
catID int  IDENTITY(1,1) PRIMARY KEY,
category NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL
)
GO
CREATE TABLE tbCustomer(
cusID int IDENTITY(1,1) PRIMARY KEY,
cusName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
Contact NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL
)
GO
CREATE TABLE tbSale(
saleID INT IDENTITY(1,1),-- PRIMARY KEY,
saleDate DATETIME NOT NULL,
empID char(5)NOT NULL,
empName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
cusID INT NOT NULL,
cusName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
saleTotal MONEY NOT NULL
CONSTRAINT tbSale_pk PRIMARY KEY(saleID),
CONSTRAINT fk_tbEmployee FOREIGN KEY(empID)REFERENCES tbEmployee(empID), 
CONSTRAINT fk_tbCustomer FOREIGN KEY(cusID) REFERENCES tbCustomer(cusID)
)
GO
CREATE TABLE tbProduct(
proID varchar(13),
proName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
qty INT,
upis MONEY,
sup MONEY,
catID int
CONSTRAINT tbProduct_pk PRIMARY KEY(proID)
CONSTRAINT fk_tbCategory FOREIGN KEY (catID) REFERENCES tbCategory(catID),
)
GO
CREATE TABLE tbSaleDetail(
saleID INT NOT NULL,
proID VARCHAR(13) NOT NULL,
proName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
saleqty INT NOT NULL,
saleprice MONEY NOT NULL,
saleAmount MONEY NOT NULL
CONSTRAINT pk_tbSaleDetail PRIMARY KEY(saleID,proID),
CONSTRAINT fk_tbSale FOREIGN KEY (saleID) REFERENCES tbSale(saleID)ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT fk_tbProduct FOREIGN KEY (proID) REFERENCES tbProduct(proID)ON UPDATE CASCADE ON DELETE CASCADE
)
GO
------------------------------------------------------------------------------
CREATE TABLE tbImport(
impID int IDENTITY(1,1) NOT NULL,
impDate DATETIME NOT NULL,
supID int ,
supName NVARCHAR(MAX)COLLATE Khmer_100_BIN,
empID char(5),
empName NVARCHAR(MAX) COLLATE Khmer_100_BIN,
impTotal MONEY
CONSTRAINT tbImport_pk PRIMARY KEY(impID)
CONSTRAINT fk_tbSupplier FOREIGN KEY(supID) REFERENCES tbSupplier(supID),
CONSTRAINT tbEmployeefk FOREIGN KEY(empID)REFERENCES tbEmployee(empID) 
)
GO
CREATE TABLE tbImportDetail(
impID INT NOT NULL,
proID varchar(13) NOT NULL,
proName NVARCHAR(MAX)COLLATE Khmer_100_BIN NOT NULL,
impqty INT NOT NULL,
impPrice MONEY NOT NULL,
amount MONEY NOT NULL
CONSTRAINT pk_tbImportDetail PRIMARY KEY(impID,proID)
CONSTRAINT fktbImport FOREIGN KEY (impID) REFERENCES tbImport(impID)ON UPDATE CASCADE ON DELETE CASCADE,
CONSTRAINT fktbProduct FOREIGN KEY (proID) REFERENCES tbProduct(proID)ON UPDATE CASCADE ON DELETE CASCADE
)
GO
----------------------------------------------------------------------------------


CREATE TABLE tbUser(
empID char(5) NOT NULL PRIMARY KEY,
empName NVARCHAR(MAX) COLLATE Khmer_100_BIN NOT NULL,
username NVARCHAR(MAX) NOT NULL,
upassword NVARCHAR(MAX) NOT NULL,
empPos NVARCHAR(MAX) NOT NULL,
)
GO
CREATE Procedure InsertEmployee(@i CHAR(5),
								@n nvarchar(max),
								@g nchar(1),
								@d date,
								@po nvarchar(max),
								@s money,
								@a nvarchar(max),
								@c varchar(max),
								@h date,
								@pt varbinary(max)
								)
AS 
begin
	Insert into tbEmployee 
	values(@i,@n,@g,@d,@po,@s,@a,@c,@h,@pt,'false')
end
GO

Create function GetEmployee()
returns table as return
(select empID as [ID], empName as [Name], empGender as [Sex],dob as [BirthDate],
		pos as [Position], salary as [Salary],[address] as [Address],
		empContact as [Contact],hired as [Hired Date],photo as [Photo]
 from tbEmployee where stopwork='false')
 GO
 CREATE Procedure UpdateEmployee(@i CHAR(5),
								@n nvarchar(max),
								@g nchar(1),
								@d date,
								@po nvarchar(max),
								@s money,
								@a nvarchar(max),
								@c varchar(max),
								@h date,
								@pt varbinary(max)
								)
AS 
begin
	update tbEmployee
	set empName=@n,
		empGender=@g,
		dob=@d,
		pos=@po,
		salary=@s,
		[address]=@a,
		empContact=@c,
		hired=@h,
		photo=@pt
	where empID=@i
end
GO
 CREATE Procedure DeleteEmployee(@i CHAR(5),
								@n nvarchar(max),
								@g nchar(1),
								@d date,
								@po nvarchar(max),
								@s money,
								@a nvarchar(max),
								@c varchar(max),
								@h date,
								@pt varbinary(max)
								)
AS 
begin
	update tbEmployee
	set
	stopwork='true'
	where empID=@i
end
GO
create procedure SEMPBYName(@s nvarchar(max))
as
begin
	select empID as [ID], empName as [Name], empGender as [Sex],dob as [BirthDate],
		pos as [Position], salary as [Salary],[address] as [Address],
		empContact as [Contact],hired as [Hired Date],photo as [Photo]
	from tbEmployee
	where empName like N'%' + @s + '%' AND stopwork='false'
end
GO
create procedure SEMPBYID(@s nvarchar(max))
as
begin
	select empID as [ID], empName as [Name], empGender as [Sex],dob as [BirthDate],
		pos as [Position], salary as [Salary],[address] as [Address],
		empContact as [Contact],hired as [Hired Date],photo as [Photo]
	from tbEmployee
	where empID like '%' + @s + '%' AND stopwork='false'
end
GO
------------------------Category----------------
create function GetCategory()
returns table as return 
(select *from tbCategory)
GO
create procedure InsertCategory(@i int,@c nvarchar(max))
as
begin
	insert into tbCategory
	values(@c)
end
GO
create procedure UpdateCategory(@i int,@c nvarchar(max))
as
begin
	update tbCategory
	set category=@c
	where catID=@i	
end
GO
create procedure SCat(@c nvarchar(max))
as
begin
	select *from tbCategory
	where category like N'%' + @c + '%'
end
GO
---------------Customer------------
create function GetCustomer()
returns table as return
(select *from tbCustomer)
GO
create procedure InsertCustomer(@i int,@n nvarchar(max),@c nvarchar(max))
as
begin
	insert into tbCustomer(cusName,Contact)
	values(@n,@c)
end
GO
create procedure UpdateCustomer(@i int,@n nvarchar(max),@c nvarchar(max))
as
begin
	update tbCustomer 
	set	cusName=@n,Contact=@c
	where cusID=@i
end
GO
create procedure SCusByName(@n nvarchar(max))
as
begin
	select *from tbCustomer
	where cusName like N'%' + @n + '%'
end
GO
create procedure SCusByCon(@n nvarchar(max))
as
begin
	select *from tbCustomer
	where Contact like N'%' + @n + '%'
end
GO
-------------------Import Detail------------
create type ImportMaster as table
(
	ImpDate Datetime, --import date
	supID int, --supplier id
	supName nvarchar(max), --supplier name
	supCon nvarchar(max), --supplier contact
	empID char(5), --employee id
	empName nvarchar(max), --employee name
	Amount money --total
)
Go
create type ImportDetail as Table(
	proID varchar(13),--product id
	proName nvarchar(max),--product name
	qty int, --product quantity
	upis money,--unit price in stock
	catID int --category id
)
GO
create procedure InsertImport(@IM as ImportMaster READONLY , @ID as ImportDetail READONLY)
AS 
begin
	declare @sid int--supplier id
	declare @sn nvarchar(max) --supplier name
	declare @imid int --import id
	declare @imd datetime --import date
	declare @eid char(5) --employee id
	declare @en nvarchar(max) --employee name
	declare @ta money--total amount

	select @sid=supID from @IM --Get supplier id from import master
	if(@sid=0) --check new supplier
		begin --2
			insert into tbSupplier(supName,supContact)
			select supName,supCon from @IM

			select @sid=max(supID) from tbSupplier

			select @imd=impDate,
					@sn=supName ,
					@eid=empID,
					@en=empName,
					@ta=Amount 
			from @IM

			insert into tbImport(impDate,supID,supName,empID,empName,impTotal)
			values(@imd,@sid,@sn,@eid,@en,@ta)
		end --2
	else
		begin--3
			insert into tbImport(impDate,supID,supName,empID,empName,impTotal)
			select ImpDate,supID,supName,empID,empName,Amount from @IM

		end --3

		select @imid =max(impID) from tbImport

		declare @pid varchar(13)
		declare @pn nvarchar(max)
		declare @qty int
		declare @upis money
		declare @sup money
		declare @cat int

		declare csDetail cursor scroll dynamic
		for select * from @ID
		
		open csDetail

		fetch first from csDetail into @pid,@pn,@qty,@upis,@cat
		while(@@FETCH_STATUS=0)
			begin --4
				if((select count(proID)from tbProduct where proID=@pid)=0)
					begin --5
						insert into tbProduct
						values(@pid,@pn,@qty,@upis,@upis+2,@cat)
					end --5
				else
					begin --6
						update tbProduct
						set
							qty=qty+@qty,
							upis=@upis
						where proID=@pid
					end --6
				insert into tbImportDetail
				values(@imid,@pid,@pn,@qty,@upis,@qty*@upis)

				fetch next from csDetail into @pid,@pn,@qty,@upis,@cat
			end --4
			close csDetail --close cursor
			deallocate csDetail
end
GO
-------------------------sale Detail----------------
create type SaleMaster as Table(
	saleDate Datetime,
	empID char(5),
	empName nvarchar(max),
	cusID int,
	cusName nvarchar(max),
	cusCon nvarchar(max),
	sTotal money
)
GO
create type SaleDetail as table(
	proID varchar(13),
	proName nvarchar(max),
	qty int,
	up money
)
GO
create procedure InsertSale(@SM as SaleMaster readonly,@SD as SaleDetail readonly,@sid int output)
as
begin
	--declare @sid int --sale id
	declare @sda date --sale date
	declare @eid char(5) --employee id
	declare @en nvarchar(max) --employee name
	declare @cid int --customer id
	declare @cn nvarchar(max) --customer name
	declare @ta money --toatl amount

	select @cid=cusID from @SM

	if(@cid=0)
		begin --2
			insert into tbCustomer(cusName,Contact)
			select cusName,cusCon from @SM

			select @cid =max(cusID) from tbCustomer

			select @sda=SaleDate,@eid=empID,@en=empName,@cn=cusName,@ta=sTotal from @SM

			insert into tbSale(saleDate,empID,empName,cusID,cusName,saleTotal)
			values(@sda,@eid,@en,@cid,@cn,@ta)
		end --2
	else
		begin --3
			insert into tbSale(saleDate,empID,empName,cusID,cusName,saleTotal)
			select saleDate,empID,empName,cusID,cusName,sTotal from @SM
		end --3
	select @sid=max(saleID) from tbSale
	declare @pid varchar(13) --product id
	declare @pn nvarchar(max) --product name
	declare @q int --Quantity
	declare @p money --Unot price

	declare csDetail cursor scroll dynamic
	for select *from @SD

	open csDetail

	fetch first from csDetail into @pid,@pn,@q,@p
	while(@@FETCH_STATUS=0)
	begin --4
		update tbProduct
		set qty=qty-@q
		where proID=@pid

		insert into tbSaleDetail
		values(@sid,@pid,@pn,@q,@p,@q*@p)

		fetch next from csDetail into @pid,@pn,@q,@p
	end --4
end

GO
-----------------------User Login------------------
create procedure UserLogin(@uid nvarchar(max),@pwd nvarchar(max))
as
begin
	select *from tbUser
	where lower(username)=lower(@uid) and upassword=@pwd
end
GO
create function GetNonUser()
	returns table as return
		(select *from tbEmployee where empID not in
		(select empID from tbUser))
GO
create function GetUser()
returns table as return
(select empID,username from tbUser)
GO
create function GetAUSER(@I char(50))
returns table as return
(select empID,username from tbUser where empID=@I)
GO
create procedure DelAcc(@I char(5))
as
begin
	delete from tbUser where empID=@I
end
GO
create procedure CreateAcc(@I char(5),@EN nvarchar(max),@UN nvarchar(max), 
							@PW nvarchar(max),@PO nvarchar(max))
as
begin
	insert into tbUser
	values(@i,@EN,@UN,@PW,@PO)
end
GO
create procedure UpdateAcc(@I char(5),@EN nvarchar(max),@UN nvarchar(max), 
							@PW nvarchar(max),@PO nvarchar(max))
as
begin
	update tbUser
	set
	username=@UN,upassword=@PW where empID=@I
end
GO
--------------------------Product-------------------------
create procedure UpdateProduct(@pi varchar(13), 
							   @pn nvarchar(max),
							   @q int,
							   @up money,
							   @su money,
							   @ci int
								)
as
begin
	update tbProduct
	set
	proName=@pn,
	qty=@q,
	upis=@up,
	sup=@su,
	catID=@ci
	where proID=@pi
end

GO
------------------------------
create procedure ImportReport(@EI char(5),@SI int,@SA datetime,@SO datetime)
as
begin
	IF(@SI=0)
		begin
			select I.impID,I.impDate,I.supName,ID.proID,ID.proName,ID.impqty,ID.impPrice,ID.amount from tbImport I 
			inner join tbImportDetail ID on I.impID=ID.impID

			where I.empID=@EI and

			convert(date,impDate)>=convert(date,@SA)
			and 
			convert(date,impDate)<=convert(date,@SO)
			--(year(I.impDate)>=year(@SA) and month(I.impDate)>=month(@SA) and day(I.impDate)>=day(@SA))
			--and
			--(year(I.impDate)<=year(@SO) and month(I.impDate)<=month(@SO) and day(I.impDate)<=day(@SO))
		end
	else
	begin
		select I.impID,I.impDate,I.supName,ID.proID,ID.proName,ID.impqty,ID.impPrice,ID.amount from tbImport I 
			inner join tbImportDetail ID on I.impID=ID.impID

			where I.empID=@EI and I.supID=@SI and
			convert(date,impDate)>=convert(date,@SA)
			and 
			convert(date,impDate)<=convert(date,@SO)
			--(year(I.impDate)>=year(@SA) and month(I.impDate)>=month(@SA) and day(I.impDate)>=day(@SA))
			--and
			--(year(I.impDate)<=year(@SO) and month(I.impDate)<=month(@SO) and day(I.impDate)<=day(@SO))
	
	end
end
GO
-----------------Supplier------------------
create function GetSupplier()
returns table as return
(select *from tbSupplier)
GO
create procedure InsertSupplier(@i int,
							   @s nvarchar(max),
							   @c nvarchar(max)
								)
as
begin
	insert into tbSupplier(supName,supContact)
	values(@s,@c)
end
GO
create procedure UpdateSupplier(@i int,
							   @s nvarchar(max),
							   @c nvarchar(max)
								)
as
begin
	update tbSupplier
	set
	supName=@s,
	supContact=@c
	where supID=@i
end
GO
create procedure SearchSup(@s nvarchar(max))
as
begin
	select * from tbSupplier where supName like N'%' + @s + '%'
end
GO

