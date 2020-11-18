USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategory]    Script Date: 11/17/2020 9:54:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlag
-- Create date: 16/11/2020
-- Description:	Get_category
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCategory]
	@CategoryId int
AS
BEGIN
	declare @Message varchar(50) = 'something wrong please try again'
	IF(EXISTS(SELECT * FROM [dbo].[Category] WHERE [IsDeleted] IN (0) and @CategoryId = [CategoryId]))
		BEGIN
		SELECT [CategoryId]
			  ,[CategoryName]
		  FROM [dbo].[Category] where @CategoryId = [CategoryId]
		  SET @Message = 'has found'
		END
	ELSE
		BEGIN
			SET @CategoryId = 0
			SET @Message = 'Category cannot found'
		END
	SELECT @Message AS [Message], @CategoryId as [CategoryId]
END
GO

