/* Write your T-SQL query statement below */
update Salary 
set sex = IIF(sex = 'm' , 'f', 'm')