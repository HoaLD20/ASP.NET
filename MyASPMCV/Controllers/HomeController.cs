using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseIO;
using DatabaseProvider;

namespace MyASPMCV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBIO db = new DBIO();
            user u = db.getObjectUser("hoa", "123");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}