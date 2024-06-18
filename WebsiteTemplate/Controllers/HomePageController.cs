using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteTemplate.Controllers
{
    public class HomePageController : Controller
    {
        
        // GET: HomePage
        [HttpGet]
        public ActionResult Index()
        {
            //var Sales = from e in db.TTemp
            //         orderby e.ID
            //         select e;

            //return View(Sales);

            // Row Count: 1
            DataTable tdy_sales_dt = clsTrash.TOrderTransaction_TdySales();

            // DataTable is Like List
            // Get Value

            DataRow tdy_sales_obj = tdy_sales_dt.Rows[0];

            ViewData["total_today_sales_transaction"] = clsCommon.ToDbl(tdy_sales_obj["total_today_sales_transaction"]);
            ViewData["total_today_num_order"] = clsCommon.ToDbl(tdy_sales_obj["total_today_num_order"]);
            ViewData["total_today_num_refunds"] = clsCommon.ToDbl(tdy_sales_obj["total_today_num_refunds"]);

            // Data Is Stored Here
            List<clsTTemp> itemLs = clsTTemp.GetAllList(-1);

            int num = itemLs.Count;

            ViewData["Trash"] = "Hello, World";

            // for (int ind = 0; ind <= tdy_sales_dt.Rows.Count - 1; ind++)
            // {
            //     DataRow dr = tdy_sales_dt.Rows[ind];

            //     obj.Id = clsCommon.ToInt(dr["Id"]);
            //     obj.Title = clsCommon.ToStr(dr["Title"]);
            //     obj.Quantity = clsCommon.ToInt(dr["Quantity"]);
            //     obj.Price = clsCommon.ToDbl(dr["Price"]);
            //     obj.Category = clsCommon.ToStr(dr["Category"]);
            //     obj.MetaData = clsCommon.ToStr(dr["MetaData"]);
            //     obj.Created_By = clsCommon.ToStr(dr["Created_By"]);
            //     obj.Created_At = clsCommon.ToDateTime(dr["Created_At"]).ToString(clsConst.constDate_SQLDateFmt);
            // }

            return View();
        }
    }
}