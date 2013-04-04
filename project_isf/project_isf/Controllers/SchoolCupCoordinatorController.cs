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
    public class SchoolCupCoordinatorController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /SchoolCupCoordinator/

        public ActionResult Index()
        {
            var schoolcupcoordinators = db.SchoolCupCoordinators.Include(s => s.Region).Include(s => s.School);
            return View(schoolcupcoordinators.ToList());
        }

        //
        // GET: /SchoolCupCoordinator/Details/5

        public ActionResult Details(int id = 0)
        {
            SchoolCupCoordinator schoolcupcoordinator = db.SchoolCupCoordinators.Find(id);
            if (schoolcupcoordinator == null)
            {
                return HttpNotFound();
            }
            return View(schoolcupcoordinator);
        }

        //
        // GET: /SchoolCupCoordinator/Create

        public ActionResult Create()
        {
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name");
            ViewBag.SchoolId = new SelectList(db.Schools, "SchoolId", "Name");
            return View();
        }

        //
        // POST: /SchoolCupCoordinator/Create

        [HttpPost]
        public ActionResult Create(SchoolCupCoordinator schoolcupcoordinator)
        {
            if (ModelState.IsValid)
            {
                db.SchoolCupCoordinators.Add(schoolcupcoordinator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", schoolcupcoordinator.RegionId);
            ViewBag.SchoolId = new SelectList(db.Schools, "SchoolId", "Name", schoolcupcoordinator.SchoolId);
            return View(schoolcupcoordinator);
        }

        //
        // GET: /SchoolCupCoordinator/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SchoolCupCoordinator schoolcupcoordinator = db.SchoolCupCoordinators.Find(id);
            if (schoolcupcoordinator == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", schoolcupcoordinator.RegionId);
            ViewBag.SchoolId = new SelectList(db.Schools, "SchoolId", "Name", schoolcupcoordinator.SchoolId);
            return View(schoolcupcoordinator);
        }

        //
        // POST: /SchoolCupCoordinator/Edit/5

        [HttpPost]
        public ActionResult Edit(SchoolCupCoordinator schoolcupcoordinator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolcupcoordinator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", schoolcupcoordinator.RegionId);
            ViewBag.SchoolId = new SelectList(db.Schools, "SchoolId", "Name", schoolcupcoordinator.SchoolId);
            return View(schoolcupcoordinator);
        }

        //
        // GET: /SchoolCupCoordinator/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SchoolCupCoordinator schoolcupcoordinator = db.SchoolCupCoordinators.Find(id);
            if (schoolcupcoordinator == null)
            {
                return HttpNotFound();
            }
            return View(schoolcupcoordinator);
        }

        //
        // POST: /SchoolCupCoordinator/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SchoolCupCoordinator schoolcupcoordinator = db.SchoolCupCoordinators.Find(id);
            db.SchoolCupCoordinators.Remove(schoolcupcoordinator);
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