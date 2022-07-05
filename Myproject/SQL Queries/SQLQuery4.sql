--author id will act as a foreign key in book

create table author
(authorid int primary key,
 authorname varchar(20) not null);

 insert into author values(1,'J.K.Rowling'),(2,'Sarah J Maas'),(3,'Stephen King');

 select * from author;


 create table book
 (bookid int primary key,
  bookname varchar(20) not null,
  aid int,
  constraint fkaid foreign key(aid) references author(authorid)
  on delete set null on update cascade);

  insert into book values(101,'Harry Potter',1);
  insert into book values(102,'Throne Of Glass',2);
  insert into book values(103,'The Shining',3);
  select * from book;

  drop table book;

  delete author where authorid = 2;
  update author set authorid =100 where authorid =1;
  --if you are using foreign key and you have refernce of that column in another table it will not let you either update or delete the value of the foreign key
  --so if you want to delete that value you have to write on delete set null/cascade for deletion and to update the value you can write on update set null/cascade.