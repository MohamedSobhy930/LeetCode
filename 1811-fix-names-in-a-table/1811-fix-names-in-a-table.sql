/* Write your T-SQL query statement below */
select user_id , CONCAT(UPPER(SUBSTRING(name, 1, 1)), LOWER(SUBSTRING(name, 2, Len(name)))) as name from Users
order by user_id asc