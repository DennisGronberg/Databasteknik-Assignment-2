CREATE TABLE [dbo].[CustomerContactNameChanges]
(
	[ContactNameChangesID] [int] IDENTITY(1,1) NOT NULL,
	[Customer] nvarchar(40) NOT NULL,
    [OldName] nvarchar(30) NOT NULL,
    [NewName] nvarchar(30) NOT NULL,
    [ChangedDate] [datetime] NOT NULL,
    PRIMARY KEY CLUSTERED 
    (
        [ContactNameChangesID] ASC
    )
)

GO