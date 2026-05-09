Create Database NFSDB2;
Use NFSDB2;
Go

CREATE TABLE Students
(
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(50),
    Age INT
)
 select *from Students;
 Truncate table Students;