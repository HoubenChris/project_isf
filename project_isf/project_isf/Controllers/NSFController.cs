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
    public class NSFController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /NSF/

        public ActionResult Index()
        {
            return View(db.NSFs.ToList());
        }

        //
        // GET: /NSF/Details/5

        public ActionResult Details(int id = 0)
        {
            NSF nsf = db.NSFs.Find(id);
            if (nsf == null)
            {
                return HttpNotFound();
            }
            return View(nsf);
        }

        //
        // GET: /NSF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NSF/Create

        [HttpPost]
        public ActionResult Create(NSF nsf)
        {
            if (ModelState.IsValid)
            {
                db.NSFs.Add(nsf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nsf);
        }

        //
        // GET: /NSF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NSF nsf = db.NSFs.Find(id);
            if (nsf == null)
            {
                return HttpNotFound();
            }
            return View(nsf);
        }

        //
        // POST: /NSF/Edit/5

        [HttpPost]
        public ActionResult Edit(NSF nsf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nsf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nsf);
        }

        //
        // GET: /NSF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NSF nsf = db.NSFs.Find(id);
            if (nsf == null)
            {
                return HttpNotFound();
            }
            return View(nsf);
        }

        //
        // POST: /NSF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NSF nsf = db.NSFs.Find(id);
            db.NSFs.Remove(nsf);
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