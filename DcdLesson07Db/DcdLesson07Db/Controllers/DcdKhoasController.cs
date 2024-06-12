using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DcdLesson07Db.Models;

namespace DcdLesson07Db.Controllers
{
    public class DcdKhoasController : Controller
    {
        private DcdK22CNT4Lesson07DbEntities db = new DcdK22CNT4Lesson07DbEntities();

        // GET: DcdKhoas
        public ActionResult DcdIndex()
        {
            return View(db.dcdKhoa.ToList());
        }

        // GET: DcdKhoas/Details/5
        public ActionResult DcdDetails(string id)
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

        // GET: DcdKhoas/Create
        public ActionResult DcdCreate()
        {
            return View();
        }

        // POST: DcdKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DcdCreate([Bind(Include = "DcdMaKH,DcdTenKH,DcdTrangThai")] dcdKhoa dcdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.dcdKhoa.Add(dcdKhoa);
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }

            return View(dcdKhoa);
        }

        // GET: DcdKhoas/Edit/5
        public ActionResult DcdEdit(string id)
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

        // POST: DcdKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DcdEdit([Bind(Include = "DcdMaKH,DcdTenKH,DcdTrangThai")] dcdKhoa dcdKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }
            return View(dcdKhoa);
        }

        // GET: DcdKhoas/Delete/5
        public ActionResult DcdDelete(string id)
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

        // POST: DcdKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dcdKhoa dcdKhoa = db.dcdKhoa.Find(id);
            db.dcdKhoa.Remove(dcdKhoa);
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
