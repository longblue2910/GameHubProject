USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteBrand]    Script Date: 11/18/2020 2:11:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 17/11/2020
-- Description:	Delete_Brand
-- =============================================
Create PROCEDURE [dbo].[sp_DeleteBrand]
	@BrandId int
AS
BEGIN
	declare @Message varchar(50) = 'something wrong please try again'
	IF(EXISTS(SELECT * FROM [dbo].[Brand] WHERE @BrandId = [BrandId]))
		BEGIN
			UPDATE [dbo].[Brand]
			   SET [IsDeleted] = 1
			 WHERE  @BrandId = [BrandId]
			 SET @Message = 'Brand has deleted'
		END
	ELSE
		BEGIN
			SET @BrandId = 0
			SET @Message = 'Brand cannot found'
		END
	SELECT @Message AS [Message], @BrandId as [BrandId]
END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteCategory]    Script Date: 11/18/2020 2:11:31 PM ******/
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

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_DeleteGame]    Script Date: 11/18/2020 2:11:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Delete_Game
-- =============================================
Create PROCEDURE [dbo].[sp_DeleteGame]
	@GameId int
AS
BEGIN
	declare @Message varchar(50) = 'something wrong please try again'
	IF(EXISTS(SELECT * FROM [dbo].[Game] WHERE @GameId = [GameId]))
		BEGIN
			UPDATE [dbo].[Game]
			   SET [IsDeleted] = 1
			 WHERE  @GameId = [GameId]
			 SET @Message = 'Game has deleted'
		END
	ELSE
		BEGIN
			SET @GameId = 0
			SET @Message = 'Game cannot found'
		END
	SELECT @Message AS [Message], @GameId as [GameId]
END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetBrand]    Script Date: 11/18/2020 2:11:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 17/11/2020
-- Description:	Get_Brand
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetBrand]
	@BrandId int
AS
BEGIN
	declare @Message varchar(50) = 'something wrong please try again'
	IF(EXISTS(SELECT * FROM [dbo].Brand WHERE [IsDeleted] IN (0) and @BrandId = [BrandId]))
		BEGIN
		SELECT BrandId
			  ,[BrandName]
		  FROM [dbo].[Brand] where @BrandId = [BrandId]
		  SET @Message = 'has found'
		END
	ELSE
		BEGIN
			SET @BrandId = 0
			SET @Message = 'Category cannot found'
		END
	SELECT @Message AS [Message], @BrandId as [BrandId]
END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCategory]    Script Date: 11/18/2020 2:11:54 PM ******/
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

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetGame]    Script Date: 11/18/2020 2:12:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Get_GamebyId
-- =============================================
CREate PROCEDURE [dbo].[sp_GetGame]
	@GameId int
AS
BEGIN
	declare @Message varchar(50) = 'something wrong please try again'
	IF(EXISTS(SELECT * FROM [dbo].[Game] WHERE [GameId] = @GameId))
	BEGIN
		SELECT [GameId]
				,[GameName]
				,[CategoryId]
				,[BrandId]
				,[Desciption]
				,[UserId]
				,[Visit]
				,[CreateDate]
				,[UserModified]
				,[ModifieDate]
				,[Download]
			
			FROM [dbo].[Game] where [IsDeleted] = 0 and [GameId] = @GameId
			SET @Message = 'Game was found'
		  
	END
	ELSE
	BEGIN
		SET @Message = 'Game not found'
		SELECT @Message AS [Message], @GameId AS [GameId]
	END
END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetsBrand]    Script Date: 11/18/2020 2:12:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlag
-- Create date: 16/11/2020
-- Description:	Gets_Brand
-- =============================================
Create PROCEDURE [dbo].[sp_GetsBrand]
AS
BEGIN
SELECT [BrandId]
      ,[BrandName]
  FROM [dbo].[Brand] where [IsDeleted] = 0


END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetsCategory]    Script Date: 11/18/2020 2:12:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlag
-- Create date: 16/11/2020
-- Description:	Gets_category
-- =============================================
Create PROCEDURE [dbo].[sp_GetsCategory]
AS
BEGIN
SELECT [CategoryId]
      ,[CategoryName]
  FROM [dbo].[Category] where [IsDeleted] = 0

END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetsGame]    Script Date: 11/18/2020 2:12:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Gets_Game
-- =============================================
CREate PROCEDURE [dbo].[sp_GetsGame]
AS
BEGIN
	SELECT [GameId]
			,[GameName]
			,[CategoryId]
			,[BrandId]
			,[Desciption]
			,[UserId]
			,[Visit]
			,[CreateDate]
			,[UserModified]
			,[ModifieDate]
			,[Download]
			
		FROM [dbo].[Game] where [IsDeleted] = 0

END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetsGameByBrand]    Script Date: 11/18/2020 2:12:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Gets_GamebyBrand
-- =============================================
CREate PROCEDURE [dbo].[sp_GetsGameByBrand]
	@BrandId int
AS
BEGIN
	SELECT [GameId]
			,[GameName]
			,[CategoryId]
			,[BrandId]
			,[Desciption]
			,[UserId]
			,[Visit]
			,[CreateDate]
			,[UserModified]
			,[ModifieDate]
			,[Download]
			
		FROM [dbo].[Game] where [IsDeleted] = 0 and [BrandId] = @BrandId

END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetsGameByCategory]    Script Date: 11/18/2020 2:12:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Gets_GamebyCategory
-- =============================================
CREate PROCEDURE [dbo].[sp_GetsGameByCategory]
	@CategoryId int
