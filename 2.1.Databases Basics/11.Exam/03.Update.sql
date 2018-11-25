UPDATE Rooms
SET Price += 14/100.00*Price
WHERE HotelId IN (5, 7, 9)