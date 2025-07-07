/* Write your T-SQL query statement below */
select class from Courses 
Group by class 
having count(class) >= 5