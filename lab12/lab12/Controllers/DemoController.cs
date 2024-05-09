using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab12.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            //pass data to front-end (view)
            //1st way: using ViewBag
            ViewBag.VN = "Việt Nam";
            //2nd way: using ViewData
            ViewData["HN"] = "Hà Nội";
            return View();
        }
    }
}