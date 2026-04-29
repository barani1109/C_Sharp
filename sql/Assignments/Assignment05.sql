use assignment5;


create table tblemployee (
    empid int primary key,
    empname varchar(20),
    gender varchar(10),
    salary decimal(10,2),
    departmentid int
);

insert into tblemployee values (101,'raj','male',5000,1);
insert into tblemployee values (102,'kumar','male',8000,2);
insert into tblemployee values (103,'anita','female',6000,3);


create or alter proc sp_payslip
@empid int
as
begin
    declare @ename varchar(20), @salary decimal(10,2)
    declare @hra decimal(10,2), @da decimal(10,2)
    declare @pf decimal(10,2), @it decimal(10,2)
    declare @deductions decimal(10,2)
    declare @gross decimal(10,2), @net decimal(10,2)

    select @ename = empname, @salary = salary
    from tblemployee
    where empid = @empid

    set @hra = @salary * 0.10
    set @da = @salary * 0.20
    set @pf = @salary * 0.08
    set @it = @salary * 0.05

    set @deductions = @pf + @it
    set @gross = @salary + @hra + @da
    set @net = @gross - @deductions

    print '----------- payslip -----------'
    print 'employee id   : ' + cast(@empid as varchar)
    print 'employee name : ' + @ename
    print 'salary        : ' + cast(@salary as varchar)

    print 'hra (10%)     : ' + cast(@hra as varchar)
    print 'da  (20%)     : ' + cast(@da as varchar)

    print 'pf  (8%)      : ' + cast(@pf as varchar)
    print 'it  (5%)      : ' + cast(@it as varchar)

    print 'deductions    : ' + cast(@deductions as varchar)
    print 'gross salary  : ' + cast(@gross as varchar)
    print 'net salary    : ' + cast(@net as varchar)
end;


exec sp_payslip 101;



create table holidays (
    holiday_date date,
    holiday_name varchar(50)
);

insert into holidays values ('2026-01-01','new year');
insert into holidays values ('2026-08-15','independence day');
insert into holidays values ('2026-10-02','gandhi jayanthi');
insert into holidays values ('2026-4-29','diwali');


create or alter trigger trg_block_holiday
on tblemployee
for insert, update, delete
as
begin
    declare @holidayname varchar(50)

    select @holidayname = holiday_name
    from holidays
    where holiday_date = cast(getdate() as date)

    if(@holidayname is not null)
    begin
        raiserror('due to %s you cannot manipulate data',16,1,@holidayname)
       
    end
end;

update tblemployee set empname='mary' where empid=102;
