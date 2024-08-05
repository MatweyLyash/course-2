use LM_MyBase
--1
select issue_date, credit_name, sum(summa)summa
from Treaty
where credit_name in('льготный','лизинг')
group by credit_name,issue_date

select issue_date, credit_name, sum(summa)summa
from Treaty
where credit_name in('льготный','лизинг')
group by rollup (credit_name,issue_date);

--2
select issue_date, credit_name, sum(summa)summa
from Treaty
where credit_name in('льготный','лизинг')
group by cube (credit_name,issue_date);

--3

select credit_name, sum(summa)summa from Treaty where credit_name ='льготный'
group by credit_name
union
--union all
--intersect
--except
select credit_name, sum(summa)summa from Treaty where credit_name ='лизинг'
group by credit_name

--4


