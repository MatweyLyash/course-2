use LM_MyBase
--1
go 
--create Procedure dogovor
--as 
--begin
--	declare @n int = (select count (*) from Treaty);
--	select * from Treaty
--	return @n;
--end;
--declare @g int  =0
--exec	@g  = dogovor 
--print @g
--2
--ALTER Procedure dogovor @p varchar(20), @c int output
--as 
--begin
--	declare @n int = (select count (*) from Treaty);
--	print 'параметры: @p= ' +@p+ '@c= '+cast(@c as varchar(3));
--	select * from Treaty where company_name = @p;
--	set @c=@@ROWCOUNT
--	return @n;
--end;
--GO
declare @k int =0, @r int =0, @p varchar(20);
exec @k = dogovor @p='ооо аегис', @c = @r output;
print 'кол-во договоров всего ' + cast(@k as varchar(3));
print 'кол-во догоровов компании '+ cast(@p as varchar(20)) + ' = '+cast(@r as varchar(20));

--3
--alter procedure dogovor @p varchar(20)
--as begin
--	declare @k int = (select count(3) from Treaty);
--	select * from Treaty where company_name = @p;
--end;
Create table #dog
(credit_id int primary key,
company_name nvarchar(50),
credit_name nvarchar(20),
summa int,
issue_date datetime,
return_date datetime
)
insert #dog exec dogovor @p	='ооо аегис'
select * from #dog
--4
go
create procedure TreatyInsert
	@cn  nvarchar(50),@a nvarchar(20) , @p Nvarchar(20),@cp nvarchar(20)  as declare @asd int =1
	begin try
		insert into Company(company_name, addres, phone, contact_person) values (@cn, @a,@p, @cp);
		return @asd
	end try
	begin catch
		print 'номер ошибки ' + cast(error_number()as varchar(6));
		print 'сообщение '+ error_message();
		print 'уровень' + cast(error_severity()as varchar(6));
		print 'метка' + cast(error_state() as varchar(6));
		print 'номер строки' + cast(error_line() as varchar(6));
		if ERROR_PROCEDURE() is not null
		print 'им€ процедуры' +error_procedure();
		return -1;
	end catch;

	declare @asd int;
	exec @asd = TreatyInsert @cn = 'бгту', @a='г. вологда', @p='+375222332', @cp='Ўиман'
	print 'код ошибки ' + cast(@asd as varchar(3));
	
--5
	go 
	create procedure Treaty_report @p char (50)
	as declare @rc int = 0;
	begin try
		declare @all nvarchar(20), @someAll char(300) = '';
		declare treatyKur cursor local static for select company_name from Treaty where credit_name = @p;
		if not exists (select company_name from Treaty where credit_name  =@p  )
			raiserror('error',11,1);
		else 
		begin
			open treatyKur
			fetch treatyKur into @all;
			print 'крeдиты' ;
			while @@fetch_status =0
			begin
				set @someAll  =rtrim(@all)+','+@someAll;
				set @rc  = @rc +1;
				fetch treatyKur into @all;
			end
			print @someAll;
		end;
	close treatyKur;
	return @rc;
	end try
	begin catch
		print 'error in param' 
		if ERROR_PROCEDURE() is not null
			print 'proc name: '+error_procedure();
		return @rc;
	end catch

declare @rc int
exec @rc = Treaty_report @p='лизинг';
print 'amount credit ' + cast(@rc as varchar(3))

--6

go 
	create  procedure Insert_X
    @c_i int, @cn nvarchar(20), @cred_n nvarchar(20) , @sum int, @issue datetime, @return datetime,
@c_n nvarchar(20),@a nvarchar(20), @p nvarchar(20),@c_p nvarchar(20)
as  declare @rc int=1;                            
begin try 
    set transaction isolation level SERIALIZABLE;          
    begin tran
    insert into Treaty(credit_id, company_name,credit_name, summa, issue_date, return_date  )
	values (@c_i, @cn, @cred_n, @sum, @issue, @return)
   exec @rc = TreatyInsert @c_n, @a, @p, @c_p 
    commit tran; 
    return @rc;           
end try
begin catch 
    print 'номер ошибки  : ' + cast(error_number() as varchar(6));
    print 'сообщение     : ' + error_message();
    print 'уровень       : ' + cast(error_severity()  as varchar(6));
    print 'метка         : ' + cast(error_state()   as varchar(8));
    print 'номер строки  : ' + cast(error_line()  as varchar(8));
    if error_procedure() is not  null   
		print 'им€ процедуры : ' + error_procedure();
		 if @@trancount > 0 rollback tran ; 
		 return -1;	  
end catch;

declare @rc int;  
exec @rc = Insert_X @c_i=3, @cn='ооо пасик', @cred_n='льготный', @sum=123, @issue = '2024-03-04', @return='2029-01-02',
@c_n = '',@a='г. дрып', @p='745687645',@c_p='павел пиво';
print 'код ошибки=' + cast(@rc as varchar(3));  
--delete Treaty where credit_id =3

select * from Treaty
select * from Company