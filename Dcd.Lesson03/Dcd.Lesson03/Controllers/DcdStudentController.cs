using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dcd.Lesson03.Controllers
{
    public class DcdStudentController : Controller
    {
        /// <summary>
        /// Author : Đinh Công Định
        /// Class : K22Cntt4
        /// </summary>
        /// <returns></returns>
        // GET: DcdStudent
        public ActionResult Index()
        {
            return View();
        }
    }
}