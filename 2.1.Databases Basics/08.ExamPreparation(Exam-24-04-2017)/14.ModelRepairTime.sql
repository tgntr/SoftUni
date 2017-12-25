SELECT 
	m.ModelId, 
	m.Name, 
	CONVERT(VARCHAR(MAX),
		AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)
		)) + ' days' AS 'Average Service Time'
FROM Models AS m
JOIN Jobs AS j ON j.ModelId = m.ModelId
WHERE j.FinishDate IS NOT NULL
GROUP BY m.ModelId, m.Name
ORDER BY AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))