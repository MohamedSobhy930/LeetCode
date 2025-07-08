/* Write your T-SQL query statement below */
select x,y,z ,
IIF(x + y > z and y + z > x and x + z > y , 'Yes' , 'No') as triangle
from Triangle