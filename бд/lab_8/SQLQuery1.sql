use LM_MyBase

--1
select credit_name[�������� �������], summa[�����], issue_date[���� ������ �������]
from Treaty
--����������� ������� ������� �� ���������(�������������, �������)
go
create view [�������]
as select credit_name[�������� �������], summa[�����], issue_date[���� ������ �������]
from Treaty

select * from [�������]
select * from [�������] order by[�����]
go
alter view [�������]
as select credit_name[�������� �������], summa[�����], issue_date[���� ������ �������], return_date[���� ����������� �������]
from Treaty

drop view [�������]

--2
go
create view[���� � ���������]
as select t.credit_name [�������� �������], t.summa[�����], c.company_name[�������� ��������], c.addres[�����]
	from Treaty t join Company c
	on t.company_name =c.company_name
select * from [���� � ���������]
--3 
go 
create view �������_�������(id,��������_������� ,�����, ��������_��������)
as select credit_id, credit_name, summa, company_name
from Treaty
where summa>2000 ;
--where summa>2000 with check option;
go 


select* from �������_�������
insert �������_������� values(10,'��������',12300,'��� �������')
update �������_������� set ����� = 666 where ��������_��������= '��� �������'
delete  �������_������� where ��������_�������� ='��� �������'

--5
go
create view �������_�������_���_���(id,��������_������� ,�����, ��������_��������)
as select top 2 credit_id, credit_name, summa, company_name
from Treaty
order by credit_id

select * from �������_�������_���_���

--6
go
create view Credits with schemabinding
as select t.credit_name [�������� �������], t.summa[�����], c.company_name[�������� ��������], c.addres[�����]
	from dbo.Treaty t join dbo.Company c
	on t.company_name =c.company_name


