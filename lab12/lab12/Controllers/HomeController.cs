using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult VNU()
        {
            //render the view file in location: Views/Home/VNU.cshtml
            //use empty layout
            return View();
        }

        public ActionResult Hanoi()
        {
            //Location: Views/Home/Hanoi.cshtml
            //use default layout
            return View();
        }
    }
}