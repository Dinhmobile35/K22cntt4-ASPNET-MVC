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
    public class dcdSinhViensController : Controller
    {
        private DcdK22CNT4Lesson09DbEntities5 db = new DcdK22CNT4Lesson09DbEntities5();

        // GET: dcdSinhViens
        public ActionResult Index()
        {
            var dcdSinhVien = db.dcdSinhVien.Include(d => d.dcdKhoa);
            return View(dcdSinhVien.ToList());
        }

        // GET: dcdSinhViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdSinhVien dcdSinhVien = db.dcdSinhVien.Find(id);
            if (dcdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dcdSinhVien);
        }

        // GET: dcdSinhViens/Create
        public ActionResult Create()
        {
            ViewBag.DcdMaKH = new SelectList(db.dcdKhoa, "DcdMaKH", "DcdTenKH");
            return View();
        }

        // POST: dcdSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdMaSV,DcdHoSV,DcdTenSV,DcdPhai,DcdNgaySinh,DcdNoiSinh,DcdMaKH,DcdHocBong,DcdDiemTrungBinh")] dcdSinhVien dcdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.dcdSinhVien.Add(dcdSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DcdMaKH = new SelectList(db.dcdKhoa, "DcdMaKH", "DcdTenKH", dcdSinhVien.DcdMaKH);
            return View(dcdSinhVien);
        }

        // GET: dcdSinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdSinhVien dcdSinhVien = db.dcdSinhVien.Find(id);
            if (dcdSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.DcdMaKH = new SelectList(db.dcdKhoa, "DcdMaKH", "DcdTenKH", dcdSinhVien.DcdMaKH);
            return View(dcdSinhVien);
        }

        // POST: dcdSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdMaSV,DcdHoSV,DcdTenSV,DcdPhai,DcdNgaySinh,DcdNoiSinh,DcdMaKH,DcdHocBong,DcdDiemTrungBinh")] dcdSinhVien dcdSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DcdMaKH = new SelectList(db.dcdKhoa, "DcdMaKH", "DcdTenKH", dcdSinhVien.DcdMaKH);
            return View(dcdSinhVien);
        }

        // GET: dcdSinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dcdSinhVien dcdSinhVien = db.dcdSinhVien.Find(id);
            if (dcdSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(dcdSinhVien);
        }

        // POST: dcdSinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dcdSinhVien dcdSinhVien = db.dcdSinhVien.Find(id);
            db.dcdSinhVien.Remove(dcdSinhVien);
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
