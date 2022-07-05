select * from departments;

select * from employees where salary>=15000;

select * from departments where department_id=3 or department_id=6 or department_id=9;

--another way to do it is

select * from departments where department_id in(3,6,9);

select * from departments where department_id not in(3,6,9);

--emo==> salary>10000 and works in 6th department

select * from employees where salary<10000 and department_id =6;

--Between keyword

select * from employees where salary>=10000 and salary <=20000; 

--another way to do it is

select * from employees where salary between 10000 and 20000; 


--ToFind out the null value in database

select * from employees where phone_number is null;

select * from employees where phone_number is not null;

--Wild card (like) -used for string.

select * from employees where first_name like 'j%';

select * from employees where first_name like 'j___';

select * from employees where first_name like '__a__';