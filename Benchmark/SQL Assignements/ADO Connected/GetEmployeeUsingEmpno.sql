USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEmpUsingEmpno]    Script Date: 24-11-2021 22:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetEmpUsingEmpno] 
	-- Add the parameters for the stored procedure here
	(@eno int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from employee where eno =@eno
END
