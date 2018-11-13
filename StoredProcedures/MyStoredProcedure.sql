CREATE PROCEDURE InsertShoe
(
	@Name nvarchar(50),
	@Brand nvarchar(50)
)
AS
BEGIN
	INSERT INTO Shoe (Name, Brand)
	VALUES(@Name, @Brand)
END
GO

CREATE PROC [dbo].[InsertPerson]
	@Name nvarchar(50),
	@Gender nchar(1)

AS
BEGIN
	INSERT INTO Person([Name], Gender)
		VALUES(@Name, @Gender)
END
GO


CREATE PROCEDURE InsertPersonShoe
(
@Name Nvarchar(30),
@Age int,
@Gender Nchar(1),
@ShoeName nvarchar(20),
@ShoeBrand nvarchar(20)
)

AS

BEGIN

DECLARE @ShoeID INT = 0;
DECLARE @PersonID INT = 0;

SELECT @ShoeId = Id FROM Shoe WHERE NAME = @ShoeName

IF (@ShoeID > 0)
	UPDATE Shoe SET Brand = @ShoeBrand WHERE Id = @ShoeID
ELSE
	BEGIN
	INSERT INTO Shoe ([Name],Brand) VALUES (@ShoeName,@ShoeBrand)
	
	SELECT @ShoeID = SCOPE_IDENTITY()
	END

	INSERT INTO Person ([Name],Age,Gender) VALUES (@Name,@Age,@Gender)

	SELECT @PersonID = SCOPE_IDENTITY()

	INSERT INTO PersonShoe (PersonID,ShoeID) VALUES (@ShoeID,@PersonID)

END

COMMIT 
GO