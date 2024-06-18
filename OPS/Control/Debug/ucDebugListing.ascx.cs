using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OPS.Control.Debug
{
    public partial class ucDebugListing : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdExportExcel_Click(object sender, EventArgs e)
        {
            grdExport.WriteXlsxToResponse("Debug Listing-" + DateTime.Now.ToString("yyyy-MM-dd"));
        }

        protected void grdDetails_DataSelect(object sender, EventArgs e)
        {
            var data = (sender as ASPxGridView).GetMasterRowKeyValue();
            Session["TempId"] = data;
        }
    }
}