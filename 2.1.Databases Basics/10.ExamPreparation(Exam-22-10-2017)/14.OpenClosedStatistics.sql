SELECT 
	CONCAT(e.FirstName, ' ', e.LastName) AS Name,
	CONCAT(
		SUM(CASE WHEN YEAR(r.CloseDate) = 2016 THEN 1 ELSE 0 END),
		'/', 
		SUM(CASE WHEN YEAR(r.OpenDate) = 2016 THEN 1 ELSE 0 END)
	) AS 'Closed Open Reports'
FROM Employees AS e
JOIN Reports AS r ON r.EmployeeId = e.Id
WHERE 
	YEAR(r.OpenDate) = 2016 OR
	YEAR(r.CloseDate) = 2016
GROUP BY e.FirstName, e.LastName, e.Id
ORDER BY Name, e.id