WITH Ranking AS (
	SELECT
		a.Id,
		a.Email,
		c.CountryCode,
		COUNT(*) AS TripsCount,
		ROW_NUMBER() OVER (PARTITION BY c.CountryCode ORDER BY COUNT(*) DESC) AS Place
	FROM Accounts AS a
	JOIN AccountsTrips AS att ON att.AccountId = a.Id
	JOIN Trips AS t ON t.Id = att.TripId
	JOIN Rooms AS r ON r.Id = t.RoomId
	JOIN Hotels AS h ON h.Id = r.HotelId
	JOIN Cities AS c ON c.Id = h.CityId
	GROUP BY a.Id, a.Email, c.CountryCode
)

SELECT
	Id, Email, CountryCode, TripsCount
FROM Ranking
WHERE PLACE = 1
ORDER BY TripsCount DESC, Id