SELECT e.EmployeeID, 
e.FirstName,
e.ManagerID,
ep.FirstName
FROM Employees as e
JOIN Employees as ep
ON e.ManagerID = ep.EmployeeID
WHERE e.ManagerID IN (3, 7)