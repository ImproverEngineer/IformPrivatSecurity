--1) ������� ���� ������ 
create database InformPrivateSecure
on
(
	NAME = InformPrivateSecure_data,
	FILENAME = 'E:\project\InformPrivatSecurity\db_MS_SQL\db',
	SIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME ='InformPrivateSecure_log',
	FILENAME = 'E:\project\InformPrivatSecurity\db_MS_SQL\log', -- ��� � ���� ����� ������� � ������ ������
	SIZE = 5MB,
	MAXSIZE = 10GB,
	FILEGROWTH =5%
)

--2) ������� ������� 

Use InformPrivateSecure
go
-- ����� ���������� ������ CamelCase
-- �� -������������� �������� (PeriodicInspection)
-- �������� (Workers)
-- �� - ����������� ������� (MedicalCommission)
-- �� - ����������� ����� (MedicalCenter)
-- ������������� (Identity�ard)
-- ������ (Discharge)
-- �� - ��������� ���������� (InitialTraining)
-- ��������������� ����������� (EducationalInstitutions)

create table MedicalCenter(
	[id] int Identity(1,1),
	[name] varchar(50),
	[addres] varchar(50),
	[tel] varchar(20)
	CONSTRAINT PK_MedicalCenter PRIMARY KEY ([id])
)
create INDEX MedicalCenterIndex on MedicalCenter([name] asc);

create table MedicalCommission(
	[id] int Identity(1,1),	   -- id
	[medicalCenterID] int null,-- ����������� �����
	[code] varchar(10),		   -- ���
	[Date] datetime,		   -- ���� ������
	[valiedPeriod] int,		   -- ������ ��������
	[extenxionDate] datetime,  -- ���� ���������
	CONSTRAINT PK_MedicalCommission PRIMARY KEY ([id]),
	CONSTRAINT FK_MedikalCenter FOREIGN KEY ([medicalCenterID]) REFERENCES MedicalCenter([id])
)

create table Discharge(
	[id] int Identity(1,1) PRIMARY KEY NOT NULL,
	[code] varchar(10),
	[discription] varchar(50)
)

-- ��������������� �����������
create table EducationalInstitutions(
	id int identity(1,1) PRIMARY KEY NOT NULL,
	Name varchar(50) not null,
	license varchar(50) null,
	address varchar(50) null,
)
create INDEX EducationalInstitutionsIndex on EducationalInstitutions([name] asc);


create table InitialTraining(
	id int identity(1,1) PRIMARY KEY NOT NULL ,
	code varchar(8) not null,
	EducationalInstitutionsID int Not NULL,
	[date] datetime NOT NULL, -- ���� ������
	CONSTRAINT FK_EducationalInstitutionsID FOREIGN KEY (EducationalInstitutionsID) REFERENCES EducationalInstitutions(id),
)

create table Identity�ard(
	[id] int Identity(1,1) PRIMARY KEY NOT NULL,
	[dischrgeID] int not null,
	[InitialTrainingID] int not null, 
	[date] datetime not null, --���� ��������		
	[validPeriod] datetime default dateadd(day,365,getdate()),--������ ���� �������� � ������ �������� ���� 365 ����
	workersId int null, --������� � ������ �������� �������� "������������� ��������"
	deleted bit null,
	CONSTRAINT FK_InitialTraining FOREIGN KEY (InitialTrainingID) REFERENCES InitialTraining(id),
	CONSTRAINT FK_Dischrge FOREIGN KEY (dischrgeID) REFERENCES Discharge(id),
)

create table Workers(
	[id] int Identity(1,1), -- ������������� ��������
	[name] varchar(30) not null,
	[surname] varchar(30) not null,
	[middleName] varchar(30) not null,
	[birthday] datetime not null,
	[telefon] varchar(20) null,
	[IdentityCard] int null,
	[MedicalCommissionID] int null,
	[deleted] bit,		-- ������� ����������
	CONSTRAINT PK_idWorkers PRIMARY KEY ([id]), -- ���������� ������� �������� �����
	CONSTRAINT FK_MedicalCommission FOREIGN KEY ([MedicalCommissionID]) REFERENCES MedicalCommission([id]),
	CONSTRAINT FK_IdentityCard FOREIGN KEY ([IdentityCard]) REFERENCES Identity�ard([id])
)
CREATE INDEX workersIndex ON Workers ([name] asc, [surname] ASC, [middleName] asc)

