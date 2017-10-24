CREATE FUNCTION dbo.ufn_CalculateFutureValue (@sum DECIMAL(15,4), @yearlyRate FLOAT, @years INT) 
RETURNS DECIMAL(15, 4)
AS
BEGIN
	DECLARE @futureValue DECIMAL(15, 4)= @sum * POWER((1+@yearlyRate), @years);
	RETURN @futureValue;
END