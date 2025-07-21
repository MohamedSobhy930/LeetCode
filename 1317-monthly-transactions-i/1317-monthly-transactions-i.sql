/* Write your T-SQL query statement below */
select 
CONCAT(YEAR(trans_date), '-', RIGHT('0' + CAST(MONTH(trans_date) AS VARCHAR(2)), 2)) as month,
country,
count(1) as trans_count,
sum(iif(state = 'approved' , 1, 0)) as approved_count,
sum(isnull(amount,0)) as trans_total_amount,
sum(iif(state = 'approved' , isnull(amount,0),0)) as approved_total_amount
from Transactions
group by YEAR(trans_date), MONTH(trans_date), country