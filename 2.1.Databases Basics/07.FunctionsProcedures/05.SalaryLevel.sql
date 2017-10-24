CREATE FUNCTION ufn_GetSalaryLevel (@Salary DECIMAL(18, 4))
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @Level VARCHAR(50);
  IF(@Salary>50000)
  BEGIN
    SET @Level = 'High'
  END
  ELSE IF (@Salary>=30000)
  BEGIN
	SET @Level = 'Average'
  END
  ELSE
  BEGIN
	SET @Level = 'Low'
  END
  RETURN @Level;
END

