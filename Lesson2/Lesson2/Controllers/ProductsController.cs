using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ https://localhost:44305/Products
        public ActionResult Index()
        {
            ViewBag.name = "Đinh Công Định - 2210900095";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string GetName()
        {
            return "Đinh Công Định - 2210900095";
        }
        public JsonResult ListName()
        {
            string[] names = { "Hùng", "Dũng", "Sang", "Trọng" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}