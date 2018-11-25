CREATE PROC usp_SwitchRoom @TripId INT, @TargetRoomId INT
AS
BEGIN
	DECLARE @currentHotelId INT = (
									SELECT h.Id
									FROM Trips AS t
									JOIN Rooms AS r ON r.Id = t.RoomId
									JOIN Hotels AS h ON h.Id = r.HotelId
									WHERE t.Id = @TripId
								 )

	DECLARE @targetHotelId INT = (
									SELECT h.Id
									FROM Rooms AS r
									JOIN Hotels AS h ON h.Id = r.HotelId
									WHERE r.Id = @TargetRoomId
								)

	IF (@currentHotelId <> @targetHotelId)
	BEGIN
		RAISERROR('Target room is in another hotel!', 16, 1)
		RETURN
	END

	DECLARE @targetRoomBeds INT  = (
								SELECT Beds
								FROM Rooms
								WHERE Id = @TargetRoomId
							)
	DECLARE @accounts INT = (SELECT COUNT(*) FROM AccountsTrips WHERE TripId = @TripId)
	IF (@targetRoomBeds < @accounts)
	BEGIN
		RAISERROR('Not enough beds in target room!', 16, 1)
		RETURN
	END

	UPDATE Trips
	SET RoomId = @TargetRoomId
	WHERE Id = @TripId
END

