using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallenge_WebForms.App_Code
{
    internal class BusinessLogic
    {
        public Benefits GetBenefits()
        {
            DataAccess _dataAccess = new DataAccess();
            return _dataAccess.GetBenefits();
        }

        public bool IsQualifiedNameForDiscount(string name, string discountLetter)
        {
            return name.StartsWith(discountLetter);
        }

    }
}