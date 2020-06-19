CREATE TABLE [dbo].[Story]
(
	[Story_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Story_Description] NVARCHAR(500) NULL, 
    [StoryLocationX] INT NULL, 
    [StoryLocationY] INT NULL, 
    [Story_Color] NVARCHAR(200) NULL, 
    [Story_Task_Count] INT NULL, 
    [Story_Name] NVARCHAR(200) NULL, 
    [Story_AddDate] NVARCHAR(200) NULL, 
    [Story_Author] NVARCHAR(200) NULL
)
