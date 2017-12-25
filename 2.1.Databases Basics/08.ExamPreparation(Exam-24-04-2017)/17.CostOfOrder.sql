CREATE FUNCTION udf_GetCost (@JobId AS INT)
RETURNS DECIMAL(14, 2)
AS
BEGIN
	DECLARE @TotalPrice DECIMAL(14,2) = (
		SELECT 
		ISNULL(SUM(op.Quantity * p.Price), 0)
		FROM Jobs AS j
		FULL JOIN Orders AS o ON j.JobId = o.JobId
		FULL JOIN OrderParts AS op ON o.OrderId = op.OrderId
		FULL JOIN Parts AS p ON op.PartId = p.PartId
		WHERE j.JobId = @JobId
	)
	RETURN @TotalPrice
END
