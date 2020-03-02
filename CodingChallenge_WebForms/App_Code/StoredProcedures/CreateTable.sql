USE [CodingChallenge_WebForms]
GO

/****** Object:  Table [dbo].[Benefits]    Script Date: 3/1/2020 7:28:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Benefits](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DiscountLetter] [char](1) NOT NULL,
	[DiscountPercentage] [decimal](5, 2) NOT NULL,
	[EmployeeBenefitCost] [decimal](7, 2) NOT NULL,
	[DependentBenefitCost] [decimal](7, 2) NOT NULL,
	[EmployeePaycheckAmount] [decimal](7, 2) NOT NULL,
	[NumberPaychecksPerYear] [int] NOT NULL,
 CONSTRAINT [PK_Benefits] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


