DECLARE @Name VARCHAR(100)
SET @Name = 'Map Pumpkin Head'

-- Remove spaces and symbols for the EnemyImage
DECLARE @CleanedName VARCHAR(100)
SET @CleanedName = 'eldenring/Enemies/' + REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@Name, ' ', ''), '-', ''), ',', ''), '@', ''), '!', '') + '.png'

INSERT INTO Enemies (Name,LocationId, IsBoss, DamageType, GameId,EnemyImage)
VALUES (@Name,47,1,'Standard',1,@CleanedName)


SELECT * FROM Enemies
ORDER BY EnemyId DESC

