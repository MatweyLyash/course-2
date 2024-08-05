use LM_MyBase
select Treaty.company_name, Company.contact_person, Treaty.summa, Company.company_name
from Company inner join Treaty
on Treaty.company_name = Company.company_name and
Treaty.credit_name like '%�%';
--Treaty.summa >1000;

--select  Treaty.company_name, Company.contact_person, Treaty.summa, Company.company_name
--from Company, Treaty
--where Treaty.company_name = Company.company_name;

select Treaty.summa, Treaty.issue_date,Treaty.company_name,
case 
when (Treaty.summa between 100 and 700 )then'����� ������'
when (Treaty.summa between 701 and 9999 ) then '������� ������'
else '��� ������� �� ������� ���!!!'
end [����� ��������]	
from Treaty inner join Company
on Treaty.company_name = Company.company_name
		order by Treaty.issue_date

		--������������ ���� ������
select isnull(Company.contact_person,'*')[�������], isnull(Treaty.credit_name,'*')[��� �������]
	from Company left outer join Treaty
		on Treaty.company_name	= Company.company_name

select* from Treaty 
full outer join Company  co  on Treaty.company_name = co.company_name
full outer join Credit  cr on Treaty.credit_name = cr.credit_name
--where Treaty.company_name is null
--where co.contact_person is null
--where Treaty.company_name is not null and co.company_name is not null
order by co.company_name
	
--select count(*)[�������� ������] from Treaty 
--full outer join Company  co  on Treaty.company_name = co.company_name
--full outer join Credit  cr on Treaty.credit_name = cr.credit_name
--where Treaty.summa is NULL	

select Treaty.summa, Credit.stake
	from Treaty cross join Credit
	where Treaty.summa>700



		