using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project_isf.Domain.POCO;
using project_isf.Domain.Concrete;

namespace project_isf.Controllers
{
    public class NSFRepresentativeController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /NSFRepresentative/

        public ActionResult Index()
        {
            var nsfrepresentatives = db.NSFRepresentatives.Include(n => n.Region);
            return View(nsfrepresentatives.ToList());
        }

        //
        // GET: /NSFRepresentative/Details/5

        public ActionResult Details(int id = 0)
        {
            NSFRepresentative nsfrepresentative = db.NSFRepresentatives.Find(id);
            if (nsfrepresentative == null)
            {
                return HttpNotFound();
            }
            return View(nsfrepresentative);
        }

        //
        // GET: /NSFRepresentative/Create

        public ActionResult Create()
        {
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name");
            return View();
        }

        //
        // POST: /NSFRepresentative/Create

        [HttpPost]
        public ActionResult Create(NSFRepresentative nsfrepresentative)
        {
            if (ModelState.IsValid)
            {
                db.NSFRepresentatives.Add(nsfrepresentative);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", nsfrepresentative.RegionId);
            return View(nsfrepresentative);
        }

        //
        // GET: /NSFRepresentative/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NSFRepresentative nsfrepresentative = db.NSFRepresentatives.Find(id);
            if (nsfrepresentative == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", nsfrepresentative.RegionId);
            return View(nsfrepresentative);
        }

        //
        // POST: /NSFRepresentative/Edit/5

        [HttpPost]
        public ActionResult Edit(NSFRepresentative nsfrepresentative)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nsfrepresentative).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", nsfrepresentative.RegionId);
            return View(nsfrepresentative);
        }

        //
        // GET: /NSFRepresentative/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NSFRepresentative nsfrepresentative = db.NSFRepresentatives.Find(id);
            if (nsfrepresentative == null)
            {
                return HttpNotFound();
            }
            return View(nsfrepresentative);
        }

        //
        // POST: /NSFRepresentative/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NSFRepresentative nsfrepresentative = db.NSFRepresentatives.Find(id);
            db.NSFRepresentatives.Remove(nsfrepresentative);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}