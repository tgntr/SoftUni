SELECT ISNULL(SUM(op.Quantity * p.Price),0) AS 'Parts Total'
FROM OrderParts AS op
JOIN Orders AS o ON o.OrderId = op.OrderId
JOIN Parts AS p ON p.PartId = op.PartId
WHERE DATEDIFF(WEEK, o.IssueDate, '2017-04-24') <= 3