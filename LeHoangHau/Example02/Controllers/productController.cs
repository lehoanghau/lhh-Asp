using Example02.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example02.Controllers
{
    public class productController : Controller
    {
        hauEntities1 objhauEntities1 = new hauEntities1();
        //
        // GET: /product/
        public ActionResult Detail(int id)
        {
            var product = objhauEntities1.Products.Where(p => p.Id == id).FirstOrDefault();
            return View(product);
        }
	}
}