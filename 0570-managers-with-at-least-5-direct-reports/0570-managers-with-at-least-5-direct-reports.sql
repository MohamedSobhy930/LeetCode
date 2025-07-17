/* Write your T-SQL query statement below */
select e1.name from 
Employee e1 inner join Employee e2 
on e1.id = e2.managerId 
group by e2.managerId , e1.name
having count(1) >= 5