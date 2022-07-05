use hr2;


--DELETE EMP FROM SALES DEPARTMENT.
delete e1 from employees e1 inner join departments d on	e1.department_id = d.department_id where department_name = 'Sales'; 

--INCREASE SALARY  OF IT PEOPLE BY 10000

update employees set  salary = salary +10000 from employees e inner join departments d on e.department_id = d.department_id where department_name = 'IT';