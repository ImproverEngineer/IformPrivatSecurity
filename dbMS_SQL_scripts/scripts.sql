--1) Создать базу данных 
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
	FILENAME = 'E:\project\InformPrivatSecurity\db_MS_SQL\log', -- Лог и базу стоит хранить в разных местах
	SIZE = 5MB,
	MAXSIZE = 10GB,
	FILEGROWTH =5%
)

--2) Создать таблицы 

Use InformPrivateSecure
go
-- Стиль оформление таблиц CamelCase
-- ПП -Переодическая проверка (PeriodicInspection)
-- Охраники (Workers)
-- МК - Медецинская комисия (MedicalCommission)
-- МЦ - Медецинский центр (MedicalCenter)
-- Удостоверение (IdentityСard)
-- Разряд (Discharge)
-- НП - Начальная подготовка (InitialTraining)
-- Образовательное учереждение (EducationalInstitutions)

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
	[medicalCenterID] int null,-- медецинский центр
	[code] varchar(10),		   -- код
	[Date] datetime,		   -- дата начала
	[valiedPeriod] int,		   -- период действия
	[extenxionDate] datetime,  -- дата продления
	CONSTRAINT PK_MedicalCommission PRIMARY KEY ([id]),
	CONSTRAINT FK_MedikalCenter FOREIGN KEY ([medicalCenterID]) REFERENCES MedicalCenter([id])
)

create table Discharge(
	[id] int Identity(1,1) PRIMARY KEY NOT NULL,
	[code] varchar(10),
	[discription] varchar(50)
)

-- Образовательное учереждение
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
	[date] datetime NOT NULL, -- Дата выдачи
	CONSTRAINT FK_EducationalInstitutionsID FOREIGN KEY (EducationalInstitutionsID) REFERENCES EducationalInstitutions(id),
)

create table IdentityСard(
	[id] int Identity(1,1) PRIMARY KEY NOT NULL,
	[dischrgeID] int not null,
	[InitialTrainingID] int not null, 
	[date] datetime not null, --Дата действия		
	[validPeriod] datetime default dateadd(day,365,getdate()),--задать дату действия с начала создания плюс 365 дней
	workersId int null, --указать к какому человеку привязан "идентификатор охраника"
	deleted bit null,
	CONSTRAINT FK_InitialTraining FOREIGN KEY (InitialTrainingID) REFERENCES InitialTraining(id),
	CONSTRAINT FK_Dischrge FOREIGN KEY (dischrgeID) REFERENCES Discharge(id),
)

create table Workers(
	[id] int Identity(1,1), -- идентификатор человека
	[name] varchar(30) not null,
	[surname] varchar(30) not null,
	[middleName] varchar(30) not null,
	[birthday] datetime not null,
	[telefon] varchar(20) null,
	[IdentityCard] int null,
	[MedicalCommissionID] int null,
	[deleted] bit,		-- Признак увольнения
	CONSTRAINT PK_idWorkers PRIMARY KEY ([id]), -- необходимо зарание задовать ключи
	CONSTRAINT FK_MedicalCommission FOREIGN KEY ([MedicalCommissionID]) REFERENCES MedicalCommission([id]),
	CONSTRAINT FK_IdentityCard FOREIGN KEY ([IdentityCard]) REFERENCES IdentityСard([id])
)
CREATE INDEX workersIndex ON Workers ([name] asc, [surname] ASC, [middleName] asc)

--переодическая проверка
create table PeriodicInspection(
	[id] int Identity(1,1),
	[dateCreate] datetime not null, --дата создания
	[validate] int null, -- срок действия по умолчанию поставим 330 дней
	[extensionDate] datetime null, --дата продления
	[workerId] int not null,
	CONSTRAINT PK_idPeriodicInspection PRIMARY KEY ([id]),
	CONSTRAINT FK_workers FOREIGN KEY ([workerId]) REFERENCES dbo.Workers([id])
)

-- 3 ) Создаем процедуры для работы со справочниками 
-- Под понятия справочники попадают разряд, медецинский центры, учебные заведения 
/*-------------------------------------------------------------------------------------
	Справочник медецинских центров
*/-------------------------------------------------------------------------------------
Use InformPrivateSecure
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 29.03.2023
-- Description:	Процедура пишет новое медецинское учереждение в таблицу
-- =============================================
CREATE PROCEDURE AddMedicalCenter	
	@MedicalCenterName varchar(50), --Наименование медецинского центра
	@addres varchar(50) null,		-- Адрес медецинского центра
	@tel varchar(20) null			-- Телефон Центра
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
-- Вставляем туда данные 
exec AddMedicalCenter 'ГБУЗППК', 'ул. Пушкина, 85, Пермь, Пермский край','8 (342) 236-44-31';
exec AddMedicalCenter 'ГБУЗ №4', 'ул. Куфонина, 12, каб. 217, Пермь, Пермский край','8 (342) 222-01-09';
exec AddMedicalCenter 'Поликлиника № 5','ул. Яблочкова, 21, Пермь, Пермский край','8 (342) 269-48-57';
exec AddMedicalCenter 'ГБУЗ ПК ГКП № 2','ул. Братьев Игнатовых, 3, Пермь, Пермский край', '8 (342) 221-79-99';

-- Работаем только со view для любой таблицы
CREATE VIEW v_MedicalCenter 
as
select * from dbo.MedicalCenter;

/*---------------------------------------------------------------------------------------------------------------------
	Справочник Разрядов Охраника
*/---------------------------------------------------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 29.03.2023
-- Description:	Процедура добавляет Разряд охраника.
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
exec AddDischarge '1', 'Без оружия';
exec AddDischarge '2', 'С травматичесим оружием';
exec AddDischarge '3', 'Оружие и специальные средства';
Create view v_Discharge
as
select * from Discharge

/*----------------------------------------------------------------------------------------------------------------------
	Учебные заведения
*/----------------------------------------------------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 29.03.2023
-- Description:	Процедура добавляет учебное заведение в справочник учебных заведений
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
exec AddEducationalInstitutions 'ЧУ ДПО "Алекс"','025451 от 7 ноября 2011 г','город Пермь,ул.Комиссара Пожарского,д. 19';
exec AddEducationalInstitutions 'ЧУ ДПО "Олимп"','59Л01 0003334 от 24 мая 2016 г','ул.Героев Хасана,д.7,корпус а,офис 251';
exec AddEducationalInstitutions 'ЧУ ДПО"Спартак-Профи"','6465 от 19 августа 2019 г.',' город Пермь, ул. Плеханова, д. 39';

Create view v_EducationalInstitutions
as
select * from EducationalInstitutions
