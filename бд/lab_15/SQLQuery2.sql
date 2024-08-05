use LM_MyBase
--1
create table lab_15_1(
id int identity,
st varchar(20) check (ST in('ins', 'del','upd')),
trn varchar(50),
c varchar(300)
)

go
alter trigger Trig_1_ins on Company after Insert
as declare @a1 varchar(20), @a2 varchar(30), @a3 varchar(20), @a4 varchar(20), @in varchar(300);
print 'insert operation';
set @a1 = (select company_name from inserted);
set @a2 = (select addres from inserted);
set @a3 = (select phone from inserted);
set @a4 = (select contact_person from inserted);
set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4;
insert into lab_15_1 values ('ins', 'Trig_1_ins', @in);
return;

insert into Company values('ооо чарныч2','г. баруны','444444','афанасий')
select * from lab_15_1

--2
go
alter trigger Trig_1_del on Company after Delete
as declare @a1 varchar(20), @a2 varchar(30), @a3 varchar(20), @a4 varchar(20), @in varchar(300);
print 'delete operation';
set @a1 = (select company_name from deleted WHERE company_name is NOT NULL);
set @a2 = (select addres from deleted WHERE addres is NOT NULL);
set @a3 = (select phone from deleted WHERE phone is NOT NULL);
set @a4 = (select contact_person from deleted WHERE contact_person is NOT NULL);
set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4;
insert into lab_15_1 values ('del', 'Trig_1_del', @in);
return;

delete Company where company_name='ооо чарныч'
select * from lab_15_1

--select * from Company

--3
go
alter trigger Trig_1_upd on Company after Update
as declare @a1 varchar(20), @a2 varchar(30), @a3 varchar(20), @a4 varchar(20), @in varchar(300);
print 'update operation';
set @a1 = (select company_name from inserted WHERE company_name is NOT NULL);
set @a2 = (select addres from inserted WHERE addres is NOT NULL);
set @a3 = (select phone from inserted WHERE phone is NOT NULL );
set @a4 = (select contact_person from inserted WHERE contact_person is NOT NULL);
set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4;
insert into lab_15_1 values ('upd', 'Trig_1_upd', @in);
return;

update Company set phone ='1111'  where company_name='ооо чарон'
select * from lab_15_1

--4
go
create trigger Trig_1_all on Company after Insert, delete, update
as declare @a1 varchar(20), @a2 varchar(30), @a3 varchar(20), @a4 varchar(20), @in varchar(300);
declare @ins int = (select count(*) from inserted),
        @del int = (select count(*) from deleted); 
if	 @ins>0 and @del=0
begin
	print 'insert operation';
	set @a1 = (select company_name from inserted);
	set @a2 = (select addres from inserted);
	set @a3 = (select phone from inserted);
	set @a4 = (select contact_person from inserted);
	set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4;
	insert into lab_15_1 values ('ins', 'Trig_1_ins', @in);
end;
else if @ins=0 and @del>0
begin
	print 'delete operation';
	set @a1 = (select company_name from deleted WHERE company_name is NOT NULL);
	set @a2 = (select addres from deleted WHERE addres is NOT NULL);
	set @a3 = (select phone from deleted WHERE phone is NOT NULL);
	set @a4 = (select contact_person from deleted WHERE contact_person is NOT NULL);
	set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4;
	insert into lab_15_1 values ('del', 'Trig_1_del', @in);
end;
else if @ins>0 and @del>0
begin
	print 'update operation';
	set @a1 = (select company_name from inserted WHERE company_name is NOT NULL);
	set @a2 = (select addres from inserted WHERE addres is NOT NULL);
	set @a3 = (select phone from inserted WHERE phone is NOT NULL );
	set @a4 = (select contact_person from inserted WHERE contact_person is NOT NULL);
	set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4;
	set @a1 = (select company_name from deleted WHERE company_name is NOT NULL);
	set @a2 = (select addres from deleted WHERE addres is NOT NULL);
	set @a3 = (select phone from deleted WHERE phone is NOT NULL );
	set @a4 = (select contact_person from deleted WHERE contact_person is NOT NULL);
	set @in =@a1 +' '+@a2 +' '+@a3 +' '+@a4+' '+@in;
	insert into lab_15_1 values ('upd', 'Trig_1_upd', @in);
end;
return;
insert into Company values('ооо чарныч2','г. баруны','444444','афанасий')
delete  from Company where company_name ='ооо чарныч2';
update Company set phone='111' where company_name='ооо чарон'
select * from lab_15_1

--5
alter table Company add constraint phone check(len(phone)>3)
go update Company set phone='1111' where company_name='ооо чарон';
--Возникла неустранимая ошибка скрипта.
--В ходе анализа go обнаружена синтаксическая ошибка.

--6
go
create trigger Comp_upd_a on Company after UPdate
	as print 'upd_a';
return;
go
create trigger Comp_upd_b on Company after UPdate
	as print 'upd_b';
return;
go
create trigger Comp_upd_c on Company after UPdate
	as print 'upd_c';
return;
go

select t.name, e.type_desc 
  from sys.triggers  t join  sys.trigger_events e  
  on t.object_id = e.object_id  
  where OBJECT_NAME(t.parent_id) = 'Company' and e.type_desc = 'UPDATE' ; 
  
  exec  SP_SETTRIGGERORDER @triggername = 'Comp_upd_c', 
	                        @order = 'First', @stmttype = 'UPDATE';

exec  SP_SETTRIGGERORDER @triggername = 'Comp_upd_b', 
	                        @order = 'Last', @stmttype = 'UPDATE';

--7
go
create trigger TR_ConstraintCompany on Treaty after UPDATE,insert,DeLetE
as decLare @sum int =(select sum(summa) From Treaty);
if (@sum>24000000)
	begin 
		raiserror('нет столько  денек,чтобы взять НАШ кредит>24mln',10,1 );
		rollback;
	end
return;
insert Treaty values (24,'ооо ватруха','лизинг',25000000,'2021-03-05','2030-05-09');

--8
go
create trigger TRInstend_off on Company instead of delete as raiserror(N'delete is forbidden',10,1);
return;
--select * from Company
delete Company where  contact_person='павел пиво'

--drop trigger 
--9
go 
create trigger ddl_drop on database for 
DDL_DATABASE_LEVEL_EVENTS  as   
  declare @t varchar(50) =  EVENTDATA().value('(/EVENT_INSTANCE/EventType)[1]', 'varchar(50)');
  declare @t1 varchar(50) = EVENTDATA().value('(/EVENT_INSTANCE/ObjectName)[1]', 'varchar(50)');
  declare @t2 varchar(50) = EVENTDATA().value('(/EVENT_INSTANCE/ObjectType)[1]', 'varchar(50)'); 
  if @t1 = 'Credit' 
  begin
       print 'Тип события: '+@t;
       print 'Имя объекта: '+@t1;
       print 'Тип объекта: '+@t2;
       raiserror( N'операции с таблицей credit запрещены', 16, 1);  
       rollback;    
   end;

   alter table Credit Drop Column  credit_name;
