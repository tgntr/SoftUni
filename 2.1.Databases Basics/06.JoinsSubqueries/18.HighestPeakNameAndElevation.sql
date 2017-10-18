SELECT TOP 5
c.CountryName,
ISNULL (p.PeakName, '(no highest peak)') AS 'Highest Peak Name',
ISNULL(p.Elevation, 0) AS 'Highest Peak Elevation',
ISNULL(p.MountainRange, '(no mountain)') AS 'Mountain'
FROM Countries as c
LEFT OUTER JOIN (
	SELECT p.Id,
	p.PeakName,
	p.Elevation,
	p.MountainId,
	m.MountainRange,
	mc.CountryCode,
	RANK() OVER (PARTITION BY mc.CountryCode ORDER BY p.Elevation DESC) AS Rank
	
	FROM Peaks as p
	FULL JOIN MountainsCountries AS mc
	ON mc.MountainId = p.MountainId
	FULL JOIN Mountains AS m
	ON m.Id = p.MountainId
) AS p
ON (c.CountryCode = p.CountryCode
AND p.Rank = 1)

ORDER BY c.CountryName,
'Highest Peak Name'
