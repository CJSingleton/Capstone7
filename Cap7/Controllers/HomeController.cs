using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cap7.Models;

namespace Cap7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }



        

       
        

    }

    //public class ProductInfo
    //{
    //    private productid;
    //    private productname;

    //}
}
