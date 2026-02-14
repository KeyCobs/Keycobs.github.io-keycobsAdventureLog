DECLARE @GameId INT
DECLARE @Name VARCHAR(100)
DECLARE @LocationId INT
SET @GameId = 3
SET @Name = 'Chromatic Braseleur'
SET @LocationId = 2114

-- Remove spaces and symbols for the EnemyImage
DECLARE @CleanedName VARCHAR(100)
SET @CleanedName = 'expedition33/Enemies/' + REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@Name, ' ', ''), '-', ''), ',', ''), '@', ''), '!', ''), '(Duo)','') + '.png'

INSERT INTO Enemies (Name,LocationId, IsBoss, DamageType, GameId,EnemyImage)
VALUES (@Name,@LocationId,1,'Standard',@GameId,@CleanedName)

--UPDATE Enemies
--SET DamageType = REPLACE(EnemyImage, 'eldenring', 'expedition33')
--WHERE GameId = @GameId AND EnemyId = 98

--UPDATE Enemies
--SET IsBoss = 1
--WHERE EnemyId = 125

--UPDATE Enemies
--SET EnemyImage = 'eldenring/Enemies/ErdtreeBurialWatchdog.png'
--WHERE EnemyId = 56

SELECT * FROM Enemies
WHERE GameId = @GameId
ORDER BY EnemyId DESC



