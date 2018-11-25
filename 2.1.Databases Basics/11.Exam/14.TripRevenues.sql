SELECT 
	t.Id,
	h.Name AS HotelName,
	r.Type AS RoomType,
	(CASE
		WHEN t.CancelDate IS NOT NULL THEN 0
		ELSE r.Price + h.BaseRate
	END) AS Revenue
FROM Trips AS t
JOIN Rooms AS r ON r.Id = t.RoomId
JOIN Hotels AS h ON h.Id = r.HotelId 
ORDER BY r.Type, t.Id
