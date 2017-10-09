SELECT DepositGroup, TotalSum
FROM (SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits 
WHERE MagicWandCreator = 'Ollivander Family' GROUP BY DepositGroup) AS Sums
WHERE TotalSum < 150000
ORDER BY TotalSum DESC
