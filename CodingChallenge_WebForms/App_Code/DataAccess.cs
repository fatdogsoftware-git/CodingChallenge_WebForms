using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;
using System.IO;
using System.Configuration;
using System.Data;
using System.Text;
using CodingChallenge_WebForms.App_Code;

/// <summary>
/// Summary description for DataAccess
/// </summary>
internal class DataAccess
{
    public DataAccess()
    {
        // add constructor logic here
    }

    static private string connectionString;

    public string ConnectionString
    {
        get
        {
            if (connectionString == null)
            {
                connectionString = ConfigurationManager.ConnectionStrings["CodingChallengeConnectionString"].ToString();
            }
            return connectionString;
        }
        set { connectionString = value; }
    }

    #region Benefits

    public Benefits GetBenefits()
    {
        SqlCommand command = null;
        Benefits item = new Benefits();
       
        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                // Open SQL connection
                conn.Open();

                // Create and setup the SQL command
                command = new SqlCommand("spGetBenefits", conn);
                command.CommandType = CommandType.StoredProcedure;

                // run the SQL command
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        item = new Benefits();
                        item.DiscountLetter = reader["DiscountLetter"].ToString();
                        item.DiscountPercentage = (decimal)reader["DiscountPercentage"];
                        item.EmployeeBenefitCost = (decimal)reader["EmployeeBenefitCost"];
                        item.DependentBenefitCost = (decimal)reader["DependentBenefitCost"];
                        item.EmployeePaycheckAmount = (decimal)reader["EmployeePaycheckAmount"];
                        item.NumberPaychecksPerYear = (int)reader["NumberPaychecksPerYear"];
                        return item;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("problem when getting Benefits info " + ex.Message.ToString());
        }

    }

    #endregion

}