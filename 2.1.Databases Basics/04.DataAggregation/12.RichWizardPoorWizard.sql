SELECT SUM(Diff) as Difference FROM ( 
	SELECT DepositAmount - LEAD(DepositAmount) OVER (ORDER BY Id) AS Diff 
	FROM WizzardDeposits) AS Differences