USE [InformPrivateSecure]
GO

/****** Object:  View [dbo].[v_ShortStatistic]    Script Date: 14.05.2023 22:57:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*
name: ShortStatiatic
discription: ��������� � ���� �������� ����� ���������� �� ������ ����������, �������������, ����������� ��������, ������������� �������.
*/
ALTER view [dbo].[v_ShortStatistic]
as
select
w.id,
w.surname  + ' ' + w.name+' ' + w.middleName as 'Name',
cast(format(ic.[���� �������� ��],'dd.MM.yyyy') as varchar(10)) as 'Term',
'�������� ������������� �������� � ����� ���� �����������' as 'Type'
,'lightRed' as 'color'
from
Workers w  
left join v_identityCard ic on w.id = ic.id 
where 1=1 
and (ic.[���� �������� ��]<dateadd(MONTH,3,GetDate()) or ic.[���� �������� ��]<GetDate() or ic.[���� �������� ��] is null)
and (w.IdentityCard = ic.ic_id) -- ����� ������ ����������� �������������
Union all 
select
w.id,
w.surname  + ' ' + w.name+' ' + w.middleName as 'Name',
'' as 'Term',
'������������� �� ���� ��������' as 'Type'
,'lightRed' as 'color'
from
Workers w
where 1=1 
and w.IdentityCard is null
Union all
select 
w.id,
w.surname  + ' ' + w.name+' ' + w.middleName as 'Name',
cast(format(dateadd(MONTH,valiedPeriod,mc.Date),'dd.MM.yyyy') as varchar(10)) as 'Term',
'����������� ������������������� �������� � ����� ���� ����������� ' as 'Type',
'yellow' as 'color'
from  [dbo].[v_MedicalCommission] mc
inner join Workers as  w on w.id =mc.workersID 
where 1=1
and (dateadd(MONTH,valiedPeriod,mc.Date)<dateadd(MONTH,3,GetDate()) or dateadd(MONTH,valiedPeriod,mc.Date)<GetDate() or valiedPeriod is null)
Union all
select
w.id,
w.surname  + ' ' + w.name+' ' + w.middleName as 'Name', 
cast(format(max(dateValidate),'dd.MM.yyyy') as varchar(10)) as 'Term',
'������������� ��������� �������� � ����� ���� �����������' as 'Type',
'violet' as 'color'
from  v_PeriodicInspection vpi
inner join Workers w on w.id =vpi.workerId 
group by vpi.name, workerId, w.surname,w.name, w.middleName,w.id
having (max(dateValidate)<GETDATE() or max(dateValidate)<dateadd(MONTH,3,GetDate())) 
Union all
select
w.id,
w.surname  + ' ' + w.name+' ' + w.middleName as 'Name', 
'' as 'Term',
'�� ���� �� �������� ������������� ���������' as 'Type',
'Red' as 'color'
from Workers w 
where w.id not in(Select distinct workerId  from v_PeriodicInspection vp)

GO


