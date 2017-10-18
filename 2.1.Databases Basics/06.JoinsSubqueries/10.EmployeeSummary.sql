SELECT TOP 50
e.EmployeeID,
e.FirstName + ' ' + e.LastName,
(
	SELECT ep.FirstName + ' ' + ep.LastName
	FROM Employees as ep
	WHERE ep.EmployeeID = e.ManagerID
) AS ManagerName,
d.Name
FROM Employees as e
INNER JOIN Departments as d
ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID

