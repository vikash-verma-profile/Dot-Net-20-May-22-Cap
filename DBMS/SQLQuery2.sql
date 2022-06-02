
--full outer join
--left outer join
--right outer join

select * from employee;

select * from department;

select * from employee emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee emp LEFT OUTER JOIN department dep on emp.departmentid=dep.id;

--select * from employee emp LEFT INNER JOIN department dep on emp.departmentid=dep.id;

select * from employee emp RIGHT OUTER JOIN department dep on emp.departmentid=dep.id;

create table students(id int ,rollno int,firstname varchar(100),lastname varchar(100),gender varchar(20),classid int)

create table studentclass(id int,classname varchar(100))

select * from students
select * from studentclass

insert into studentclass values(1,'V');
insert into studentclass values(2,'VI')
insert into studentclass values(3,'VII')

insert into students values(1,101,'Vikash','Verma','Male',1)
insert into students values(2,102,'Rohit','Kumar','Male',1)
insert into students values(3,103,'Amit','Soni','Male',1)
insert into students values(4,104,'Rakesh','Sharma','Male',1)
insert into students values(5,105,'Anjali','Sharma','Female',1)


select rollno,CONCAT(firstname,' ',lastname) as FullName,gender,sc.classname from students s
inner join studentclass sc on sc.id=s.classid