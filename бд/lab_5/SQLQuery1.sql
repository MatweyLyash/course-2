--1
use LM_MyBase
select Company.company_name, Treaty.credit_name
	from Company, Treaty
	where Treaty.company_name = Company.company_name
	and credit_id in (select credit_id from Treaty
	where credit_id = 1)
--2
select Company.company_name, Treaty.credit_name
	from Company inner join Treaty
	on Treaty.company_name = Company.company_name
	where credit_id in(select credit_id from Credit
	where credit_id = 1)
--3
select Company.company_name, Treaty.credit_name
	from Company inner join Treaty
	on Treaty.company_name = Company.company_name
	inner join Credit
	on Credit.credit_name = Treaty.credit_name
		where credit_id =1
--4

select credit_name, summa 
from Treaty t 
	where company_name=(select top(1) company_name from Treaty tt
	where tt.credit_name = t.credit_name
		order by summa desc)
--5

select credit_name from Credit
where not exists (select * from Treaty
where Credit.credit_name = Treaty.credit_name)

--6
select top (1)
(select AVG(summa) from Treaty
	where credit_name like 'лизинг')[лизинг],
(select AVG(summa) from Treaty
	where credit_name like 'потребительский')[Потребительский]
	from Treaty
--7
select credit_name,company_name, summa from Treaty
where summa>=all(select summa from Treaty
where company_name like 'ооо%')
--8
select credit_name,company_name, summa from Treaty	
where summa>=any(select summa from Treaty
where company_name like 'ооо%')