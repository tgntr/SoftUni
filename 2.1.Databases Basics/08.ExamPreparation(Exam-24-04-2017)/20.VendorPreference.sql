WITH a AS (
	SELECT m.FirstName + ' ' + m.LastName AS Mechanic,
	v.Name AS Vendor,
	SUM(op.Quantity) AS Parts
	FROM OrderParts AS op
	JOIN Orders AS o ON op.OrderId = o.OrderId
	JOIN Jobs AS j ON o.JobId = j.JobId
	JOIN Mechanics AS m ON j.MechanicId = m.MechanicID
	JOIN Parts AS p ON op.PartId = p.PartId
	JOIN Vendors AS v ON p.VendorId = v.VendorId
	GROUP BY m.MechanicID, v.VendorId, v.Name, m.FirstName, m.LastName
)
SELECT *, 
CAST((a.Parts * 100 / (
		SELECT SUM(aa.Parts) 
		FROM a AS aa 
		WHERE aa.Mechanic = a.Mechanic)) 
	AS VARCHAR(4)) + '%'  AS Preference
FROM a
ORDER BY Mechanic, Parts DESC, Vendor


