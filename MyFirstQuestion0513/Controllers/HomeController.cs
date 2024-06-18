using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flora_Assignment1.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //Home/Season
        public ActionResult Season(int? num) 
        {
            if(num == null) {
                ViewBag.Temp = "Unknown";
                    }
            else ViewBag.Temp = num;
            return View();
        }
    }
}
