CREATE PROC usp_CalculateFutureValueForAccount (@account INT, @interestRate FLOAT)
AS 
	SELECT a.Id AS 'Account Id', 
	h.FirstName AS 'First Name',
	h.LastName AS 'Last Name',
	a.Balance AS 'Current Balance',
	(dbo.ufn_CalculateFutureValue (a.Balance, @interestRate, 5)) AS 'Balance in 5 years'
	FROM Accounts  AS a
	FULL JOIN AccountHolders AS h
	ON h.Id = a.AccountHolderId
	WHERE a.Id = @account