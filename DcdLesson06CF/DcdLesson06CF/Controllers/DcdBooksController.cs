using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DcdLesson06CF.Models;

namespace DcdLesson06CF.Controllers
{
    public class DcdBooksController : Controller
    {
        private DcdBookStore db = new DcdBookStore();

        // GET: DcdBooks
        public ActionResult Index()
        {
            return View(db.DcdBooks.ToList());
        }

        // GET: DcdBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdBook dcdBook = db.DcdBooks.Find(id);
            if (dcdBook == null)
            {
                return HttpNotFound();
            }
            return View(dcdBook);
        }

        // GET: DcdBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DcdBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdId,DcdBookId,DcdTitle,DcdAuthor,DcdYear,DcdPulisher,DcdPicture,DcdCategoryId")] DcdBook dcdBook)
        {
            if (ModelState.IsValid)
            {
                db.DcdBooks.Add(dcdBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dcdBook);
        }

        // GET: DcdBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdBook dcdBook = db.DcdBooks.Find(id);
            if (dcdBook == null)
            {
                return HttpNotFound();
            }
            return View(dcdBook);
        }

        // POST: DcdBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdId,DcdBookId,DcdTitle,DcdAuthor,DcdYear,DcdPulisher,DcdPicture,DcdCategoryId")] DcdBook dcdBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dcdBook);
        }

        // GET: DcdBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdBook dcdBook = db.DcdBooks.Find(id);
            if (dcdBook == null)
            {
                return HttpNotFound();
            }
            return View(dcdBook);
        }

        // POST: DcdBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DcdBook dcdBook = db.DcdBooks.Find(id);
            db.DcdBooks.Remove(dcdBook);
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
