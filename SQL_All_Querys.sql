/*To List List*/
sp_databases 

/*(lists Tables in current database)*/
sp_tables

/*Create Database*/
Create Database NathanArk
Drop Database NathanArk

/*(to select database)*/
Use NathanArk

/*Create Table*/
Create table Department
(
	DeptId int primary key Identity(1, 1),
	Department nvarchar(100),
)

Create table student
(
	StudentId int primary key Identity(1, 1),
	Name nvarchar(200),
	Age tinyint,
	City nvarchar(50),
	Fees money,
	DeptId int foreign key references Department(DeptId)
)

create table class
(
	Id int primary key Identity(1, 1),
	Class nvarchar(20)
)

Insert into Department (Department) values
('IT'), ('CSE'), ('E&TC'), ('Mechanical'), ('Electronics')

Insert into student(Name, Age, City, Fees, DeptId) values 
('Navjyot Gurhale', 24, 'Pune', 700000, 2),
('Nitin Patil', 25, 'Mumbai', 700000, 2),
('Girish Kangne', 27, 'Bangalore', 700000, 2),
('Sumit Patil', 30, 'Delhi', 700000, 2)

insert into class (Class) values
('FE'), ('SE'), ('TE'), ('BE')

update student set Fees=90000, DeptId=5 where StudentId=2
update student set Fees=75000, DeptId=3 where StudentId=3
update student set Fees=90000, DeptId=4 where StudentId=4

select * from Student 
select * from Department 
select * from class

select s.Name, s.Fees, d.Department from Department d, student s where s.DeptId=d.DeptId

