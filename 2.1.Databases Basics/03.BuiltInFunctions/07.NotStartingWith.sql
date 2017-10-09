SELECT TownID, Name FROM Towns
WHERE NOT (SUBSTRING(Name, 1, 1) IN ('R', 'D', 'B'))
ORDER BY Name