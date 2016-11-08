CREATE TRIGGER [CustomerUpdateTrigger]
ON [dbo].[Customers]
FOR UPDATE
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO [dbo].[CustomerContactNameChanges]
        ([Customer], [OldName], [NewName], [ChangedDate])
    SELECT i.[CompanyName], d.[ContactName], i.[ContactName], GETDATE()
    FROM inserted i
		INNER JOIN deleted d ON i.[CustomerID]=d.[CustomerID]
    WHERE d.[ContactName] <> i.[ContactName]
END
