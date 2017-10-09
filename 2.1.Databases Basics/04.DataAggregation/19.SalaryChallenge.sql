SELECT TOP (10) Salaries.FirstName as FirstName, Salaries.LastName as LastName, DepartmentID FROM (
	SELECT FirstName, LastName, DepartmentID, Salary, AVG(Salary) as Average 
	FROM Employees GROUP BY DepartmentID) AS Salaries
	
SELECT TOP 10 FirstName, LastName, DepartmentID FROM Employees AS emp1
WHERE Salary > (SELECT AVG(Salary) FROM Employees AS emp2 
WHERE emp1.DepartmentID = emp2.DepartmentID 
GROUP BY DepartmentID)
ORDER BY DepartmentID