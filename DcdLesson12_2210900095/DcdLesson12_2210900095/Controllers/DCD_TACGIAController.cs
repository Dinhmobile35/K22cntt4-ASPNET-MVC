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
    public class DCD_TACGIAController : Controller
    {
        private DinhCongDinh_2210900095Entities2 db = new DinhCongDinh_2210900095Entities2();

        // GET: DCD_TACGIA
        public ActionResult DcdIndex()
        {
            return View(db.DCD_TACGIA.ToList());
        }

        // GET: DCD_TACGIA/Details/5
        public ActionResult DcdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCD_TACGIA dCD_TACGIA = db.DCD_TACGIA.Find(id);
            if (dCD_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(dCD_TACGIA);
        }

        // GET: DCD_TACGIA/Create
        public ActionResult DcdCreate()
        {
            return View();
        }

        // POST: DCD_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DcdCreate([Bind(Include = "Dcd_MaTG,Dcd_TenTG")] DCD_TACGIA dCD_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.DCD_TACGIA.Add(dCD_TACGIA);
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }

            return View(dCD_TACGIA);
        }

        // GET: DCD_TACGIA/Edit/5
        public ActionResult DcdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCD_TACGIA dCD_TACGIA = db.DCD_TACGIA.Find(id);
            if (dCD_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(dCD_TACGIA);
        }

        // POST: DCD_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DcdEdit([Bind(Include = "Dcd_MaTG,Dcd_TenTG")] DCD_TACGIA dCD_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dCD_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DcdIndex");
            }
            return View(dCD_TACGIA);
        }

        // GET: DCD_TACGIA/Delete/5
        public ActionResult DcdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DCD_TACGIA dCD_TACGIA = db.DCD_TACGIA.Find(id);
            if (dCD_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(dCD_TACGIA);
        }

        // POST: DCD_TACGIA/Delete/5
        [HttpPost, ActionName("DcdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DcdDeleteConfirmed(string id)
        {
            DCD_TACGIA dCD_TACGIA = db.DCD_TACGIA.Find(id);
            db.DCD_TACGIA.Remove(dCD_TACGIA);
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
