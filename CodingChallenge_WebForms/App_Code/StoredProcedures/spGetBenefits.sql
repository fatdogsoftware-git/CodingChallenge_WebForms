SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===================================================
-- Author:		Chris Woodbury
-- Create date: 3/1/2020
-- Description:	Stored Proc for getting Benefits info
-- ===================================================
CREATE PROCEDURE spGetBenefits

AS
BEGIN
	
	select DiscountLetter, DiscountPercentage, EmployeeBenefitCost, DependentBenefitCost, EmployeePaycheckAmount, NumberPaychecksPerYear from Benefits;

END
GO
