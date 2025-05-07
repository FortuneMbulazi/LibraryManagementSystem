-- =============================================
-- Author:		Simphiwe Mabaso
-- Create date: 07 May 2025
-- Description:	When called, this stored procedure will create a new book.
-- =============================================
CREATE   PROCEDURE CreateBook
	@Title NVARCHAR(50), 
	@Author NVARCHAR(50),
	@ISBN NVARCHAR(13)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @IsInserted BIT = 0;

    BEGIN TRY
		BEGIN TRAN;
		INSERT INTO Book(Title, Author, ISBN, PublishedDate)
		VALUES(@Title, @Author, @ISBN, GETDATE());

		SET @IsInserted = 1;
		SELECT @IsInserted;

		COMMIT TRAN;
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN;

		SELECT @IsInserted;
	END CATCH
END
