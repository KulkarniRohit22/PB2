use PB2;

create table Student_Attendance
(sid int,
attend_date date,
present char(1),
primary key(sid,attend_date),
constraint fksid foreign key(sid) references student(rollno));

insert into Student_Attendance values(5,'2022-6-29','p');

select * from Student_Attendance;

delete from Student_Attendance;
--we use composite pk coz first column cannot gives us a unique values and neither can second,only together can they give us a unique value.  