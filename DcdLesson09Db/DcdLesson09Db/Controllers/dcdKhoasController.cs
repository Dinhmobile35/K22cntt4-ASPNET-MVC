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
    public class dcdKhoasController : Controller
    {
        private DcdK22CNT4Lesson09DbEntities4 db = new DcdK22CNT4Lesson09DbEntities4();

        // GET: dcdKhoas
        public ActionResult Index()
        {
            return View(db.dcdKhoa.ToList());
        }

        // GET: dcdKhoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdKhoa dcdKhoa = db.dcdKhoa.Find(id);
            if (dcdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dcdKhoa);
        }

        // GET: dcdKhoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dcdKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdMaKH,DcdTenKH")] dcdKhoa dcdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.dcdKhoa.Add(dcdKhoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dcdKhoa);
        }

        // GET: dcdKhoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdKhoa dcdKhoa = db.dcdKhoa.Find(id);
            if (dcdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dcdKhoa);
        }

        // POST: dcdKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdMaKH,DcdTenKH")] dcdKhoa dcdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dcdKhoa);
        }

        // GET: dcdKhoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdKhoa dcdKhoa = db.dcdKhoa.Find(id);
            if (dcdKhoa == null)
            {
                return HttpNotFound();
            }
            return View(dcdKhoa);
        }

        // POST: dcdKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dcdKhoa dcdKhoa = db.dcdKhoa.Find(id);
            db.dcdKhoa.Remove(dcdKhoa);
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
