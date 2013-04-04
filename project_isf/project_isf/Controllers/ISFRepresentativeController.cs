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
    public class ISFRepresentativeController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /ISFRepresentative/

        public ActionResult Index()
        {
            var isfrepresantives = db.ISFRepresantives.Include(i => i.Region);
            return View(isfrepresantives.ToList());
        }

        //
        // GET: /ISFRepresentative/Details/5

        public ActionResult Details(int id = 0)
        {
            ISFRepresentative isfrepresentative = db.ISFRepresantives.Find(id);
            if (isfrepresentative == null)
            {
                return HttpNotFound();
            }
            return View(isfrepresentative);
        }

        //
        // GET: /ISFRepresentative/Create

        public ActionResult Create()
        {
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name");
            return View();
        }

        //
        // POST: /ISFRepresentative/Create

        [HttpPost]
        public ActionResult Create(ISFRepresentative isfrepresentative)
        {
            if (ModelState.IsValid)
            {
                db.ISFRepresantives.Add(isfrepresentative);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", isfrepresentative.RegionId);
            return View(isfrepresentative);
        }

        //
        // GET: /ISFRepresentative/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ISFRepresentative isfrepresentative = db.ISFRepresantives.Find(id);
            if (isfrepresentative == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", isfrepresentative.RegionId);
            return View(isfrepresentative);
        }

        //
        // POST: /ISFRepresentative/Edit/5

        [HttpPost]
        public ActionResult Edit(ISFRepresentative isfrepresentative)
        {
            if (ModelState.IsValid)
            {
                db.Entry(isfrepresentative).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", isfrepresentative.RegionId);
            return View(isfrepresentative);
        }

        //
        // GET: /ISFRepresentative/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ISFRepresentative isfrepresentative = db.ISFRepresantives.Find(id);
            if (isfrepresentative == null)
            {
                return HttpNotFound();
            }
            return View(isfrepresentative);
        }

        //
        // POST: /ISFRepresentative/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ISFRepresentative isfrepresentative = db.ISFRepresantives.Find(id);
            db.ISFRepresantives.Remove(isfrepresentative);
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