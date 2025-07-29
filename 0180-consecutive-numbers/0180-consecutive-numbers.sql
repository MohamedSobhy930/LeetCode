/* Write your T-SQL query statement below */
select distinct num ConsecutiveNums
from 
(
    select 
    num,
    lag(num,1) over (order by id) as prev_num ,
    lead(num,1) over (order by id) as next_num 
    from Logs
) t
where 
prev_num = num and num = next_num