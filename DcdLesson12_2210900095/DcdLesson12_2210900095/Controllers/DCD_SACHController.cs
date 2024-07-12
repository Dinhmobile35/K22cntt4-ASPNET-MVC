using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DcdLesson12_2210900095.Models;

namespace DcdLesson12_2210900095.Controllers
{
    public class DCD_SACHController : Controller
    {
        private DinhCongDinh_2210900095Entities2 db = new DinhCongDinh_2210900095Entities2();

        // GET: DCD_SACH
        public ActionResult DcdIndex()
        {
            var dCD_SACH = db.DCD_SACH.Include(d => d.DCD_TACGIA);
            return View(dCD_SACH.ToList());
        }

        // GET: DCD_SACH/Details/5
        public ActionResult DcdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCD_SACH dCD_SACH = db.DCD_SACH.Find(id);
            if (dCD_SACH == null)
            {
                return HttpNotFound();
            }
            return View(dCD_SACH);
        }

        // GET: DCD_SACH/Create
        public ActionResult DcdCreate()
        {
            ViewBag.Dcd_MaTG = new SelectList(db.DCD_TACGIA, "Dcd_MaTG", "Dcd_TenTG");
            return View();
        }

        // POST: DCD_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DcdCreate([Bind(Include = "Dcd_MaSach,Dcd_TenSach,Dcd_SoTrang,Dcd_NamXB,Dcd_MaTG,Dcd_TrangThai")] DCD_SACH dCD_SACH)
        {
            if (ModelState.IsValid)
            {
                db.DCD_SACH.Add(dCD_SACH);
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }

            ViewBag.Dcd_MaTG = new SelectList(db.DCD_TACGIA, "Dcd_MaTG", "Dcd_TenTG", dCD_SACH.Dcd_MaTG);
            return View(dCD_SACH);
        }

        // GET: DCD_SACH/Edit/5
        public ActionResult DcdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCD_SACH dCD_SACH = db.DCD_SACH.Find(id);
            if (dCD_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Dcd_MaTG = new SelectList(db.DCD_TACGIA, "Dcd_MaTG", "Dcd_TenTG", dCD_SACH.Dcd_MaTG);
            return View(dCD_SACH);
        }

        // POST: DCD_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DcdEdit([Bind(Include = "Dcd_MaSach,Dcd_TenSach,Dcd_SoTrang,Dcd_NamXB,Dcd_MaTG,Dcd_TrangThai")] DCD_SACH dCD_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dCD_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }
            ViewBag.Dcd_MaTG = new SelectList(db.DCD_TACGIA, "Dcd_MaTG", "Dcd_TenTG", dCD_SACH.Dcd_MaTG);
            return View(dCD_SACH);
        }

        // GET: DCD_SACH/Delete/5
        public ActionResult DcdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCD_SACH dCD_SACH = db.DCD_SACH.Find(id);
            if (dCD_SACH == null)
            {
                return HttpNotFound();
            }
            return View(dCD_SACH);
        }

        // POST: DCD_SACH/Delete/5
        [HttpPost, ActionName("DcdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DcdDeleteConfirmed(string id)
        {
            DCD_SACH dCD_SACH = db.DCD_SACH.Find(id);
            db.DCD_SACH.Remove(dCD_SACH);
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
