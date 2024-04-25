CREATE DATABASE StudenAPI;

USE StudenAPI;

CREATE TABLE Student
(StudentId int PRIMARY KEY IDENTITY(1,1),
StudentName VARCHAR(20),
Address VARCHAR(50),
PhoneNumber int
);

DROP TABLE Student;
SELECT * FROM Student;

INSERT INTO Student(StudentName,Address,PhoneNumber) 
	VALUES('abc','Valsad',1234567890);