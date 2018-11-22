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

--PL/SQL

if 1=2
	select 'Name'
else
	select 'Id' 
