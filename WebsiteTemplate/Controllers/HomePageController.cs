using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace WebsiteTemplate.Controllers
{
    public class HomePageController : Controller
    {
        private TestingDBContext db = new TestingDBContext();
        // GET: HomePage
        [HttpGet]
        public ActionResult Index()
        {
            var Sales = from e in db.TTemp
                     orderby e.ID
                     select e;

            return View(Sales);
        }
    }
}