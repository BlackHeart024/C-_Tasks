create table department
(
	Dept_id int identity(1,1) primary key,
	Dept_name varchar(50)
);

create table employee
(
	Emp_id int identity(1,1) primary key,
	Emp_name varchar(50),
	Emp_dept_id int references department(Dept_id),
);