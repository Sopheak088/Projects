Create Database Inventory On (Name = SaleInventory, FileName = "D:\Database\Inventory.mdf",
Size = 5MB,MaxSize = Unlimited, FileGrowth = 2MB)
Log On (Name = SaleInventory_log, FileName = "D:\Database\Inventory_log.ldf",
Size = 4MB, MaxSize = Unlimited, FileGrowth =10%)
GO
--MaxSize=4GB
USE Inventory
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
