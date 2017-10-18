SELECT TOP 5 
e.EmployeeID,
e.FirstName,
p.Name as ProjectName
FROM Employees as e
JOIN (
	SELECT p.Name, 
	ep.EmployeeID
	FROM Projects as p
	JOIN EmployeesProjects as ep
	ON p.ProjectID = ep.ProjectID
	WHERE p.StartDate > '2002-08-13'
	AND p.EndDate IS NULL
) as p
ON e.EmployeeID = p.EmployeeID
ORDER BY e.EmployeeID

