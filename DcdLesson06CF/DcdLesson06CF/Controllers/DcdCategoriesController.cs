using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DcdLesson06CF.Models;

namespace DcdLesson06CF.Controllers
{
    public class DcdCategoriesController : Controller
    {
        private static DcdBookStore dcdDb;
        public DcdCategoriesController()
        {
            dcdDb = new DcdBookStore();
        }
        // GET: DcdCategories
        public ActionResult DcdIndex()
        {
            /*
             * Khởi tạo DbContext
             * Ef sẽ tìm thông tin kết nối trong file machinee.config của .Net  Frameword trên máy 
             * và sau đó tạo csdl 
             * */
           // DcdBookStore dcdDb = new DcdBookStore();
            var dcdCategories = dcdDb.DcdCategories.ToList();
            return View(dcdCategories); 
        }
        public ActionResult DcdCreate()
        {
            var dcdCategory = new DcdCategory();
            return View(dcdCategory);
        }
        [HttpPost]
        public ActionResult DcdCreate(DcdCategory dcdCategory)
        {
            dcdDb.DcdCategories.Add(dcdCategory);
            dcdDb.SaveChanges();    



            return RedirectToAction("DcdIndex");
        }
    }
}