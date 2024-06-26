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
    public class dcdKetQuasController : Controller
    {
        private DcdK22CNT4Lesson09DbEntities5 db = new DcdK22CNT4Lesson09DbEntities5();

        // GET: dcdKetQuas
        public ActionResult Index()
        {
            var dcdKetQua = db.dcdKetQua.Include(d => d.dcdMonHoc).Include(d => d.dcdSinhVien);
            return View(dcdKetQua.ToList());
        }

        // GET: dcdKetQuas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdKetQua dcdKetQua = db.dcdKetQua.Find(id);
            if (dcdKetQua == null)
            {
                return HttpNotFound();
            }
            return View(dcdKetQua);
        }

        // GET: dcdKetQuas/Create
        public ActionResult Create()
        {
            ViewBag.dcdMaMH = new SelectList(db.dcdMonHoc, "DcdMaMH", "DcdTenMH");
            ViewBag.dcdMaSV = new SelectList(db.dcdSinhVien, "DcdMaSV", "DcdHoSV");
            return View();
        }

        // POST: dcdKetQuas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dcdMaSV,dcdMaMH,Diem")] dcdKetQua dcdKetQua)
        {
            if (ModelState.IsValid)
            {
                db.dcdKetQua.Add(dcdKetQua);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.dcdMaMH = new SelectList(db.dcdMonHoc, "DcdMaMH", "DcdTenMH", dcdKetQua.dcdMaMH);
            ViewBag.dcdMaSV = new SelectList(db.dcdSinhVien, "DcdMaSV", "DcdHoSV", dcdKetQua.dcdMaSV);
            return View(dcdKetQua);
        }

        // GET: dcdKetQuas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdKetQua dcdKetQua = db.dcdKetQua.Find(id);
            if (dcdKetQua == null)
            {
                return HttpNotFound();
            }
            ViewBag.dcdMaMH = new SelectList(db.dcdMonHoc, "DcdMaMH", "DcdTenMH", dcdKetQua.dcdMaMH);
            ViewBag.dcdMaSV = new SelectList(db.dcdSinhVien, "DcdMaSV", "DcdHoSV", dcdKetQua.dcdMaSV);
            return View(dcdKetQua);
        }

        // POST: dcdKetQuas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dcdMaSV,dcdMaMH,Diem")] dcdKetQua dcdKetQua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdKetQua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.dcdMaMH = new SelectList(db.dcdMonHoc, "DcdMaMH", "DcdTenMH", dcdKetQua.dcdMaMH);
            ViewBag.dcdMaSV = new SelectList(db.dcdSinhVien, "DcdMaSV", "DcdHoSV", dcdKetQua.dcdMaSV);
            return View(dcdKetQua);
        }

        // GET: dcdKetQuas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdKetQua dcdKetQua = db.dcdKetQua.Find(id);
            if (dcdKetQua == null)
            {
                return HttpNotFound();
            }
            return View(dcdKetQua);
        }

        // POST: dcdKetQuas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dcdKetQua dcdKetQua = db.dcdKetQua.Find(id);
            db.dcdKetQua.Remove(dcdKetQua);
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
