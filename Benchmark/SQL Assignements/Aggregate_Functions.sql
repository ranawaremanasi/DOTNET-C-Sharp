-- Aggregate functions
-- sum,min,max,count,avg

select * from employee
select deptno,
			count(eno) as no_of_employees,
			sum (salary ) as Total_salary,
			min(salary) minimun_salary,
			max(salary) as Maximum_salary,
			round(AVG(salary),2) as average_salary from employee
group by deptno

select deptno,
		count(eno) as no_of_employees,
		sum (salary ) as Total_salary,
		min(salary) minimun_salary,
		max(salary) as Maximum_salary,
		round(AVG(salary),2) as average_salary from employee
where salary>2000
group by deptno
having count(eno)>1