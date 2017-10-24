CREATE PROC usp_GetHoldersWithBalanceHigherThan (@salary MONEY)
AS
	SELECT h.FirstName, h.LastName
	FROM Accounts  AS a
	FULL JOIN AccountHolders AS h
	ON h.Id = a.AccountHolderId
	GROUP BY h.FirstName, h.LastName
	HAVING SUM(a.Balance) > @salary