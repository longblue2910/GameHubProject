USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_SaveCategory]    Script Date: 11/17/2020 10:06:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlag
-- Create date: 16/11/2020
-- Description:	Save_Category
-- =============================================
CREATE PROCEDURE [dbo].[sp_SaveCategory]
	@CategoryId int,
	@CategoryName nvarchar(max)
AS
BEGIN
	DECLARE @Message NVARCHAR(100) = 'Something went wrong, please try again later!'
	BEGIN TRY
		IF(ISNULL(@CategoryId,0) = 0)
		BEGIN
			IF(NOT EXISTS(SELECT * FROM [dbo].[Category] WHERE [CategoryName] = @CategoryName))
			BEGIN
			INSERT INTO [dbo].[Category]
					   ([CategoryName]
					   ,[IsDeleted])
				 VALUES
					   (@CategoryName
					   ,0)
				SET @Message = 'Category has been successfully created'
				SET @CategoryId = SCOPE_IDENTITY()
			END
			ELSE
			BEGIN
				SET @CategoryId = 0
				SET @Message = 'Category has been registered'
			END
		END
		else
		begin
			IF(NOT EXISTS(SELECT * FROM [dbo].[Category] WHERE [CategoryId] = @CategoryId))
			BEGIN
				SET @CategoryId = 0
				SET @Message = 'Category cannot find'
			end
			else
			begin
				update [dbo].[Category]
					set [CategoryName] = @CategoryName
					where [CategoryId] = @CategoryId

				SET @Message = 'Category has update success'
			end
		end

		SELECT @Message AS [Message], @CategoryId AS [CategoryId]
	END TRY
	BEGIN CATCH
		SELECT @Message AS [Message], @CategoryId AS [CategoryId]
	END CATCH
END
GO

