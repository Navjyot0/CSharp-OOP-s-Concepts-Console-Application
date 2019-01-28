-- Data : facts and statistics collected together for reference or analysis.
-- Information : Processed Data is known as Information.
-- Database : Collection of information belongs to a particular topic written in a predetermined manner stored at a particular place is called as database.
-- DBMS : It is software which is present inside the database, which maintains Database

-- Types of Database 
-- 1. FMS (File Managment System)
-- 2. HMS (Hierarchy Managment System)
-- 3. NDBMS (Network Database Management System)
-- 4. RDMS (Relational Database Management System)

-- CODD RULES

-- SQL SERVER: SQL Server is an RDBMS product which was designed and developed by Microsoft Company.

-- Server Authentication :
-- 1. Windows Authentication
-- 2. SQL Server Authentication

-- System Database : 
-- Master
-- Model
-- Msdb
-- Tempdb

-- Data Types in SQL Server
-- 1. Integer Data Types
-- 2. Decimal Data Types
-- 3. Money (or) Currency Data Types
-- 4. Date & Time Data Types
-- 5. Character Data Types
-- 6. Binary Data Types

-- 1. Integer Data Types
-- TinyInt (0-255) 1 byte
-- SmallInt (-32768 to 32767) 2 byte
-- Int (-2,147,483,648 to 2,147,483,647) 4 byte
-- Bigint (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807) 8 byte


-- 2. Decimal Data Types
-- Decimal (P,S) -----> P=Precision & S=Scale
-- Numeric (P,S) 

-- 3. Money Data Type
-- Small Money (4 byte)
-- Money (8 byte)

-- 4. Date and Time Data Type
-- Date & Time  ---> "yy/mm/dd" "hh/mm/ss.ms"

-- 5. Character Data Types
-- Char(n)
-- varchar(n/max)
-- Text [varchar(max)]
-- nchar(n)
-- nvarchar(n/max)
-- ntext [nvarchar(max)]

-- 6. Binary Data Type
-- Binary(n)
-- varbinary(n/max)
-- Image [varbinary(max)] 

-- Structured query language
--						|_______ 1. DDL (Data Defination Language) [Drop, SP_RENAME, Create, Alter, Truncate]
--						|_______ 2. DML (Data Manipulaion Language) [Select, Insert, Update, Delete]
--						|_______ 3. TCL (Transaction Control Language) [Commit, Rollback, Save Transaction]
--						|_______ 4. DCL (Data Control Language) [Grant, Invoke]

-- Every object name should contain minimum one character and maximum 128 characters
-- The maximum no. of columns a table can have 1024 columns.

sp_databases -- list databases 

SP_Tables -- list tables 

Drop database NathanArk --Remove database 

Create Database NathanArk -- Create database

use NathanArk --set default database

--Create Table 
Create table Department 
(
	DeptID int primary key Identity(1, 1), --set identity and primary key at creation
	DepartmentName nvarchar(150) 
)

-- Check how to add primary key Forign key, Identity to created tables?

Create Table Employee 
(
	EmpID int primary key Identity(1, 1),
	FirstName nvarchar(150),
	LastName nvarchar(150),
	Age tinyint,
	Location nvarchar(150),
	DeptID int foreign Key references Department(DeptID) -- Set forign key
)

insert into Department (DepartmentName) values ('IT'), ('Sales'), ('Marketing'), ('Clark'), ('Manager')
select * from Department

Insert into Employee 
(FirstName, LastName, Age, Location, DeptID) 
values 
('Navjyot', 'Gurhale', 24, 'Hyderabad', 1),
('Netaji', 'Jadhav', 29, 'Chenai', 2),
('Shekhar', 'Kashid', 27, 'Bangalore', 3),
('Nitin', 'Kulkarni', 26, 'Mumbai', 2),
('Ankit', 'Rai', 30, 'Pune', 1)


Select * from Employee


--Alter 
alter table Department alter column DepartmentName nvarchar(200) --update column
alter table Department add NewColumn nvarchar(100) --Add Column 
alter table Department drop column NewColumn -- drop column 


-- SP_Rename
alter table Department add NewColumn nvarchar(100) --Add Column 
SP_Rename 'Department.NewColumn', 'LocationColumn', 'Column'
alter table Department drop column LocationColumn
SP_Rename 'Department', 'Dept' -- Rename table Name
SP_Rename 'Dept', 'Department' -- Rename table Name


-- Truncate 
Truncate table Department

--Drop 
Drop table Department

--SP_help
sp_help Department

-- Difrence between Delete and truncate 
-- Projection (Retrieving the data from specific columns is known as Projection)
-- Selection (Retrieving the data based on some condition is called selection)
-- ALIAS ALIAS is a duplicate name (or) alternate name for the original column name (or) Table name (or) an expression name.


