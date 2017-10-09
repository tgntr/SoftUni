SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MiniDepositCharge FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup