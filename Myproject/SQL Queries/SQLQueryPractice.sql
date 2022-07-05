--create ,insert,update,alter,delete,drop,select.

create database Practice;

use Practice;

create table Movies
(movieid int primary key,
moviename varchar(20) not null,
budget int check(budget>500000),
imdb float,
actorid int,
constraint fkaid foreign key(actorid) references actor(actorid)
on delete set null on update cascade);

select * from Movies;

insert into Movies values(101,'The Dark Knight',1000000,8.7,1);
insert into Movies values(102,'Inception',3000000,8.9,2);
insert into Movies values(103,'Interstellar',5000000,9.1,3);
insert into Movies values(104,'The Green Book',900000,8.3,4);
insert into Movies values(105,'Harry Potter 7',7000000,7.7,5);


update Movies set imdb =8.1 where movieid = 105;

create table actor
(actorid int primary key,
first_name varchar(20) not null,
last_name varchar(20) not null,
annual_income int ,
);


insert into actor values(1,'Christian','Bale',12000000);
insert into actor values(2,'Lionardo-de','Chaprio',24000000);
insert into actor values(3,'Matthew','McConaughey',8000000);
insert into actor values(5,'Daniel','Radcliffe',13000000);
insert into actor values(4,'Viggo','Mortensen',15000000);

select * from actor;

drop table Movies;

alter table actor add gender char(1);

update actor set gender ='M' where actorid=5;

delete from actor where actorid=4;

update actor set actorid=4 where actorid =5;

insert into actor values(5,'Viggo','Mortensen',15000000,'M');

update actor set first_name='Danial',last_name='Radcliffe' where actorid =5;

alter table actor drop column gender;

--alter table actor alter gender datatype not null;


select* from actor where annual_income between 10000000 and 20000000;

select * from actor where first_name is not null;

select * from Movies where moviename is null;

select * from Movies where moviename like '%ar%';
select * from actor where first_name like 'D_____';

--USE OF AGREEGATE FUNCTIONS(sum, count,avg,min,max)

select max(budget) as 'Maximum budget' from Movies ;
select min(budget) as 'Minimum budget' from Movies;
select avg(budget) as 'Average budget' from Movies;
select count(*) from Movies;
select sum(budget) as 'Total budget' from Movies;
