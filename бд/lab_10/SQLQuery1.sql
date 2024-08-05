use LM_MyBase
--1
exec sp_helpindex'Treaty'
create table #OMYGAH(
TIND int,
TFIELD varchar(100),
TFLOAT float
);

	
go

set nocount on;
declare @i int =0;
while @i<1000
begin
insert #OMYGAH(TIND, TFIELD, TFLOAT)
values (1, 'string', 10);
set @i = @i+1;
end; 

	
	 create clustered index #OMY on #OMYGAH  (TIND desc);

go
select TIND from #OMYGAH order by TIND desc

		drop index #OMY on #OMYGAH
		drop table #OMYGAH
--2
CREATE table #EX(TKEY int, 
      CC int identity(1, 1),
      TF varchar(100)
);

  set nocount on;           
  declare @i int = 0;
  while   @i < 10000      
  begin
       INSERT #EX(TKEY, TF) values(floor(100*RAND()), replicate('строка ', 10));
        set @i = @i + 1; 
  end;
  SELECT count(*)[количество строк] from #EX;
  SELECT * from #EX

  CREATE index #EX_NONCLU on #EX(TKEY, CC)
  drop index #EX_NONCLU on #EX
  SELECT * from  #EX where  TKEY > 1500 and  CC < 4500;  --1 step = 0.1 / 2 step = 0.006
  SELECT * from  #EX order by  TKEY, CC--1 step = 1.52=2 step 
SELECT * from  #EX where  TKEY = 556 and  CC > 3-- step = 0.1 / 2 step = 0.006

--3
CREATE  index #EX_TKEY_X on #EX(TKEY) INCLUDE (CC)
drop index #EX_TKEY_X on #EX
SELECT CC from #EX where TKEY>150 --1step = 0.1 /2 step = 0.003

--4
    CREATE  index #EX_WHERE on #EX(TKEY) where (TKEY>=15000 and 
 TKEY < 20000);  
	drop index #EX_WHERE on #EX
SELECT TKEY from  #EX where TKEY between 5000 and 19999; --1 step = 0.1 /2 step = 0.1
SELECT TKEY from  #EX where TKEY>15000 and  TKEY < 20000 --1 step = 0.1 /2 step = 0.003
SELECT TKEY from  #EX where TKEY=17000 --1 step = 0.1 /2 step = 0.003

--5
CREATE   index #EX_TKEY ON #EX(TKEY); 
drop index #EX_TKEY on #EX

use tempdb
SELECT name [Индекс], avg_fragmentation_in_percent [Фрагментация (%)]
FROM sys.dm_db_index_physical_stats(DB_ID(N'tempdb'), 
OBJECT_ID(N'#EX'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;
     INSERT top(10000) #EX(TKEY, TF) select TKEY, TF from #EX;
	ALTER index #EX_TKEY on #EX reorganize;
	ALTER index #EX_TKEY on #EX rebuild with (online = off);

	--6

	DROP index #EX_TKEY on #EX;
    CREATE index #EX_TKEY on #EX(TKEY) with (fillfactor = 65);
	drop index #EX_TKEY on #EX

	INSERT top(50)percent INTO #EX(TKEY, TF) SELECT TKEY, TF  FROM #EX;
	
	SELECT name [Индекс], avg_fragmentation_in_percent [Фрагментация (%)]
FROM sys.dm_db_index_physical_stats(DB_ID(N'TEMPDB'),    
OBJECT_ID(N'#EX'), NULL, NULL, NULL) ss  JOIN sys.indexes ii 
ON ss.object_id = ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;






