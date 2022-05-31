Create database SampleDb2;
Drop database SampleDb2;
use SampleDb1
--Create table
/*
create table <TABLE NAME>(<columns> data-type)
*/
create table sample(id int,name varchar(200));

select * from sample where id=3;--select columns

insert into sample values(1,'Vikash 1');
insert into sample values(2,'Vikash 2');
insert into sample values(3,'Vikash 3');
insert into sample values(4,'Vikash 4');

alter table sample Add salary int;
alter table sample Drop column salary ;
delete  from sample where id=1;--deleting rows

update  sample set name='rohit' where id=2;

create table student(id int,rollno int,FirstName varchar(20),LastName varchar(20),Gender varchar(10));

select Gender from student group by Gender having count(*)>2;

select FirstName from student group by FirstName having count(*)>1;

insert into student values(1,'101','Vikash',' 1','Male');
insert into student values(2,'102','Rohit','Kumar','Male');
insert into student values(3,'103','Viyan','Soni','Male');
insert into student values(4,'104','Anjali','Soni','FeMale');
insert into student values(5,'105','Shivani','Verma','FeMale');
insert into student values(6,'106','Raj','Kumar','Other');

insert into student values(7,'107','Vikash',' 1','Male');

select * from student where Gender='Female';

select * from student where Gender='Male';

select * from student order by id desc 
select * from student order by id asc 

select * from student where rollno=101;
select * from student where rollno=103;
select * from student where rollno=105;

select * from student where rollno in (101,103,105);
select * from student where rollno not in (101,103,105);

select max(rollno) from student
select min(rollno) from student
select AVG(rollno) from student
select count(*) from student 

select  * from student where FirstName like 'V%'
--name=v
--name=vasdlkasd
select  * from student where FirstName like 'a%'

select CONCAT(FirstName,' ',LastName) as FullName  from student

select * from student where rollno between 101 and 105


create table employee (id int,name varchar(200),departmentid int)
create table department(id int,department varchar(20))
insert into employee values(1,'Vikash',1)
insert into employee values(2,'Rohit',2)
insert into employee values(3,'Rahul',1)
insert into employee values(4,'Rahul',3)

insert into department values(1,'IT')
insert into department values(2,'Sales')
insert into department values(4,'Admin')

select * from employee
select * from department

select emp.name,dep.department from employee as emp inner join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee as emp left join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee as emp right join department as dep on emp.departmentid=dep.id

select * from employee as emp inner join department as dep on emp.departmentid=dep.id;

