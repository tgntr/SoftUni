SELECT TOP 5
c.CountryName,
r.RiverName
FROM (
	SELECT 
	c.CountryName,
	c.ContinentCode,
	cr.RiverId
	FROM Countries AS c
	LEFT OUTER JOIN CountriesRivers AS cr
	ON cr.CountryCode = c.CountryCode
) AS c
LEFT OUTER JOIN Rivers AS r
ON r.Id = c.RiverId
WHERE c.ContinentCode = (
	SELECT c.ContinentCode 
	FROM Continents AS c
	WHERE c.ContinentName = 'Africa'
)
ORDER BY c.CountryName
