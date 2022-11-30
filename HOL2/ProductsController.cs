using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Models.product p = new Models.product();
            //pass a list of products to the view
            return View(p.GetProducts());
        }
    }
}