CREATE TABLE [dbo].[Schedule]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ScheduleName] NCHAR(80) NULL, 
    [Description] NCHAR(80) NOT NULL, 
    [StartTime] DATETIME NULL, 
    [EndTime] DATETIME NULL, 
    [Priority] INT NOT NULL, 
    [ParentSchedule] INT NULL
)
