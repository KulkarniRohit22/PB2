use hr2;


select * from employees;

select * from employees order by salary, first_name desc;

--when we write two column names in front of order by then it will first sort by salary,if salary two employees have same salary then it will sort those two employees 
--by their first names in descending order.


--AGGREGATE FUNCTIONS:-
-- max,min,avg,count,sum these are some aggregate functions.

select max(salary) as 'Maximum Salary' from employees;
select min(salary) as 'Minimum Salary' from employees;
select sum(salary) as 'Total Salary' from employees;
select avg(salary) as 'Avarage Salary' from employees;
select count(salary) from employees;

--you cannot add another column name  besides aggregate function in select statement, while using aggregate function.
--e.g- select * from max(salary),first_name from employees, this is not allowed.It will give you an error.

--count will return values of all the not null entities.4



--GROUP By Clause.

select department_id,max(salary) as 'MaxSal' from employees group by department_id order by MaxSal desc;

select department_id,count(*) as 'employee count' from employees group by department_id;

--Having Clause:- is same as where clause ,however we use having clause when we have to apply filter on Groups ,and we use where clause when we have to apply
--filter on Tables

select department_id ,max(salary) as 'maxsal' from employees group by department_id having max(salary)>10000;


--we can only use having clause on aggregate function so you have to write an aggreagate function after having clause.


--subquery:- Query within another query is called as subquery. In subquery first the inner query will be get executed and it will return some value based on that
-- value the outer query will get executed and it will give us the information that we seek.

--list all the employees working  in department IT
select * from employees where department_id=(select department_id from departments where department_name= 'IT');

--list all the employees working  as a programmer.

select * from employees where job_id=(select job_id from jobs where job_title='Programmer');