USE [StudentDB]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentDataUsingrollno]    Script Date: 06-12-2021 23:43:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetStudentDataUsingrollno]
	-- Add the parameters for the stored procedure here
	@rollno int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from StudentTab where rollno=@rollno
END
