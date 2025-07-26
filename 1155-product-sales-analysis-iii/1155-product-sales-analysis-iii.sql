/* Write your T-SQL query statement below */
select s.product_id , s.year as first_year , s.quantity , s.price 
from Sales s
where s.year in (select min(s1.year) from Sales s1 where s.product_id = s1.product_id)