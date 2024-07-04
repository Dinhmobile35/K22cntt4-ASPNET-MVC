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
    public class DcdProductsController : Controller
    {
        private DcdK22CNT4Lesson11DbEntities db = new DcdK22CNT4Lesson11DbEntities();

        // GET: DcdProducts
        public ActionResult DcdIndex()
        {
            var dcdProduct = db.DcdProduct.Include(d => d.DcdCategory);
            return View(dcdProduct.ToList());
        }

        // GET: DcdProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdProduct dcdProduct = db.DcdProduct.Find(id);
            if (dcdProduct == null)
            {
                return HttpNotFound();
            }
            return View(dcdProduct);
        }

        // GET: DcdProducts/Create
        public ActionResult Create()
        {
            ViewBag.DcdCateId = new SelectList(db.DcdCategory, "DcdID", "DcdCateName");
            return View();
        }

        // POST: DcdProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdId2210900095,DcdProName,DcdQty,DcdPrice,DcdCateId,DcdActive")] DcdProduct dcdProduct)
        {
            if (ModelState.IsValid)
            {
                db.DcdProduct.Add(dcdProduct);
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }

            ViewBag.DcdCateId = new SelectList(db.DcdCategory, "DcdID", "DcdCateName", dcdProduct.DcdCateId);
            return View(dcdProduct);
        }

        // GET: DcdProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdProduct dcdProduct = db.DcdProduct.Find(id);
            if (dcdProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.DcdCateId = new SelectList(db.DcdCategory, "DcdID", "DcdCateName", dcdProduct.DcdCateId);
            return View(dcdProduct);
        }

        // POST: DcdProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdId2210900095,DcdProName,DcdQty,DcdPrice,DcdCateId,DcdActive")] DcdProduct dcdProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }
            ViewBag.DcdCateId = new SelectList(db.DcdCategory, "DcdID", "DcdCateName", dcdProduct.DcdCateId);
            return View(dcdProduct);
        }

        // GET: DcdProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdProduct dcdProduct = db.DcdProduct.Find(id);
            if (dcdProduct == null)
            {
                return HttpNotFound();
            }
            return View(dcdProduct);
        }

        // POST: DcdProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DcdProduct dcdProduct = db.DcdProduct.Find(id);
            db.DcdProduct.Remove(dcdProduct);
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
