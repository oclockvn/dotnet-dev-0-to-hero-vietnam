create database ProductMangement
go
use ProductMangement
go
create table Products (
Id int identity (1,1) primary key,
[Name] nvarchar (255) not null,
Price decimal not null default(0),
Quantity int not null default(0),
)


