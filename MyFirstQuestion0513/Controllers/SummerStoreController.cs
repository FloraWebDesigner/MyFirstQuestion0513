using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstQuestion0513.Controllers
{
    public class SummerStoreController : Controller
    {
        // GET: SummerStore/Index -> a webpage
        public ActionResult Index()
        {
            // Route to Views/SummerStore/Index.cshtml
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        //GET: SummerStore/Checkout -> an order summary webpage
        // localhost:54050/summerstore/Checkout?GlassNum=7&TowelSize=L&CustomerName=Flora
/*
        [HttpPost]
        //FORM DATA:
        public ActionResult Checkout(string GlassesNum, string TowelSize, string CustomerName) 
        {
            //pass along the order information to the view
            ViewData["CustomerName"] = CustomerName;
            ViewData["GlassNum"] = GlassesNum;
            ViewData["TowelSize"] = TowelSize;

            // Small - 10
            // Medium - 15
            // large - 20
            //Each pair of sunglasses - 5
           int OrderTotal = 0;
            if(TowelSize=="S")
            { OrderTotal = 10; }
            else if(TowelSize=="M")
            { OrderTotal = 15; }
            else if(TowelSize=="L")
            { OrderTotal= 20; }
            OrderTotal = OrderTotal * (int)GlassesNum;

            return View();

        }
        */
    }
}