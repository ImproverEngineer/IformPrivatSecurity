USE [InformPrivateSecure]
GO
/****** Object:  Table [dbo].[MedicalCenter]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  View [dbo].[v_MedicalCenter]    Script Date: 09.04.2023 22:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_MedicalCenter] 
as
select * from dbo.MedicalCenter;
GO
/****** Object:  Table [dbo].[Discharge]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  View [dbo].[v_Discharge]    Script Date: 09.04.2023 22:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_Discharge]
as
select * from Discharge
GO
/****** Object:  Table [dbo].[EducationalInstitutions]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  View [dbo].[v_EducationalInstitutions]    Script Date: 09.04.2023 22:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[v_EducationalInstitutions]
as
select * from EducationalInstitutions
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  View [dbo].[v_workers]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  Table [dbo].[IdentityСard]    Script Date: 09.04.2023 22:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdentityСard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dischrgeID] [int] NOT NULL,
	[InitialTrainingID] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[validPeriod] [datetime] NULL,
	[workersId] [int] NULL,
	[deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InitialTraining]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  Table [dbo].[MedicalCommission]    Script Date: 09.04.2023 22:07:14 ******/
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
	[extenxionDate] [datetime] NULL,
	[workersId] [int] NULL,
 CONSTRAINT [PK_MedicalCommission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeriodicInspection]    Script Date: 09.04.2023 22:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeriodicInspection](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dateCreate] [datetime] NOT NULL,
	[validate] [int] NULL,
	[extensionDate] [datetime] NULL,
	[workerId] [int] NOT NULL,
 CONSTRAINT [PK_idPeriodicInspection] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[IdentityСard] ADD  DEFAULT (dateadd(day,(365),getdate())) FOR [validPeriod]
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
/****** Object:  StoredProcedure [dbo].[AddDischarge]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[AddEducationalInstitutions]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[AddEmployee]    Script Date: 09.04.2023 22:07:14 ******/
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
           ,[extenxionDate]
           ,[workersId])
	values (null,null,null,null,null,null);
	
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
/****** Object:  StoredProcedure [dbo].[AddMedicalCenter]    Script Date: 09.04.2023 22:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[deleteFromSrp]    Script Date: 09.04.2023 22:07:14 ******/
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
