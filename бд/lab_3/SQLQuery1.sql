use master;
 go 
create database LM_MyBase
 on primary
(name = N'SALES_mdf', filename = N'D:\Desktop\Лаборато рные работы\бд\sales_mdf.mdf',
size = 10240Kb, maxsize = UNLIMITED, filegrowth = 1024Kb),
(name = N'SALES_ndf', filename = N'D:\Desktop\Лаборато рные работы\бд\sales_ndf.ndf', 
   size = 10240KB, maxsize=1Gb, filegrowth=25%),
   filegroup FG1
( name = N'SALES_fg1_1', filename = N'D:\Desktop\Лаборато рные работы\бд\sales_fgq-1.ndf', 
   size = 10240Kb, maxsize=1Gb, filegrowth=25%),
( name = N'UNIVER_fg1_2', filename = N'D:\Desktop\Лаборато рные работы\бд\sales_fgq-2.ndf', 
   size = 10240Kb, maxsize=1Gb, filegrowth=25%)
   log on 
(name = N'SALES_log', filename = N'D:\Desktop\Лаборато рные работы\бд\sales_log.log',
size = 10240Kb, maxsize = 2048Gb, filegrowth = 10%),

( name = N'UNIVER_log', filename=N'D:\Desktop\Лаборато рные работы\бд\sales_log.ldf',       
   size=10240Kb,  maxsize=2048Gb, filegrowth=10%)
   go
use LM_MyBase
create table Credit(
	credit_name nvarchar(50) primary key,
	stake float not null
) on FG1;
CREATE TABLE Company
 (   
	company_name nvarchar(20) primary key,
	addres nvarchar(20),
	phone nvarchar(15),
	contact_person nvarchar(20)
 )on FG1;
CREATE TABLE Treaty
	(   credit_id int primary key,
		company_name nvarchar(20)   foreign key  references Company (company_name) ,
		credit_name nvarchar(50) foreign key references Credit (credit_name),
		summa int not null,
		issue_date datetime,
		return_date datetime
     )on FG1 ;


use LM_MyBase
 ALTER Table Treaty ADD Дата_поступления date; 
 Alter Table Treaty drop Column Дата_поступления;


 insert into Credit(credit_name, stake)
		Values ('лизинг', 0.13),
		('потребительский', 0.20);

insert into Company(company_name, addres, phone,contact_person)
			values ('Белвест', 'г. Минск',1232132, 'Павел пиво'	);

insert into Treaty(credit_id, company_name, credit_name, summa, issue_date, return_date)
		Values (1, 'Белвест', 'лизинг', 1488,'2020-02-01','2030-02-01');

 
 
 select * from Company;

 select credit_name, stake from Credit;
 select count(*) from Credit;
 select stake from Credit;
 select credit_name hghgfg  from Credit
 where stake<0.4
 update Credit set stake= stake+0.24;
 --ALTER Table STUDENT ADD POL nchar(1) default 'м' check (POL in ('м', 'ж'));

	--use master
	--drop database LM_MyBase;
--	USE master;
--GO

--ALTER DATABASE LM_MyBase
--SET SINGLE_USER
--WITH ROLLBACK IMMEDIATE;
--GO