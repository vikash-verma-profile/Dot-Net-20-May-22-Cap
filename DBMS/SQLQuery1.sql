Create database SampleDb2;
Drop database SampleDb2;
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

delete  from sample where id=1;--deleting rows

update  sample set name='rohit' where id=2;