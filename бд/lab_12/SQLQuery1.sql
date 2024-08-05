use LM_MyBase
--1

CREATE TABLE Excp (K INT);
INSERT INTO Excp VALUES (1), (2), (3);

IF EXISTS (SELECT K FROM Excp WHERE K = 4)
BEGIN
    DROP TABLE Excp;
END
ELSE
BEGIN
    DECLARE @c INT, @flag CHAR = 'c';
    SET IMPLICIT_TRANSACTIONS  ON 
        INSERT INTO Excp VALUES (4);
        SET @c = (SELECT COUNT(*) FROM Excp);
        PRINT 'Количество строк в таблице: ' + CAST(@c AS VARCHAR(2));
        IF @flag = 'c'
            COMMIT ;
        ELSE
            ROLLBACK ;
     SET IMPLICIT_TRANSACTIONS  OFF
    IF EXISTS (SELECT K FROM Excp WHERE K = 4)
        PRINT 'Таблица есть';
    ELSE
        PRINT 'Таблицы нет';
END
--2

begin try
	begin tran
	delete Company where company_name = 'ооо чарик';
	insert Company values ('ооо аегис', 'Барановичи',676767,'Женёк')
	insert Company values ('вапоресса',	'aboba'	,8800555,	'abobik');
	commit tran
end try
begin catch
	print patindex('%PK_Company%',error_message())
	 print 'Error ' +case
	 when error_number()=2627 and patindex('%PK__Company%',error_message())>0
	 then 'double stuff'
	 else ' nn error ' +cast(error_number() as varchar(5)) + error_message()
	 end;
if @@trancount >0 rollback tran
end catch
--3
declare @point varchar(32)
begin try
	begin tran 
	delete Company where Company_name  = 'Белвест'
	set @point='p1';
	save tran @point
	insert Company values ('ооо аегис', 'Барановичи',676767,'Женёк');
	set @point ='p2' ;
	save tran @point;
	insert Company values ('ооо ватруха', 'Петры',212121,'Женёк');
	commit tran;
end try
begin catch
		print patindex('%PK_Company%',error_message())
	 print 'Error ' +case
	 when error_number()=2627 and patindex('%PK__Company%',error_message())>0
	 then 'double stuff'
	 else ' nn error ' +cast(error_number() as varchar(5)) + error_message()
	 end;
if @@trancount >0 
	begin 
		print 'control point ' +@point
		rollback tran @point
		commit tran;
	end
end catch
--4
--разобраться
set transaction isolation level READ UNCOMMITTED 
	begin transaction 
	-------------------------- t1 ------------------
	select @@SPID, 'insert Company' 'результат', * from Company 
	                                                               
	select @@SPID, 'update Treaty'  'результат',  credit_name, 
                      summa from Treaty   where credit_name= 'лизинг';
	commit; 
	-------------------------- t2 -----------------
	--- B --	
	begin transaction 
	select @@SPID
	insert Company values ('ооо бут', 'Бараны',378432874,'Пиво'); 
	update Treaty set credit_name=  'лизинг' 
                           where credit_name = 'льготный' 
	-------------------------- t1 --------------------
	-------------------------- t2 --------------------
	rollback;
--5

	-- A ---
          set transaction isolation level READ COMMITTED 
	begin transaction 
	select count(*) from Treaty 	where credit_name = 'лизинг';
	-------------------------- t1 ------------------ 
	-------------------------- t2 -----------------
	select  'update Treaty'  'результат', count(*)
	                           from Treaty  where credit_name= 'льготный';
	commit; 

	--- B ---	
	begin transaction 	  
	-------------------------- t1 --------------------
          update Treaty set credit_name = 'льготный' 
                                       where credit_name= 'лизинг' 
          commit; 
	-------------------------- t2 --------------------
--6
	--А--
	set transaction isolation level  REPEATABLE READ 
	begin transaction 
	select company_name from Treaty where credit_name = 'льготный';
	-------------------------- t1 ------------------ 
	-------------------------- t2 -----------------
	select  case
          when company_name = 'ооо аегис' then 'insert  treaty'  else ' ' 
end 'результат', company_name from Treaty  where credit_name= 'лизинг';
	commit; 

	--- B ---	
	begin transaction 	  
	-------------------------- t1 --------------------
          insert Treaty values (12,  'ооо аегис',  'лизинг',  34567,'2006-12-01', '2024-03-30');
          commit; 
	-------------------------- t2 --------------------
--7
	      -- A ---
    set transaction isolation level SERIALIZABLE 
	begin transaction 
	delete Treaty where company_name = 'ооо аегис';  
	insert Treaty values (14, 'ооо аегис', 'лизинг',  10124,  '01.12.2014','01.12.2024' );
          update Treaty set credit_name = 'лизинг' where company_name= 'ооо аегис';
          select  credit_name from Treaty where company_name= 'ооо аегис';
	-------------------------- t1 -----------------
	select  credit_name from Treaty where company_name= 'ооо аегис';
	-------------------------- t2 ------------------ 
	commit; 	

	--- B ---	
	begin transaction 	  
	delete Treaty where company_name = 'ооо аегис';  
	insert Treaty values (14, 'ооо аегис', 'лизинг',  10124,  '01.12.2014','01.12.2024' );
          update Treaty set credit_name = 'лизинг' where company_name= 'ооо аегис';
          select  credit_name from Treaty where company_name= 'ооо аегис';
          -------------------------- t1 --------------------
          commit; 
          select  credit_name from Treaty where company_name= 'ооо аегис';
		  -------------------------- t2 --------------------
--8

begin tran
	insert Company values ('ооо минифит','г.Жмых',5555,'Жма')
	begin tran
		update Treaty set company_name  = 'ооо минифит' where company_name = 'ооо ватруха'
		commit;
		--commit;
		print @@trancount
		if @@TRANCOUNT>0 rollback
	select
		(select count(*) from Treaty where company_name = 'ооо минифит') 'Treaty',
		(select count(*) from Company where company_name = 'ооо минифит') 'Company'


