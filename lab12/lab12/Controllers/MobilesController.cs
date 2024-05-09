using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lab12.Data;
using lab12.Models;

namespace lab12.Controllers
{
    public class MobilesController : Controller
    {
        private lab12Context db = new lab12Context();

        // GET: Mobiles
        public ActionResult Index()
        {
            return View(db.Mobiles.ToList());
        }

        // GET: Mobiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile mobile = db.Mobiles.Find(id);
            if (mobile == null)
            {
                return HttpNotFound();
            }
            return View(mobile);
        }

        // GET: Mobiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mobiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price")] Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                db.Mobiles.Add(mobile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mobile);
        }

        // GET: Mobiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile mobile = db.Mobiles.Find(id);
            if (mobile == null)
            {
                return HttpNotFound();
            }
            return View(mobile);
        }

        // POST: Mobiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price")] Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mobile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mobile);
        }

        // GET: Mobiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile mobile = db.Mobiles.Find(id);
            if (mobile == null)
            {
                return HttpNotFound();
            }
            return View(mobile);
        }

        // POST: Mobiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mobile mobile = db.Mobiles.Find(id);
            db.Mobiles.Remove(mobile);
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
