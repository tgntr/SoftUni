WITH a AS (
	SELECT 
		d.Name AS Department,
		c.Name AS Category,
		COUNT(*) AS ReportsCount
		 FROM Departments AS d
	JOIN Categories AS c ON c.DepartmentId = d.Id
	JOIN Reports AS r ON r.CategoryId = c.Id
	GROUP BY d.Name, c.Name
)

SELECT 
	a.Department AS 'Department Name',
	a.Category AS 'Category Name',
	CAST(ROUND((a.ReportsCount * 100.00 / (SELECT SUM(ReportsCount) FROM a AS aa WHERE a.Department = aa.Department)), 0) AS INT) AS Percentage
	FROM a
	ORDER BY a.Department, a.Category, Percentage