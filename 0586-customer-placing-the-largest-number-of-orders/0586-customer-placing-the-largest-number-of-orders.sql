/* Write your T-SQL query statement below */
select top 1 customer_number from Orders
Group by customer_number
order by Count(*) desc