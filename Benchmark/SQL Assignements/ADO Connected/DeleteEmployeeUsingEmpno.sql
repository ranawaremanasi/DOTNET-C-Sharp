USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUsingEmpno]    Script Date: 24-11-2021 18:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[DeleteUsingEmpno] 
	-- Add the parameters for the stored procedure here
	(@eno int)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from employee where eno=@eno
END
