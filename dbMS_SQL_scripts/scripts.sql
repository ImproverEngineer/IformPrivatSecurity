USE [InformPrivateSecure]
GO
/****** Object:  Table [dbo].[MedicalCenter]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalCenter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[addres] [varchar](50) NULL,
	[tel] [varchar](20) NULL,
 CONSTRAINT [PK_MedicalCenter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_MedicalCenter]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_MedicalCenter] 
as
select * from dbo.MedicalCenter;
GO
/****** Object:  Table [dbo].[Discharge]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discharge](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](10) NULL,
	[discription] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_Discharge]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_Discharge]
as
select * from Discharge
GO
/****** Object:  Table [dbo].[EducationalInstitutions]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationalInstitutions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[license] [varchar](50) NULL,
	[address] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_EducationalInstitutions]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_EducationalInstitutions]
as
select * from EducationalInstitutions
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[surname] [varchar](30) NOT NULL,
	[middleName] [varchar](30) NOT NULL,
	[birthday] [datetime] NOT NULL,
	[telefon] [varchar](20) NULL,
	[IdentityCard] [int] NULL,
	[MedicalCommissionID] [int] NULL,
	[deleted] [bit] NULL,
	[photo] [varchar](500) NULL,
 CONSTRAINT [PK_idWorkers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_workers]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[v_workers]
as
select
id as 'id'
, name as 'name'
, surname as 'surname'
, middleName as 'middleName'
, birthday as 'birthday'
, telefon as 'telefon'  
, deleted as 'deleted'
, photo as 'photo'
from [dbo].[Workers] w ;
GO
/****** Object:  Table [dbo].[MedicalCommission]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalCommission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[medicalCenterID] [int] NULL,
	[code] [varchar](10) NULL,
	[Date] [datetime] NULL,
	[valiedPeriod] [int] NULL,
	[workersId] [int] NULL,
 CONSTRAINT [PK_MedicalCommission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_MedicalCommission]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   view [dbo].[v_MedicalCommission]
as
select  mc.[name] as 'name', 
		m.[code] as 'code', 
		m.[Date] as 'Date', 
		m.[valiedPeriod] as 'valiedPeriod', 		
		DATEADD(MONTH,valiedPeriod, Date)  as [extenxionDate],
		m.workersId as 'workersID'
from [dbo].[MedicalCommission] m 
left join [dbo].v_MedicalCenter mc on m.medicalCenterID = mc.id 
GO
/****** Object:  Table [dbo].[InitialTraining]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InitialTraining](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](8) NOT NULL,
	[EducationalInstitutionsID] [int] NOT NULL,
	[date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IdentityСard]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdentityСard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dischrgeID] [int] NOT NULL,
	[InitialTrainingID] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[workersId] [int] NULL,
	[deleted] [bit] NULL,
	[validPeriod] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_IdentityCard]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[v_IdentityCard]
as
select
 ic.id as 'ic_id'
 ,ic.workersId as 'id'
,discription as 'Разряд'
, cast(ic.[date] as date) as 'Дата получения'
, cast(dateadd(MONTH,isnull(ic.validPeriod,12),ic.[date]) as date) as 'Срок действия до' 
,InitialTraining.code as 'Номер удостоверения'
,cast(InitialTraining.date as date) as 'Дата окончания университета'
,EI.Name as 'Учебное заведение'
,IIF(w.id is null,'Не действующее','Действующее') as 'Удостоверение'
from dbo.[IdentityСard] as ic
inner join dbo.[Discharge] as Discharge on Discharge.id = ic.dischrgeID
left join dbo.[InitialTraining] as InitialTraining on InitialTraining.id = ic.InitialTrainingID
left join dbo.[EducationalInstitutions] as EI on EI.id = InitialTraining.EducationalInstitutionsID
left join Workers w on w.IdentityCard = ic.id
GO
/****** Object:  View [dbo].[v_idenityCard]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
 Создаем предстовление по заполнению полей удостоверения
*/
create view [dbo].[v_idenityCard]
as
select 
ic.[id] as 'id',
d.discription as 'discription',
ic.[date] as 'icdate',
ic.validPeriod as 'validperiod',
it.code as 'code',
it.[date] as 'itdate',
e.Name as 'name'
,case when (w.name) is not null then '1' else '0' end as 'остовное' -- является ли основным удостоверением
from IdentityСard ic
inner join Discharge d on ic.dischrgeID = d.id 
inner join InitialTraining it on it.id = ic.id
inner join EducationalInstitutions e on e.id = it.EducationalInstitutionsID 
left join Workers w on w.IdentityCard = ic.id



