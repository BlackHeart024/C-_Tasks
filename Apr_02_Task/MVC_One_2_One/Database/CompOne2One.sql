create table EmployeeMaster
(
	Employee_id int identity(1,1) primary key,
	Employee_address_id int references AddressMaster(Address_ID),
	Employee_name nvarchar(max),
);

create table AddressMaster
(
	Address_ID int identity(1,1) primary key,
	Address nvarchar(max)
);

select * from EmployeeMaster;
select * from AddressMaster;