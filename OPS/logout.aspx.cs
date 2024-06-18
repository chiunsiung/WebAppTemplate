using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
namespace OPS
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Write("<script>parent.parent.location.href='login.aspx';</script>");
            Response.End();
            //if (!Page.IsPostBack)
            //    GenerateGrid();


        }

        //public void GenerateGrid()
        //{
        //    DataTable dt = new DataTable();
        //    dt = clsTTransaction.GetDataTable_For_PlanoAnalysis(-1, "2020-10-01", "2020-10-31", "");
        //    if (clsFuncs.DataTableIsNotNothing(dt))
        //    {
        //        int Count = 0;
        //        string HeaderName = "";
        //        GridViewBandColumn Band = new GridViewBandColumn();
        //        for (int i = 0; i < dt.Columns.Count; i++)
        //        {

        //            if (dt.Columns[i].ColumnName.Contains("_Trx") || dt.Columns[i].ColumnName.Contains("_InVM"))
        //            {
        //                if (dt.Columns[i].ColumnName.Contains("_Trx"))
        //                {
        //                    HeaderName = dt.Columns[i].ColumnName.Replace("_Trx", "");
        //                    Band = new GridViewBandColumn(HeaderName);

        //                    GridViewDataTextColumn Col = new GridViewDataTextColumn();
        //                    Col.FieldName = dt.Columns[i].ColumnName ;
        //                    Col.Caption = dt.Columns[i].ColumnName.Replace(HeaderName+"_","");
        //                    Band.Columns.Add(Col);
        //                }
        //                else
        //                {
        //                    GridViewDataTextColumn Col = new GridViewDataTextColumn();
        //                    Col.FieldName = dt.Columns[i].ColumnName;
        //                    Col.Caption = dt.Columns[i].ColumnName.Replace(HeaderName + "_", "");
        //                    Band.Columns.Add(Col);

        //                    grdData.Columns.Add(Band);
        //                }
        //            }
        //            else
        //            {

        //                GridViewDataTextColumn Col = new GridViewDataTextColumn();
        //                Col.FieldName = dt.Columns[i].ColumnName;
        //                grdData.Columns.Add(Col);
        //            }
        //        }

        //        grdData.DataSource = dt;
        //        grdData.DataBind();
        //    }

        //}
    }

}