CREATE TRIGGER t_CloseReports
ON Reports
AFTER UPDATE
AS
BEGIN
	UPDATE Reports
	SET StatusId = 3
	WHERE Id IN (
		SELECT r.Id FROM Reports AS r
		JOIN inserted AS i ON r.Id = i.Id
		JOIN deleted AS d ON r.Id = d.Id
		WHERE d.CloseDate IS NULL AND i.CLoseDate IS NOT NULL
	)
END
