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
        PRINT '���������� ����� � �������: ' + CAST(@c AS VARCHAR(2));
        IF @flag = 'c'
            COMMIT ;
        ELSE
            ROLLBACK ;
     SET IMPLICIT_TRANSACTIONS  OFF
    IF EXISTS (SELECT K FROM Excp WHERE K = 4)
        PRINT '������� ����';
    ELSE
        PRINT '������� ���';
END
--2

begin try
	begin tran
	delete Company where company_name = '��� �����';
	insert Company values ('��� �����', '����������',676767,'����')
	insert Company values ('���������',	'aboba'	,8800555,	'abobik');
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
	delete Company where Company_name  = '�������'
	set @point='p1';
	save tran @point
	insert Company values ('��� �����', '����������',676767,'����');
	set @point ='p2' ;
	save tran @point;
	insert Company values ('��� �������', '�����',212121,'����');
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
--�����������
set transaction isolation level READ UNCOMMITTED 
	begin transaction 
	-------------------------- t1 ------------------
	select @@SPID, 'insert Company' '���������', * from Company 
	                                                               
	select @@SPID, 'update Treaty'  '���������',  credit_name, 
                      summa from Treaty   where credit_name= '������';
	commit; 
	-------------------------- t2 -----------------
	--- B --	
	begin transaction 
	select @@SPID
	insert Company values ('��� ���', '������',378432874,'����'); 
	update Treaty set credit_name=  '������' 
                           where credit_name = '��������' 
	-------------------------- t1 --------------------
	-------------------------- t2 --------------------
	rollback;
--5

	-- A ---
          set transaction isolation level READ COMMITTED 
	begin transaction 
	select count(*) from Treaty 	where credit_name = '������';
	-------------------------- t1 ------------------ 
	-------------------------- t2 -----------------
	select  'update Treaty'  '���������', count(*)
	                           from Treaty  where credit_name= '��������';
	commit; 

	--- B ---	
	begin transaction 	  
	-------------------------- t1 --------------------
          update Treaty set credit_name = '��������' 
                                       where credit_name= '������' 
          commit; 
	-------------------------- t2 --------------------
--6
	--�--
	set transaction isolation level  REPEATABLE READ 
	begin transaction 
	select company_name from Treaty where credit_name = '��������';
	-------------------------- t1 ------------------ 
	-------------------------- t2 -----------------
	select  case
          when company_name = '��� �����' then 'insert  treaty'  else ' ' 
end '���������', company_name from Treaty  where credit_name= '������';
	commit; 

	--- B ---	
	begin transaction 	  
	-------------------------- t1 --------------------
          insert Treaty values (12,  '��� �����',  '������',  34567,'2006-12-01', '2024-03-30');
          commit; 
	-------------------------- t2 --------------------
--7
	      -- A ---
    set transaction isolation level SERIALIZABLE 
	begin transaction 
	delete Treaty where company_name = '��� �����';  
	insert Treaty values (14, '��� �����', '������',  10124,  '01.12.2014','01.12.2024' );
          update Treaty set credit_name = '������' where company_name= '��� �����';
          select  credit_name from Treaty where company_name= '��� �����';
	-------------------------- t1 -----------------
	select  credit_name from Treaty where company_name= '��� �����';
	-------------------------- t2 ------------------ 
	commit; 	

	--- B ---	
	begin transaction 	  
	delete Treaty where company_name = '��� �����';  
	insert Treaty values (14, '��� �����', '������',  10124,  '01.12.2014','01.12.2024' );
          update Treaty set credit_name = '������' where company_name= '��� �����';
          select  credit_name from Treaty where company_name= '��� �����';
          -------------------------- t1 --------------------
          commit; 
          select  credit_name from Treaty where company_name= '��� �����';
		  -------------------------- t2 --------------------
--8

begin tran
	insert Company values ('��� �������','�.����',5555,'���')
	begin tran
		update Treaty set company_name  = '��� �������' where company_name = '��� �������'
		commit;
		--commit;
		print @@trancount
		if @@TRANCOUNT>0 rollback
	select
		(select count(*) from Treaty where company_name = '��� �������') 'Treaty',
		(select count(*) from Company where company_name = '��� �������') 'Company'


