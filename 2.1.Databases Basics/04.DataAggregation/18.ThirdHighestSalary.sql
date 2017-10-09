SELECT DepartmentID, Salary FROM (
	SELECT DepartmentID, Salary, 
	ROW_NUMBER() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) 
	AS Position FROM Employees GROUP BY DepartmentID, Salary) AS Ranking
WHERE Position = 3