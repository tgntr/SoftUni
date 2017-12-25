SELECT 
	j.JobId, 
	ISNULL(SUM(op.Quantity * p.Price), 0) AS Total 
	FROM Jobs AS j
FULL JOIN Orders AS o ON j.JobId = o.JobId
FULL JOIN OrderParts AS op ON o.OrderId = op.OrderId
FULL JOIN Parts AS p ON op.PartId = p.PartId
GROUP BY j.JobId, j.Status
HAVING j.JobId IS NOT NULL AND j.Status = 'Finished'
ORDER BY Total DESC, j.JobId




SELECT 
	j.JobId, 
	(
		SELECT ISNULL(SUM(op.Quantity * p.Price),0) AS 'Parts Total'
		FROM OrderParts AS op
		JOIN Orders AS o ON o.OrderId = op.OrderId
		JOIN Parts AS p ON p.PartId = op.PartId
		WHERE o.JobId = j.JobId
	) AS Total
FROM Jobs AS j
WHERE Status = 'Finished'
ORDER BY Total DESC, j.JobId