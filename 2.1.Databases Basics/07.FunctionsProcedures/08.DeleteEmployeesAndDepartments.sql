CREATE PROC	usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS 
	ALTER TABLE Departments
	ALTER COLUMN ManagerID INT NULL

	ALTER TABLE Employees
	ALTER COLUMN DepartmentID INT NULL

	ALTER TABLE Employees
	ALTER COLUMN ManagerID INT NULL

	UPDATE Employees
	SET DepartmentID = NULL
	WHERE DepartmentID = @departmentId


	DELETE FROM Employees
	WHERE DepartmentID = NULL
	
	DELETE FROM Departments
	WHERE DepartmentId = NULL
	
	SELECT COUNT(*) 
	FROM Employees
	WHERE DepartmentID = @departmentId