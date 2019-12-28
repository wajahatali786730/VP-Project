CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [Speciality] NVARCHAR(50) NOT NULL, 
    [Description] NCHAR(10) NOT NULL, 
    [Fee] MONEY NOT NULL, 
    [Availibility] TIME NOT NULL
)
