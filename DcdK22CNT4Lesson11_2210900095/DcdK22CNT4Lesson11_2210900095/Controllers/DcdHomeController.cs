using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DcdK22CNT4Lesson11_2210900095.Controllers
{
    public class DcdHomeController : Controller
    {
        public ActionResult DcdIndex()
        {
            return View();
        }

        public ActionResult DcdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DcdContact()
        {
            ViewBag.msv = "2210900095.";
            ViewBag.fullname = "Đinh Công Định.";

            return View();
        }
    }
}