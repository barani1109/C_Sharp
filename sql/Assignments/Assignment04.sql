create database assignment4;

use assignment4;

-- 1)factorial of a given number

declare @num int = 5;
declare @fact bigint = 1;

while @num > 0
begin
    set @fact = @fact * @num;
    set @num = @num - 1;
end

select @fact as factorial;

-- 2)stored procedure for multiplication table

create procedure sp_multiplication
    @num int,
    @limit int
as
begin
    declare @i int = 1;

    while @i <= @limit
    begin
        print cast(@num as varchar) + ' x ' + cast(@i as varchar) + ' = ' + cast(@num*@i as varchar);
        set @i = @i + 1;
    end
end;

exec sp_multiplication 5, 10;


-- function
-- create tables

create table student (
    sid int primary key,
    sname varchar(20)
);

create table marks (
    mid int primary key,
    sid int,
    score int,
    foreign key (sid) references student(sid)
);

-- insert values

insert into student values (1,'jack');
insert into student values (2,'rithvik');
insert into student values (3,'jaspreeth');
insert into student values (4,'praveen');
insert into student values (5,'bisa');
insert into student values (6,'suraj');

insert into marks values (1,1,23);
insert into marks values (2,6,95);
insert into marks values (3,4,98);
insert into marks values (4,2,17);
insert into marks values (5,3,53);
insert into marks values (6,5,13);


-- create function (pass/fail)

create function fn_status (@score int)
returns varchar(10)
as
begin
    declare @result varchar(10);

    if @score >= 50
        set @result = 'pass';
    else
        set @result = 'fail';

    return @result;
end;

-- display
select s.sid, s.sname, m.score, dbo.fn_status(m.score) as status
from student s
join marks m on s.sid = m.sid;