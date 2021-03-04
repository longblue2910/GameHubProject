# GameHubProject
USE [GameHubDatabase2]
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveGame]    Script Date: 3/4/2021 7:18:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Save_Game
-- =============================================
ALTER PROCEDURE [dbo].[sp_SaveGame]
	@GameId int,
	@GameName nvarchar(500),
	@Category varchar(200),
	@Image varchar(max),
	@BrandId int,
	@Description nvarchar(max),
	@UserId nvarchar(450)
AS
BEGIN
	DECLARE @tbCategoryId TABLE(CategoryId INT)
	INSERT INTO @tbCategoryId SELECT value FROM STRING_SPLIT ( @Category , ',' )  
	DECLARE @CategoryId INT

	DECLARE @tbImage TABLE(PathImage Nvarchar(max))
	INSERT INTO @tbImage SELECT value FROM STRING_SPLIT ( @Image , '%' )  
	DECLARE @PathImage Nvarchar(450)

	DECLARE @Message NVARCHAR(100) = 'Something went wrong, please try again later!'
	BEGIN TRY
		IF(ISNULL(@GameId,0) = 0)
		BEGIN
			IF(NOT EXISTS(SELECT * FROM [dbo].[Game] WHERE [GameName] = @GameName))
			BEGIN
				IF(EXISTS(SELECT * FROM [dbo].[Brand] where @BrandId = [BrandId]))
				BEGIN
					IF(EXISTS(SELECT * FROM [dbo].[AspNetUsers] where @UserId = [Id]))
					BEGIN
						INSERT INTO [dbo].[Game]
									([GameName]
									,[BrandId]
									,[CategoryId]
									,[Description]
									,[UserId]
									,[Visit]
									,[CreateDate]
									,[UserModified]
									,[ModifieDate]
									,[Download]
									,[IsDeleted])
								VALUES
									(@GameName
									,@BrandId
									,(select top(1) CategoryId from @tbCategoryId)
									,@Description
									,@UserId
									,0
									,GETDATE()
									,@UserId
									,GETDATE()
									,0
									,0)
						SET @Message = 'GameName has been successfully created'
						SET @GameId = SCOPE_IDENTITY()

						WHILE(EXISTS(SELECT * FROM @tbImage))
						BEGIN
							SET @PathImage = (SELECT TOP(1) PathImage FROM @tbImage)
							INSERT INTO [dbo].[Image]
									([PathImage]
									,[GameId])
								VALUES
									(@PathImage
									,@GameId)

							DELETE FROM @tbImage WHERE PathImage = @PathImage
						END

						WHILE(EXISTS(SELECT * FROM @tbCategoryId))
						BEGIN
							SET @CategoryId = (SELECT TOP(1) CategoryId FROM @tbCategoryId)
							INSERT INTO [dbo].[Category_Game]
									([CategoryId]
									,[GameId]
									,[CategoryName])
								VALUES
									(@CategoryId
									,@GameId
									,(select top(1) [CategoryName] from [dbo].[Category] c where @CategoryId = [CategoryId]))
							DELETE FROM @tbCategoryId WHERE CategoryId = @CategoryId
						END

					END
					ELSE
					BEGIN
						SET @Message = 'User Not exist'
						SET @GameId = 0
					END
				END
				ELSE
				BEGIN
					SET @Message = 'Brand Not exist'
					SET @GameId = 0
				END
			END
			ELSE
			BEGIN
				SET @GameId = 0
				SET @Message = 'GameName has been registered'
			END
		END
		else -- update
		begin
			IF(NOT EXISTS(SELECT * FROM [dbo].[Game] WHERE @GameId != [GameId] and [GameName] = @GameName))
			BEGIN
				IF(EXISTS(SELECT * FROM [dbo].[Brand] where @BrandId = [BrandId]))
				BEGIN
					IF(EXISTS(SELECT * FROM [dbo].[AspNetUsers] where @UserId = [Id]))
					BEGIN
							UPDATE [dbo].[Game]
							   SET [GameName] = @GameName
								  ,[BrandId] = @BrandId
								  ,[Description] = @Description
								  ,[UserModified] = @UserId
								  ,[ModifieDate]= GETDATE()
							 WHERE @GameId = [GameId]
							
							SET @Message = 'GameName has been successfully Update'

							Delete from [dbo].[Image] where [GameId] = @GameId

							WHILE(EXISTS(SELECT * FROM @tbImage))
							BEGIN
								SET @PathImage = (SELECT TOP(1) PathImage FROM @tbImage)
								INSERT INTO [dbo].[Image]
										([PathImage]
										,[GameId])
									VALUES
										(@PathImage
										,@GameId)

								DELETE FROM @tbImage WHERE PathImage = @PathImage
							END

							Delete from [dbo].[Category_Game] where [GameId] = @GameId
							
							WHILE(EXISTS(SELECT * FROM @tbCategoryId))
							BEGIN
								SET @CategoryId = (SELECT TOP(1) CategoryId FROM @tbCategoryId)
								INSERT INTO [dbo].[Category_Game]
									([CategoryId]
									,[GameId]
									,[CategoryName])
								VALUES
									(@CategoryId
									,@GameId
									,(select top(1) [CategoryName] from [dbo].[Category] c where @CategoryId = [CategoryId]))
								DELETE FROM @tbCategoryId WHERE CategoryId = @CategoryId
							END

						END
						ELSE
						BEGIN
							SET @Message = 'User Not exist'
							SET @GameId = 0
						END
					END
					ELSE
					BEGIN
						SET @Message = 'Brand Not exist'
						SET @GameId = 0
					END
			END
			ELSE
			BEGIN
				SET @GameId = 0
				SET @Message = 'GameName has been registered'
			END
		end

		SELECT @Message AS [Message], @GameId AS [GameId]
	END TRY
	BEGIN CATCH
		SELECT @Message AS [Message], @GameId AS [GameId]
	END CATCH
END
