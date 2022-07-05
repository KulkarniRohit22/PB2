create database PB2;

use PB2;

create table student
(
sid int primary key,
sname varchar(20) not null,
marks int check(marks>0),
city varchar(20) default 'pune');

select * from student;

insert into student values(2,'Siddhant',99,'Nashik');
insert into student(sid ,sname ,marks) values(3,'Vaibhav',91); 
insert into student(sid,sname) values(4,'Dheeraj');