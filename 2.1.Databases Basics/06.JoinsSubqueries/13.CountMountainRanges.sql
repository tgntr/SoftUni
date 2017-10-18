SELECT
c.CountryCode,
COUNT(m.MountainRange) AS MountainRanges
FROM Mountains as m
INNER JOIN MountainsCountries as c
ON c.MountainId = m.Id
WHERE c.CountryCode IN ('US', 'RU', 'BG')
GROUP BY c.CountryCode

