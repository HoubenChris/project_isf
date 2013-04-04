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
    public class AdvertisementLocationController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /AdvertisementLocation/

        public ActionResult Index()
        {
            var advertisementlocations = db.AdvertisementLocations.Include(a => a.Country).Include(a => a.Advertisement);
            return View(advertisementlocations.ToList());
        }

        //
        // GET: /AdvertisementLocation/Details/5

        public ActionResult Details(int id = 0)
        {
            AdvertisementLocation advertisementlocation = db.AdvertisementLocations.Find(id);
            if (advertisementlocation == null)
            {
                return HttpNotFound();
            }
            return View(advertisementlocation);
        }

        //
        // GET: /AdvertisementLocation/Create

        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            ViewBag.AdvertisementId = new SelectList(db.Advertisements, "AdvertisementId", "Company");
            return View();
        }

        //
        // POST: /AdvertisementLocation/Create

        [HttpPost]
        public ActionResult Create(AdvertisementLocation advertisementlocation)
        {
            if (ModelState.IsValid)
            {
                db.AdvertisementLocations.Add(advertisementlocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", advertisementlocation.CountryId);
            ViewBag.AdvertisementId = new SelectList(db.Advertisements, "AdvertisementId", "Company", advertisementlocation.AdvertisementId);
            return View(advertisementlocation);
        }

        //
        // GET: /AdvertisementLocation/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AdvertisementLocation advertisementlocation = db.AdvertisementLocations.Find(id);
            if (advertisementlocation == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", advertisementlocation.CountryId);
            ViewBag.AdvertisementId = new SelectList(db.Advertisements, "AdvertisementId", "Company", advertisementlocation.AdvertisementId);
            return View(advertisementlocation);
        }

        //
        // POST: /AdvertisementLocation/Edit/5

        [HttpPost]
        public ActionResult Edit(AdvertisementLocation advertisementlocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertisementlocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", advertisementlocation.CountryId);
            ViewBag.AdvertisementId = new SelectList(db.Advertisements, "AdvertisementId", "Company", advertisementlocation.AdvertisementId);
            return View(advertisementlocation);
        }

        //
        // GET: /AdvertisementLocation/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AdvertisementLocation advertisementlocation = db.AdvertisementLocations.Find(id);
            if (advertisementlocation == null)
            {
                return HttpNotFound();
            }
            return View(advertisementlocation);
        }

        //
        // POST: /AdvertisementLocation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AdvertisementLocation advertisementlocation = db.AdvertisementLocations.Find(id);
            db.AdvertisementLocations.Remove(advertisementlocation);
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