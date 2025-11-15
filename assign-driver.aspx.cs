using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQU_Transportation
{
    public partial class assign_driver : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperations dbo = new DatabaseOperations();

        static int intRecordCounter;
        static int intRowIndex;
        static DataTable tblDriver = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                dbc.strSql = "SELECT * FROM DRIVER";
                dbc.strTableName = "DRIVER";
                tblDriver = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
                intRecordCounter = tblDriver.Rows.Count;
                displayRecords(intRowIndex);
            }
        }
        private void displayRecords(int intRowIndex)
        {
            txtDriverID.Text = tblDriver.Rows[intRowIndex][0].ToString();
            txtDriverName.Text = tblDriver.Rows[intRowIndex][1].ToString();
            txtStatus.Text = tblDriver.Rows[intRowIndex][2].ToString();
            imgDriver.ImageUrl = "~/Images/" + txtDriverID.Text + ".jpg";
            DatabaseConnection.strDriverID = txtDriverID.Text;
        }

      

        protected void btnBack_Click(object sender, EventArgs e)
        {
            if (intRowIndex > 0)
            {
                intRowIndex -= 1;
                displayRecords(intRowIndex);
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "This is the first record";
                lblMessage.Visible = true;
            }
        }
        protected void btnFirst_Click(object sender, EventArgs e)
        {
            intRowIndex = 0;
            displayRecords(intRowIndex);
            lblMessage.Text = "This is the first record";
            lblMessage.Visible = true;
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            intRowIndex = intRecordCounter - 1;
            displayRecords(intRowIndex);
            lblMessage.Text = "This is the last record";
            lblMessage.Visible = true;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (intRowIndex < intRecordCounter - 1)
            {
                intRowIndex += 1;
                displayRecords(intRowIndex);
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "This is the last record";
                lblMessage.Visible = true;
            }
        }
    }
}