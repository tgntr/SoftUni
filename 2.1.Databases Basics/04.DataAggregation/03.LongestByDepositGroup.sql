SELECT DepositGroup, MAX(MagicWandSize) AS LongesMagicWand FROM WizzardDeposits
GROUP BY DepositGroup