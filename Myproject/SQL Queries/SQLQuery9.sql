--LEFT JOIN.
use PB2

select sname,batchname from student s left join batch b on s.bid = b.batchid;

select sname,batchname from batch b left join student s on b.batchid = s.bid;

--IN LEFT OUTER JOIN ALL THE MATCHED AS WELL AS ALL THE UNMATCHED RECORDS FROM THE LEFT HAND SIDE TABLE WILL BE SHOWED.AND YOU CAN CHANGE THE ORDER OF THE TABLE SINCE LEFT OUTER JOIN
--IS ASYMMETRIC.

--RIGHT JOIN.

select sname,batchname from student s right join batch b on s.bid = b.batchid;

select sname,batchname from batch b right join student s on b.batchid = s.bid;

--RIGHT JOIN IS SAME AS LEFT JOIN ,AFTER USING THE RIGHT JOIN WHAT WILL HAPPEN IS THAT THE MATCHED AND UNMATCHED RECORDS FROM RIGHT HAND SIDE TABLE WILL BE SHOWED. AND
--RIGHT JOIN IS ALSO ASYMMETRIC SO YOU CAN CHANGE THE ORDER OF THE TABLE.


--FULL OUTER JOIN.

select * from student s full join batch b on s.bid=b.batchid;
select * from batch b full join student s on  s.bid=b.batchid;

--IN FULL OUTER JOIN IT WILL SHOW BOTH MATCHED AND UNMATCHED RECORDS FROM BOTH LEFT AND RIGHT HAND SIDE TABLES. IT IS ALSO SYMMETRIC SO YOU CAN CHANGE THE ORDER OF THE 
--TABLE.