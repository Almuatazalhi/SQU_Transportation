using SQU_Transportation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQU_Transportation
{
    public partial class select_a_car : System.Web.UI.Page
    {
        
      DatabaseConnection dbc = new DatabaseConnection();
      DatabaseOperations dbo = new DatabaseOperations();
      DataTable tblCar = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int intRowcounter;
                dbc.strSql = "SELECT * FROM CAR";
                dbc.strTableName = "CAR";
                tblCar = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
                intRowcounter = tblCar.Rows.Count;
                grdCar.DataSource = tblCar;
                grdCar.DataBind();
                int intCarIndex;
                intCarIndex = 0;

                List<String> StrCarName = new List<String>();
                while (intCarIndex < intRowcounter)
                {
                    if (!StrCarName.Contains(tblCar.Rows[intCarIndex][1].ToString()))
                    {
                        StrCarName.Add(tblCar.Rows[intCarIndex][1].ToString());
                        ddlCar.Items.Add(tblCar.Rows[intCarIndex][1].ToString());
                        intCarIndex++;
                    }
                    else
                    {
                        intCarIndex++;

                    }
                }
            }

        }

        protected void ddlCar_SelectedIndexChanged(object sender, EventArgs e)
        {

            int intRowCounter;
            dbc.strSql = "SELECT * FROM CAR WHERE [Car_Name] = '" + ddlCar.Text + "'";
            dbc.strTableName = "CAR";
            tblCar = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            intRowCounter = tblCar.Rows.Count;
            grdCar.DataSource = tblCar;
            grdCar.DataBind(); grdCar.DataSource = null;
            grdCar.DataBind();
            int intRowcounter;
            dbc.strSql = "SELECT * FROM CAR WHERE [Car_Name] = '" + ddlCar.Text + "'";
            dbc.strTableName = "CAR";
            tblCar = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            intRowcounter = tblCar.Rows.Count;
            grdCar.DataSource = tblCar;
            grdCar.DataBind();


        }

        protected void grdCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPlateNumber.Text = grdCar.SelectedRow.Cells[1].Text;
            txtBrand.Text = grdCar.SelectedRow.Cells[2].Text;
        }
    }
}
