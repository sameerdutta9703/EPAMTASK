using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Session["UserName"] = "Sameer".ToString();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            string name = Session["UserName"].ToString();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}