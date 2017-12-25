SELECT 
	c.Name, 
	COUNT(*) AS ReportsNumber,
	(CASE
		WHEN SUM(CASE WHEN s.Label = 'in progress' THEN 1 ELSE 0 END)
			> (SUM(CASE WHEN s.Label = 'waiting' THEN 1 ELSE 0 END))
		THEN 'in progress'
		WHEN SUM(CASE WHEN s.Label = 'in progress' THEN 1 ELSE 0 END)
			< (SUM(CASE WHEN s.Label = 'waiting' THEN 1 ELSE 0 END))
		THEN 'waiting'
		ELSE 'equal'
	END) AS MainStatus
FROM Categories AS c
JOIN Reports AS r ON c.Id = r.CategoryId
JOIN Status AS s ON s.Id = r.StatusId
WHERE s.Label IN ('waiting', 'in progress')
GROUP BY c.Name