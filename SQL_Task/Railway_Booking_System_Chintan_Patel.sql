-- Created a database for Railway Booking System
create database Railway_Booking_System

-- Created a table for Railway Booking
create table Railway_Booking
(
	Sr_no int Primary key,
	Passengers_ID int references Passengers(Passengers_ID),
	Train_ID int references Train(Train_ID),
);

-- Created a table for Passengers
create table Passengers
(
	Passengers_ID int Primary key,
	Passengers_Name varchar(50),
	Passengers_Gender char(1),
	Passengers_Age int
);

-- Created a table for Train
create table Train
(
	Train_ID int Primary key,
	Train_Name varchar(50),
	Coach varchar(50),
	Seat_no int,
	Timings datetime,
	Destination_From varchar(50),
	Destination_To varchar(50),
	Price int
);

-- 1). Displaying Railway Booking Table
select * from Railway_Booking

-- 2). Displaying Passengers Table
select * from Passengers

-- 3). Displaying Train Table
select * from Train

-- 4). Inserting Data into Passengers Table
insert into Passengers (Passengers_ID, Passengers_Name, Passengers_Gender, Passengers_Age) values (1, 'Chintan Patel', 'M', 23),
																								  (2, 'Darpan Patel', 'M', 22),
																								  (3, 'Twinkle Rana', 'F', 22),
																								  (4, 'Rahul Pachauri', 'M', 26),
																								  (5, 'Nivedita Tewani', 'F', 29),
																								  (6, 'Dhyan Desai', 'M', 23),
																								  (7, 'Kirtan Patel', 'M', 22),
																								  (8, 'Nachiketa Patel', 'M', 24),
																								  (9, 'Subham Bhumar', 'M', 28),
																								  (10, 'Princy Patel', 'F', 22);

-- 5). Inserting Data into Train Table
insert into Train (Train_ID, Train_Name, Coach, Seat_no, Timings, Destination_From, Destination_To, Price) values (1, 'Bharat Express', 'HA1', 224, GETDATE(), 'Valsad', 'Amhedabad', 200),
																												  (2, 'Gujarat Express', '1A', 486, GETDATE(), 'Valsad', 'Surat', 50),
																												  (3, 'Ayodhya Express', '1A', 283, GETDATE(), 'Valsad', 'Mumbai', 1000),
																												  (4, 'Goa Express', 'B3', 455, GETDATE(), 'Valsad', 'Goa', 2500),
																												  (5, 'Maharastra Express', 'B3', 664, GETDATE(), 'Valsad', 'Ayodya', 635);

-- 6). Inserting Data into Railway Booking Table
insert into Railway_Booking (Sr_no, Passengers_ID, Train_ID) values (1, 4, 4),
																	(2, 6, 1),
																	(3, 9, 5),
																	(4, 7, 4),
																	(5, 8, 2),
																	(6, 10, 4),
																	(7, 2, 1),
																	(8, 5, 2),
																	(9, 1, 3),
																	(10, 3, 3);

-- WHERE Expressions

-- 7). Displaying Tickets booked for Ayodya
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Destination_From, Destination_To  from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and Destination_To = 'Ayodya';

-- 8). Displaying Tickets booked for Mumbai
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Destination_From, Destination_To  from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and Destination_To = 'Mumbai';

-- 9). Displaying Tickets booked for Goa
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Destination_From, Destination_To  from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and Destination_To = 'Goa';

-- 10). Displaying Tickets booked for Ayodhya Express
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Train_Name from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and t.Train_Name = 'Ayodhya Express';

-- 11). Displaying Tickets booked for Gujarat Express and Goa Express using like
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Train_Name from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and t.Train_Name Like 'G%';

-- 12). Displaying Tickets booked by Passengerss who are older than 24
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age from Railway_Booking r, Passengers c where c.Passengers_ID = r.Passengers_ID and c.Passengers_Age >= 24;

-- 13). Displaying Tickets booked for Bharat Express
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Train_Name, Destination_From, Destination_To from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and t.Train_Name = 'Bharat Express';

-- 14). Displaying Tickets booked for Maharastra Express
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Train_Name, Destination_From, Destination_To from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and t.Train_Name = 'Maharastra Express';

-- 15). Diplaying all Tickets booked
select Sr_no, Passengers_Name, Passengers_Gender, Passengers_Age, Train_Name, Coach, Seat_no, Timings, Destination_From, Destination_To, Price from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID;

-- 16). Diplaying Ticket Prices Greater than 1000
select Train_Name, Destination_From, Destination_To, Price from Train where Price >= 1000;

-- 17). Diplaying Ticket Prices Smaller than 1000
select Train_Name, Destination_From, Destination_To, Price from Train where Price <= 1000;

-- 18). Displaying Passengerss whose Surname is Patel
select * from Passengers where Passengers_Name like '%_Patel';

-- 19). Displaying Female Passengerss
select * from Passengers where Passengers_Gender like 'F';

-- 20). Displaying Tickets booked for both Mumbai and Surat
select Sr_no, Passengers_Name, Destination_To  from Railway_Booking r, Passengers c, Train t where c.Passengers_ID = r.Passengers_ID and t.Train_ID = r.Train_ID and Destination_To in ('Mumbai','Surat');