-- =============================================
-- Author:		Simphiwe Mabaso
-- Create date: 07 May 2025
-- Description:	When called, this stored procedure will get all books.
-- =============================================
CREATE   PROCEDURE GetAllBooks
AS
BEGIN
	SET NOCOUNT ON;

    SELECT	[ID],
			[Title],
			[Author],
			[ISBN],
			[DeletedOn]
	FROM dbo.Book
	WHERE DeletedOn IS NULL;
END
