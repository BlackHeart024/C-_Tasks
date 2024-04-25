create database CompDb;

create table Employee
(
	Emp_Id int identity(1,1) primary key,
	Emp_department_id int references Department(Dept_id),
	Emp_name nvarchar(max),
	Emp_address nvarchar(max),
	Emp_salary decimal
);

create table Department
(
	Dept_id int identity(1,1) primary key,
	Dept_name nvarchar(max)
);

select * from Employee;
select * from Department;

truncate table Employee;
truncate table Department;

drop table Employee;
drop table Department;

drop database ComDb;