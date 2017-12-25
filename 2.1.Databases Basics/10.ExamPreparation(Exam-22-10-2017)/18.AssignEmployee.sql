CREATE PROC usp_AssignEmployeeToReport 
(@employeeId INT, @reportId INT)
AS
BEGIN
	DECLARE @ReportDepartment INT = (SELECT c.DepartmentId FROM Reports AS r JOIN Categories AS c ON c.Id = r.CategoryId WHERE r.Id = @reportId)
	DECLARE @EmployeeDepartment INT = (SELECT DepartmentId FROM Employees WHERE Id = @employeeId)
	IF (@ReportDepartment <> @EmployeeDepartment)
	BEGIN
		RAISERROR('Employee doesn''t belong to the appropriate department!', 16,1)
		RETURN
	END
	UPDATE Reports
	SET EmployeeId = @employeeId
	WHERE Id = @reportId
END