-- IDENTITY 
-- It is use to generate unique values in sequential order without user interaction. 
-- The default value of identity is Identity (1, 1).

-- Built In Functions
-- ABS ()
select ABS(-15)

-- CEILING () 
select CEILING(15.003)
select CEILING(-3.14)

-- FLOOR ():
select FLOOR(15.003)
select FLOOR(-3.14)

-- SQUARE ()
select SQUARE(2)

--SQRT()
select SQRT(16)
select SQRT(17)

--Power()
select Power(2, 3)

-- OPERATORS IN SQL
-- 1. Assignment operator
-- 2. Arithmetic operator
-- 3. Comparison operator
-- 4. Logical operator
-- 5. Set operator

-- Set Operators
-- UNION / UNION ALL / INTERSECT /EXCEPT
Create Table Employee_Chennai
(
	EmpID int,
	Name nvarchar(100)
)

Create Table Employee_Pune
(
	EmpID int,
	Name nvarchar(100),
	Age tinyint
)

Insert into Employee_Chennai (Name) values ('Navjyot Gurhale'), ('Arun Agrwal'), ('Will Smith')
Insert into Employee_Pune (Name, Age) values ('Navjyot Gurhale', 25), ('Netaji Jadhav', 29), ('Girish Kangne', 45)

select EmpID, Name from Employee_Chennai
union 
Select EmpID, Name from Employee_Pune

select EmpID, Name from Employee_Chennai
union all
Select EmpID, Name from Employee_Pune

select EmpID, Name from Employee_Chennai
intersect
Select EmpID, Name from Employee_Pune

select Name from Employee_Chennai
Except
Select Name from Employee_Pune
except
select Name from Employee_Chennai

-- CLAUSES IN SQL
-- Where 
Select * from Employee where DeptID=1

-- Order By
Select * from Employee order by EmpID
Select * from Employee order by EmpID desc

-- Top N clause
Select top(2) * from Employee

-- Group By
SELECT DeptID, COUNT=COUNT (*) FROM Employee GROUP BY DeptID

-- Having
SELECT DeptID, COUNT=COUNT (*) FROM Employee GROUP BY DeptID having count (*)>=2

-- Differences Between WHERE and HAVING Clause 

-- Types of constraints in SQL Server:-
-- 1. Unique Key constraint.
Create Table Person
(
	UserID nvarchar(150) unique
)

-- 2. Not Null constraint.
Create Table Student
(
	StudID int not null
)

-- 3. Check constraint
create table emp4
(
	eno int,ename varchar(50),
	age int check (age between 18 and 40)
)

-- 4. Primary key constraint.
create table emp
(
	EID int primary key,ENAME
	varchar(50),SALARY money
)

-- 5. Foreign Key constraint.
create table Employee
(
	EID int,ENAME varchar(50),
	SALARY money,
	Deptno int foreign key references Department(Deptno)
)

-- JOINS IN SQL
-- EQUI JOIN
Select * from Employee, Department where (Employee.DeptID=Department.DeptID) 

-- INNER JOIN
Select * from Employee E inner join Department D on E.DeptID=D.DeptID
Select Name=E.FirstName + ' ' + E.LastName, D.DepartmentName from Employee E inner join Department D on E.DeptID=D.DeptID

-- OUTER JOIN
	-- LEFT OUTER JOIN
	select * from Employee Left outer join Department on Employee.DeptID=Department.DeptID

	-- RIGHT OUTER JOIN
	select * from Employee right outer join Department on Employee.DeptID=Department.DeptID

	-- FULL OUTER JOIN
	select * from Employee full outer join Department on Employee.DeptID=Department.DeptID

-- NON EQUI JOIN
--SELECT * FROM EMP, SALGRADE WHERE (SALARY > LOWSAL) AND (SALARY < HIGHSAL)

-- SELF JOIN
SELECT E.EmpID, E.FirstName, E.LastName, M.EmpID, M.FirstName, M.LastName FROM Employee E, Employee M WHERE E.EmpID=M.EmpID

-- CROSS JOIN
SELECT * FROM Employee CROSS JOIN Department

-- NATURAL JOIN
SELECT EmpID, FirstName, LastName, DepartmentName FROM Employee E, Department D WHERE E.DeptID=D.DeptID

-- Create table from existing Table 
--Select * into <New Table Name> from <Old Table Name>


-- TRANSACTION CONTROLL LANGUAGE
-- TRANSACTION
-- BEGIN TRANSACTION
-- COMMIT
-- ROLLBACK
-- SAVE POINT

BEGIN TRANSACTION
INSERT INTO EMPLOYEE VALUES('Kamal', 'Hasan', 26 ,'MUMBAI', 4)
INSERT INTO EMPLOYEE VALUES('Sujata', 'Singh', 31, 'DELHI', 5)
COMMIT

