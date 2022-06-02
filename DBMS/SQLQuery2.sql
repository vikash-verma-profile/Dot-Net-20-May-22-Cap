
--full outer join
--left outer join
--right outer join

select * from employee;

select * from department;

select * from employee emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee emp LEFT OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee emp RIGHT OUTER JOIN department dep on emp.departmentid=dep.id;

