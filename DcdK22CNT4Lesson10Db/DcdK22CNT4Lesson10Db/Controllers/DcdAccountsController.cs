using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DcdK22CNT4Lesson10Db.Models;

namespace DcdK22CNT4Lesson10Db.Controllers
{
    public class DcdAccountsController : Controller
    {
        private DcdK22CNT4Lesson10DbEntities db = new DcdK22CNT4Lesson10DbEntities();

        // GET: DcdAccounts
        public ActionResult Index()
        {
            return View(db.DcdAccount.ToList());
        }

        // GET: DcdAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdAccount dcdAccount = db.DcdAccount.Find(id);
            if (dcdAccount == null)
            {
                return HttpNotFound();
            }
            return View(dcdAccount);
        }

        // GET: DcdAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DcdAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DcdID,DcdUserName,DcdPassword,DcdFullName,DcdEmail,DcdPhone,DcdActive")] DcdAccount dcdAccount)
        {
            if (ModelState.IsValid)
            {
                db.DcdAccount.Add(dcdAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dcdAccount);
        }

        // GET: DcdAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdAccount dcdAccount = db.DcdAccount.Find(id);
            if (dcdAccount == null)
            {
                return HttpNotFound();
            }
            return View(dcdAccount);
        }

        // POST: DcdAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DcdID,DcdUserName,DcdPassword,DcdFullName,DcdEmail,DcdPhone,DcdActive")] DcdAccount dcdAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dcdAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dcdAccount);
        }

        // GET: DcdAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DcdAccount dcdAccount = db.DcdAccount.Find(id);
            if (dcdAccount == null)
            {
                return HttpNotFound();
            }
            return View(dcdAccount);
        }

        // POST: DcdAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DcdAccount dcdAccount = db.DcdAccount.Find(id);
            db.DcdAccount.Remove(dcdAccount);
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
        //login 
        public ActionResult DcdLogin()
        {
            var dcdmodel = new DcdAccount();
            return View(dcdmodel);
        }
    }
}
