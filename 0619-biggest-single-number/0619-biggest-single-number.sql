/* Write your T-SQL query statement below */
select isnull((
select top 1 num from MyNumbers
Group by num 
having Count(num) = 1
order by num desc)
,null)
as num