AS
BEGIN
	SELECT [GameId]
			,[GameName]
			,[CategoryId]
			,[BrandId]
			,[Desciption]
			,[UserId]
			,[Visit]
			,[CreateDate]
			,[UserModified]
			,[ModifieDate]
			,[Download]
			
		FROM [dbo].[Game] where [IsDeleted] = 0 and [CategoryId] = @CategoryId

END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_SaveBrand]    Script Date: 11/18/2020 2:12:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 17/11/2020
-- Description:	Save_Brand
-- =============================================
CREATE PROCEDURE [dbo].[sp_SaveBrand]
	@BrandId int,
	@BrandName nvarchar(max)
AS
BEGIN
	DECLARE @Message NVARCHAR(100) = 'Something went wrong, please try again later!'
	BEGIN TRY
		IF(ISNULL(@BrandId,0) = 0)
		BEGIN
			IF(NOT EXISTS(SELECT * FROM [dbo].[Brand] WHERE [BrandName] = @BrandName))
			BEGIN
			INSERT INTO [dbo].[Brand]
					   ([BrandName]
					   ,[IsDeleted])
				 VALUES
					   (@BrandName
					   ,0)
				SET @Message = 'Brand has been successfully created'
				SET @BrandId = SCOPE_IDENTITY()
			END
			ELSE
			BEGIN
				SET @BrandId = 0
				SET @Message = 'Brand has been registered'
			END
		END
		else
		begin
			IF(NOT EXISTS(SELECT * FROM [dbo].[Brand] WHERE [BrandId] != @BrandId and [BrandName] = @BrandName))
			BEGIN
			update [dbo].[Brand]
					set [BrandName] = @BrandName
					where [BrandId] = @BrandId

				SET @Message = 'Brand has update success'
				
			end
			else
			begin
				SET @BrandId = 0
				SET @Message = 'Category cannot find'
			end
		end

		SELECT @Message AS [Message], @BrandId AS [BrandId]
	END TRY
	BEGIN CATCH
		SELECT @Message AS [Message], @BrandId AS [BrandId]
	END CATCH
END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_SaveCategory]    Script Date: 11/18/2020 2:12:57 PM ******/
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
			IF(NOT EXISTS(SELECT * FROM [dbo].[Category] WHERE [CategoryId] != @CategoryId and [CategoryName] = @CategoryName))
			BEGIN
				update [dbo].[Category]
					set [CategoryName] = @CategoryName
					where [CategoryId] = @CategoryId

				SET @Message = 'Category has update success'
			end
			else
			begin
				SET @CategoryId = 0
				SET @Message = 'Category cannot find'
			end
		end

		SELECT @Message AS [Message], @CategoryId AS [CategoryId]
	END TRY
	BEGIN CATCH
		SELECT @Message AS [Message], @CategoryId AS [CategoryId]
	END CATCH
END
GO

USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_SaveGame]    Script Date: 11/18/2020 2:13:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		HoangBlah
-- Create date: 18/11/2020
-- Description:	Save_Game
-- =============================================
CREATE PROCEDURE [dbo].[sp_SaveGame]
	@GameId int,
	@GameName nvarchar(500),
	@CategoryId int,
	@BrandId int,
	@Desciption nvarchar(max),
	@UserId nvarchar(450)
AS
BEGIN
	DECLARE @Message NVARCHAR(100) = 'Something went wrong, please try again later!'
	BEGIN TRY
		IF(ISNULL(@GameId,0) = 0)
		BEGIN
			IF(NOT EXISTS(SELECT * FROM [dbo].[Game] WHERE [GameName] = @GameName))
			BEGIN
				IF(EXISTS(SELECT * FROM [dbo].[Category] where @CategoryId = [CategoryId]))
				BEGIN
					IF(EXISTS(SELECT * FROM [dbo].[Brand] where @BrandId = [BrandId]))
					BEGIN
						IF(EXISTS(SELECT * FROM [dbo].[AspNetUsers] where @UserId = [Id]))
						BEGIN
							INSERT INTO [dbo].[Game]
									   ([GameName]
									   ,[CategoryId]
									   ,[BrandId]
									   ,[Desciption]
									   ,[UserId]
									   ,[Visit]
									   ,[CreateDate]
									   ,[UserModified]
									   ,[ModifieDate]
									   ,[Download]
									   ,[IsDeleted])
								 VALUES
									   (@GameName
									   ,@CategoryId
									   ,@BrandId
									   ,@Desciption
									   ,@UserId
									   ,0
									   ,GETDATE()
									   ,@UserId
									   ,GETDATE()
									   ,0
									   ,0)
							SET @Message = 'GameName has been successfully created'
							SET @GameId = SCOPE_IDENTITY()
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
					SET @Message = 'Category Not exist'
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
				IF(EXISTS(SELECT * FROM [dbo].[Category] where @CategoryId = [CategoryId]))
				BEGIN
					IF(EXISTS(SELECT * FROM [dbo].[Brand] where @BrandId = [BrandId]))
					BEGIN
						IF(EXISTS(SELECT * FROM [dbo].[AspNetUsers] where @UserId = [Id]))
						BEGIN
							UPDATE [dbo].[Game]
							   SET [GameName] = @GameName
								  ,[CategoryId] = @CategoryId
								  ,[BrandId] = @CategoryId
								  ,[Desciption] = @Desciption
								  ,[UserModified] = @UserId
								  ,[ModifieDate]= GETDATE()
							 WHERE @GameId = [GameId]
							
							SET @Message = 'GameName has been successfully Update'
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
					SET @Message = 'Category Not exist'
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
GO

