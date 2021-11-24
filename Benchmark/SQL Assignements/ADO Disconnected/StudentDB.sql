Create table Course
(cid int primary key,
cname varchar(40) not null,
instructor varchar(40))

alter table Course
add fees decimal(8,0)

--To add Constraint through Alter table
alter table Course 
add constraint chk_fees check(fees>0)


create table Student
(sid int primary key, 
sname varchar(40) not null, 
address varchar(40),
cid int foreign key references Course(cid))

insert into Course values(1,'C#','Nikita',10000)
insert into Course values(11,'Csharp','Nikita Bhoir',100000)
insert into Course values(12,'Java','Nikita Bhoir',100000)
insert into Course values(2,'Java','Meenal',7000)
insert into Course values(3,'Angular','Devyani',9000)
insert into Course values(4,'SQL','Nikita',5000)
insert into Course values(5,'Android','Sagar',6000)

insert into Student values(1,'Manali','Pune',1)
insert into Student values(2,'Mrunal','Pune',2)
insert into Student values (111,'ABC','Thane',11)
insert into Student values(333,'PQR','Pune',12)
insert into Student values(222,'PQR','Pune',12)
insert into Student values(3,'Sam','Surat',3)
insert into Student values(4,'Rudra','Tripura',4)
insert into Student values(5,'Anne','Goa',5)

select * from Course
select * from Student

delete from Course where cid=11
--cannot delete as 11 record is present in another table

--primary key- ensures uniqueness of data accpets only unique and not null values

--foreign key - when primary key of one table is referenced into another table it is called as foreign key

-- unique - accepts only values null allowed
-- check - checks datafor any valid condition
--not null -will not null values to be entered but duplicates allowed

