CREATE TABLE [dbo].[Restaurants] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (MAX) NULL,
    [City]    NVARCHAR (MAX) NULL,
    [Country] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Restaurants] PRIMARY KEY CLUSTERED ([Id] ASC)
);


INSERT INTO [OdeToFoodDb].[dbo].[Restaurants] (Name, City, Country)
VALUES ('5', 'Nowhere', 'NoCountry');

DECLARE @cnt INT = 0;
WHILE @cnt < 3
BEGIN
INSERT INTO [OdeToFoodDb].[dbo].[Restaurants] (Name, City, Country)
VALUES (@cnt, 'Nowhere', 'NoCountry');
   SET @cnt = @cnt + 1;
END;

DELETE FROM [OdeToFoodDb].[dbo].[Restaurants]
WHERE Name = '5';