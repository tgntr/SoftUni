CREATE PROC dbo.usp_GetTownsStartingWith (@start VARCHAR(50))
AS
	SELECT t.Name
	FROM Towns AS t
	WHERE t.Name LIKE @start + '%'