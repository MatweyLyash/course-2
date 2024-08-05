--1
declare @a char,
		@b varchar(4),
		@c datetime = getdate(),
		@d smallint = 1000,
		@e tinyint = 255,
		@f numeric(12,5) = 123456.78901;
		set @a = 'a';
		set @b = 'Abob';
		--select @a a, @b b
		select @a = 'b', @b  = 'BSTU';
		select @a a, @b b
		print '��� �:' + @a;
		print '��� ����:'+ @b;
--2
use LM_MyBase;
declare @amountCredit real,
		@sumCredit int = (select cast(sum(summa) as int)from Treaty),
		@y3 numeric(8,3), @y4 real;
		if @sumCredit>10000
		begin 
			select  @amountCredit  = (select cast(count(*) as int) from Treaty),
					@y3 = (select cast (avg(summa)as numeric(8,3))from Treaty)
			set @y4 = (select cast (count(*) as numeric(8,3))from Treaty where summa >@y3)

			select @sumCredit '����� ����� ', @amountCredit '���-��', @y3 '������� ����',
			@y4 '���-�� �������� � ����� ���� ��������'
			end
		else if @sumCredit>5000 print '����� ����� �� 5� �� 10�'
		else if @sumCredit>1000 print '����� ����� �� 1� �� 5�'
		else print '����� ����� <1000'

--3
SELECT @@ROWCOUNT AS '���������� ������������ �����';
SELECT @@VERSION AS '������ SQL Server';
SELECT @@SPID AS '��������� ������������� ��������';
SELECT @@ERROR AS '��� ��������� ������';
SELECT @@SERVERNAME AS '��� �������';
SELECT @@TRANCOUNT AS '������� ����������� ����������';
DECLARE @FetchStatus INT;
SET @FetchStatus = 0;
SELECT @FetchStatus AS '������ ���������� �����';
SELECT @@NESTLEVEL AS '������� ����������� ������� ���������';

--4 |5
declare @z float, @x float = 0.5, @t float = 0.5;
if (@t>@x) set @z = power(sin(@t),2);
else if(@t<@x) set @z = 4*(@t+@x);
else  set @z = 1-power(exp(2.7),@x-2);
print 'z= ' + cast(@z as varchar(10) );

SELECT 
   CONCAT(
      LEFT(contact_person, CHARINDEX(' ', contact_person) - 1),
      ' ',
      SUBSTRING(contact_person, CHARINDEX(' ', contact_person) + 1, 1),
      '. ',
      LEFT(SUBSTRING(contact_person, CHARINDEX(' ', contact_person, CHARINDEX(' ', contact_person) + 1) + 1, LEN(contact_person)), 1),
      '.'
   ) AS '����������� ���'
FROM Company;

SELECT 
   issue_date,
   return_date,
   company_name,
   DATEDIFF(DAY, issue_date, return_date) AS '���������� ������� (���)'
FROM 
   Treaty
   where DATEDIFF(DAY, issue_date, return_date) > 2000;


SELECT 
   credit_name,
   COUNT(*) AS '���������� ��������'
FROM 
   Treaty
WHERE 
   credit_name = '��������' 
GROUP BY 
   credit_name;
--6
select case 
	when summa between 0 and 1000then '����� ������'
	when summa between 1000 and 7000 then '������� ������'
	else '����������� ������'
	end summa, COUNT(*)[����������]
	from dbo.Treaty
	group by case
	when summa between 0 and 1000then '����� ������'
	when summa between 1000 and 7000 then '������� ������'
	else '����������� ������'
	end

--7

create table #OMYGAH(
TIND int,
TFIELD varchar(100),
TFLOAT float
);
set nocount on;
declare @i int =0;
while @i<10
begin
insert #OMYGAH(TIND, TFIELD, TFLOAT)
values (floor(30000*rand()), replicate('string',10), 30000*rand());
if(@i%1 =0)
print @i;
set @i = @i+1;
end;
select * from #OMYGAH

--8
declare @r int = 1
print @r+1
print @r+2
return 
print @r+3

--9
use LM_MyBase
CREATE TABLE Accounts (FirstName NVARCHAR NOT NULL, Age INT NOT NULL)
	
BEGIN TRY
    INSERT INTO Accounts VALUES(NULL, NULL)
    PRINT '������ ������� ���������!'
END TRY
BEGIN CATCH
   print error_number()
	print error_message()
	print error_line()
	print error_procedure()
	print error_severity()
	print error_state()
END CATCH
