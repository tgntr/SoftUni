SELECT 'Rila' as MountainRange, PeakName, Elevation
FROM Peaks
WHERE MountainId = 17
ORDER BY Elevation DESC