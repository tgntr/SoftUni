CREATE PROC dbo.usp_GetEmployeesSalaryAboveNumber (@Salary DECIMAL(18,4))
AS
	SELECT e.FirstName, 
	e.LastName
	FROM Employees AS e
	WHERE Salary >= @Salary