GO
/****** Object:  View [dbo].[v_shortInfoAboutPerson]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[v_shortInfoAboutPerson]
as
select
w.id,
w.name +' '+w.surname+' '+middleName as 'FIO',
w.telefon,
cast(Format(isNull(Dateadd(MONTH,m.valiedPeriod,m.Date),'19000101'),'d','de-de') as varchar) as 'medDate',
cast(Format(isNull(Dateadd(MONTH,ic.validPeriod,ic.date),'19000101') ,'d','de-de') as varchar) as 'identDate'
from 
Workers w
left join MedicalCommission m on m.workersId = w.id
left join IdentityСard ic on ic.id = w.IdentityCard
GO
/****** Object:  Table [dbo].[AppUser]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](10) NULL,
	[password] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeriodicInspection]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeriodicInspection](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dateCreate] [datetime] NOT NULL,
	[validate] [int] NULL,
	[workerId] [int] NOT NULL,
	[result] [int] NULL,
 CONSTRAINT [PK_idPeriodicInspection] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Workers] ADD  DEFAULT (NULL) FOR [photo]
GO
ALTER TABLE [dbo].[IdentityСard]  WITH CHECK ADD  CONSTRAINT [FK_Dischrge] FOREIGN KEY([dischrgeID])
REFERENCES [dbo].[Discharge] ([id])
GO
ALTER TABLE [dbo].[IdentityСard] CHECK CONSTRAINT [FK_Dischrge]
GO
ALTER TABLE [dbo].[IdentityСard]  WITH CHECK ADD  CONSTRAINT [FK_InitialTraining] FOREIGN KEY([InitialTrainingID])
REFERENCES [dbo].[InitialTraining] ([id])
GO
ALTER TABLE [dbo].[IdentityСard] CHECK CONSTRAINT [FK_InitialTraining]
GO
ALTER TABLE [dbo].[InitialTraining]  WITH CHECK ADD  CONSTRAINT [FK_EducationalInstitutionsID] FOREIGN KEY([EducationalInstitutionsID])
REFERENCES [dbo].[EducationalInstitutions] ([id])
GO
ALTER TABLE [dbo].[InitialTraining] CHECK CONSTRAINT [FK_EducationalInstitutionsID]
GO
ALTER TABLE [dbo].[MedicalCommission]  WITH CHECK ADD  CONSTRAINT [FK_MedikalCenter] FOREIGN KEY([medicalCenterID])
REFERENCES [dbo].[MedicalCenter] ([id])
GO
ALTER TABLE [dbo].[MedicalCommission] CHECK CONSTRAINT [FK_MedikalCenter]
GO
ALTER TABLE [dbo].[PeriodicInspection]  WITH CHECK ADD  CONSTRAINT [FK_workers] FOREIGN KEY([workerId])
REFERENCES [dbo].[Workers] ([id])
GO
ALTER TABLE [dbo].[PeriodicInspection] CHECK CONSTRAINT [FK_workers]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_IdentityCard] FOREIGN KEY([IdentityCard])
REFERENCES [dbo].[IdentityСard] ([id])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_IdentityCard]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_MedicalCommission] FOREIGN KEY([MedicalCommissionID])
REFERENCES [dbo].[MedicalCommission] ([id])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_MedicalCommission]
GO
/****** Object:  StoredProcedure [dbo].[AddDischarge]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 29.03.2023
-- Description:	Процедура добавляет Разряд охраника.
-- =============================================
CREATE PROCEDURE [dbo].[AddDischarge] 
	@Discharge varchar(10), 
	@discription varchar(50),
	@id int null = null
AS
BEGIN	
	SET NOCOUNT ON;
	BEGIN TRY
		IF(@id is not null)
		BEGIN
			UPDATE Discharge
			set [code] = @Discharge,
				[discription] =@discription
			WHERE id =@id;
		END
		ELSE
			BEGIN
			INSERT INTO Discharge([code], [discription]) values (@Discharge, @discription);
			SELECT id FROM Discharge WHERE id = @@IDENTITY;
		END
	END TRY
	BEGIN CATCH
		SELECT 'Error';
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AddEducationalInstitutions]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 29.03.2023
-- Description:	Процедура добавляет учебное заведение в справочник учебных заведений
-- =============================================
CREATE PROCEDURE [dbo].[AddEducationalInstitutions]
	-- Add the parameters for the stored procedure here
	@name varchar(50), 
	@license varchar(50) null,
	@address varchar(50) null,
	@id int null  = null
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		IF(@id is not null)
		BEGIN
			UPDATE dbo.EducationalInstitutions
			set [name] = @name,
				[license] =@license,
				[address] =@address
			WHERE id =@id
		END
		ELSE
		BEGIN
			INSERT INTO EducationalInstitutions([name], [license],[address]) values (@name, @license,@address);
		END
		SELECT id FROM EducationalInstitutions WHERE id = @@IDENTITY;
	END TRY
	BEGIN CATCH
		SELECT 'Error';
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AddEmployee]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 04.04.2023
-- Description:	<Процедура создания работника>
-- =============================================
CREATE PROCEDURE [dbo].[AddEmployee] 
	-- Add the parameters for the stored procedure here
	@name varchar(30),
	@surname varchar(30),
	@middleName varchar(30),
	@birthday datetime,
	@telefon varchar(20),
	@photo varchar(500)  = null		
AS
BEGIN
	SET NOCOUNT ON;
	Declare @idMedicalComission int;
	INSERT INTO [dbo].[MedicalCommission]
           ([medicalCenterID]
           ,[code]
           ,[Date]
           ,[valiedPeriod]          
           ,[workersId])
	values (null,null,null,null,null);
	
	select @idMedicalComission = @@IDENTITY --получаем id центра присвоеного работнику

	-- создать работника 
	INSERT INTO [dbo].[Workers]
           ([name]
           ,[surname]
           ,[middleName]
           ,[birthday]
           ,[telefon]
           ,[photo]
		   ,MedicalCommissionID)
		VALUES
		(
			@name ,
			@surname,
			@middleName,
			@birthday, 
			@telefon,
			@photo,
			@idMedicalComission
		)
	Declare @id_worker int; --получаем id работника

	set @id_worker = @@IDENTITY

	select cast(@id_worker as varchar(5)) as id --получить id последнего вставленого элемента.

	update [dbo].[MedicalCommission] --обновляем работника
	 set [workersId] = @id_worker
	where id = @idMedicalComission; 
END
GO
/****** Object:  StoredProcedure [dbo].[AddMedicalCenter]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 29.03.2023
-- Description:	Процедура пишет новый медецинский центр в таблицу
-- =============================================
CREATE PROCEDURE [dbo].[AddMedicalCenter]	
	@MedicalCenterName varchar(50), --Наименование медецинского центра
	@addres varchar(50) null,		-- Адрес медецинского центра
	@tel varchar(20) null,			-- Телефон Центра
	@id int  = null					-- Для изменения 
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY	
	if(@id is not null)
	Begin
		UPDATE dbo.MedicalCenter
		set [name] =@MedicalCenterName,
			[addres] =@addres,
			[tel] = @tel
		WHERE id =@id
	END
	ELSE
	BEGIN
		insert into dbo.MedicalCenter([name], [addres], [tel]) values (@MedicalCenterName, @addres, @tel);
		SELECT cast(ID as varchar(10)) as id FROM dbo.MedicalCenter WHERE ID = @@IDENTITY
	END
	END TRY
	BEGIN CATCH
		select 'Error' as id
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[createIdentityCard]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 23.04.2023
-- Description:	Создать удостовирение охраика
-- =============================================
CREATE PROCEDURE [dbo].[createIdentityCard]
	@id int, --id охраника.
	@discarge varchar(150),
	@dateCreate datetime,
	@Term int,
	@codeEducation varchar(50),
	@dateEducation datetime,
	@nameEducation varchar(50)
AS
BEGIN
/*Находим id учебного заведения*/
	DECLARE @idEducation int
	SELECT @idEducation = id FROM [dbo].[EducationalInstitutions] WHERE NAME = @nameEducation;
