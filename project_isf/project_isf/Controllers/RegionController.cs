﻿using System;
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
    public class RegionController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /Region/

        public ActionResult Index()
        {
            return View(db.Regions.ToList());
        }

        //
        // GET: /Region/Details/5

        public ActionResult Details(int id = 0)
        {
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        //
        // GET: /Region/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Region/Create

        [HttpPost]
        public ActionResult Create(Region region)
        {
            if (ModelState.IsValid)
            {
                db.Regions.Add(region);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(region);
        }

        //
        // GET: /Region/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        //
        // POST: /Region/Edit/5

        [HttpPost]
        public ActionResult Edit(Region region)
        {
            if (ModelState.IsValid)
            {
                db.Entry(region).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(region);
        }

        //
        // GET: /Region/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Region region = db.Regions.Find(id);
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
        }

        //
        // POST: /Region/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Region region = db.Regions.Find(id);
            db.Regions.Remove(region);
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