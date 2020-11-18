USE [GameHubDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetsCategory]    Script Date: 11/17/2020 9:54:18 AM ******/
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

