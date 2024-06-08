--[PEUN ARTH :: Uy chamroeun]--


--Create View 
create view vInsuranceInfo 
as 
select 
	InsuranceID,
	CompanyName,
	PolicyNumber,
	ExpirationDate,
	Amount,
	Description,
	PatientID
from tbInsurance
GO
---------------------
--select *from vInsuranceInfo
--select *from tbInsurance
---------------------------
--------Procedure Insert info in row------
Create proc spInsertInsurance
	@InsuranceID int OUTPUT,
	@CompanyName varchar(50),
	@PolicyNumber varchar(5),
	@EfefectiveDate date,
	@ExpirationDate date,
	@Amount money,
	@CompanyContact varchar (50),
	@Description varchar(255),
	@PateintID int
AS
BEGIN
INSERT tbInsurance values
(
	@CompanyName,
	@PolicyNumber,
	@EfefectiveDate,
	@ExpirationDate,
	@Amount,
	@CompanyContact,
	@Description,
	@PateintID
)
set @InsuranceID = @@IDENTITY
END
GO
---USING [  EXECUTE spInsertInsurance ...parameter... ]

---------Update Row insurance tabel ---------------
Create proc spUpadteInsurance
	@InsuranceID int,
	@CompanyName varchar(50),
	@PolicyNumber varchar(5),
	@EfefectiveDate date,
	@ExpirationDate date,
	@Amount money,
	@CompanyContact varchar (50),
	@Description varchar(255),
	@PateintID int
AS
BEGIN
UPDATE tbInsurance
SET CompanyName = @CompanyName,
	PolicyNumber = @PolicyNumber,
	EffectiveDate = @EfefectiveDate,
	ExpirationDate = @ExpirationDate,
	Amount = @Amount,
	CompanyContact = @CompanyContact,
	Description = @Description,
	PatientID = @PateintID
	where InsuranceID = @InsuranceID
END
GO

-------------------------------------------------
----------------[Delete 1 row by Insurance ID]---
Create proc spDeleteRowInsurance
	@InsuranceID int
AS
DELETE tbInsurance 
	where InsuranceID = @InsuranceID
GO
---------------------------------------------------
-----------[Search Insurance by ID]----------------
Create PROCEDURE spSearchByInsuranceID 
	@InsuranceID int
AS
SELECT *from tbInsurance 
	where InsuranceID =  @InsuranceID
GO
----------------------------------------------------
exec spSearchByInsuranceID 2