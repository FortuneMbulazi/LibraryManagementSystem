-- =============================================
-- Author:		Simphiwe Mabaso
-- Create date: 07 May 2025
-- Description:	When called, this stored procedure will get a book by ID.
-- =============================================
CREATE   PROCEDURE GetBookById
	@ID BIGINT
AS
BEGIN
	SET NOCOUNT ON;

    SELECT	[ID],
			[Title],
			[Author],
			[ISBN],
			[DeletedOn]
	FROM dbo.Book
	WHERE ID = @ID AND DeletedOn IS NULL;
END
