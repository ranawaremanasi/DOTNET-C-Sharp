USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 24-11-2021 14:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[InsertEmployee]
	-- Add the parameters for the stored procedure here
	(@eno int, 
	@ename varchar(200), 
	@designation varchar(200),
	@sal decimal(6,2),
	@deptno int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Employee values (@eno,@ename,@designation,@sal,@deptno)
	print 'Employee Details inserted into table'
END
