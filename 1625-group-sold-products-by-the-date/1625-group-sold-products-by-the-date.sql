/* Write your T-SQL query statement below */
select sell_date ,  count( distinct product) as num_sold,
STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product ASC) AS products
from (select distinct sell_date , product from Activities) as sub
group by sell_date 
order by sell_date