using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQU_Transportation
{
    public partial class Student_Login : System.Web.UI.Page
    {

        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperations dbo = new DatabaseOperations();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            dbc.strSql = "SELECT * FROM AdminLogin1 WHERE UserName = '" + txtStudentID.Text + "'";
            dbc.strSql += " AND UserPassword = '" + txtPassword.Text + "'";
            dbc.strTableName = "AdminLogin1";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            int intRecordCounter;
            intRecordCounter = dbc.tblMyTable.Rows.Count;
            if (intRecordCounter > 0)
            {
                lblErrorMsg.Visible = false;
                DatabaseConnection.strStudentID = txtStudentID.Text;
                Response.Redirect("~/student.aspx");
                
            }
            else
            {
                lblErrorMsg.Visible = true;
            }
        }
    }
}