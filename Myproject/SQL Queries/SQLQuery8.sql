use practice;
select * from actor;
select * from Movies;

--Joins 
--cross join 
--inner join
--outer join(left join , right join)
--self join.

--CROSS JOIN:

select * from actor cross join Movies;

--INNER JOIN:
select first_name, last_name,moviename from actor inner join Movies on actor.actorid = Movies.actorid;