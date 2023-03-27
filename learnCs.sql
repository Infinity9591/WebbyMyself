USE master;
DROP DATABASE IF EXISTS SV;
GO
CREATE DATABASE SV;
GO
USE SV;
GO
DROP TABLE IF EXISTS Branch
GO
CREATE TABLE Branch
(
	ID int primary key,
	BranchName nvarchar(100)
)
DROP TABLE IF EXISTS Class
GO
CREATE TABLE Class
(
    ID int primary key,
    ClassName nvarchar(50),
	BranchID int foreign key references Branch(ID)
)
GO
DROP TABLE IF EXISTS Student
GO
CREATE TABLE Student
( 
    ID int PRIMARY KEY,
    [Name] nvarchar(50) NOT NULL,
    Phone nvarchar(50) NOT NULL,
    Email nvarchar(50) NOT NULL,
    [Address] nvarchar(50),
    ClassID int foreign key references Class(ID)
)
INSERT INTO Branch VALUES (1, N'Công ngh? thông tin')
INSERT INTO Branch VALUES (2, N'Công ngh? ph?n m?n')
INSERT INTO Branch VALUES (3, N'Truy?n thông m?ng máy tính')

INSERT INTO Class VALUES (1, N'CNT62DH',1)
INSERT INTO Class VALUES (2, N'KPM62DH',2)
INSERT INTO Class VALUES (3, N'TTM62DH',3)

INSERT INTO Student VALUES (90658, N'Nguyen Trung Son', N'0123456789', N'burhlmeo@gmail.com', N'HP', 1)
INSERT INTO Student VALUES (10000, N'Tran Ba Quoc Dung', N'0987654321', N'lmeo@gmail.com', N'HP', 2)

DROP VIEW IF EXISTS ClassManage
GO
CREATE VIEW ClassManage AS
SELECT Class.ID, Class.ClassName, Branch.BranchName
FROM Branch, Class
where Class.BranchID = Branch.ID