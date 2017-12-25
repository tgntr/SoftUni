CREATE FUNCTION udf_GetReportsCount (@employeeId INT, @statusId INT)
RETURNS INT
AS
BEGIN
	DECLARE @count INT = (SELECT COUNT(*) FROM Reports WHERE StatusId = @statusId AND EmployeeId = @employeeId)
	RETURN @count
END
