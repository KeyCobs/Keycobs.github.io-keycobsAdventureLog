DECLARE @GameId INT
SET @GameId = 3
DECLARE @Name VARCHAR(100)
SET @Name = 'Dualliste'

-- Remove spaces and symbols for the EnemyImage
DECLARE @CleanedName VARCHAR(100)
SET @CleanedName = 'eldenring/Enemies/' + REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@Name, ' ', ''), '-', ''), ',', ''), '@', ''), '!', ''), '(Duo)','') + '.png'

INSERT INTO Enemies (Name,LocationId, IsBoss, DamageType, GameId,EnemyImage)
VALUES (@Name,126,1,'Standard',@GameId,@CleanedName)

--UPDATE Enemies
--SET LocationId = 114
--WHERE EnemyId = 82

--UPDATE Enemies
--SET EnemyImage = 'eldenring/Enemies/ErdtreeBurialWatchdog.png'
--WHERE EnemyId = 56

SELECT * FROM Enemies
WHERE GameId = @GameId
ORDER BY EnemyId DESC


