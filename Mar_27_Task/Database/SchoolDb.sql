create table Students
(
	StudentId int identity(1,1) primary key,
	FirstName nvarchar(max),
	LastName nvarchar(max)
);

create table Marks
(
	MarksId int identity(1,1) primary key,
	StudentId int references Students(StudentId),
	Science int,
	Maths int,
	English int
);

select * from Students
truncate table Students
select * from Marks

drop table Marks