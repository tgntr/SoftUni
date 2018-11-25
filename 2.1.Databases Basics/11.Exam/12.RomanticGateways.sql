SELECT
	a.Id,
	a.Email,
	c.Name,
	COUNT(t.Id) AS Trips
FROM Accounts AS a
JOIN AccountsTrips AS att ON att.AccountId = a.Id
JOIN Trips AS t ON t.Id = att.TripId
JOIN Rooms AS r ON r.Id = t.RoomId
JOIN Hotels AS h ON h.Id = r.HotelId
JOIN Cities AS c ON c.Id = h.CityId
WHERE a.CityId = h.CityId
GROUP BY a.Id, a.Email, c.Name
ORDER BY Trips DESC, a.Id