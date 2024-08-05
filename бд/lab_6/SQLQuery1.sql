--1
use LM_MyBase
select Treaty.credit_name,
max(summa)[Лимитный займ],
min(summa)[Минимальный займ],
avg(summa)[Средний займ],
count(*)[Количество взятых кредитов]
from Treaty inner join Credit
on Treaty.credit_name  = Credit.credit_name
 group by Treaty.credit_name

--2
--
--

--3	
select * 
from
(
select case when summa between 10 and 1500 then 'сумма < 1500'
when summa between 1500 and 9999 then 'сумма от 1.5к до 9999'
else 'сумма больше 10к'
end [Пределы займов], count(*)[Количество]
from Treaty group by Case
	when summa between 10 and 1500 then'сумма < 1500'
	when summa between 1500 and 9999 then 'сумма от 1.5к до 9999'
	else 'сумма больше 10к'
	end
) as T
	order by case [Пределы займов]
	when 'сумма < 1500'then 3
	when 'сумма от 1.5 к до 9999'then 2
	when 'сумма больше 10к'then 1
	else 0
	end


--4
select Credit.stake, Company.addres, round(avg(cast(Treaty.summa as float(4))),2)
from Company inner join Treaty
on Company.company_name = Treaty.company_name
inner join Credit
on Credit.credit_name = Treaty.credit_name
where Treaty.summa > 700
	group by Treaty.credit_name,
	 --Credit.stake,
			 Company.addres,
			  Credit.stake
			


--5
SELECT Credit.stake, Company.addres, Treaty.credit_name, ROUND(AVG(CAST(Treaty.summa AS float(4))), 2)
FROM Company
INNER JOIN Treaty ON Company.company_name = Treaty.company_name
INNER JOIN Credit ON Credit.credit_name = Treaty.credit_name
WHERE Treaty.summa > 700
  AND Credit.credit_name IN ('льготный', 'лизинг')
GROUP BY Treaty.credit_name, Company.addres, Credit.stake

--6
select credit_name , sum(summa) [сумма]
from Treaty
where credit_name in('лизинг', 'льготный')
group by credit_name
--7

select t.company_name, t.summa ,(
	select count(*) from Treaty tt
	where tt.company_name = t.company_name
	and tt.summa = t.summa
)[Количество]
from Treaty t
group by t.company_name, t.summa
having	summa<1000 or summa>5000