delete from student where StudentId=1
delete from student --Delete all recoreds
truncate table department --remove all records (its faster than delete because it don't depend upon other dependencies)
drop table department --delete all table and its structure too..

--Keys 
--Types of Keys
--1. Candidate Key
--2. Primary key (Imp)
--3. Foreign key (Imp)
--4. Alternate key(all keys other than primary key)
--5. Composite Key (Imp) (primary key on multiple column)

--Primary key (Imp)
Create table Employee
(
	EmpId int primary key Identity(1, 1),
	FirstName nvarchar(100),
	LastName nvarchar(100),
	Age tinyint
)
--Composite Key (Imp)
Create table Employee
(
	EmpId int Identity(1, 1),
	FirstName nvarchar(100),
	LastName nvarchar(100),
	Age tinyint,
	constaint PK_Employee Primary key (EmpId, FirstName)
)
--Forign key (Imp)
create table Department
(
	DeptId int primary key identity(1, 1),
	Department nvarchar(100)
)
create table Employee 
(
	EmpId int primary key Identity(1, 1),
	FirstName nvarchar(100),
	LastName nvarchar(100),
	Age tinyint
	DeptId int forign key references Department(DeptId) 
)

--Constraints
--constraints are used to specify rules for the data in a table
--NOT NULL - Ensures that a column cannot have a NULL value
--UNIQUE - Ensures that all values in a column are different
--PRIMARY KEY - A combination of a NOT NULL and UNIQUE. Uniquely identifies each row in a table
--FOREIGN KEY - Uniquely identifies a row/record in another table
--CHECK - Ensures that all values in a column satisfies a specific condition
--DEFAULT - Sets a default value for a column when no value is specified
--INDEX - Used to create and retrieve data from the database very quickly

-- Join 
-- Types 
--1. Inner Join
--2. Outer Join 
--	1. Left Join 
--	2. right join
--	3. full outer join
--3. self join
--4. cross join

--Inner Join 
select * from student inner join Department on student.DeptId=Department.DeptId

--Outer Join 
select * from student full outer join Department on student.DeptId=Department.DeptId
--Left Join
select * from student left join Department on student.DeptId=Department.DeptId

--Right Join
select * from student right join Department on student.DeptId=Department.DeptId

--Full Outer Join 
select * from student full outer join Department on student.DeptId=Department.DeptId

--cross Join
select * from student cross join Department 
--or 
select * from student, Department

--Self Join
select s1.Name, s1.Fees from student s1, student s2 where s1.StudentId<>s2.StudentId and s1.Fees=s2.Fees

--Union
select DeptId, Name from student
union
select DeptId, Department from Department

--Group by 
select StudentId, Fees from student group by Fees

--Get random record
select top(1)* from student order by NEWID()


--Alter table
exec sp_rename 'Teacher', 'Student'

alter table student add Marks smallint

alter table student add TotalMarks smallint not null constraint DF_Student_TotalMarks default(1000) with values 1000

alter table student drop constraint DF_Student_TotalMarks

alter table student drop column totalmarks

sp_rename 'student.TotalMarks', 'Total', 'column' -- Rename of column 

alter table student alter column Name nvarchar(50)

update student set classId=1

select * from student

-- Aggregate function 
-- An aggregate function performs a calculation on a set of values, and returns a single value.
-- Except for COUNT, aggregate functions ignore null values.
-- Aggregate functions are often used with the GROUP BY clause of the SELECT statement.
-- All aggregate functions are deterministic.

select Min(Fees) as 'Lowest Salary' from Student

select Min(Name) as 'Lowest Name' from Student

select Max(Fees) as 'Max Fees' from Student

select Max(Name) as 'Max Name' from Student

select Sum(Fees) as 'Total Fees' from Student

select Sum(Name) from Student -- Error : "Operator data type nvarchar is invalid for sum operator."

select avg(fees) as 'Average fees' from Student

select Count(*) as 'Total Student' from Student where DeptId=3

select distinct(Fees) as 'Total Fees' from Student

-- Group By 
-- select exp1, exp2, exp3, .. , exp_n aggrigate_function(expresion) from tables [where condition] group by exp1, exp2, exp3, .. , exp_n
select DeptId, Name, COUNT(*) as 'No of student' from Student group by DeptId, Name

-- Aggregate function 
-- An aggregate function performs a calculation on a set of values, and returns a single value.
-- Except for COUNT, aggregate functions ignore null values.
-- Aggregate functions are often used with the GROUP BY clause of the SELECT statement.
-- All aggregate functions are deterministic.

select Min(Fees) as 'Lowest Salary' from Student

select Min(Name) as 'Lowest Name' from Student

select Max(Fees) as 'Max Fees' from Student

select Max(Name) as 'Max Name' from Student

select Sum(Fees) as 'Total Fees' from Student

select Sum(Name) from Student -- Error : "Operator data type nvarchar is invalid for sum operator."

select avg(fees) as 'Average fees' from Student

select Count(*) as 'Total Student' from Student where DeptId=3

select distinct(Fees) as 'Total Fees' from Student

-- Group By 
-- select exp1, exp2, exp3, .. , exp_n aggrigate_function(expresion) from tables [where condition] group by exp1, exp2, exp3, .. , exp_n
select DeptId, Name, COUNT(*) as 'No of student' from Student group by DeptId, Name


-- Union Operator (Common(single time), not common)
-- SELECT expression1, expression2, ... expression_n FROM tables [WHERE conditions] UNION SELECT expression1, expression2, ... expression_n FROM tables [WHERE conditions];
select DeptId from Student
union
select DeptId from Department

-- Intersect Operator (Common records)
-- SELECT expression1, expression2, ... expression_n FROM tables [WHERE conditions] INTERSECT SELECT expression1, expression2, ... expression_n FROM tables [WHERE conditions];
select DeptId from Student
intersect 
select DeptId from Department

-- IN() 
-- expression IN (value1, value2, .... value_n);   
select * from Student where Name in ('Navjyot Gurhale', 'Nitin Patil')

-- NOT()
-- NOT condition
select * from Student where name not in ('Navjyot Gurhale', 'Nitin Patil')
select * from Student where name is not null
select * from Student where Name not like '%Navjyot%'
select * from Student where StudentId not between 2 and 3

-- Between Operator
-- expression BETWEEN value1 AND value2;  
select * from Student where StudentId between 2 and 3

-- IS NULL
-- Expression IS NULL
select * from Student where Name is null

-- IS Not Null 
-- Expression IS NOT NULL
Select * from Student where Fees is not null

-- Like 
select * from Student where Name like '%N%'

-- Key Updates
-- Check (Enable) 
-- Ex : Alter Table <table_Name> check constraint <key_name>
-- NoCheck (Disable)
-- Ex : Alter Table <table_Name> uncheck constraint <key_name>
-- Drop (Drop)
-- Ex : Alter Table <table_Name> drop constraint <key_name>

-- Views 
-- A view is a virtual table created according to the result set of an SQL statement
-- A view contains rows and columns, just like a real table. 
-- The columns in the view are the columns from one or more real tables in the database. 
-- SQL functions, WHERE, and JOIN statements can also be added to the view.
-- Syntax : create view [View_Name] as select col_1, col_2, .. col_n from [Table_Name] where condition
create view StudentDept 
as 
select stu.Name, stu.Age, stu.Fees, dept.Department from Student stu, Department dept where stu.deptId=dept.deptid

select * from StudentDept

alter view StudentDept
as
select stu.StudentId as 'Id', stu.Name, stu.Age, stu.Fees, dept.Department from Student stu, Department dept where stu.deptId=dept.deptid

Drop view StudentDept

		--  PL/SQL --

/*
What is PL/SQL(Procedural Language) or T/SQL (Transact)?
- PL/SQL is a block structured language.
- PL/SQL stands for "Procedural Language extension of SQL"
- PL/SQL is not case sensitive
- SQL does not support conditional and looping statements like IF-Else and While loop. 
- But we can implement these conditional and looping statements in T/SQL.
- SQL language will not provide reusability facilities where as T/SQL language will provide reusability facilities by defining objects such as Procedures and Functions.
- T/SQL Program blocks can be divided into two types. Those are
	1. Anonymous Blocks
	2. Sub-Program Blocks


Declare variables in T/SQL Programm?
Syntax : Declare @<var> [as] <data type> [size]... 
Ex :- 
*/

Declare @Eid int;
declare @EmployeeName nvarchar(200);
/*
Assigning value to variables 
Syntax : set @var = <value>
Ex:-
*/
Set @Eid=101;
set @EmployeeName='Name of Emplyee'
--Print
select @Eid as 'EID', @EmployeeName as 'EmployeeName'
--OR
print @Eid 
print @EmployeeName

/*Conditional Statements*/
-- 1. IF-ELSE
declare @a int, @b int;
set @a=100;
set @b=100;
if(@a>@b)
print 'a > b';
else if(@a<@b)
print 'a < b';
else
print 'a=b'

-- 2. While 
Declare @i int;
set @i=1;
while @i<=10
begin
print @i;
set @i=@i+1;
end

/*
##Stored Procedures/Procedure: 
- A stored procedure is a database object which contains precompiled queries. 
- Stored Procedures are a block of code designed to perform a task whenever we called.

Syntax: 
	Create Procedures <Procedures Name>
	(Passing parameters)
	As
	Begin
		<Statements>
	End

To Call SP:-
Syntax: Exec <Procedure name>

To Drop SP:-
Drop Procedure <Procedure Name>

## Stored Functions/Functions: 
-- Function is a block of code similar to a stored procedure which is also used to perform an action and returns result as a value. 
-- Function can be divided into two types, these are

1. Scalar-Valued Fuction 
-- In this case we can return a attribute datatype as an output from the function.
Syntax: 
Create Function <Function Name> 
	(@parameter <Data Type> [size])
	Returns <return attribute data type>
As
Begin
	<Function Body>
	Return <return attribute name>
End

Call Syntax : Select dbo.<Function Name> (value)

2. Table-Valued Fuction
-- In this case we can return a table as an output from the function.

Syntax : 
Create Function <Function Name> 
	(@parameter <Data Type> [size])
	Returns <Table>
As
	Return <return select statement>


Drop Function: 
Drop Function <Function Name>
Difference between Function And Procedure:
- A function must return a value where as procedure never returns a value.
- A procedure can have parameters of both input (with parameters) and output (without parameters) where as a function can have only input (with parameters) parameters only.
- In procedure we can perform select, insert, update and delete operation where as function can used only to perform select. Cannot be used to perform insert, update and delete operations.
- A procedure provides the option for to perform transaction management where as these operations are not permitted in a function.
- We call a procedure using execute command where as function are called by using select command only.
*/


/*Triggers*/

/*Magic Table*/

/*CURSOR*/

/*DATA CONTROL LANGUAGE*/

/*Normalization*/
