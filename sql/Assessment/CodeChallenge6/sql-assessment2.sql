use assignment2

select * from emp

--1. Write a query to display your birthday (day of week)

select datename(dw,'2004-11-09') as 'Birthday Day'


--2. Write a query to display your age in days

select datediff(day,'2004-11-09',getdate()) as 'Age In Days'


--query 3

select *
from emp
where year(hiredate) <= year(getdate()) - 5
and month(hiredate) = month(getdate())


--q4
create table Employee
(
 empno int,
 ename varchar(20),
 sal decimal,
 doj date
)


begin tran;

-- a. insert 3 rows

insert into Employee(empno, ename, sal, doj) values
(1,'Arun',5000,'2019-05-10'),
(2,'Kumar',6000,'2018-05-15'),
(3,'Ravi',7000,'2022-03-15');



select * from Employee;



-- b. update 2nd row salary with 15% increment
update Employee
set sal = sal * 1.15
where empno = 2;

select * from Employee;


-- c. delete first row
delete from Employee
where empno = 1;

select * from Employee;


-- restoring deleted row
insert into Employee(empno, ename, sal, doj) values
(1,'Arun',5000,'2019-05-10');
select * from Employee;

commit tran;
select * from Employee;


---5

create or alter function fn_calculateBonus
(
 @deptno int,
 @sal decimal
)
returns decimal
as
begin
 declare @bonus decimal
 if(@deptno = 10)
   set @bonus = @sal * 15/100
 else if(@deptno = 20)
   set @bonus = @sal * 20/100
 else
   set @bonus = @sal * 5/100

 return @bonus
end

select empno, ename, deptno, sal,
dbo.fn_calculateBonus(deptno, sal) as Bonus
from emp

---6

create or alter proc sp_UpdateSalesSalary
as
begin

 update emp
 set sal = sal + 500
 where deptno in
       (select deptno from dept where dname = 'Sales')
       and sal < 1500

 print 'Salary Updated Successfully'

end

exec sp_UpdateSalesSalary

select * from emp