/*Находим id разряда*/
	Declare @idDescharge int 
	SELECT @idDescharge = id FROM [dbo].[Discharge] WHERE discription = @discarge;
/*Записываем в таблицу [dbo].[InitialTraining]*/
	Declare @InitialTrainingID int;
	Insert into [dbo].[InitialTraining] ([code], [EducationalInstitutionsID], [date]) values (@codeEducation,@idEducation,@dateEducation);
	SELECT @InitialTrainingID =@@IDENTITY;
	Declare @idIdentityCard int;
	Insert into [dbo].[IdentityСard]([dischrgeID],[InitialTrainingID],[date],workersId,validPeriod,deleted) values (@idDescharge,@InitialTrainingID,@dateCreate,@id,@Term,0);
	SELECT @idIdentityCard =@@IDENTITY;
	/*В таблице пользователей обнавляем текущую запись пользователей */
	update Workers
	set IdentityCard = @idIdentityCard
	where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[deleteFromSrp]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:			'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date:		29.03.2023
-- Description:		Почистить справочник в зависимости от типа и id
-- =============================================
CREATE PROCEDURE [dbo].[deleteFromSrp]
	-- Add the parameters for the stored procedure here
	@id int, -- id элемента который необходимо удалить
	@typeSpr varchar(10) -- удаляем по типу справочника.
