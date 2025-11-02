using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQU_Transportation
{
    public partial class process_transaction : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperations dbo = new DatabaseOperations();
        protected void Page_Load(object sender, EventArgs e)
        {
            dbc.strSql = "SELECT [Request_NO] As [Reference No], [Student_ID] As [ID] , [Move_From] AS [From], ";
            dbc.strSql += " [Move_To] As [Destination], [Departure_Time] As [Departure Time], [Retrun_Time] As [Return Time], ";
            dbc.strSql += " [Date_Issued] As [Date], [Time_Issued] As [Time], [RequestStatus] AS [Approved] ";
            dbc.strSql += " FROM [REQUSTEDTRIP]";
            dbc.strTableName = "REQUSTEDTRIP";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            grdTranscations.DataSource = dbc.tblMyTable;
            grdTranscations.DataBind();

        }

        protected void grdTranscations_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReference.Text = grdTranscations.SelectedRow.Cells[1].Text;
            txtStudentID.Text = grdTranscations.SelectedRow.Cells[2].Text;
            txtFrom.Text = grdTranscations.SelectedRow.Cells[3].Text;
            txtDestination.Text = grdTranscations.SelectedRow.Cells[4].Text;
            txtDepartureTime.Text = grdTranscations.SelectedRow.Cells[5].Text;
            txtReturnTime.Text = grdTranscations.SelectedRow.Cells[6].Text;
            txtDate.Text = grdTranscations.SelectedRow.Cells[7].Text;
            txtTime.Text = grdTranscations.SelectedRow.Cells[8].Text;
            txtApproved.Text = grdTranscations.SelectedRow.Cells[9].Text;
            passValues();
        }

        private void passValues()
        {
            DatabaseConnection.strReferenceNo = txtReference.Text;
            DatabaseConnection.strStudentID = txtStudentID.Text;
            DatabaseConnection.strMoveFrom = txtFrom.Text;
            DatabaseConnection.strMoveTo = txtDestination.Text;
            DatabaseConnection.strDepTime = txtDepartureTime.Text;
            DatabaseConnection.strReturnTime = txtReturnTime.Text;
        }

        protected void txtReference_TextChanged(object sender, EventArgs e)
        {

        }
    }
}