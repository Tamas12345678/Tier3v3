CREATE TABLE [dbo].[User]
(
	[UserID] CHAR(4) NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [EmailAddress] VARCHAR(50) NOT NULL, 
    [Age] NCHAR(10) NOT NULL
)
