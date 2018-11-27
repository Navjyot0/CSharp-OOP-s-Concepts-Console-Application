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
--4. Alternate key(primary key on multiple column)
--5. Composite Key (Imp)

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

-- Aggrigate function 
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

--PL/SQL

if 1=2
	select 'Name'
else
	select 'Id' 
