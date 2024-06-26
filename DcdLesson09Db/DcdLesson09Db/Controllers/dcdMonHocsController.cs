using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DcdLesson09Db.Models;

namespace DcdLesson09Db.Controllers
{
    public class dcdMonHocsController : Controller
    {
        private DcdK22CNT4Lesson09DbEntities5 db = new DcdK22CNT4Lesson09DbEntities5();

        // GET: dcdMonHocs
        public ActionResult Index()
        {
            return View(db.dcdMonHoc.ToList());
        }

        // GET: dcdMonHocs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdMonHoc dcdMonHoc = db.dcdMonHoc.Find(id);
            if (dcdMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(dcdMonHoc);
        }

        // GET: dcdMonHocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dcdMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdMaMH,DcdTenMH")] dcdMonHoc dcdMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.dcdMonHoc.Add(dcdMonHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dcdMonHoc);
        }

        // GET: dcdMonHocs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdMonHoc dcdMonHoc = db.dcdMonHoc.Find(id);
            if (dcdMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(dcdMonHoc);
        }

        // POST: dcdMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdMaMH,DcdTenMH")] dcdMonHoc dcdMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dcdMonHoc);
        }

        // GET: dcdMonHocs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdMonHoc dcdMonHoc = db.dcdMonHoc.Find(id);
            if (dcdMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(dcdMonHoc);
        }

        // POST: dcdMonHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dcdMonHoc dcdMonHoc = db.dcdMonHoc.Find(id);
            db.dcdMonHoc.Remove(dcdMonHoc);
            db.SaveChanges();
            return RedirectToAction("Index");
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
