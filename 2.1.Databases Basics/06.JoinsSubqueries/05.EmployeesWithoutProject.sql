SELECT TOP 3 e.EmployeeID, 
e.FirstName
FROM (
	SELECT e.EmployeeID, 
	e.FirstName,
	p.ProjectID
	FROM Employees as e
	LEFT OUTER JOIN EmployeesProjects as p
	ON p.EmployeeID = e.EmployeeID
	WHERE p.ProjectID IS NULL
) as e

