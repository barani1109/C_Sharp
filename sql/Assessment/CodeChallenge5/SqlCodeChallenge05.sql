create database assessment

use assessment


-- question no-1 
create table books
(
    id int primary key,
    title varchar(100) not null,
    author varchar(50) not null,
    isbn bigint unique,
    published_date datetime
);

insert into books values
(1,'My First SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My Third SQL book','Cary Flint',523120967812,'2015-10-18 14:05:44');



select * from books where author like '%er';


-- question no-1 

create table reviews
(
    id int primary key,
    book_id int,
    reviewer_name varchar(50),
    content varchar(100),
    rating int,
    published_date datetime,
    foreign key (book_id) references books(id)
);

insert into reviews values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10');


select b.title, b.author, r.reviewer_name from books b
left join reviews r
on b.id = r.book_id;





-- question no-2

select reviewer_name from reviews
group by reviewer_name
having count(distinct book_id) > 1;

-- question no-3

create table customer
(
    id int primary key,
    name varchar(20),
    age int,
    address varchar(50),
    salary decimal(10,2)
);

insert into customer values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00);


select name from customer
where address like '%o%';


-- question no-4

create table orders
(
    oid int primary key,
    odate datetime,
    customer_id int,
    amount int,
    foreign key (customer_id) references customer(id)
);

insert into orders values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060);

select  odate,
count(distinct customer_id) as total_customers
from orders
group by odate;

-- question no-5 
create table Employee
(
    id int primary key,
    name varchar(20),
    age int,
    address varchar(50),
    salary decimal(10,2)
);

insert into Employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null);


select LOWER(name)
from Employee
WHERE salary IS NULL;

-- question no-5


CREATE TABLE Studentdetails (
    RegisterNo INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Qualification VARCHAR(20),
    MobileNo BIGINT,
    Mail_id VARCHAR(50),
    Location VARCHAR(30),
    Gender CHAR(1)
);


INSERT INTO Studentdetails VALUES
(2, 'Sai', 22, 'B.E',    9952836777, 'Sai@gmail.com',    'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC',  7890125648, 'Kumar@gmail.com',  'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech',8904567342,'selvi@gmail.com',  'Selam',   'F'),
(5, 'Nisha', 25, 'M.E',  7834672310, 'Nisha@gmail.com',  'Theni',   'F'),
(6, 'SaiSaran', 21, 'B.A',7890345678,'saran@gmail.com',  'Madurai', 'F'),
(7, 'Tom', 23, 'BCA',    8901234675, 'Tom@gmail.com',    'Pune',    'M');


select Gender, COUNT(*) AS Total_Count
from Studentdetails
GROUP BY Gender;
