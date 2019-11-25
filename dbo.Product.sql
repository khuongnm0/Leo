CREATE TABLE [dbo].[Product]
(
	[Id] INT primary key not null identity(1,1),  
    [Name] NCHAR(50) NULL, 
    [ExpiryDate] DATETIME NULL, 
    [CompanyName] NCHAR(100) NULL, 
    [Year] INT NULL, 
    [Category] NCHAR(100) NULL
)
