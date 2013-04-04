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
    public class ContinentController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /Continent/

        public ActionResult Index()
        {
            return View(db.Continents.ToList());
        }

        //
        // GET: /Continent/Details/5

        public ActionResult Details(int id = 0)
        {
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        //
        // GET: /Continent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Continent/Create

        [HttpPost]
        public ActionResult Create(Continent continent)
        {
            if (ModelState.IsValid)
            {
                db.Continents.Add(continent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(continent);
        }

        //
        // GET: /Continent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        //
        // POST: /Continent/Edit/5

        [HttpPost]
        public ActionResult Edit(Continent continent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(continent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(continent);
        }

        //
        // GET: /Continent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return HttpNotFound();
            }
            return View(continent);
        }

        //
        // POST: /Continent/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Continent continent = db.Continents.Find(id);
            db.Continents.Remove(continent);
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