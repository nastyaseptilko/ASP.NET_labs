use master
create database Lab4_MVC
use Lab4_MVC


CREATE TABLE Persons
(
	[Id] int PRIMARY KEY IDENTITY,
	[LastName] nvarchar(30) NOT NULL,
	[Phone] nvarchar(15) NOT NULL
)

INSERT INTO [Persons] ([LastName], [Phone])
VALUES ( '«ина','5555555'),
	   ( '≈ва', '2222222');

select * from Persons