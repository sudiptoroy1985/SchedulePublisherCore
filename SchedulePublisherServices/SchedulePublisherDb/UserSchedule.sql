CREATE TABLE [dbo].[UserSchedule]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [ScheduleId] INT NOT NULL, 
    CONSTRAINT [FK_UserSchedule_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_UserSchedule_Schedule] FOREIGN KEY ([ScheduleId]) REFERENCES [Schedule]([Id])
)
