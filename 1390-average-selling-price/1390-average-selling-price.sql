/* Write your T-SQL query statement below */
select p.product_id ,round(sum(isnull(units,0)*price)*1.0/isnull(sum(units),1) , 2) as average_price 
from Prices p left join UnitsSold u 
on p.product_id = u.product_id 
and purchase_date between  start_date and  end_date
group by p.product_id 