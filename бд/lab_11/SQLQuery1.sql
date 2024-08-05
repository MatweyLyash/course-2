use LM_MyBase
--1

declare Treatys cursor  for select credit_name from Treaty;
declare @buff char(20), @c_n char(300)=''

open Treatys 
fetch Treatys into @buff;
print 'Кредиты'
while @@FETCH_STATUS=0
begin 
	set @c_n = rtrim(@buff)+','+@c_n;
	fetch Treatys into @buff;
end
print @c_n;
close Treatys
select credit_name from Treaty
--2

declare Companys cursor local 
	for select company_name, contact_person from Company
	declare @c_m char(20), @c_p char (40)
		Open Companys 
		fetch Companys into @c_m, @c_p;
		print '1'+@c_m + @c_p;
	go
	declare @c_m char(20), @c_p char (40)
	Open Companys 
		fetch Companys into @c_m, @c_p;
		print '2'+@c_m + @c_p;

declare Companys cursor global
	for select company_name, contact_person from Company
	declare @c_m1 char(20), @c_p1 char (40)
		Open Companys 
		fetch Companys into @c_m1, @c_p1;
		print '1'+@c_m1 + @c_p1;
	go
	declare @c_m1 char(20), @c_p1 char (40)
	
		fetch Companys into @c_m1, @c_p1;
		print '2'+@c_m1 + @c_p1;
	close Companys
	deallocate Companys
	go
--3
insert Company (company_name,addres,phone, contact_person) values ('вапоресса','aboba', 8800555, 'abobik')
      DECLARE @tid char(10), @tnm char(40), @tgn char(1);  
	DECLARE Dogovor CURSOR LOCAL Dynamic                              
		 for SELECT credit_name, summa, company_name 
		       FROM dbo.Treaty where credit_name = 'лизинг';				   
	open Dogovor;
	print   'Количество строк : '+cast(@@CURSOR_ROWS as varchar(5)); 
    	UPDATE Treaty set summa = 5 where company_name = 'Белвест';
	DELETE Treaty where company_name = 'ооо чарик';
	INSERT Treaty (credit_id, company_name, credit_name,    
                               summa, issue_date, return_date) 
	                 values (666, 'вапоресса', 'лизинг', 444, '2014-08-02', '2024-08-02'); 
	FETCH  Dogovor into @tid, @tnm, @tgn;     
	while @@fetch_status = 0                                    
      begin 
          print @tid + ' '+ @tnm + ' '+ @tgn;      
          fetch Dogovor into @tid, @tnm, @tgn; 
       end;          
   CLOSE  Dogovor;

--4
DECLARE  @tc int, @rn char(50);  
DECLARE Primer1 cursor local dynamic SCROLL                               
      for SELECT row_number() over (order by company_name) , credit_name
FROM dbo.Treaty 
where  credit_name = 'лизинг' 
	OPEN Primer1;
	FETCH first Primer1 into  @tc, @rn;                 
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);      
	FETCH  LAST from  Primer1 into @tc, @rn;       
	print 'последняя строка          : ' +  cast(@tc as varchar(3))+ rtrim(@rn);    
	Fetch prior from Primer1 into @tc, @rn;   
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);      
	Fetch next from Primer1 into @tc, @rn;   
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);     
	Fetch absolute -1 from Primer1 into @tc, @rn;   
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);   
	Fetch absolute 1 from Primer1 into @tc, @rn;   
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);   
	Fetch relative 1 from Primer1 into @tc, @rn;   
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);   
	Fetch relative -1 from Primer1 into @tc, @rn;   
	print 'следующая строка        : ' + cast(@tc as varchar(3))+ rtrim(@rn);   
	Close Primer1
--5
	declare @cn char(50), @s real, @crn char(15);
	declare Primer2 Cursor  local dynamic
	for select company_name, summa, credit_name from Treaty for Update;
	Open Primer2
	fetch Primer2 into @cn, @s, @crn;
	delete Treaty where Current of Primer2;
	fetch Primer2 into @cn, @s, @crn;
	update Treaty set summa  = summa +1 where current of Primer2;
	Close Primer2
--6
DECLARE @companyId char(20);
DECLARE CursorToDelete CURSOR LOCAL STATIC FOR
SELECT c.company_name
FROM Company c
INNER JOIN Treaty t ON c.company_name = t.company_name
WHERE t.summa < 500;
OPEN CursorToDelete;
FETCH NEXT FROM CursorToDelete INTO @companyId;
WHILE @@FETCH_STATUS = 0
BEGIN
	delete from Treaty where company_name = @companyId
    DELETE FROM Company WHERE company_name = @companyId;
    FETCH NEXT FROM CursorToDelete INTO @companyId;
END
CLOSE CursorToDelete;
DEALLOCATE CursorToDelete;


