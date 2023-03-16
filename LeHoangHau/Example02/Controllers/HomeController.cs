using Example02.Context;
using Example02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example02.Controllers
{
    public class HomeController : Controller
    {
        hauEntities1 objhauEntities1 = new hauEntities1();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();

            objHomeModel.ListCategory = objhauEntities1.Categories.ToList();
            objHomeModel.ListProduct= objhauEntities1.Products.ToList();
            return View(objHomeModel);
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