drop table student;

create table batch
( batchid int primary key,
  batchname varchar(20) not null
);


create table student
(rollno int primary key,
 sname varchar(20) not null,
 city varchar(10),
 marks int,
 bid int,
 constraint fkbid foreign key(bid) references batch(batchid));

 insert into batch  values(1,'PB2'),(2,'cisco'),(3,'Amazon');

 select * from batch;

-- insert into student(rollno,sname,bid) values(3,'Dheeraj',10);  since we have used the foreign key this will give you an error since in the batch table we not have batchid as 10.
 select * from student;