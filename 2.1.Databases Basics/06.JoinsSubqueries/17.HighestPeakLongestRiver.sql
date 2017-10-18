SELECT TOP 5
c.CountryName,
(
	SELECT TOP 1
	p.Elevation
	FROM Peaks AS p
	INNER JOIN MountainsCountries AS mc
	ON mc.MountainId = p.MountainId
	WHERE mc.CountryCode = (SELECT TOP 1 CountryCode FROM Countries WHERE CountryName = c.CountryName)
	ORDER BY p.Elevation DESC
) AS HighestPeakElevation,
(
	SELECT TOP 1 
	r.Length
	FROM Rivers as r
	INNER JOIN CountriesRivers AS cr
	ON cr.RiverId = r.id
	WHERE cr.CountryCode = (SELECT TOP 1 CountryCode FROM Countries WHERE CountryName = c.CountryName)
	ORDER BY r.Length DESC
) AS LongestRiverLength
FROM Countries as c
ORDER BY 
HighestPeakElevation DESC, 
LongestRiverLength DESC,
c.CountryName