using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjectManager.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Your application user page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your projects page.";

            return View();
        }

        public ActionResult Allocations()
        {
            ViewBag.Message = "Your project allocation page.";

            return View();
        }
    }
}
