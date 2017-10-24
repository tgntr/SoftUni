CREATE FUNCTION dbo.ufn_CashInUsersGames (@gameName VARCHAR(MAX))
RETURNS @oddRowsTable TABLE (SumCash MONEY)
AS
BEGIN
	INSERT INTO @oddRowsTable
		SELECT SUM(ugg.Cash) AS Sum
		FROM (
			SELECT ug.Cash,
			ROW_NUMBER() OVER (ORDER BY ug.Cash DESC) AS RowNumber,
			g.Name
			FROM UsersGames as ug
			INNER JOIN Games as g
			ON g.Id = ug.GameId
			WHERE g.Name = @gameName
		) AS ugg
		WHERE ugg.RowNumber % 2 = 1
	RETURN
END