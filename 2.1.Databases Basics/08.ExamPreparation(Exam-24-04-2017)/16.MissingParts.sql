SELECT 
	p.PartId,
	p.Description,
	SUM(pn.Quantity) AS [Required],
	AVG(p.StockQty) AS [In Stock],
	ISNULL(SUM(op.Quantity), 0) AS Ordered
FROM PartsNeeded AS pn
JOIN Jobs AS j ON pn.JobId = j.JobId
JOIN Parts AS p ON pn.PartId = p.PartId
LEFT JOIN Orders AS o ON o.JobId = j.JobId
LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
WHERE j.Status <> 'Finished'
GROUP BY p.PartId,p.Description
HAVING AVG(p.StockQty) + ISNULL(SUM(op.Quantity), 0) < SUM(pn.Quantity)