AS
BEGIN
	SET NOCOUNT ON;
	IF(@typeSpr ='MEDICAL')
	BEGIN
		DELETE FROM dbo.MedicalCenter WHERE id = @id;
	END;
	IF(@typeSpr='DISCHARCHE')
	BEGIN
		DELETE FROM  dbo.Discharge WHERE id =@id;
	END;
	IF(@typeSpr='EDUCATION')
	BEGIN
		DELETE FROM dbo.EducationalInstitutions WHERE id =@id
	END;
END
GO
/****** Object:  StoredProcedure [dbo].[updateIdentityCard]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		'Оля - ля - ля' и 'Тру - ля - ля'
-- Create date: 23.04.2023
-- Description:	Создать удостовирение охраика
-- =============================================
CREATE PROCEDURE [dbo].[updateIdentityCard]
	@id int, --id удостоверения охраника
	@discarge varchar(150),
	@dateCreate datetime,
	@Term int,
	@codeEducation varchar(50),
	@dateEducation datetime,
	@nameEducation varchar(50)
AS
BEGIN
/*Находим id учебного заведения*/
	DECLARE @idEducation int
	SELECT @idEducation = id FROM [dbo].[EducationalInstitutions] WHERE NAME = @nameEducation;
/*Находим id разряда*/
	Declare @idDescharge int 
	SELECT @idDescharge = id FROM [dbo].[Discharge] WHERE discription = @discarge;
/*Обновляем таблицу обучения охранника*/	
	update it
	set it.code =@codeEducation, it.EducationalInstitutionsID = @idEducation, it.date = @dateEducation
	from IdentityСard as ic
	inner join InitialTraining as it on ic.InitialTrainingID = it.id 
	where ic.id = @id
/*обновляем таблицу удостоверений охранников*/	
	update IdentityСard
	set dischrgeID =@idDescharge, validPeriod =@Term, [date] = @dateCreate
	where id =@id	
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateMedicalCommission]    Script Date: 01.05.2023 21:06:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Оля-ля, Тру-ля-ля>
-- Create date: <16.04.2023>
-- Description:	<Изменить медецинскую карту работника>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateMedicalCommission] 
	-- Add the parameters for the stored procedure here
	@idWorker int,
	@stMedicalCenter varchar(500),
	@stCode varchar(10),
	@Date datetime,
	@validatePeriod int
AS
BEGIN
 --Получить id медецинского центра 
	Declare @idMedCenter int;
	select @idMedCenter = id from  dbo.MedicalCenter where name = @stMedicalCenter

--Обновить данные медецинской комиссии
	update MedicalCommission
	set [medicalCenterID] =@idMedCenter,
		[code] = @stCode,
		[Date] = @Date,
		[valiedPeriod] =@validatePeriod		
	where workersId = @idWorker

END
GO
