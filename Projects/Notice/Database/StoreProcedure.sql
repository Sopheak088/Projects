-- ListAllNote
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllNote]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllNote
GO

CREATE PROCEDURE ListAllNote 
AS 
BEGIN
	SELECT ID,NoteDate,Note, CreateBy FROM NOTE ORDER BY NoteDate DESC
END
GO
-- ListAllPayment
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllPayment
GO

CREATE PROCEDURE ListAllPayment 
AS 
BEGIN
	SELECT ID,PaymentDate, Items,Price,CreateBy FROM PAYMENT ORDER BY PaymentDate DESC
END
GO
INSERT INTO LOVECOUNT(Name, Photo, StartDate, Status, CreateDate, CreateBy)
VALUES('Your Name', null, '2018-07-29','Male','2018-07-29','Sopheak')
GO
INSERT INTO LOVECOUNT(Name, Photo, StartDate, Status, CreateDate, CreateBy)
VALUES('Her Name', null, '2018-07-29','Female','2018-07-29','Sopheak')
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllYourPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllYourPayment
GO
CREATE PROCEDURE ListAllYourPayment 
AS 
BEGIN
	SELECT ID,PaymentDate, Items,Price,CreateBy FROM YOURPAYMENT ORDER BY PaymentDate DESC
END
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllBank]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllBank
GO
CREATE PROCEDURE ListAllBank
AS 
BEGIN
	SELECT ID,[Date],Amount,Type,CreateBy FROM BANK ORDER BY [Date] DESC
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllIncome
GO
CREATE PROCEDURE ListAllIncome 
AS 
BEGIN
	SELECT ID,IncomeDate, Amount,IncomeFrom ,CreateBy FROM INCOME ORDER BY IncomeDate DESC
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllBankSaving]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllBankSaving
GO
CREATE PROCEDURE ListAllBankSaving
AS 
BEGIN
	SELECT ID,[Date],Amount,Type,CreateBy FROM BANK_SAVING ORDER BY [Date] DESC
END
Go
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllEvent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllEvent
GO
CREATE PROCEDURE ListAllEvent 
AS 
BEGIN
	SELECT ID,EventDate, EventName,CreateBy FROM [ALLEVENT] ORDER BY EventDate
END
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ListAllAbout]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].ListAllAbout
GO

CREATE PROCEDURE ListAllAbout 
AS 
BEGIN
	SELECT ID,Note, CreateBy FROM ABOUT
END
GO
