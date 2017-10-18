SELECT TOP 1
AVG(e.Salary) as MinAverageSalary
FROM Employees as e
GROUP BY DepartmentID 
ORDER BY AVG(e.Salary)