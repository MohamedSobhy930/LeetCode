/* Write your T-SQL query statement below */
select s.user_id , round(isnull(sum(case when c.action='confirmed' then 1 end) * 1.00/count(*),0),2) 
as confirmation_rate 
from Signups s 
left join Confirmations c 
on s.user_id = c.user_id
group by s.user_id 