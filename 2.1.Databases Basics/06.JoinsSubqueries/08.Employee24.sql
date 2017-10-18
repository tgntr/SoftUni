SELECT 
ep.EmployeeID,
ep.FirstName,
(
	CASE
	WHEN DATEPART(year, p.StartDate) > 2004 THEN NULL
	ELSE p.Name
	END
) AS ProjectName
FROM (
	SELECT 
	ep.EmployeeID,
	e.FirstName,
	ep.ProjectID
	FROM EmployeesProjects as ep
	INNER JOIN Employees as e
	ON ep.EmployeeID = e.EmployeeID
	WHERE e.EmployeeID = 24
) as ep
INNER JOIN Projects as p
ON ep.ProjectID = p.ProjectID
