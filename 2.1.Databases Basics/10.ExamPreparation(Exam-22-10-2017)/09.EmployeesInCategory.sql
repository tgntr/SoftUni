SELECT
	c.Name,
	COUNT(*) AS 'Employees Number'
FROM Categories AS c
JOIN Departments AS d ON d.Id = c.DepartmentId
JOIN Employees AS e ON d.Id = e.DepartmentId
GROUP BY c.Name
ORDER BY c.Name