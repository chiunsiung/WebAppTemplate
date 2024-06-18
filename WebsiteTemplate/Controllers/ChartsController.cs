using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteTemplate.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult Index()
        {
            var chartData = new
            {
                labels = new[] { "January", "February", "March", "April", "May", "June", "July" },
                datasets = new[]
               {
                    new {
                        label = "My First dataset",
                        backgroundColor = "rgba(75, 192, 192, 0.2)",
                        borderColor = "rgba(75, 192, 192, 1)",
                        pointBackgroundColor = "rgba(75, 192, 192, 1)",
                        pointBorderColor = "#fff",
                        data = new[] { 65, 59, 80, 81, 56, 55, 40 }
                    }
                }
            };

            ViewBag.ChartData = Newtonsoft.Json.JsonConvert.SerializeObject(chartData);
            return View();
        }
    }
}