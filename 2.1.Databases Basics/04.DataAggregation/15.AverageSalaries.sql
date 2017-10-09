SELECT * INTO Sorted FROM Employees 
WHERE Salary > 30000

DELETE FROM Sorted 
WHERE ManagerId = 42

UPDATE Sorted
SET Salary += 5000
WHERE DepartmentID = 1
SELECT DepartmentID, AVG(Salary) AS AverageSalary FROM Sorted
GROUP BY DepartmentID