USE [InformPrivateSecure]
GO

/****** Object:  View [dbo].[v_PeriodicInspection]    Script Date: 09.05.2023 21:13:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[v_PeriodicInspection]
as
select 
pi.id as 'id',
w.surname+'.' + Left(w.name,1)+'.'+ Left(w.middleName,1) as 'name',
dateCreate,
workerId,
case when result =1 then 'Зачтено' 
	 when result =0 then 'Не зачтено'
	 when result is null then 'Не проводилось'
else '' end as 'result',  
it.code,
dateadd(MONTH,pi.validate,dateCreate) as 'dateValidate',
d.discription
from dbo.PeriodicInspection pi
inner join Workers w on w.id = pi.workerId
left join IdentityСard ic on w.IdentityCard = ic.id
left join Discharge d on d.id = ic.dischrgeID
left join InitialTraining it on it.id  = ic.InitialTrainingID
GO


