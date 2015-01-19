CREATE TABLE [dbo].[UserSocial]
( 
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Userid] int not null,
	[SocialId] int not null,
	[SocialAccount] nvarchar(max) not null, 
    CONSTRAINT [FK_UserSocial_ToUser] FOREIGN KEY (Userid) REFERENCES [User]([id])

)
