USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteCategory]    Script Date: 11/17/2020 9:53:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlag
-- Create date: 16/11/2020
-- Description:	Delete_category
-- =============================================
Create PROCEDURE [dbo].[sp_DeleteCategory]
	@CategoryId int
AS
BEGIN
	declare @Message varchar(50) = 'something wrong please try again'
	IF(EXISTS(SELECT * FROM [dbo].[Category] WHERE @CategoryId = [CategoryId]))
		BEGIN
			UPDATE [dbo].[Category]
			   SET [IsDeleted] = 1
			 WHERE @CategoryId = [CategoryId]
			 SET @Message = 'Category has deleted'
		END
	ELSE
		BEGIN
			SET @CategoryId = 0
			SET @Message = 'Category cannot found'
		END
	SELECT @Message AS [Message], @CategoryId as [CategoryId]
END
GO