BEGIN TRANSACTION
DELETE FROM EMPLOYEE WHERE EmpID=1
DELETE FROM EMPLOYEE WHERE EmpID=2
BEGIN TRANSACTION
ROLLBACK


BEGIN TRANSACTION
UPDATE EMPLOYEE SET SALARY=99000 WHERE EID=101
UPDATE EMPLOYEE SET SALARY=88000 WHERE EID=102
SAVE TRANSACTION S1
UPDATE EMPLOYEE SET SALARY=77000 WHERE EID=103
UPDATE EMPLOYEE SET SALARY=66000 WHERE EID=104
SAVE TRANSACTION S2
UPDATE EMPLOYEE SET SALARY=55000 WHERE EID=105
UPDATE EMPLOYEE SET SALARY=44000 WHERE EID=106
BEGIN TRANSACTION
ROLLBACK TRANSACTION S1
BEGIN TRANSACTION
ROLLBACK TRANSACTION S2


select * from Employee


-- Sub Query
-- Syntax: select * from <Table Name> where (condition) (select * from…….. (Select * from….. (select * from……..)));

--INDEXES IN SQL
-- Index is a database object which is used for the quick retrieving of the data from the table.
-- types of indexes
-- 1. Clustered
-- 2. Non-Clustered
-- Syntax: Create Index <Index Name> on <Table Name> (Column Name);

-- VIEWS IN SQL: View is database object which is like table but logical.
-- Why We Need Views: To protect the data
-- View is classified into two types.
-- Simple view(Updatable view) [we create a view based on one table is called simple view or Updatable view]
-- Complex view(Non-Updatable view) [we create a view based on more than one table is called complex view or Non-Updatable view]
-- Syntax: create view <view name> as select * from <table name>
Create view AllEmpDetails 
as
select Emp.EmpID, Name=Emp.FirstName +' '+ Emp.LastName, Department=Dept.DepartmentName from Employee as Emp, Department as Dept where Emp.DeptID=Dept.DeptID

select * from AllEmpDetails

-- ********T/SQL Programming********** (Transact Structure Query Language)

declare @EmpId int; declare @Name nvarchar(150);

set @EmpId=101; Set @Name='Navjyot Gurhale'

Print @EmpId; Print @Name;

--IF_Else
Declare @num1 int;
Declare @num2 int;

set @num1=12;
set @num2=22;

IF(@num1>@num2)
Print '1st num is big'
else if(@num1<@num2)
Print '2nd no is big'
else
Print 'it seems both are equal'

-- Switch
DECLARE @WEEK INT
SET @WEEK=DATEPART(DW, GETDATE())
SELECT CASE @WEEK
WHEN 1 THEN 'SUNDAY'
WHEN 2 THEN 'MONDAY'
WHEN 3 THEN 'TUESDAY'
WHEN 4 THEN 'WEDNESDAY'
WHEN 5 THEN 'THURSDAY'
WHEN 6 THEN 'FRIDAY'
WHEN 7 THEN 'SATURDAY'
END

-- While
DECLARE @X INT
SET @X=0
WHILE @X<10
BEGIN
SET @X=@X+1
PRINT @X
END


-- 1. Stored Procedures/Procedure
-- 2. Stored Functions/Functions

-- 1. Stored Procedures/Procedure

-- Syntax 1: 
-- Create Procedures <Procedures Name>
-- As
-- Begin
-- <Statements>
-- End

-- Syntax 2: 
-- Create Procedures <Procedures Name>
-- (Passing parameters)
-- As
-- Begin
-- <Statements>
-- End

-- Syntax: Exec <Procedure name> 
-- Drop Procedure <Procedure Name>


-- 2. Stored Functions/Functions

-- 1. Scalar valued Functions
-- Syntax: 
-- Create Function <Function Name> (@parameter <Data Type> [size])
-- Returns <return attribute data type>
-- As
-- Begin
-- <Function Body>
-- Return <return attribute name>
-- End

-- Select dbo.<Function Name> (value)

-- 2. Table-Valued Fuction
-- Syntax:
-- Create Function <Function Name> (@parameter <Data Type> [size])
-- Returns <Table>
-- As
-- Return <return select statement>

-- select * from ft1('hyd')
-- Drop Function <Function Name>

-- Difference between Function And Procedure
-- A function must return a value where as procedure never returns a value. A procedure can have parameters of both input (with parameters) and output (without parameters) where as a function can have only input (with parameters) parameters only.
-- In procedure we can perform select, insert, update and delete operation where as function can used only to perform select. Cannot be used to perform insert, update and delete operations.
-- A procedure provides the option for to perform transaction management where as these operations are not permitted in a function.
-- We call a procedure using execute command where as function are called by using select command only.



--Triggers

--Magic Table

--CURSOR

--DATA CONTROL LANGUAGE

--Normalization