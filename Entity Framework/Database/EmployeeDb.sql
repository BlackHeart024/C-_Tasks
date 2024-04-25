create table Employee
(
	DeptId int references Department(Dept_Id),
	Emp_Id int identity(1,1) primary key,
	First_Name nvarchar(max),
	Last_Name nvarchar(max),
	State nvarchar(max),
	City nvarchar(max)
);

create table Department
(
	Dept_Id int identity(1,1) primary key,
	Dept_Name nvarchar(max)
);

select * from Employee;
select * from Department;

drop table Employee;
drop table Department;