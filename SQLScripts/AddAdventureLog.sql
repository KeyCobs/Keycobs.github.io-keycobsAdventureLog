--SELECT * FROM AdventureLog
--SELECT * FROM Enemies
--SELECT * FROM Games
--SELECT * FROM Locations

DECLARE @GameId INT
SET @GameId = 3

--INSERT INTO Games (Title, CoverImage, TitleImage,CharacterImage)
--VALUES ('Clair Obscur: Expedition 33', 'expedition33/Cover.jpg', 'expedition33/title.png', 'expedition33/character.png')

--VALUES (CURRENT_TIMESTAMP, 'Lost graced Discovered', 'Discovery',  2,1,null);

--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Level 42', 'Level up', 81,1,null);


--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Boc the Demi-human', 'Side Quest', 84,1,null);

--UPDATE AdventureLog
--SET LocationId = 77
--WHERE LogId = 350


--UPDATE AdventureLog
--SET LocationId = 25
--WHERE LogId = 92

---- Lost Graced
--DECLARE @LocationId INT
--SET @LocationId = 108
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Lost graced Discovered', 'Discovery', @LocationId,1,null);



--DECLARE @LocationId INT
--DECLARE @EnemyId INT
--SET @LocationId = 124
--SET @EnemyId = 94
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Fuck', 'Death', @LocationId,@GameId,@EnemyId);

--UPDATE AdventureLog
--SET  LocationId = 89
--WHERE LogId = 428

--Killed Boss Fight
DECLARE @LocationId INT
DECLARE @EnemyId INT
SET @LocationId = 126
SET @EnemyId = 96
INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
VALUES (CURRENT_TIMESTAMP, 'Boss Fight', 'Death', @LocationId,@GameId,@EnemyId);
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Boss Defeated', 'Killed', @LocationId,@GameId,@EnemyId);


--DELETE FROM AdventureLog
--WHERE EnemyId = 60 AND Type = 'Killed'

SELECT LogId, Event, AdventureLog.Type, e.Name AS 'Enemy Name', l.Name, l.Type AS 'Location' ,l.SubType, TimeStamp FROM AdventureLog
LEFT JOIN Enemies AS e ON e.EnemyId = AdventureLog.EnemyId
JOIN Locations AS l ON l.LocationId = AdventureLog.LocationId
WHERE AdventureLog.GameId = @GameId
ORDER BY LogId DESC


SELECT 
    COUNT(CASE WHEN b.Event LIKE '%fell%' THEN 1 END) AS fell_count,
    COUNT(CASE WHEN a.Type = 'Killed' THEN 1 END) AS Boss_Defeated
FROM AdventureLog AS b 
JOIN AdventureLog AS a ON a.LogId = b.LogId
WHERE a.GameId = @GameId;

