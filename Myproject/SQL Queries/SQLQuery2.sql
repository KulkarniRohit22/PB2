use PB2;

drop table trainer;

create table trainer
(tid int primary key,
tname varchar(20) not null,
exper int check(exper>=0),
city varchar(20) default 'pune');

select * from trainer;

insert into trainer values(10,'deepa',10,'pune');

update trainer set tid=3,tname='gauri',exper=15,city='mumbai' where tid=10;

insert into trainer values(4,'sameer',20,'solapur');

alter table trainer add email varchar(20);

alter table trainer drop constraint DF__trainer__city__4AB81AF0;

--alter table trainer alter column exper bigint;
