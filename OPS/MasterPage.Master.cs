using System;
using System.Web.UI.WebControls;
using DAL;
using System.Configuration;
using System.Data;

namespace OPS
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        string HostPath = ConfigurationSettings.AppSettings["HostPath"];
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["username"] == null)
            //{
            //    Response.Redirect(HostPath + clsConst.SessionExpired);
            //    Response.End();
            //}

            //if (Request.Url.ToString().Contains("ChangePassword.aspx"))
            //{

            //}
            //else
            //{

            //    if (Session["ForceChangePassword"] != null)
            //    {
            //        if (Session["ForceChangePassword"].Equals(0))
            //        {
            //            Response.Redirect(HostPath + "ChangePassword.aspx");
            //            Response.End();
            //        }
            //    }
            //}

            ////if (Session["SessionId"] != null)
            ////{
            ////    string SessionId = clsMUser.GetSessionIdByUsername(Session["Username"].ToString());
            ////    if (Session["SessionId"].Equals(SessionId))
            ////    {

            ////    }
            ////    else
            ////    {
            ////        Session.Clear();
            ////        Session.Abandon();

            ////        string myStringVariable = "Your account been login at other place, please relogin again. Thank you.";
            ////        Session["MessageNotification"] = myStringVariable;
            ////        Response.Redirect(HostPath + "Login.aspx");

            ////        Response.End();
            ////    }
            ////}

            if (Page.IsPostBack == false)
            {
                create_menu();
            }


        }

        private void create_menu()
        {
            DevExpress.Web.MenuItem mDashboard = new DevExpress.Web.MenuItem();

            //mDashboard.Text = "Dashboard";
            //mDashboard.NavigateUrl = "Dashboard.aspx";
            //this.menu.Items.Add(mDashboard);


            DataTable dtMenu = new DataTable();
            //dtMenu = clsMUserGroupFunction.GetDataTable_For_Menu_By_UserGroupCode(Session["UserGroupCode"].ToString());
            //if (clsFuncs.DataTableIsNotNothing(dtMenu))
            //{
            //    for (int i = 0; i < dtMenu.Rows.Count; i++)
            //    {
            //            DevExpress.Web.MenuItem m1 = new DevExpress.Web.MenuItem();
            //            m1.Text = dtMenu.Rows[i]["ModuleId"].ToString();
            //            DataTable dt = new DataTable();
            //            dt = clsMUserGroupFunction.GetDataTable_For_MenuDetail_By_UserGroupCode(Session["UserGroupCode"].ToString(), dtMenu.Rows[i]["ModuleId"].ToString());
            //            if (clsFuncs.DataTableIsNotNothing(dt))
            //            {
            //            for (int j = 0; j < dt.Rows.Count; j++)
            //            {
            //                if (dt.Rows[0]["functionname"].ToString().Equals("OSMonitoring"))
            //                {

            //                }
            //                else
            //                {

            //                    //credential = credential + dt.Rows[j]["functioncode"].ToString();
            //                    DevExpress.Web.MenuItem m2 = new DevExpress.Web.MenuItem();
            //                    m2.Text = dt.Rows[j]["functionname"].ToString();
            //                    m2.NavigateUrl = HostPath + dt.Rows[j]["menufolder"].ToString() + dt.Rows[j]["menulink"].ToString() + "?title=" + dt.Rows[j]["functionname"].ToString();
            //                    m1.Items.Add(m2);
            //                }
            //            }
            //            }
            //            this.menu.Items.Add(m1);
            //        } 
            //}

            //DevExpress.Web.MenuItem m3 = new DevExpress.Web.MenuItem();
            //DevExpress.Web.MenuItem m4 = new DevExpress.Web.MenuItem();

            //m3 = new DevExpress.Web.MenuItem();
            //m3.Text = "Debug";

            //m4 = new DevExpress.Web.MenuItem();
            //m4.Text = "Test Listing";
            //m4.NavigateUrl = HostPath + "/form/Debug/frmTest.aspx";

            //m3.Items.Add(m4);

            //this.menu.Items.Add(m3);

            //m3 = new DevExpress.Web.MenuItem();
            //m3.Text = "About";
            //m3.NavigateUrl = HostPath + "about.txt";
            ////m2.Target = "_parent"
            //this.menu.Items.Add(m3);

            //m3 = new DevExpress.Web.MenuItem();
            //m3.Text = "Change Password";
            //m3.NavigateUrl = HostPath + "ChangePassword.aspx?title=Change Password";
            ////m2.Target = "_parent"
            //this.menu.Items.Add(m3);
            //m3 = new DevExpress.Web.MenuItem();
            //m3.Text = "Logout";
            //m3.NavigateUrl = HostPath + "logout.aspx";
            ////m2.Target = "_parent"
            //this.menu.Items.Add(m3);
            //DevExpress.Web.MenuItem mDashboard = new DevExpress.Web.MenuItem();

          //  m3 = new DevExpress.Web.MenuItem();
          //  m3.Text = "Machine Current Stock Summary";
          //  m3.NavigateUrl = HostPath + "Form/Machine/frmMachineCurrentStockSummary.aspx?title=MachineCurrentStockSummary";
           // this.menu.Items.Add(m3);


            //m3 = new DevExpress.Web.MenuItem();
            //m3.Text = "Add To Cart Sales Summary";
            //m3.NavigateUrl = HostPath + "Form/Transaction/frmAddToCartSalesSummary.aspx?title=AddToCartSalesSummary";
            //this.menu.Items.Add(m3);

            ////mDashboard.Text = "Dashboard";
            ////mDashboard.NavigateUrl = "Dashboard.aspx";
            ////this.menu.Items.Add(mDashboard);

            //DevExpress.Web.MenuItem m1 = new DevExpress.Web.MenuItem();
            //m1.Text = "Machine";

            //DevExpress.Web.MenuItem m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Machine Listing";
            //m2.NavigateUrl = HostPath + "form/Machine/frmMachineListing.aspx?title=Machine Listing";
            //m1.Items.Add(m2);


            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Merchant Listing";
            //m2.NavigateUrl = HostPath + "form/Machine/frmMerchantListing.aspx?title=Merchant Listing";
            //m1.Items.Add(m2);

            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Machine Type Listing";
            //m2.NavigateUrl = HostPath + "form/SystemParameter/frmMachineTypeListing.aspx?title=Merchant Type Listing";
            //m1.Items.Add(m2);

            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Area Listing";
            //m2.NavigateUrl = HostPath + "form/SystemParameter/frmAreaListing.aspx?title=Area Listing";
            //m1.Items.Add(m2);

            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Replenish User Listing";
            //m2.NavigateUrl = HostPath + "form/SystemParameter/frmReplenishUserListing.aspx?title=Replenish User Listing";
            //m1.Items.Add(m2);
            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Machine Log Listing";
            //m2.NavigateUrl = HostPath + "form/Machine/frmTerminalLogListing.aspx?title=Merchant Log Listing";
            //m1.Items.Add(m2);


            //this.menu.Items.Add(m1);

            //m1 = new DevExpress.Web.MenuItem();
            //m1.Text = "Product";
            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Product Listing";
            //m2.NavigateUrl = HostPath + "form/Product/frmProductListing.aspx?title=Product Listing";
            //m1.Items.Add(m2);
            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Product Type Listing";
            //m2.NavigateUrl = HostPath + "form/Product/frmProductTypeListing.aspx?title=Product Type Listing";
            //m1.Items.Add(m2);
            //this.menu.Items.Add(m1);



            //DevExpress.Web.MenuItem m = new DevExpress.Web.MenuItem();
            //m.Text = "Replenishment Listing";
            //m.NavigateUrl = HostPath + "form/Replenishment/frmReplenishmentListing.aspx?title=Replenishment Listing";
            //this.menu.Items.Add(m);

            //m1 = new DevExpress.Web.MenuItem();
            //m1.Text = "Transaction";
            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Transaction Listing";
            //m2.NavigateUrl = HostPath + "form/Transaction/frmTransactionListing.aspx?title=Transaction Listing";
            //m1.Items.Add(m2);
            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Transaction Summary Listing";
            //m2.NavigateUrl = HostPath + "form/Transaction/frmTransactionSummaryListing.aspx?title=Transaction Summary Listing";
            //m1.Items.Add(m2);
            //this.menu.Items.Add(m1);




            //m2 = new DevExpress.Web.MenuItem();
            //m2.Text = "Logout";
            //m2.NavigateUrl = HostPath + "logout.aspx";
            ////m2.Target = "_parent"
            //this.menu.Items.Add(m2);

            //DevExpress.Web.MenuItem m3 = new DevExpress.Web.MenuItem();
            //m3.Text = "";

            //m3.ItemStyle.Width = Unit.Percentage(100);
            ////m2.Target = "_parent"
            //this.menu.Items.Add(m2);


        }
    }
}