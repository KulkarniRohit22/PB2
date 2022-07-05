create table emp
(eid int primary key,
ename varchar(20) not null,
salary int,
managerid int);

alter table emp 
add constraint fkmgrid foreign key(managerid) references emp(eid);

select * from emp; 

--SELF JOIN 
--IN SELF JOIN WE ARE TRYING TO JOIN A TABLE WITH ITSELF. IN ORDER TO DIFFERENCTIATE THE SAME TABLE WE UES ALIAS.

select e.ename,m.ename from emp e inner join emp m on e.managerid = m.eid;

