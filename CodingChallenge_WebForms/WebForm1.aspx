<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CodingChallenge_WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Employee Benefits Preview</h3>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Discount Letter:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_DiscountLetter" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label runat="server" Text="Discount Percentage:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_DiscountPercentage" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label runat="server" Text="Employee Benefit Cost:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_EmployeeBenefitCost" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label runat="server" Text="Dependent Benefit Cost:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_DependentBenefitCost" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label runat="server" Text="Employee Salary Per Paycheck (before deductions):"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_EmployeePaycheckAmount" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label runat="server" Text="Number of Paychecks Per Year:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_NumberPaychecksPerYear" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Annual Salary (before deductions):"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_AnnualSalary" runat="server" Text="" ></asp:Label>
                    </td>
                </tr>
            </table>
          
            <hr />
            <p>Employee Information</p>
            <hr />

            <label>Employee Name:</label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txt_EmpName" runat="server" CssClass="textinput" ></asp:TextBox>
             

            <div style="padding-top: 50px;"></div>
           
            <hr />
            <p>Dependent Information</p>
            <hr />

            <label>Dependent Name #1:</label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txt_Dep1" runat="server" CssClass="textinput" ></asp:TextBox>
            <br />
             <label>Dependent Name #2:</label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txt_Dep2" runat="server" CssClass="textinput" ></asp:TextBox>
            <br />
             <label>Dependent Name #3:</label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txt_Dep3" runat="server" CssClass="textinput" ></asp:TextBox>
            <br />
            <label>Dependent Name #4:</label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txt_Dep4" runat="server" CssClass="textinput" ></asp:TextBox>
            <br />
             <label>Dependent Name #5:</label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txt_Dep5" runat="server" CssClass="textinput" ></asp:TextBox>
            <br />
        </div>

        <br />
        <br />
        <asp:Button ID="btn_Calculate" runat="server" Text="Calculate Benefit Cost"  CssClass="button" OnClick="btn_Calculate_Click"/>
        <br />
        <br />
        <asp:Label id="lbl_ErrorMessage" runat="server" Text="" Visible="false" CssClass="error"></asp:Label>
        <asp:Label ID="lbl_BCAnnually" runat="server" Text="" Visible="false" CssClass="info"></asp:Label>
        <br />
        <asp:Label ID="lbl_BCPerPaycheck" runat="server" Text="" Visible="false" CssClass="info"></asp:Label>

    </form>
</body>
</html>
