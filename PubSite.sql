Drop Database Pubsite
Create Database Pubsite
use Pubsite


create table Contact
(
	ContactID int primary key identity(1, 1),
	Email nvarchar(1000),
	Phone nvarchar(20),
)

create table Address
(
	AddressID int primary key identity(1, 1),
	DetailAddress nvarchar(1000),
	City nvarchar(1000),
	State nvarchar(1000),
	Country nvarchar(1000),
	ZipCode nvarchar(10),
	Contact int unique foreign key references Contact(ContactID)
)


create table Hospital
(
	HospitalID int primary key identity(1, 1),
	HospitalName nvarchar(1000),
	Description nvarchar(max),
	WebsiteURL nvarchar(1000),
	LogoImage nvarchar(1000),
	AddressID int unique foreign key references Address(AddressID)
)

create table ContentDetails
(
	ContentID int primary key identity(1, 1),
	Title nvarchar(1000),
	Description nvarchar(max),
	Keywords nvarchar(max),
	Author nvarchar(1000),
	PublishDate DateTime,
	Image nvarchar(1000),
	URL nvarchar(1000),
	CreatedDate DateTime,
	UpdatedDate DateTime
)

create table News 
(
	NewsID int primary key identity(1,2),
	NewsDate DateTime,
	ContentID int unique foreign key references ContentDetails(ContentID)
)

create table Resources 
(
	ResourcesID int primary key identity(1,2),
	ResourceFile nvarchar(1000),
	ContentID int unique foreign key references ContentDetails(ContentID)
)

create table Event 
(
	EventID int primary key identity(1,2),
	AddressID int unique foreign key references Address(AddressID),
	StartDate DateTime,
	EndDate DateTime,
	ContentID int unique foreign key references ContentDetails(ContentID)
)


