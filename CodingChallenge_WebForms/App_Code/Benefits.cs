using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallenge_WebForms.App_Code
{
    internal class Benefits
    {
        public Benefits()
        {
            DiscountLetter = string.Empty; 
            DiscountPercentage = 0.00M;
            EmployeeBenefitCost = 0.00M;
            DependentBenefitCost = 0.00M;
            EmployeePaycheckAmount = 0.00M;
            NumberPaychecksPerYear = 0;
        }

        public string DiscountLetter;
        public decimal DiscountPercentage;
        public decimal EmployeeBenefitCost;
        public decimal DependentBenefitCost;
        public decimal EmployeePaycheckAmount;
        public int NumberPaychecksPerYear;
    }
}