using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQU_Transportation
{
    public partial class my_transaction : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperations dbo = new DatabaseOperations();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (DatabaseConnection.strStudentID == "")
            {
                Response.Redirect("~/Student_Login.aspx");


            }



            dbc.strSql = "SELECT [Request_NO] As [Reference No], [Student_ID] As [ID] , [Move_From] AS [From], ";
            dbc.strSql += " [Move_To] As [Destination], [Departure_Time] As [Departure Time], [Retrun_Time] As [Return Time], ";
            dbc.strSql += " [Date_Issued] As [Date], [Time_Issued] As [Time], [RequestStatus] AS [Approved] ";
            dbc.strSql += " FROM [REQUSTEDTRIP]";
            dbc.strSql += " WHERE Student_ID = '" + DatabaseConnection.strStudentID + "'";
            dbc.strTableName = "[REQUSTEDTRIP]";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            grdMyTranscations.DataSource = dbc.tblMyTable;
            grdMyTranscations.DataBind(); // 
        }
    }
}