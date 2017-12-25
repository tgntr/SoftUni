SELECT 
	c.Name AS CategoryName, 
	COUNT(*) AS ReportsNumber
FROM Categories AS c
JOIN Reports AS r ON r.CategoryId = c.Id
GROUP BY c.Name
ORDER BY ReportsNumber DESC, Name