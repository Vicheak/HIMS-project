create view vDiagnosis
as
select
DiagnosisID,
DiagnosisDate,
Description,
Status,
PhysicianNote,
PatientID,
StaffID
from tbDiagnosis;
GO
--Procedure Insert Diagnosis in row--
create proc pInsertDiagnosis
@PatientID char(6),
@StaffID smallint,
@DiagnosisID int output,
@DiagnosisDate date,
@Status varchar(50),
@Description varchar(255),
@PhysicianNote varchar(255)
As
Begin
Insert tbDiagnosis values(
@DiagnosisDate,
@Description,
@Status,
@PhysicianNote,
@PatientID,
@StaffID
)
set @DiagnosisID = @@IDENTITY
END
GO
--Update Diagnosis Table--
create proc pUpdateDiagnosis
@DiagnosisID int output,
@DiagnosisDate date,
@Description varchar(255),
@Status varchar(50),
@PhysicianNote varchar(255),
@PatientID char(6),
@StaffID smallint
AS
UPDATE tbDiagnosis
SET DiagnosisDate = @DiagnosisDate,
	Description = @Description,
	Status = @Status,
	PhysicianNote = @PhysicianNote,
	StaffID = @StaffID
	where DiagnosisID = @DiagnosisID
GO
--Delete by Patient ID--
create proc spDeletePatientID
@PatientID char(6)
AS
DELETE tbDiagnosis
where PatientID = @PatientID
GO
--Search by Patient ID--
create proc spSearchPatientID
@PatientID char(6)
AS
select* from tbDiagnosis
where PatientID = @PatientID
GO