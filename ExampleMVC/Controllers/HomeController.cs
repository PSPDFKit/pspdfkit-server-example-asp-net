using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult StandaloneExample()
        {
            ViewBag.Message = "StandaloneExample";

            return View();
        }

        public ActionResult ServerExample()
        {
            ViewBag.Message = "ServerExample";

            return View();
        }
    }
}