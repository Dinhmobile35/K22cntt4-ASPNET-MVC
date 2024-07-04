using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DcdK22CNT4Lesson11_2210900095.Models;

namespace DcdK22CNT4Lesson11_2210900095.Controllers
{
    public class DcdCategoriesController : Controller
    {
        private DcdK22CNT4Lesson11DbEntities db = new DcdK22CNT4Lesson11DbEntities();

        // GET: DcdCategories
        public ActionResult DcdIndex()
        {
            return View(db.DcdCategory.ToList());
        }

        // GET: DcdCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdCategory dcdCategory = db.DcdCategory.Find(id);
            if (dcdCategory == null)
            {
                return HttpNotFound();
            }
            return View(dcdCategory);
        }

        // GET: DcdCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DcdCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdID,DcdCateName,DcdStatus")] DcdCategory dcdCategory)
        {
            if (ModelState.IsValid)
            {
                db.DcdCategory.Add(dcdCategory);
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }

            return View(dcdCategory);
        }

        // GET: DcdCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdCategory dcdCategory = db.DcdCategory.Find(id);
            if (dcdCategory == null)
            {
                return HttpNotFound();
            }
            return View(dcdCategory);
        }

        // POST: DcdCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdID,DcdCateName,DcdStatus")] DcdCategory dcdCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }
            return View(dcdCategory);
        }

        // GET: DcdCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdCategory dcdCategory = db.DcdCategory.Find(id);
            if (dcdCategory == null)
            {
                return HttpNotFound();
            }
            return View(dcdCategory);
        }

        // POST: DcdCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DcdCategory dcdCategory = db.DcdCategory.Find(id);
            db.DcdCategory.Remove(dcdCategory);
            db.SaveChanges();
            return RedirectToAction("DcdIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
