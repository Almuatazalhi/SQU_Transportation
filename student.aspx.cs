using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQU_Transportation
{
    public partial class student : System.Web.UI.Page
    {

        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperations dbo = new DatabaseOperations();
        protected void Page_Load(object sender, EventArgs e)

        {
            if (DatabaseConnection.strStudentID == "") {
                Response.Redirect("~/Student_Login.aspx");


            }



            dbc.strSql = "SELECT * FROM STUDENT WHERE StudentID = '" + DatabaseConnection.strStudentID + "'";
            dbc.strTableName = "STUDENT";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0]; //View

            int intRowIndex;
            intRowIndex = 0;
            displayRecords(intRowIndex);







            ddlDepartureTime.Items.Add("08:00");
            ddlDepartureTime.Items.Add("09:00");
            ddlDepartureTime.Items.Add("10:00");
            ddlDepartureTime.Items.Add("11:00");
            ddlDepartureTime.Items.Add("12:00");
            ddlDepartureTime.Items.Add("13:00");
            ddlDepartureTime.Items.Add("14:00");
            ddlDepartureTime.Items.Add("15:00");
            ddlDepartureTime.Items.Add("16:00");
            ddlDepartureTime.Items.Add("17:00");
            ddlDepartureTime.Items.Add("18:00");
            ddlReturnTime.Items.Add("08:00");
            ddlReturnTime.Items.Add("09:00");
            ddlReturnTime.Items.Add("10:00");
            ddlReturnTime.Items.Add("11:00");
            ddlReturnTime.Items.Add("12:00");
            ddlReturnTime.Items.Add("13:00");
            ddlReturnTime.Items.Add("14:00");
            ddlReturnTime.Items.Add("15:00");
            ddlReturnTime.Items.Add("16:00");
            ddlReturnTime.Items.Add("17:00");
            ddlReturnTime.Items.Add("18:00");
        }


        private void displayRecords(int intRowIndex)
        {
            txtStudentID.Text = dbc.tblMyTable.Rows[intRowIndex][0].ToString();
            txtStudentName.Text = dbc.tblMyTable.Rows[intRowIndex][1].ToString();
            txtPhoneNumber.Text = dbc.tblMyTable.Rows[intRowIndex][2].ToString();
            txtCollege.Text = dbc.tblMyTable.Rows[intRowIndex][3].ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int intRecoredCounter;
            dbc.strSql = "SELECT * FROM [REQUSTEDTRIP]";
            dbc.strTableName = "[REQUSTEDTRIP]";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            intRecoredCounter = dbc.tblMyTable.Rows.Count;
            intRecoredCounter = intRecoredCounter + 1;
            string strRequestNo = "Re" + intRecoredCounter;

            string strDate = DateTime.Now.ToShortDateString();
            string strTime = DateTime.Now.ToShortTimeString();

            dbc.strSql = "INSERT INTO REQUSTEDTRIP (Request_No, Student_ID, Move_From, Move_To, " +
                         "Departure_Time, Retrun_Time, Date_Issued, Time_Issued, RequestStatus) " +
                         "VALUES ('" + strRequestNo + "', " +  
                         "'" + txtStudentID.Text + "', " +
                         "'" + txtFrom.Text + "', " +
                         "'" + txtTo.Text + "', " +
                         "'" + ddlDepartureTime.Text + "', " +
                         "'" + ddlReturnTime.Text + "', " +
                         "'" + strDate + "', " +
                         "'" + strTime + "', " +
                         "'No')";

            dbo.dbOperations(dbc.strSql, "");

        }
    }
}