--������������� ��������
create table PeriodicInspection(
	[id] int Identity(1,1),
	[dateCreate] datetime not null, --���� ��������
	[validate] int null, -- ���� �������� �� ��������� �������� 330 ����
	[extensionDate] datetime null, --���� ���������
	[workerId] int not null,
	CONSTRAINT PK_idPeriodicInspection PRIMARY KEY ([id]),
	CONSTRAINT FK_workers FOREIGN KEY ([workerId]) REFERENCES dbo.Workers([id])
)

-- 3 ) ������� ��������� ��� ������ �� ������������� 
-- ��� ������� ����������� �������� ������, ����������� ������, ������� ��������� 
/*-------------------------------------------------------------------------------------
	���������� ����������� �������
*/-------------------------------------------------------------------------------------
Use InformPrivateSecure
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'��� - �� - ��' � '��� - �� - ��'
-- Create date: 29.03.2023
-- Description:	��������� ����� ����� ����������� ����������� � �������
-- =============================================
CREATE PROCEDURE AddMedicalCenter	
	@MedicalCenterName varchar(50), --������������ ������������ ������
	@addres varchar(50) null,		-- ����� ������������ ������
	@tel varchar(20) null			-- ������� ������
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		INSERT INTO dbo.MedicalCenter([name], [addres], [tel]) VALUES (@MedicalCenterName, @addres, @tel);
		SELECT cast(ID as varchar(10)) as id FROM dbo.MedicalCenter WHERE ID = @@IDENTITY
	END TRY
	BEGIN CATCH
		SELECT 'Error' as id
	END CATCH
END
GO
-- ��������� ���� ������ 
exec AddMedicalCenter '�������', '��. �������, 85, �����, �������� ����','8 (342) 236-44-31';
exec AddMedicalCenter '���� �4', '��. ��������, 12, ���. 217, �����, �������� ����','8 (342) 222-01-09';
exec AddMedicalCenter '����������� � 5','��. ���������, 21, �����, �������� ����','8 (342) 269-48-57';
exec AddMedicalCenter '���� �� ��� � 2','��. ������� ���������, 3, �����, �������� ����', '8 (342) 221-79-99';

-- �������� ������ �� view ��� ����� �������
CREATE VIEW v_MedicalCenter 
as
select * from dbo.MedicalCenter;

/*---------------------------------------------------------------------------------------------------------------------
	���������� �������� ��������
*/---------------------------------------------------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'��� - �� - ��' � '��� - �� - ��'
-- Create date: 29.03.2023
-- Description:	��������� ��������� ������ ��������.
-- =============================================
CREATE PROCEDURE AddDischarge 
	@Discharge varchar(10), 
	@discription varchar(50)
AS
BEGIN	
	SET NOCOUNT ON;
	BEGIN TRY
		INSERT INTO Discharge([code], [discription]) values (@Discharge, @discription);
		SELECT id FROM Discharge WHERE id = @@IDENTITY;
	END TRY
	BEGIN CATCH
		SELECT 'Error';
	END CATCH
END
GO
exec AddDischarge '1', '��� ������';
exec AddDischarge '2', '� ������������� �������';
exec AddDischarge '3', '������ � ����������� ��������';
Create view v_Discharge
as
select * from Discharge

/*----------------------------------------------------------------------------------------------------------------------
	������� ���������
*/----------------------------------------------------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'��� - �� - ��' � '��� - �� - ��'
-- Create date: 29.03.2023
-- Description:	��������� ��������� ������� ��������� � ���������� ������� ���������
-- =============================================
CREATE PROCEDURE AddEducationalInstitutions
	-- Add the parameters for the stored procedure here
	@name varchar(50), 
	@license varchar(50) null,
	@address varchar(50) null
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		INSERT INTO EducationalInstitutions([name], [license],[address]) values (@name, @license,@address);
		SELECT id FROM EducationalInstitutions WHERE id = @@IDENTITY;
	END TRY
	BEGIN CATCH
		SELECT 'Error';
	END CATCH
END
GO
exec AddEducationalInstitutions '�� ��� "�����"','025451 �� 7 ������ 2011 �','����� �����,��.��������� ����������,�. 19';
exec AddEducationalInstitutions '�� ��� "�����"','59�01 0003334 �� 24 ��� 2016 �','��.������ ������,�.7,������ �,���� 251';
exec AddEducationalInstitutions '�� ���"�������-�����"','6465 �� 19 ������� 2019 �.',' ����� �����, ��. ���������, �. 39';

Create view v_EducationalInstitutions
as
select * from EducationalInstitutions
