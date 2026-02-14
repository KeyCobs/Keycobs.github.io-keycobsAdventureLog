DECLARE @GameId INT
SET @GameId = 3

INSERT INTO Locations (Name, Type, SubType, GameId)
VALUES ('Peak','The Reacher','',@GameId)

--UPDATE Locations
--SET Type = 'Liurnia of the Lakes'
--WHERE LocationId > 86

SELECT * FROM Locations
WHERE GameId = @GameId
ORDER BY LocationId DESC