using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteTemplate.Models;

namespace WebsiteTemplate.Controllers
{
    public class HomePageController : Controller
    {

        // GET: HomePage
        [HttpGet]
        public ActionResult Index()
        {
            //// Row Count: 1
            //DataTable tdy_sales_dt = clsTrash.TOrderTransaction_TdySales();

            //// DataTable is Like List
            //// Get Value

            //DataRow tdy_sales_obj = tdy_sales_dt.Rows[0];

            //ViewData["total_today_sales_transaction"] = clsCommon.ToDbl(tdy_sales_obj["total_today_sales_transaction"]);
            //ViewData["total_today_num_order"] = clsCommon.ToDbl(tdy_sales_obj["total_today_num_order"]);
            //ViewData["total_today_num_refunds"] = clsCommon.ToDbl(tdy_sales_obj["total_today_num_refunds"]);

            //// Data Is Stored Here
            //// YouTube Tutorial
            //List<clsTTemp> itemLs = clsTTemp.GetAllList(-1);

            ////Testing
            ////int num = itemLs.Count;

            //ViewData["Trash"] = "Hello, World";

            DataTable todaySales_Dt = clsTrash.SalesToday();
            DataRow todaySales_Dt_obj = todaySales_Dt.Rows[0];
            ViewData["Total_TodaySales"] = clsCommon.ToDbl(todaySales_Dt_obj["TotalSales"]);

            DataTable lastWeekSales_Dt = clsTrash.SalesLastWeek();
            DataRow lastWeekSales_Dt_obj = lastWeekSales_Dt.Rows[0];
            ViewData["Total_LastWeekSales"] = clsCommon.ToDbl(lastWeekSales_Dt_obj["TotalSales"]);

            DataTable lastMonthSales_Dt = clsTrash.SalesLastMonth();
            DataRow lastMonthSales_Dt_obj = lastMonthSales_Dt.Rows[0];
            ViewData["Total_LastMonthSales"] = clsCommon.ToDbl(lastMonthSales_Dt_obj["TotalSales"]);


            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("Today Sales",(Double)ViewData["Total_TodaySales"]));
            dataPoints.Add(new DataPoint("Last Week Sales", (Double)ViewData["Total_LastWeekSales"]));
            dataPoints.Add(new DataPoint("Last Month Sales", (Double)ViewData["Total_LastMonthSales"]));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }
    }
}