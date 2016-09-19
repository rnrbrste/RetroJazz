﻿CREATE TABLE [dbo].[Team]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NVARCHAR(10) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [CreatedDateTime] DATETIME NOT NULL
)
