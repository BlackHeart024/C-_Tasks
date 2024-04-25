-- Create the employee table
CREATE TABLE employee (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    department VARCHAR(50),
    position VARCHAR(50),
    salary DECIMAL(10, 2)
);





-- 18|03|24

-- AND and OR Conjuctive operators
select * from employee where department = 'Marketing' and salary > 80000;
select * from employee where department = 'Marketing' or salary > 80000;

-- Update query
update employee set First_Name = 'Will' where employee_id = 2; 

-- Delete query
delete from employee where last_name = 'Taylor';

-- Sorting results
select * from employee order by First_Name;






-- 19|03|24

-- NULL values
-- Insert sample data into the employee table
INSERT INTO employee (employee_id, first_name, last_name, department, position, salary)
VALUES
    (1, 'John', 'Doe', 'IT', 'Software Engineer', 70000.00),
    (2, 'Jane', 'Smith', 'HR', 'HR Manager', 80000.00),
    (3, 'Michael', 'Johnson', null, 'Financial Analyst', 65000.00),
    (4, 'Emily', 'Williams', 'Marketing', 'Marketing Specialist', 60000.00),
    (5, 'David', 'Brown', 'Operations', 'Operations Manager', 85000.00),
    (6, 'Sarah', 'Jones', 'IT', null, 75000.00),
    (7, 'Kevin', 'Taylor', 'Finance', 'Accountant', 60000.00),
    (8, 'Jessica', 'Martinez', 'Marketing', 'Marketing Manager', 90000.00),
    (9, 'Daniel', null, 'IT', 'System Analyst', 72000.00),
    (10, 'Lauren', 'Rodriguez', 'HR', 'HR Assistant', 55000.00);

drop table employee;

select * from employee;

-- Alias syntax
select employee_id, first_name as Phehla_naam, last_name as Aakhari_naam, department, position, salary as Aamdani from employee;

-- Indexes
create index id on employee (employee_id);
drop index id on employee;

-- Alter table command
alter table employee add age varchar(5);  -- Adds column
alter table employee drop column age;  -- Drops column
-- alter table employee rename column first_name to First_Name;  -- Renames column
EXEC sp_rename 'employee.first_name',  'First_Name', 'COLUMN';
alter table employee alter column age int;  -- Alters datatype

-- Truncate table command
truncate table employee;







-- 20|03|24

-- Using views
create view employee_view_1 as select * from employee where department = 'IT';create view employee_view_2 as select * from employee where position is not null with check option;select * from employee_view_1;select * from employee_view_2;drop view employee_view_1;drop view employee_view_2;--Having clauseselect count(employee_id), department from employee group by department having count (employee_id) > 1;-- Wildcard operatorsselect * from employee where First_Name like 'j%';select * from employee where last_name like '%a%';select * from employee where First_Name like '%n';-- 21|03|24-- Date functionsselect getdate();-- Tempory tablescreate table #employee (id int, name varchar(50));insert into #employee values (1, 'Chintan'),							 (2, 'Darpan');select * from #employee;-- Using Sequencescreate sequence sequence_1start with 1increment by 1minvalue 1maxvalue 5cycle;create table students(	roll_no int,	name varchar(50));insert into students values (null, 'Chintan'),							(null, 'Darpan'),							(null, 'Dhyan'),							(null, 'Nividita'),							(null, 'Twinkle');update students set roll_no = next value for sequence_1;select * from students;drop table students;drop sequence sequence_1;