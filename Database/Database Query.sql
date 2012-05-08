create database BMB
use BMB
----
create table Role
(
	RoleID int identity(1, 1) primary key,
	Name nvarchar(100),
	Description nvarchar(500)
)
----
create table Members
(
	MemberID int identity(1,1) primary key,
	Name nvarchar(100),
	DoB datetime,
	Address nvarchar(300),
	RoleID int foreign key references Role(RoleID)
)
-----
create table Patient
(
	PatientID int identity(1,1) primary key,
	Name nvarchar(100),
	DoB datetime,
	Address nvarchar(300),
)
------
create table Faculty
(
	FacID int identity(1,1) primary key,
	Name nvarchar(100)
)
-----
create table Doctor
(
	MemberID int identity(1,1) primary key,
	FacID int foreign key references Faculty(FacID),
	foreign key(MemberID) references Members(MemberID)
)
-------------
create table MedicalBook
(
	MedicalBookID int identity(1,1) primary key,
	Description nvarchar(max),
	foreign key(MedicalBookID) references Patient(PatientID)
	
)
----
create table MedicalHistory
(
	MedicalHistoryID int identity(1,1) primary key,
	ExamDate datetime,
	DiseaseStatus nvarchar(max),
	Diagnosis nvarchar(max),
	MedicalBookID int foreign key references MedicalBook(MedicalBookID)
)
------------
create table Nurse
(
	MemberID int identity(1,1) primary key,
	foreign key(MemberID) references Members(MemberID)
)
------------
create table Testing
(
	TestingID int identity(1,1) primary key,
	MemberID int foreign key references Nurse(MemberID),
	PatientID int foreign key references Patient(PatientID),
	TestingType nvarchar(200),
	Date datetime,
	Description nvarchar(max)
)
------------
create table Treatment
(
	TreatmentID int identity(1,1) primary key,
	MemberID int foreign key references Doctor(MemberID),
	PatientID int foreign key references Patient(PatientID),
	Date datetime,
	ExamDetails nvarchar(max),
	Diagnosis nvarchar(max),
	Description nvarchar(max)
)