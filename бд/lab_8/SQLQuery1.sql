use LM_MyBase

--1
select credit_name[Название кредита], summa[Сумма], issue_date[Дата взятие кредита]
from Treaty
--перечислите объекты которые вы создавали(представление, таблица)
go
create view [Кредиты]
as select credit_name[Название кредита], summa[Сумма], issue_date[Дата взятие кредита]
from Treaty

select * from [Кредиты]
select * from [Кредиты] order by[Сумма]
go
alter view [Кредиты]
as select credit_name[Название кредита], summa[Сумма], issue_date[Дата взятие кредита], return_date[Дата возвращения кредита]
from Treaty

drop view [Кредиты]

--2
go
create view[Инфа о компаниях]
as select t.credit_name [Название кредита], t.summa[Сумма], c.company_name[Название компании], c.addres[Адрес]
	from Treaty t join Company c
	on t.company_name =c.company_name
select * from [Инфа о компаниях]
--3 
go 
create view большие_кредиты(id,Название_кредита ,Сумма, Название_компании)
as select credit_id, credit_name, summa, company_name
from Treaty
where summa>2000 ;
--where summa>2000 with check option;
go 


select* from большие_кредиты
insert большие_кредиты values(10,'льготный',12300,'ооо ватруха')
update большие_кредиты set Сумма = 666 where Название_компании= 'ооо ватруха'
delete  большие_кредиты where Название_компании ='ооо ватруха'

--5
go
create view большие_кредиты_ещё_раз(id,Название_кредита ,Сумма, Название_компании)
as select top 2 credit_id, credit_name, summa, company_name
from Treaty
order by credit_id

select * from большие_кредиты_ещё_раз

--6
go
create view Credits with schemabinding
as select t.credit_name [Название кредита], t.summa[Сумма], c.company_name[Название компании], c.addres[Адрес]
	from dbo.Treaty t join dbo.Company c
	on t.company_name =c.company_name


