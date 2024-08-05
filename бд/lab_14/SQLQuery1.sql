use LM_MyBase
--1
go 
create function Count_Treaty(@cr_n varchar(20)) returns int
as begin declare @rc int=0;
	set @rc = (select count(t.company_name) from Company c join Treaty t
	on c.company_name=t.company_name where t.company_name=@cr_n);
	return @rc
	end;

ALTER FUNCTION Count_Treaty
(
    @cr_n varchar(20),
    @prof varchar(20) = NULL
)
RETURNS int
AS
BEGIN
    DECLARE @rc int = 0;

    SET @rc = (
        SELECT COUNT(t.company_name)
        FROM Company c
        JOIN Treaty t ON c.company_name = t.company_name
        WHERE t.company_name = @cr_n
        AND (@prof IS NULL OR t.credit_name = @prof)
    );

    RETURN @rc;
END;

--declare @f int  = dbo.Count_Treaty('ооо аегис')	;
declare @f int  = dbo.Count_Treaty('ооо аегис', 'лизинг')	;
	print 'amount treatys= '+cast(@f as varchar(4)); 

--2
go
create function SelectTreaty(@cn char(20)) returns char(300)
as begin
declare @c_n char(20);
declare	@t varchar(300) = 'Заказанные товары';
declare TCursor cursor local static 
	for select credit_name from Treaty where company_name =@cn;
	open TCursor;
	fetch TCursor into	@c_n;
	while @@FETCH_STATUS=0
		begin
			set @t =@t+', '+ RTRIM(@c_n);
			fetch TCursor into @c_n
		end
	return @t
end;

select company_name, dbo.SelectTreaty(company_name) from Treaty

--3
go
create function SumAndName(@name char(20),@sum int) returns table
as return
	select c.company_name,t.summa from Treaty t left outer join Company c
	on c.company_name = t.company_name
		where c.company_name = isnull(@name, c.company_name)
		and t.summa = isnull(@sum, t.summa);

select * from dbo.SumAndName (null, null)
select * from dbo.SumAndName ('ооо аегис', null)
select * from dbo.SumAndName(null,123)

--4
go
create function COuntingTr(@cn char(20)) returns int
as begin
	declare @rc  int= (select count(*) from Treaty where company_name =isnull(@cn, company_name));
	return @rc
end
go
select company_name, dbo.COuntingTr(company_name) from Treaty
select  dbo.COuntingTr(null) 

--6
go
CREATE FUNCTION GetCredit(@faculty varchar(50))
RETURNS int
AS
BEGIN
    RETURN (SELECT COUNT(credit_name) FROM Credit WHERE credit_name = @faculty);
END;
go
CREATE FUNCTION GetTreaty(@faculty varchar(50))
RETURNS int
AS
BEGIN
    RETURN (SELECT COUNT(credit_id) FROM Treaty WHERE credit_name = @faculty);
END;
go
CREATE FUNCTION GetCompany(@faculty varchar(50))
RETURNS int
AS
BEGIN
    RETURN (SELECT COUNT(company_name)FROM Company where company_name=@faculty);
END;
go



ALTER FUNCTION FACULTY_REPORT (@c int)
RETURNS @fr TABLE
(
	[компания] nvarchar(30),
    [кредиты] int,
    [договора] int,
    [компании] int   
)
AS
BEGIN
    DECLARE cc CURSOR STATIC FOR 
        SELECT company_name FROM Company
        WHERE dbo.Count_Treaty(company_name, DEFAULT) > @c;
    
    DECLARE @f nvarchar(30);
    
    OPEN cc;
    FETCH cc INTO @f;
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT INTO @fr
        VALUES (
            @f,
			dbo.GetCredit(@f),
            dbo.GetTreaty(@f),
            dbo.GetCompany(@f)
       );
        
        FETCH cc INTO @f;
    END;
    
    CLOSE cc;
    DEALLOCATE cc;
    
    RETURN;
END;


select * FROM dbo.FACULTY_REPORT(0);



