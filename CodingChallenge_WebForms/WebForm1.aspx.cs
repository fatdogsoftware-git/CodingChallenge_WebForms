using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CodingChallenge_WebForms.App_Code;


namespace CodingChallenge_WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // get benefit values (from database), and place onto screen heading
                BusinessLogic _bl = new BusinessLogic();
                Benefits bene = _bl.GetBenefits();
                lbl_DiscountLetter.Text = bene.DiscountLetter;
                lbl_DiscountPercentage.Text = bene.DiscountPercentage + "%" + " - if first name of employee or dependent begins with the letter " + bene.DiscountLetter;
                lbl_EmployeeBenefitCost.Text = bene.EmployeeBenefitCost.ToString("c");
                lbl_DependentBenefitCost.Text = bene.DependentBenefitCost.ToString("c");
                lbl_EmployeePaycheckAmount.Text = bene.EmployeePaycheckAmount.ToString("c");
                lbl_NumberPaychecksPerYear.Text = bene.NumberPaychecksPerYear.ToString();
                lbl_AnnualSalary.Text = (bene.EmployeePaycheckAmount * bene.NumberPaychecksPerYear).ToString("c");

                txt_EmpName.Focus();
            }
        }

        protected void btn_Calculate_Click(object sender, EventArgs e)
        {
            // reset error message
            lbl_ErrorMessage.Text = string.Empty;
            lbl_ErrorMessage.Visible = false;
            lbl_BCAnnually.Visible = false;
            lbl_BCPerPaycheck.Visible = false;

            // employee name is required
            if (txt_EmpName.Text == string.Empty)
            {
                lbl_ErrorMessage.Text = "Employee Name is required";
                lbl_ErrorMessage.Visible = true;
                txt_EmpName.Focus();
                return;
            }

            // no errors, create List<string> for easy iteration
            List<string> family = new List<string>();
            if (txt_Dep1.Text != string.Empty) family.Add(txt_Dep1.Text);
            if (txt_Dep2.Text != string.Empty) family.Add(txt_Dep2.Text);
            if (txt_Dep3.Text != string.Empty) family.Add(txt_Dep3.Text);
            if (txt_Dep4.Text != string.Empty) family.Add(txt_Dep4.Text);
            if (txt_Dep5.Text != string.Empty) family.Add(txt_Dep5.Text);

            // benefits / discount accumulators
            decimal benefitCost = 0.00M;
            decimal discountAmt = 0.00M;
  
            // get benefits
            Benefits bene = this.GetBenefits();

            // accumulate benefit cost for employee (check for discount)
            discountAmt = this.GetDiscount(txt_EmpName.Text, bene.DiscountLetter) == true ? ((decimal)bene.EmployeeBenefitCost * (decimal)bene.DiscountPercentage) : 0;
            benefitCost = bene.EmployeeBenefitCost - discountAmt;
                       
            // go thru each dependent, and calculate costs and discounts (if applicable)
            foreach (string dep in family)
            {
                // accumulate benefit cost for dependent (check for discount)
                discountAmt = this.GetDiscount(dep, bene.DiscountLetter) == true ? ((decimal)bene.DependentBenefitCost * (decimal)bene.DiscountPercentage) : 0;
                benefitCost += bene.DependentBenefitCost - discountAmt;
            }

            // benefit cost per paycheck
            decimal benefitCostPerPaycheck = Math.Round(benefitCost / (decimal)bene.NumberPaychecksPerYear, 2);

            // no error, calculate
            lbl_BCAnnually.Text = "Benefit Cost - Annually - " + benefitCost.ToString("c");
            lbl_BCAnnually.Visible = true;
            lbl_BCPerPaycheck.Text = "Benefit Cost - Per Paycheck - " + benefitCostPerPaycheck.ToString("c");
            lbl_BCPerPaycheck.Visible = true;
        }

        private Benefits GetBenefits()
        {
            BusinessLogic _bl = new BusinessLogic();
            Benefits bene = _bl.GetBenefits();
            return bene;
        }

        private bool GetDiscount(string name, string discountLetter)
        {
            BusinessLogic _bl = new BusinessLogic();
            return _bl.IsQualifiedNameForDiscount(name, discountLetter);
        }
    }
}