--SELECT * FROM AdventureLog
--SELECT * FROM Enemies
--SELECT * FROM Games
--SELECT * FROM Locations

--VALUES (CURRENT_TIMESTAMP, 'Lost graced Discovered', 'Discovery',  2,1,null);

--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Level 18', 'Level up', 33,1,null);


--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Irena''s letter', 'Side Quest', 27,1,null);

--UPDATE AdventureLog
--SET LocationId = 26
--WHERE LogId = 109


--UPDATE AdventureLog
--SET LocationId = 25
--WHERE LogId = 92

-- Lost Graced
--DECLARE @LocationId INT
--SET @LocationId = 48
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Lost graced Discovered', 'Discovery', @LocationId,1,null);



--DECLARE @LocationId INT
--DECLARE @EnemyId INT
--SET @LocationId = 43
--SET @EnemyId = 7
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Fortress Death', 'Death', @LocationId,1,@EnemyId);

--Killed Boss Fight
--DECLARE @LocationId INT
--DECLARE @EnemyId INT
--SET @LocationId = 47
--SET @EnemyId = 24
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Boss Fight', 'Death', @LocationId,1,@EnemyId);
--INSERT INTO AdventureLog (Timestamp, Event, Type, LocationId, GameId, EnemyId)
--VALUES (CURRENT_TIMESTAMP, 'Boss Defeated', 'Killed', @LocationId,1,@EnemyId);

SELECT LogId, Event, AdventureLog.Type, e.Name AS 'Enemy Name', l.Name, l.Type AS 'Location' ,l.SubType, TimeStamp FROM AdventureLog
LEFT JOIN Enemies AS e ON e.EnemyId = AdventureLog.EnemyId
JOIN Locations AS l ON l.LocationId = AdventureLog.LocationId
ORDER BY LogId DESC

