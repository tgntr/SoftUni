SELECT TOP 10
	c.Id,
	c.Name,
	SUM(h.BaseRate + r.Price) AS TotalRevenue,
	COUNT(t.Id) AS Trips
FROM Trips AS t
JOIN Rooms AS r ON r.Id = t.RoomId
JOIN Hotels AS h ON h.Id = r.HotelId
JOIN Cities AS c ON c.Id = h.CityId
WHERE YEAR(t.BookDate) = 2016
GROUP BY c.Id, c.Name
ORDER BY TotalRevenue DESC, Trips DESC