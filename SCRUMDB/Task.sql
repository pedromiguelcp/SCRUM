CREATE TABLE [dbo].[Task]
(
	[Task_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Task_DeadLine] NVARCHAR(100) NULL, 
    [TaskLocationX] INT NULL, 
    [TaskLocationY] INT NULL, 
    [Task_Author] NVARCHAR(100) NULL, 
    [Task_Status] INT NULL, 
    [Task_Description] NVARCHAR(500) NULL, 
    [Story_ID] INT NULL, 
    [Task_Color] INT NULL, 
    [Task_Header] NVARCHAR(200) NULL
)
