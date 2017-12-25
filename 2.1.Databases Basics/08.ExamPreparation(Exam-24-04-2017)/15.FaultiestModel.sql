SELECT 
m.Name,
COUNT(j.JobId),
SUM(p.Price * op.Quantity) AS 'Parts Total'







SELECT TOP 1 WITH TIES
	m.Name,
	COUNT(m.ModelId) AS 'Times Servived', 
	ISNULL(SUM(op.Quantity * p.Price), 0) AS 'Parts Total' 
	FROM Jobs AS j
FULL JOIN Orders AS o ON j.JobId = o.JobId
FULL JOIN OrderParts AS op ON o.OrderId = op.OrderId
FULL JOIN Parts AS p ON op.PartId = p.PartId
JOIN Models AS m ON m.ModelId = j.ModelId
GROUP BY m.ModelId, m.Name
ORDER BY COUNT(m.ModelId) DESC
