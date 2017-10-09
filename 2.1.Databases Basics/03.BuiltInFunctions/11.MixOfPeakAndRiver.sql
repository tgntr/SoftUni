SELECT Peaks.PeakName, Rivers.RiverName, 
LOWER(Peaks.PeakName) + LOWER(SUBSTRING(Rivers.RiverName, 2, DATALENGTH(Rivers.RiverName) - 1))
AS 'Mix' FROM Peaks, Rivers
WHERE RIGHT(Peaks.PeakName, 1) = LEFT(Rivers.RiverName, 1)
ORDER BY 'Mix'