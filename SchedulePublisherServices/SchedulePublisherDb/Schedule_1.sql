CREATE TABLE [dbo].[Schedule]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NCHAR(80) NOT NULL, 
    [description] NCHAR(80) NULL, 
    [starttime] DATETIME NOT NULL, 
    [endtime] DATETIME NULL, 
    [priority] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_Schedule_ToUser] FOREIGN KEY (UserId) REFERENCES [User]([id])
)
