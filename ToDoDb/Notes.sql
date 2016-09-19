CREATE TABLE [dbo].[Notes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Note] NVARCHAR(250) NOT NULL, 
    [TypeId] INT NOT NULL, 
    [CreatedDateTime] DATETIME NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    [Stars] INT NOT NULL DEFAULT 0
)
