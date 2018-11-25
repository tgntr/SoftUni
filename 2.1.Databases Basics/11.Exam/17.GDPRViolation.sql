WITH Durations AS(
	SELECT
		t.Id,
		a.Id AS AccountId,
		c.Name AS Town,
		(CASE
			WHEN t.CancelDate IS NOT NULL THEN 'Canceled'
			ELSE
			CONCAT(
				CAST(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate) AS VARCHAR(10)),
				' days')
		END) AS Duration
	FROM Trips AS t
	JOIN Rooms AS r ON r.Id = t.RoomId
	JOIN Hotels AS h ON h.Id = r.HotelId
	JOIN Cities AS c ON c.Id = h.CityId
	JOIN AccountsTrips AS att ON att.TripId = t.Id
	JOIN Accounts AS a ON a.Id = att.AccountId
)

SELECT 
	d.Id,
	(CASE
		WHEN a.MiddleName IS NULL THEN CONCAT(a.FirstName, ' ', a.LastName)
		ELSE CONCAT(a.FirstName, ' ', a.MiddleName, ' ', a.LastName)
	END) AS FullName,
	c.Name AS 'From',
	d.Town AS 'To',
	Duration
FROM Durations AS d
JOIN Accounts AS a ON a.Id = d.AccountId
JOIN Cities AS c ON c.Id = a.CityId
ORDER BY FullName, d.Id